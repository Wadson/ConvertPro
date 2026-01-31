using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace ConvertPro
{
    public partial class FrmAguarde : KryptonForm
    {
        public FrmAguarde(string mensagem = "Carregando lista, aguarde...")
        {
            InitializeComponent();
            lblMensagem.Text = mensagem;
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 30;
        }
    }
}
