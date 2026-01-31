namespace ConvertPro
{
    partial class FrmConverterMpQuatro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConverterMpQuatro));
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            txtPathVideo = new Krypton.Toolkit.KryptonTextBox();
            lblLink = new Krypton.Toolkit.KryptonLabel();
            lblDestino = new Krypton.Toolkit.KryptonLabel();
            txtSaveTo = new Krypton.Toolkit.KryptonTextBox();
            listBoxVideos = new Krypton.Toolkit.KryptonListBox();
            btnExcluirSelecionados = new FontAwesome.Sharp.IconButton();
            btnLimparLista = new FontAwesome.Sharp.IconButton();
            progressBar = new Krypton.Toolkit.KryptonProgressBar();
            lblProgress = new Krypton.Toolkit.KryptonLabel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnPausar = new FontAwesome.Sharp.IconButton();
            btnContinuar = new FontAwesome.Sharp.IconButton();
            lblStatusContagem = new Label();
            lblTotalVideos = new Label();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            panel1 = new Panel();
            btnSair = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            btnFechar = new FontAwesome.Sharp.IconButton();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            btnOpenVideo = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            btnConverter = new FontAwesome.Sharp.IconButton();
            cmbAudioQuality = new Krypton.Toolkit.KryptonComboBox();
            lblAudioQuality = new Krypton.Toolkit.KryptonLabel();
            toolTip1 = new ToolTip(components);
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbAudioQuality).BeginInit();
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
            txtPathVideo.Location = new Point(0, 98);
            txtPathVideo.Margin = new Padding(4, 3, 4, 3);
            txtPathVideo.Name = "txtPathVideo";
            txtPathVideo.Size = new Size(622, 30);
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
            lblLink.Location = new Point(3, 76);
            lblLink.Name = "lblLink";
            lblLink.Size = new Size(177, 21);
            lblLink.StateCommon.ShortText.Color1 = Color.FromArgb(6, 128, 254);
            lblLink.StateCommon.ShortText.Color2 = Color.FromArgb(6, 128, 254);
            lblLink.StateCommon.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLink.TabIndex = 1016;
            lblLink.Values.Text = "Insira os arquivos de vídeos:";
            // 
            // lblDestino
            // 
            lblDestino.Location = new Point(4, 134);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(126, 21);
            lblDestino.StateCommon.ShortText.Color1 = Color.FromArgb(6, 128, 254);
            lblDestino.StateCommon.ShortText.Color2 = Color.FromArgb(6, 128, 254);
            lblDestino.StateCommon.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDestino.TabIndex = 1027;
            lblDestino.Values.Text = "Escolha onde salvar";
            // 
            // txtSaveTo
            // 
            txtSaveTo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSaveTo.Location = new Point(0, 157);
            txtSaveTo.Margin = new Padding(4, 3, 4, 3);
            txtSaveTo.Name = "txtSaveTo";
            txtSaveTo.Size = new Size(622, 30);
            txtSaveTo.StateCommon.Back.Color1 = Color.White;
            txtSaveTo.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtSaveTo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtSaveTo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSaveTo.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSaveTo.StateCommon.Border.Rounding = 20F;
            txtSaveTo.StateCommon.Border.Width = 1;
            txtSaveTo.StateCommon.Content.Color1 = Color.Gray;
            txtSaveTo.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtSaveTo.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtSaveTo.TabIndex = 1026;
            // 
            // listBoxVideos
            // 
            listBoxVideos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxVideos.Location = new Point(3, 193);
            listBoxVideos.Name = "listBoxVideos";
            listBoxVideos.Size = new Size(618, 96);
            listBoxVideos.TabIndex = 1028;
            listBoxVideos.DragDrop += listBoxVideos_DragDrop;
            listBoxVideos.DragEnter += listBoxVideos_DragEnter;
            // 
            // btnExcluirSelecionados
            // 
            btnExcluirSelecionados.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluirSelecionados.FlatAppearance.BorderSize = 0;
            btnExcluirSelecionados.FlatStyle = FlatStyle.Flat;
            btnExcluirSelecionados.ForeColor = SystemColors.ActiveCaption;
            btnExcluirSelecionados.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnExcluirSelecionados.IconColor = Color.FromArgb(6, 128, 254);
            btnExcluirSelecionados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExcluirSelecionados.IconSize = 42;
            btnExcluirSelecionados.Location = new Point(627, 249);
            btnExcluirSelecionados.Name = "btnExcluirSelecionados";
            btnExcluirSelecionados.Size = new Size(42, 42);
            btnExcluirSelecionados.TabIndex = 1031;
            toolTip1.SetToolTip(btnExcluirSelecionados, "Excluir o vídeo selecionado");
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
            btnLimparLista.IconColor = Color.FromArgb(6, 128, 254);
            btnLimparLista.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimparLista.IconSize = 42;
            btnLimparLista.Location = new Point(629, 201);
            btnLimparLista.Name = "btnLimparLista";
            btnLimparLista.Size = new Size(42, 42);
            btnLimparLista.TabIndex = 1030;
            toolTip1.SetToolTip(btnLimparLista, "Limpa a lista");
            btnLimparLista.UseVisualStyleBackColor = true;
            btnLimparLista.Click += btnLimparLista_Click;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(-11, 376);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(569, 23);
            progressBar.TabIndex = 1033;
            progressBar.UseKrypton = true;
            // 
            // lblProgress
            // 
            lblProgress.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblProgress.Location = new Point(556, 378);
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
            btnCancelar.IconColor = Color.FromArgb(6, 128, 254);
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 42;
            btnCancelar.Location = new Point(343, 322);
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
            btnPausar.IconColor = Color.FromArgb(6, 128, 254);
            btnPausar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPausar.IconSize = 42;
            btnPausar.Location = new Point(293, 322);
            btnPausar.Name = "btnPausar";
            btnPausar.Size = new Size(42, 42);
            btnPausar.TabIndex = 1037;
            toolTip1.SetToolTip(btnPausar, "Pausar");
            btnPausar.UseVisualStyleBackColor = true;
            btnPausar.Click += btnPausar_Click;
            // 
            // btnContinuar
            // 
            btnContinuar.Anchor = AnchorStyles.Bottom;
            btnContinuar.FlatAppearance.BorderSize = 0;
            btnContinuar.FlatStyle = FlatStyle.Flat;
            btnContinuar.IconChar = FontAwesome.Sharp.IconChar.Play;
            btnContinuar.IconColor = Color.FromArgb(6, 128, 254);
            btnContinuar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnContinuar.IconSize = 42;
            btnContinuar.Location = new Point(243, 322);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(42, 42);
            btnContinuar.TabIndex = 1038;
            toolTip1.SetToolTip(btnContinuar, "Continuar");
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // lblStatusContagem
            // 
            lblStatusContagem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblStatusContagem.AutoSize = true;
            lblStatusContagem.BackColor = Color.Transparent;
            lblStatusContagem.Font = new Font("Microsoft Sans Serif", 10F);
            lblStatusContagem.ForeColor = Color.FromArgb(6, 128, 254);
            lblStatusContagem.Location = new Point(63, 295);
            lblStatusContagem.Margin = new Padding(4, 0, 4, 0);
            lblStatusContagem.Name = "lblStatusContagem";
            lblStatusContagem.Size = new Size(13, 17);
            lblStatusContagem.TabIndex = 1039;
            lblStatusContagem.Text = "-";
            // 
            // lblTotalVideos
            // 
            lblTotalVideos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalVideos.AutoSize = true;
            lblTotalVideos.BackColor = Color.Transparent;
            lblTotalVideos.Font = new Font("Microsoft Sans Serif", 10F);
            lblTotalVideos.ForeColor = Color.FromArgb(6, 128, 254);
            lblTotalVideos.Location = new Point(7, 295);
            lblTotalVideos.Margin = new Padding(4, 0, 4, 0);
            lblTotalVideos.Name = "lblTotalVideos";
            lblTotalVideos.Size = new Size(28, 17);
            lblTotalVideos.TabIndex = 1040;
            lblTotalVideos.Text = "0/0";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 402);
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
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(kryptonLabel1);
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
            btnSair.IconColor = Color.FromArgb(6, 128, 254);
            btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSair.IconSize = 42;
            btnSair.Location = new Point(639, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(32, 32);
            btnSair.TabIndex = 82;
            toolTip1.SetToolTip(btnSair, "Sair");
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(303, 3);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 81;
            pictureBox1.TabStop = false;
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
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(6, 148, 254);
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.FromArgb(6, 148, 254);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.TabIndex = 74;
            kryptonLabel1.Values.Text = "Converter Vídeo em Audio Mp3";
            // 
            // btnOpenVideo
            // 
            btnOpenVideo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenVideo.FlatAppearance.BorderSize = 0;
            btnOpenVideo.FlatStyle = FlatStyle.Flat;
            btnOpenVideo.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            btnOpenVideo.IconColor = Color.FromArgb(6, 128, 254);
            btnOpenVideo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOpenVideo.IconSize = 42;
            btnOpenVideo.Location = new Point(629, 89);
            btnOpenVideo.Name = "btnOpenVideo";
            btnOpenVideo.Size = new Size(42, 42);
            btnOpenVideo.TabIndex = 1043;
            toolTip1.SetToolTip(btnOpenVideo, "Escolher vídeos para converter");
            btnOpenVideo.UseVisualStyleBackColor = true;
            btnOpenVideo.Click += btnOpenVideo_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.Transparent;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            btnSave.IconColor = Color.FromArgb(6, 128, 254);
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 42;
            btnSave.Location = new Point(627, 153);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(42, 42);
            btnSave.TabIndex = 1044;
            toolTip1.SetToolTip(btnSave, "Escolha  local para salvar os arquivos ");
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnConverter
            // 
            btnConverter.Anchor = AnchorStyles.Bottom;
            btnConverter.BackColor = Color.Transparent;
            btnConverter.FlatAppearance.BorderSize = 0;
            btnConverter.FlatStyle = FlatStyle.Flat;
            btnConverter.ForeColor = Color.Transparent;
            btnConverter.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            btnConverter.IconColor = Color.FromArgb(6, 128, 254);
            btnConverter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConverter.IconSize = 42;
            btnConverter.Location = new Point(391, 322);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(42, 42);
            btnConverter.TabIndex = 1045;
            toolTip1.SetToolTip(btnConverter, "Iniciar Conversão");
            btnConverter.UseVisualStyleBackColor = false;
            btnConverter.Click += btnConverter_Click;
            // 
            // cmbAudioQuality
            // 
            cmbAudioQuality.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cmbAudioQuality.CornerRoundingRadius = 20F;
            cmbAudioQuality.DropDownWidth = 185;
            cmbAudioQuality.IntegralHeight = false;
            cmbAudioQuality.Location = new Point(481, 295);
            cmbAudioQuality.Name = "cmbAudioQuality";
            cmbAudioQuality.Size = new Size(140, 35);
            cmbAudioQuality.StateActive.ComboBox.Back.Color1 = Color.FromArgb(8, 142, 254);
            cmbAudioQuality.StateActive.ComboBox.Border.Color1 = Color.FromArgb(6, 174, 244);
            cmbAudioQuality.StateActive.ComboBox.Border.Color2 = Color.FromArgb(8, 142, 254);
            cmbAudioQuality.StateActive.ComboBox.Border.ColorAngle = 45F;
            cmbAudioQuality.StateActive.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbAudioQuality.StateActive.ComboBox.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            cmbAudioQuality.StateActive.ComboBox.Border.Rounding = 20F;
            cmbAudioQuality.StateActive.ComboBox.Border.Width = 1;
            cmbAudioQuality.StateActive.ComboBox.Content.Color1 = Color.White;
            cmbAudioQuality.StateActive.ComboBox.Content.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAudioQuality.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(8, 142, 254);
            cmbAudioQuality.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(6, 174, 244);
            cmbAudioQuality.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(8, 142, 254);
            cmbAudioQuality.StateCommon.ComboBox.Border.ColorAngle = 45F;
            cmbAudioQuality.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbAudioQuality.StateCommon.ComboBox.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            cmbAudioQuality.StateCommon.ComboBox.Border.Rounding = 20F;
            cmbAudioQuality.StateCommon.ComboBox.Border.Width = 1;
            cmbAudioQuality.StateCommon.ComboBox.Content.Color1 = Color.White;
            cmbAudioQuality.StateCommon.ComboBox.Content.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAudioQuality.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbAudioQuality.StateCommon.Item.Border.Color1 = Color.FromArgb(6, 174, 244);
            cmbAudioQuality.StateCommon.Item.Border.Color2 = Color.FromArgb(8, 142, 254);
            cmbAudioQuality.StateCommon.Item.Border.ColorAngle = 45F;
            cmbAudioQuality.StateCommon.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbAudioQuality.StateCommon.Item.Border.Rounding = 20F;
            cmbAudioQuality.StateCommon.Item.Border.Width = 1;
            cmbAudioQuality.StateCommon.Item.Content.ShortText.Color1 = Color.White;
            cmbAudioQuality.StateNormal.ComboBox.Back.Color1 = Color.FromArgb(8, 142, 254);
            cmbAudioQuality.StateNormal.ComboBox.Content.Color1 = Color.White;
            cmbAudioQuality.TabIndex = 1046;
            cmbAudioQuality.Text = " ";
            // 
            // lblAudioQuality
            // 
            lblAudioQuality.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblAudioQuality.Location = new Point(383, 304);
            lblAudioQuality.Name = "lblAudioQuality";
            lblAudioQuality.Size = new Size(92, 21);
            lblAudioQuality.StateCommon.ShortText.Color1 = Color.FromArgb(6, 128, 254);
            lblAudioQuality.StateCommon.ShortText.Color2 = Color.FromArgb(6, 128, 254);
            lblAudioQuality.StateCommon.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAudioQuality.TabIndex = 1047;
            lblAudioQuality.Values.Text = "Audio Quality";
            // 
            // FrmConverterMpQuatro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 252);
            ClientSize = new Size(683, 424);
            Controls.Add(lblAudioQuality);
            Controls.Add(cmbAudioQuality);
            Controls.Add(btnConverter);
            Controls.Add(btnSave);
            Controls.Add(btnOpenVideo);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(lblStatusContagem);
            Controls.Add(lblTotalVideos);
            Controls.Add(btnContinuar);
            Controls.Add(btnPausar);
            Controls.Add(btnCancelar);
            Controls.Add(lblProgress);
            Controls.Add(progressBar);
            Controls.Add(btnExcluirSelecionados);
            Controls.Add(btnLimparLista);
            Controls.Add(listBoxVideos);
            Controls.Add(lblDestino);
            Controls.Add(txtSaveTo);
            Controls.Add(lblLink);
            Controls.Add(txtPathVideo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConverterMpQuatro";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            Text = "Download Vídeo do Youtube";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbAudioQuality).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public Krypton.Toolkit.KryptonTextBox txtPathVideo;
        private Krypton.Toolkit.KryptonLabel lblLink;
        private Krypton.Toolkit.KryptonLabel lblDestino;
        public Krypton.Toolkit.KryptonTextBox txtSaveTo;
        private Krypton.Toolkit.KryptonListBox listBoxVideos;
        private FontAwesome.Sharp.IconButton btnExcluirSelecionados;
        private FontAwesome.Sharp.IconButton btnLimparLista;
        private Krypton.Toolkit.KryptonProgressBar progressBar;
        private Krypton.Toolkit.KryptonLabel lblProgress;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnPausar;
        private FontAwesome.Sharp.IconButton btnContinuar;
        private Label lblStatusContagem;
        private Label lblTotalVideos;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnFechar;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private FontAwesome.Sharp.IconButton btnOpenVideo;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnSair;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnConverter;
        public Krypton.Toolkit.KryptonComboBox cmbAudioQuality;
        private Krypton.Toolkit.KryptonLabel lblAudioQuality;
        private ToolTip toolTip1;
    }
}
