namespace Converter
{
    partial class FrmConverterMpTreis
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtPathVideo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSaveTo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.listBoxVideos = new Krypton.Toolkit.KryptonListBox();
            this.lblStatus = new Krypton.Toolkit.KryptonLabel();
            this.progressBar = new Krypton.Toolkit.KryptonProgressBar();
            this.lblTotalVideos = new Krypton.Toolkit.KryptonLabel();
            this.cmbNivelCompressao = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpenVideo = new System.Windows.Forms.Button();
            this.btnConverter = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.radiobtnCompressAudio = new System.Windows.Forms.RadioButton();
            this.btnLimparLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNivelCompressao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(20, 88);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(107, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Imput vídeo path:";
            // 
            // txtPathVideo
            // 
            this.txtPathVideo.Location = new System.Drawing.Point(20, 111);
            this.txtPathVideo.Name = "txtPathVideo";
            this.txtPathVideo.Size = new System.Drawing.Size(406, 23);
            this.txtPathVideo.TabIndex = 1;
            // 
            // txtSaveTo
            // 
            this.txtSaveTo.Location = new System.Drawing.Point(20, 335);
            this.txtSaveTo.Name = "txtSaveTo";
            this.txtSaveTo.Size = new System.Drawing.Size(454, 23);
            this.txtSaveTo.TabIndex = 2;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(20, 314);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Salvar em:";
            // 
            // listBoxVideos
            // 
            this.listBoxVideos.Location = new System.Drawing.Point(20, 137);
            this.listBoxVideos.Name = "listBoxVideos";
            this.listBoxVideos.Size = new System.Drawing.Size(505, 125);
            this.listBoxVideos.TabIndex = 8;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(12, 403);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.lblStatus.Size = new System.Drawing.Size(44, 22);
            this.lblStatus.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(140)))), ((int)(((byte)(252)))));
            this.lblStatus.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(140)))), ((int)(((byte)(252)))));
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Values.Text = "Status";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(20, 270);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(454, 20);
            this.progressBar.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.progressBar.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.progressBar.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.progressBar.TabIndex = 10;
            this.progressBar.Values.Text = "";
            // 
            // lblTotalVideos
            // 
            this.lblTotalVideos.Location = new System.Drawing.Point(20, 295);
            this.lblTotalVideos.Name = "lblTotalVideos";
            this.lblTotalVideos.Size = new System.Drawing.Size(75, 20);
            this.lblTotalVideos.TabIndex = 12;
            this.lblTotalVideos.Values.Text = "TotalVideos";
            // 
            // cmbNivelCompressao
            // 
            this.cmbNivelCompressao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivelCompressao.DropDownWidth = 356;
            this.cmbNivelCompressao.Location = new System.Drawing.Point(198, 363);
            this.cmbNivelCompressao.Name = "cmbNivelCompressao";
            this.cmbNivelCompressao.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.cmbNivelCompressao.Size = new System.Drawing.Size(71, 21);
            this.cmbNivelCompressao.TabIndex = 13;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(20, 363);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(175, 20);
            this.kryptonLabel3.TabIndex = 14;
            this.kryptonLabel3.Values.Text = "Alterar o tamanho do arquivo:";
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::Converter.Properties.Resources.Exit24;
            this.btnFechar.Location = new System.Drawing.Point(12, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(35, 31);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFechar.TabIndex = 15;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Converter.Properties.Resources.Folders;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(252)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(479, 329);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(42, 29);
            this.btnSave.TabIndex = 43;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpenVideo
            // 
            this.btnOpenVideo.BackgroundImage = global::Converter.Properties.Resources.Folders;
            this.btnOpenVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenVideo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(252)))));
            this.btnOpenVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenVideo.Location = new System.Drawing.Point(437, 105);
            this.btnOpenVideo.Name = "btnOpenVideo";
            this.btnOpenVideo.Size = new System.Drawing.Size(42, 29);
            this.btnOpenVideo.TabIndex = 44;
            this.btnOpenVideo.UseVisualStyleBackColor = true;
            this.btnOpenVideo.Click += new System.EventHandler(this.btnOpenVideo_Click);
            // 
            // btnConverter
            // 
            this.btnConverter.BackgroundImage = global::Converter.Properties.Resources.Play;
            this.btnConverter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConverter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(252)))));
            this.btnConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverter.Location = new System.Drawing.Point(479, 362);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(42, 29);
            this.btnConverter.TabIndex = 45;
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Converter.Properties.Resources.Stop;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(252)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(428, 362);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(42, 29);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.lblProgress.Location = new System.Drawing.Point(479, 270);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(45, 20);
            this.lblProgress.TabIndex = 47;
            this.lblProgress.Text = "0,0%";
            // 
            // radiobtnCompressAudio
            // 
            this.radiobtnCompressAudio.AutoSize = true;
            this.radiobtnCompressAudio.BackColor = System.Drawing.Color.Transparent;
            this.radiobtnCompressAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnCompressAudio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.radiobtnCompressAudio.Location = new System.Drawing.Point(23, 62);
            this.radiobtnCompressAudio.Name = "radiobtnCompressAudio";
            this.radiobtnCompressAudio.Size = new System.Drawing.Size(172, 20);
            this.radiobtnCompressAudio.TabIndex = 48;
            this.radiobtnCompressAudio.Text = "Compress Audio mp3";
            this.radiobtnCompressAudio.UseVisualStyleBackColor = false;
            // 
            // btnLimparLista
            // 
            this.btnLimparLista.BackgroundImage = global::Converter.Properties.Resources.Clear;
            this.btnLimparLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimparLista.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(252)))));
            this.btnLimparLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparLista.Location = new System.Drawing.Point(481, 105);
            this.btnLimparLista.Name = "btnLimparLista";
            this.btnLimparLista.Size = new System.Drawing.Size(42, 29);
            this.btnLimparLista.TabIndex = 51;
            this.btnLimparLista.UseVisualStyleBackColor = true;
            this.btnLimparLista.Click += new System.EventHandler(this.btnLimparLista_Click);
            // 
            // FrmConverterMpTreis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(554, 425);
            this.Controls.Add(this.btnLimparLista);
            this.Controls.Add(this.radiobtnCompressAudio);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.btnOpenVideo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.cmbNivelCompressao);
            this.Controls.Add(this.lblTotalVideos);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.listBoxVideos);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.txtSaveTo);
            this.Controls.Add(this.txtPathVideo);
            this.Controls.Add(this.kryptonLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConverterMpTreis";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.Text = "Converter Mp4 pra Mp3";
            ((System.ComponentModel.ISupportInitialize)(this.cmbNivelCompressao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPathVideo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSaveTo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonListBox listBoxVideos;
        private Krypton.Toolkit.KryptonLabel lblStatus;
        private Krypton.Toolkit.KryptonProgressBar progressBar;
        private Krypton.Toolkit.KryptonLabel lblTotalVideos;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbNivelCompressao;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpenVideo;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.RadioButton radiobtnCompressAudio;
        private System.Windows.Forms.Button btnLimparLista;
    }
}

