using ConvertPro;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class UpdateService
{
    // URL RAW do GitHub (IMPORTANTE)
    private const string VERSION_URL = "https://raw.githubusercontent.com/Wadson/Converter/main/version.json";

    public static async Task VerificarAtualizacaoAsync()
    {
        try
        {
            using var http = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(5)
            };

            http.DefaultRequestHeaders.UserAgent.ParseAdd("ConvertPro-Updater");

            string json = await http.GetStringAsync(VERSION_URL);

            var info = JsonSerializer.Deserialize<VersionInfo>(json);
            if (info == null)
                return;

            // ===== VERSÃO ONLINE =====
            if (!Version.TryParse(info.versao, out var versaoOnline))
                return;

            // ===== VERSÃO LOCAL (NORMALIZADA) =====
            var versaoLocalRaw = Assembly.GetExecutingAssembly()
                                         .GetName()
                                         .Version;

            if (versaoLocalRaw == null)
                return;

            // Ignora Revision (evita update falso)
            var versaoLocal = new Version(
                versaoLocalRaw.Major,
                versaoLocalRaw.Minor,
                versaoLocalRaw.Build
            );

            // ===== COMPARAÇÃO SEGURA =====
            if (versaoOnline <= versaoLocal)
                return;

            var resposta = MessageBox.Show(
                $"🚀 Nova versão disponível!\n\n" +
                $"Versão atual: {versaoLocal}\n" +
                $"Nova versão: {versaoOnline}\n\n" +
                $"{info.descricao}\n\n" +
                $"Deseja baixar agora?",
                "Atualização disponível",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (resposta == DialogResult.Yes)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = info.url,
                    UseShellExecute = true
                });
            }
        }
        catch
        {
            // Silencioso por design:
            // falha de rede nunca deve impedir o app de abrir
        }
    }


}
