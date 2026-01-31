using ConvertPro.Converter;
using Krypton.Toolkit;
using System.Reflection;
namespace ConvertPro
{
    public partial class FrmPrincipal : KryptonForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void AbrirFormEnPanel(Form form)
        {
            // Fecha qualquer formulário já aberto dentro do painel
            if (this.pnlContainer.Controls.Count > 0)
            {
                Control controleAtual = this.pnlContainer.Controls[0];

                if (controleAtual is Form formAberto && !formAberto.IsDisposed)
                {
                    formAberto.Close();
                }
            }

            pnlContainer.Controls.Clear(); // Remove qualquer controle que ainda esteja no painel

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormClosed += Form_FormClosed; // Garante que ao fechar, verificamos se ainda há formulários abertos
            this.pnlContainer.Controls.Add(form);
            this.pnlContainer.Tag = form;
            form.Show();
        }
        private async Task InicializarAsync()
        {
            var version = Assembly.GetExecutingAssembly()
                                 .GetName()
                                 .Version?.ToString();

            lblVersaoSistema.Text = $"ConvertPro • Versão {version} • © 2026 WR Soft";
            this.Text = $"ConvertPro • Versão {version}";

            try
            {
                EmbeddedToolsExtractor.EnsureYtDlp();
                EmbeddedToolsExtractor.EnsureFfmpeg();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Falha ao preparar ferramentas internas:\n\n{ex.Message}",
                    "Erro crítico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Close();
                return;
            }

            await UpdateService.VerificarAtualizacaoAsync();
        }

        private async void FrmPrincipal_Load(object sender, EventArgs e)
        {
            await InicializarAsync();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmDownload());
        }

        private void btnCompressAudio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmCompressMpTreis());
        }

        private void btnConverterVideo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmConverterMpQuatro());
        }
    }
}
