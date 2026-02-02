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
        private void AtualizarEstadoMenu()
        {
            bool existeFormAberto = pnlContainer.Controls
                .OfType<Form>()
                .Any(f => !f.IsDisposed);

            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Enabled = !existeFormAberto;
                }
            }
        }



        private void AbrirFormEnPanel(Form form)
        {
            // Fecha formulário atual
            if (pnlContainer.Controls.Count > 0)
            {
                if (pnlContainer.Controls[0] is Form formAberto && !formAberto.IsDisposed)
                {
                    formAberto.Close();
                }
            }

            pnlContainer.Controls.Clear();

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            form.FormClosed += (s, e) =>
            {
                // 🔴 remove o form do container
                if (pnlContainer.Controls.Contains(form))
                {
                    pnlContainer.Controls.Remove(form);
                }

                form.Dispose();

                // 🔓 agora o menu reflete o estado real
                AtualizarEstadoMenu();
            };


            pnlContainer.Controls.Add(form);
            pnlContainer.Tag = form;
            form.Show();

            // 🔒 trava menu após abrir
            AtualizarEstadoMenu();
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
