using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using FFMpegCore;
using NReco.VideoConverter;
//using NReco.VideoInfo;

namespace Converter
{
    public partial class FrmConvertPro : KryptonForm
    {
        public FrmConvertPro()
        {
            InitializeComponent();
        }
        private void AbrirFormEnPanel(Form form)
        {
            // Fecha qualquer formulário já aberto dentro do painel
            if (this.pnlContainer.Controls.Count > 0)
            {
                Form formAberto = (Form)this.pnlContainer.Controls[0];
                formAberto.Close(); // Fecha o formulário atual antes de abrir outro
            }

            pnlContainer.Controls.Clear(); // Remove qualquer controle que ainda esteja no painel

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormClosed += Form_FormClosed; // Garante que ao fechar, verificamos se ainda há formulários abertos
            this.pnlContainer.Controls.Add(form);
            this.pnlContainer.Tag = form;
            form.Show();
        }
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {// Se não houver mais formulários abertos, redefine o lblJanelaAberta
            if (pnlContainer.Controls.Count == 0)
            {
                lblJanelaAberta.Text = ".";
                lblJanelaAberta.ForeColor = System.Drawing.Color.Black;
            }
        }
        // Atualiza a lblJanelaAberta quando um formulário é fechado
        private void VerificarJanelaAberta()
        {
            if (pnlContainer.Controls.Count == 0)
            {
                lblJanelaAberta.Text = ".";
                lblJanelaAberta.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertMp_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmConverter());
            lblJanelaAberta.Text = "Converter MP4 para MP3";
            lblJanelaAberta.ForeColor = System.Drawing.Color.Green;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmDowload());
            lblJanelaAberta.Text = "Download de Vídeos";
            lblJanelaAberta.ForeColor = System.Drawing.Color.Blue;
        }

        private void btnConverterMpTreis_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmConverterMpTreis());
            lblJanelaAberta.Text = "Compressor de MP3";
        }
    }
}
