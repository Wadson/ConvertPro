namespace ConvertPro
{
    partial class FrmCompressMpTreis
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompressMpTreis));
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            txtPathVideo = new Krypton.Toolkit.KryptonTextBox();
            lblLink = new Krypton.Toolkit.KryptonLabel();
            cmbNivelCompressao = new Krypton.Toolkit.KryptonComboBox();
            lblVideoQuality = new Krypton.Toolkit.KryptonLabel();
            lblDestino = new Krypton.Toolkit.KryptonLabel();
            txtSalvarEm = new Krypton.Toolkit.KryptonTextBox();
            listBoxVideos = new Krypton.Toolkit.KryptonListBox();
            btnSave = new FontAwesome.Sharp.IconButton();
            btnExcluirSelecionados = new FontAwesome.Sharp.IconButton();
            btnLimparLista = new FontAwesome.Sharp.IconButton();
            progressBar = new Krypton.Toolkit.KryptonProgressBar();
            lblProgress = new Krypton.Toolkit.KryptonLabel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnPausar = new FontAwesome.Sharp.IconButton();
            btnContinuar = new FontAwesome.Sharp.IconButton();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            panel1 = new Panel();
            btnSair = new FontAwesome.Sharp.IconButton();
            btnFechar = new FontAwesome.Sharp.IconButton();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            pictureBox1 = new PictureBox();
            btnOpenAudio = new FontAwesome.Sharp.IconButton();
            lblTotalVideos = new Label();
            btnConverter = new FontAwesome.Sharp.IconButton();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)cmbNivelCompressao).BeginInit();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // kryptonPalette1
            // 
            kryptonPalette1.ButtonSpecs.FormClose.Image = Properties.Resources.Exit;
            kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = Properties.Resources.Sairr;
            kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = Properties.Resources.Sairr;
            kryptonPalette1.ButtonSpecs.FormMax.Image = Properties.Resources.Maximize;
            kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed = Properties.Resources.Minimiza24;
            kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking = Properties.Resources.Minimiza24;
            kryptonPalette1.ButtonSpecs.FormMin.Image = Properties.Resources.Minimize;
            kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed = Properties.Resources.Minimizar24;
            kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking = Properties.Resources.Minimizar24;
            kryptonPalette1.ButtonSpecs.FormRestore.Image = Properties.Resources.Maximize;
            kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImagePressed = Properties.Resources.Minimiza24;
            kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImageTracking = Properties.Resources.Maximize;
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = Color.FromArgb(6, 128, 254);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = Color.FromArgb(6, 128, 254);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12F;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(10, -1, -1, -1);
            // 
            // txtPathVideo
            // 
            txtPathVideo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPathVideo.Location = new Point(3, 107);
            txtPathVideo.Margin = new Padding(4, 3, 4, 3);
            txtPathVideo.Name = "txtPathVideo";
            txtPathVideo.Size = new Size(619, 30);
            txtPathVideo.StateCommon.Back.Color1 = Color.White;
            txtPathVideo.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtPathVideo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtPathVideo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPathVideo.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtPathVideo.StateCommon.Border.Rounding = 20F;
            txtPathVideo.StateCommon.Border.Width = 1;
            txtPathVideo.StateCommon.Content.Color1 = Color.Gray;
            txtPathVideo.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtPathVideo.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtPathVideo.TabIndex = 1015;
            // 
            // lblLink
            // 
            lblLink.Location = new Point(3, 85);
            lblLink.Name = "lblLink";
            lblLink.Size = new Size(177, 21);
            lblLink.StateCommon.ShortText.Color1 = Color.FromArgb(6, 128, 254);
            lblLink.StateCommon.ShortText.Color2 = Color.FromArgb(6, 128, 254);
            lblLink.StateCommon.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLink.TabIndex = 1016;
            lblLink.Values.Text = "Localizar arquivos de áudios";
            // 
            // cmbNivelCompressao
            // 
            cmbNivelCompressao.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbNivelCompressao.CornerRoundingRadius = 20F;
            cmbNivelCompressao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivelCompressao.DropDownWidth = 185;
            cmbNivelCompressao.IntegralHeight = false;
            cmbNivelCompressao.Location = new Point(207, 299);
            cmbNivelCompressao.Name = "cmbNivelCompressao";
            cmbNivelCompressao.Size = new Size(140, 35);
            cmbNivelCompressao.StateActive.ComboBox.Back.Color1 = Color.FromArgb(8, 142, 254);
            cmbNivelCompressao.StateActive.ComboBox.Border.Color1 = Color.FromArgb(6, 174, 244);
            cmbNivelCompressao.StateActive.ComboBox.Border.Color2 = Color.FromArgb(8, 142, 254);
            cmbNivelCompressao.StateActive.ComboBox.Border.ColorAngle = 45F;
            cmbNivelCompressao.StateActive.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbNivelCompressao.StateActive.ComboBox.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            cmbNivelCompressao.StateActive.ComboBox.Border.Rounding = 20F;
            cmbNivelCompressao.StateActive.ComboBox.Border.Width = 1;
            cmbNivelCompressao.StateActive.ComboBox.Content.Color1 = Color.White;
            cmbNivelCompressao.StateActive.ComboBox.Content.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbNivelCompressao.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(8, 142, 254);
            cmbNivelCompressao.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(6, 174, 244);
            cmbNivelCompressao.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(8, 142, 254);
            cmbNivelCompressao.StateCommon.ComboBox.Border.ColorAngle = 45F;
            cmbNivelCompressao.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbNivelCompressao.StateCommon.ComboBox.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            cmbNivelCompressao.StateCommon.ComboBox.Border.Rounding = 20F;
            cmbNivelCompressao.StateCommon.ComboBox.Border.Width = 1;
            cmbNivelCompressao.StateCommon.ComboBox.Content.Color1 = Color.White;
            cmbNivelCompressao.StateCommon.ComboBox.Content.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbNivelCompressao.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbNivelCompressao.StateCommon.DropBack.Color1 = Color.FromArgb(8, 142, 254);
            cmbNivelCompressao.StateCommon.DropBack.Color2 = Color.FromArgb(8, 142, 254);
            cmbNivelCompressao.StateCommon.Item.Back.Color1 = Color.Orange;
            cmbNivelCompressao.StateCommon.Item.Border.Color1 = Color.FromArgb(6, 174, 244);
            cmbNivelCompressao.StateCommon.Item.Border.Color2 = Color.FromArgb(8, 142, 254);
            cmbNivelCompressao.StateCommon.Item.Border.ColorAngle = 45F;
            cmbNivelCompressao.StateCommon.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbNivelCompressao.StateCommon.Item.Border.Rounding = 20F;
            cmbNivelCompressao.StateCommon.Item.Border.Width = 1;
            cmbNivelCompressao.StateCommon.Item.Content.ShortText.Color1 = Color.White;
            cmbNivelCompressao.StateNormal.ComboBox.Back.Color1 = Color.FromArgb(8, 142, 254);
            cmbNivelCompressao.StateNormal.ComboBox.Content.Color1 = Color.White;
            cmbNivelCompressao.TabIndex = 1021;
            // 
            // lblVideoQuality
            // 
            lblVideoQuality.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblVideoQuality.Location = new Point(12, 306);
            lblVideoQuality.Name = "lblVideoQuality";
            lblVideoQuality.Size = new Size(189, 21);
            lblVideoQuality.StateCommon.ShortText.Color1 = Color.FromArgb(6, 128, 254);
            lblVideoQuality.StateCommon.ShortText.Color2 = Color.FromArgb(6, 128, 254);
            lblVideoQuality.StateCommon.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVideoQuality.TabIndex = 1022;
            lblVideoQuality.Values.Text = "Alterar o tamanho do arquivo:";
            // 
            // lblDestino
            // 
            lblDestino.Location = new Point(7, 137);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(71, 21);
            lblDestino.StateCommon.ShortText.Color1 = Color.FromArgb(6, 128, 254);
            lblDestino.StateCommon.ShortText.Color2 = Color.FromArgb(6, 128, 254);
            lblDestino.StateCommon.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDestino.TabIndex = 1027;
            lblDestino.Values.Text = "Salvar em:";
            // 
            // txtSalvarEm
            // 
            txtSalvarEm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSalvarEm.Location = new Point(3, 160);
            txtSalvarEm.Margin = new Padding(4, 3, 4, 3);
            txtSalvarEm.Name = "txtSalvarEm";
            txtSalvarEm.Size = new Size(623, 30);
            txtSalvarEm.StateCommon.Back.Color1 = Color.White;
            txtSalvarEm.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtSalvarEm.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtSalvarEm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSalvarEm.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSalvarEm.StateCommon.Border.Rounding = 20F;
            txtSalvarEm.StateCommon.Border.Width = 1;
            txtSalvarEm.StateCommon.Content.Color1 = Color.Gray;
            txtSalvarEm.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtSalvarEm.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtSalvarEm.TabIndex = 1026;
            txtSalvarEm.TextChanged += txtSalvarEm_TextChanged;
            // 
            // listBoxVideos
            // 
            listBoxVideos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxVideos.Location = new Point(11, 193);
            listBoxVideos.Name = "listBoxVideos";
            listBoxVideos.Size = new Size(610, 100);
            listBoxVideos.TabIndex = 1028;
            listBoxVideos.DragDrop += listBoxVideos_DragDrop;
            listBoxVideos.DragEnter += listBoxVideos_DragEnter;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            btnSave.IconColor = Color.FromArgb(0, 200, 150);
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 42;
            btnSave.Location = new Point(630, 154);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(42, 42);
            btnSave.TabIndex = 1029;
            toolTip1.SetToolTip(btnSave, "Escolha uma pasta para salvar os arquivos comprimidos");
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExcluirSelecionados
            // 
            btnExcluirSelecionados.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluirSelecionados.FlatAppearance.BorderSize = 0;
            btnExcluirSelecionados.FlatStyle = FlatStyle.Flat;
            btnExcluirSelecionados.ForeColor = SystemColors.ActiveCaption;
            btnExcluirSelecionados.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnExcluirSelecionados.IconColor = Color.Red;
            btnExcluirSelecionados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExcluirSelecionados.IconSize = 42;
            btnExcluirSelecionados.Location = new Point(631, 258);
            btnExcluirSelecionados.Name = "btnExcluirSelecionados";
            btnExcluirSelecionados.Size = new Size(42, 42);
            btnExcluirSelecionados.TabIndex = 1031;
            toolTip1.SetToolTip(btnExcluirSelecionados, "Excluir audio selecionado");
            btnExcluirSelecionados.UseVisualStyleBackColor = true;
            btnExcluirSelecionados.Click += btnExcluirSelecionados_Click;
            // 
            // btnLimparLista
            // 
            btnLimparLista.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimparLista.FlatAppearance.BorderSize = 0;
            btnLimparLista.FlatStyle = FlatStyle.Flat;
            btnLimparLista.ForeColor = SystemColors.ActiveCaption;
            btnLimparLista.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimparLista.IconColor = Color.Silver;
            btnLimparLista.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimparLista.IconSize = 42;
            btnLimparLista.Location = new Point(631, 208);
            btnLimparLista.Name = "btnLimparLista";
            btnLimparLista.Size = new Size(42, 42);
            btnLimparLista.TabIndex = 1030;
            toolTip1.SetToolTip(btnLimparLista, "Limpar lista");
            btnLimparLista.UseVisualStyleBackColor = true;
            btnLimparLista.Click += btnLimparLista_Click;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(2, 434);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(569, 23);
            progressBar.TabIndex = 1033;
            progressBar.UseKrypton = true;
            // 
            // lblProgress
            // 
            lblProgress.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblProgress.Location = new Point(577, 434);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(39, 21);
            lblProgress.StateCommon.ShortText.Color1 = Color.FromArgb(6, 128, 254);
            lblProgress.StateCommon.ShortText.Color2 = Color.FromArgb(6, 128, 254);
            lblProgress.StateCommon.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgress.TabIndex = 1034;
            lblProgress.Values.Text = "0,0%";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Stop;
            btnCancelar.IconColor = Color.Crimson;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 42;
            btnCancelar.Location = new Point(312, 386);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(42, 42);
            btnCancelar.TabIndex = 1036;
            toolTip1.SetToolTip(btnCancelar, "Cancelar");
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnPausar
            // 
            btnPausar.Anchor = AnchorStyles.Bottom;
            btnPausar.FlatAppearance.BorderSize = 0;
            btnPausar.FlatStyle = FlatStyle.Flat;
            btnPausar.IconChar = FontAwesome.Sharp.IconChar.Pause;
            btnPausar.IconColor = Color.Orange;
            btnPausar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPausar.IconSize = 42;
            btnPausar.Location = new Point(262, 386);
            btnPausar.Name = "btnPausar";
            btnPausar.Size = new Size(42, 42);
            btnPausar.TabIndex = 1037;
            toolTip1.SetToolTip(btnPausar, "Continuar");
            btnPausar.UseVisualStyleBackColor = true;
            btnPausar.Click += btnPausar_Click;
            // 
            // btnContinuar
            // 
            btnContinuar.Anchor = AnchorStyles.Bottom;
            btnContinuar.FlatAppearance.BorderSize = 0;
            btnContinuar.FlatStyle = FlatStyle.Flat;
            btnContinuar.IconChar = FontAwesome.Sharp.IconChar.Play;
            btnContinuar.IconColor = Color.Green;
            btnContinuar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnContinuar.IconSize = 42;
            btnContinuar.Location = new Point(212, 386);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(42, 42);
            btnContinuar.TabIndex = 1038;
            toolTip1.SetToolTip(btnContinuar, "Pausar");
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 458);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.Size = new Size(683, 22);
            statusStrip1.TabIndex = 1041;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 17);
            lblStatus.Text = "Status";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(kryptonLabel1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 74);
            panel1.TabIndex = 1042;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnSair.IconColor = Color.FromArgb(64, 64, 64);
            btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSair.IconSize = 42;
            btnSair.Location = new Point(641, 6);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(32, 32);
            btnSair.TabIndex = 83;
            toolTip1.SetToolTip(btnSair, "Sair");
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnFechar.IconColor = Color.FromArgb(170, 204, 255);
            btnFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFechar.IconSize = 36;
            btnFechar.Location = new Point(935, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(32, 32);
            btnFechar.TabIndex = 80;
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Dock = DockStyle.Bottom;
            kryptonLabel1.Location = new Point(0, 44);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(683, 30);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.Green;
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.Green;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.TabIndex = 74;
            kryptonLabel1.Values.Text = "Compactar Aúdios Mp3";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(302, 3);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 73;
            pictureBox1.TabStop = false;
            // 
            // btnOpenAudio
            // 
            btnOpenAudio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenAudio.FlatAppearance.BorderSize = 0;
            btnOpenAudio.FlatStyle = FlatStyle.Flat;
            btnOpenAudio.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            btnOpenAudio.IconColor = Color.FromArgb(0, 200, 150);
            btnOpenAudio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOpenAudio.IconSize = 42;
            btnOpenAudio.Location = new Point(631, 103);
            btnOpenAudio.Name = "btnOpenAudio";
            btnOpenAudio.Size = new Size(42, 42);
            btnOpenAudio.TabIndex = 1043;
            toolTip1.SetToolTip(btnOpenAudio, "Selecionar arquivos de áudios");
            btnOpenAudio.UseVisualStyleBackColor = true;
            btnOpenAudio.Click += btnOpenAudio_Click;
            // 
            // lblTotalVideos
            // 
            lblTotalVideos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalVideos.AutoSize = true;
            lblTotalVideos.ForeColor = Color.FromArgb(6, 128, 254);
            lblTotalVideos.Location = new Point(548, 306);
            lblTotalVideos.Margin = new Padding(4, 0, 4, 0);
            lblTotalVideos.Name = "lblTotalVideos";
            lblTotalVideos.Size = new Size(68, 15);
            lblTotalVideos.TabIndex = 1044;
            lblTotalVideos.Text = "TotalVideos";
            // 
            // btnConverter
            // 
            btnConverter.Anchor = AnchorStyles.Bottom;
            btnConverter.FlatAppearance.BorderSize = 0;
            btnConverter.FlatStyle = FlatStyle.Flat;
            btnConverter.IconChar = FontAwesome.Sharp.IconChar.CompressArrowsAlt;
            btnConverter.IconColor = Color.FromArgb(6, 128, 254);
            btnConverter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConverter.IconSize = 36;
            btnConverter.Location = new Point(360, 391);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(32, 32);
            btnConverter.TabIndex = 1045;
            toolTip1.SetToolTip(btnConverter, "Iniciar compactação...");
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // FrmCompressMpTreis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 252);
            ClientSize = new Size(683, 480);
            Controls.Add(btnConverter);
            Controls.Add(lblTotalVideos);
            Controls.Add(btnOpenAudio);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(btnContinuar);
            Controls.Add(btnPausar);
            Controls.Add(btnCancelar);
            Controls.Add(lblProgress);
            Controls.Add(progressBar);
            Controls.Add(btnExcluirSelecionados);
            Controls.Add(btnLimparLista);
            Controls.Add(btnSave);
            Controls.Add(listBoxVideos);
            Controls.Add(lblDestino);
            Controls.Add(txtSalvarEm);
            Controls.Add(lblVideoQuality);
            Controls.Add(cmbNivelCompressao);
            Controls.Add(lblLink);
            Controls.Add(txtPathVideo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCompressMpTreis";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            Text = "Download Vídeo do Youtube";
            ((System.ComponentModel.ISupportInitialize)cmbNivelCompressao).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public Krypton.Toolkit.KryptonTextBox txtPathVideo;
        private Krypton.Toolkit.KryptonLabel lblLink;
        public Krypton.Toolkit.KryptonComboBox cmbNivelCompressao;
        private Krypton.Toolkit.KryptonLabel lblVideoQuality;
        private Krypton.Toolkit.KryptonLabel lblDestino;
        public Krypton.Toolkit.KryptonTextBox txtSalvarEm;
        private Krypton.Toolkit.KryptonListBox listBoxVideos;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnExcluirSelecionados;
        private FontAwesome.Sharp.IconButton btnLimparLista;
        private Krypton.Toolkit.KryptonProgressBar progressBar;
        private Krypton.Toolkit.KryptonLabel lblProgress;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnPausar;
        private FontAwesome.Sharp.IconButton btnContinuar;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnFechar;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnOpenAudio;
        private Label lblTotalVideos;
        private FontAwesome.Sharp.IconButton btnConverter;
        private ToolTip toolTip1;
        private FontAwesome.Sharp.IconButton btnSair;
    }
}
