namespace ConvertPro
{
    partial class FrmDownload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDownload));
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            txtUrl = new Krypton.Toolkit.KryptonTextBox();
            lblLink = new Krypton.Toolkit.KryptonLabel();
            panel1 = new Panel();
            btnSair = new FontAwesome.Sharp.IconButton();
            btnFechar = new FontAwesome.Sharp.IconButton();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            pictureBox1 = new PictureBox();
            lblTitulo = new Krypton.Toolkit.KryptonLabel();
            txtTitle = new Krypton.Toolkit.KryptonTextBox();
            btnAdicionarURL = new FontAwesome.Sharp.IconButton();
            cmbVideoQuality = new Krypton.Toolkit.KryptonComboBox();
            lblVideoQuality = new Krypton.Toolkit.KryptonLabel();
            lblAudioQuality = new Krypton.Toolkit.KryptonLabel();
            cmbAudioQuality = new Krypton.Toolkit.KryptonComboBox();
            chkAudioOnly = new Krypton.Toolkit.KryptonCheckBox();
            lblDestino = new Krypton.Toolkit.KryptonLabel();
            txtFilePath = new Krypton.Toolkit.KryptonTextBox();
            ListBoxURL = new Krypton.Toolkit.KryptonListBox();
            btnBrowse = new FontAwesome.Sharp.IconButton();
            btnExcluirSelecionados = new FontAwesome.Sharp.IconButton();
            btnLimparLista = new FontAwesome.Sharp.IconButton();
            lblAnalisando = new Label();
            progressBarVideo = new Krypton.Toolkit.KryptonProgressBar();
            btnDownload = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnPausar = new FontAwesome.Sharp.IconButton();
            btnContinuar = new FontAwesome.Sharp.IconButton();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            toolTip1 = new ToolTip(components);
            progressBarTotal = new Krypton.Toolkit.KryptonProgressBar();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblStatusContagem = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbVideoQuality).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbAudioQuality).BeginInit();
            statusStrip1.SuspendLayout();
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
            // txtUrl
            // 
            txtUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUrl.Location = new Point(57, 83);
            txtUrl.Margin = new Padding(4, 3, 4, 3);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(569, 30);
            txtUrl.StateCommon.Back.Color1 = Color.White;
            txtUrl.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtUrl.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtUrl.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtUrl.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtUrl.StateCommon.Border.Rounding = 20F;
            txtUrl.StateCommon.Border.Width = 1;
            txtUrl.StateCommon.Content.Color1 = Color.Gray;
            txtUrl.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtUrl.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtUrl.TabIndex = 1015;
            // 
            // lblLink
            // 
            lblLink.Location = new Point(3, 85);
            lblLink.Name = "lblLink";
            lblLink.Size = new Size(38, 21);
            lblLink.StateCommon.ShortText.Color1 = Color.FromArgb(6, 128, 254);
            lblLink.StateCommon.ShortText.Color2 = Color.FromArgb(6, 128, 254);
            lblLink.StateCommon.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLink.TabIndex = 1016;
            lblLink.Values.Text = "Link:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(kryptonLabel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 66);
            panel1.TabIndex = 1017;
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
            btnSair.Location = new Point(641, 3);
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
            btnFechar.IconColor = Color.White;
            btnFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFechar.IconSize = 36;
            btnFechar.Location = new Point(1011, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(32, 32);
            btnFechar.TabIndex = 78;
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Dock = DockStyle.Bottom;
            kryptonLabel2.Location = new Point(0, 40);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(683, 26);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(8, 148, 254);
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.FromArgb(32, 30, 45);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Segoe UI", 12.25F);
            kryptonLabel2.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel2.TabIndex = 75;
            kryptonLabel2.Values.Text = "Download de vídeos do YouTube";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(298, -1);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 73;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(3, 118);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(47, 21);
            lblTitulo.StateCommon.ShortText.Color1 = Color.FromArgb(6, 128, 254);
            lblTitulo.StateCommon.ShortText.Color2 = Color.FromArgb(6, 128, 254);
            lblTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.TabIndex = 1019;
            lblTitulo.Values.Text = "Título:";
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitle.Location = new Point(57, 116);
            txtTitle.Margin = new Padding(4, 3, 4, 3);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(569, 30);
            txtTitle.StateCommon.Back.Color1 = Color.White;
            txtTitle.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtTitle.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtTitle.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTitle.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtTitle.StateCommon.Border.Rounding = 20F;
            txtTitle.StateCommon.Border.Width = 1;
            txtTitle.StateCommon.Content.Color1 = Color.Gray;
            txtTitle.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtTitle.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtTitle.TabIndex = 1018;
            // 
            // btnAdicionarURL
            // 
            btnAdicionarURL.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdicionarURL.FlatAppearance.BorderSize = 0;
            btnAdicionarURL.FlatStyle = FlatStyle.Flat;
            btnAdicionarURL.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnAdicionarURL.IconColor = Color.FromArgb(6, 128, 254);
            btnAdicionarURL.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdicionarURL.IconSize = 42;
            btnAdicionarURL.Location = new Point(632, 79);
            btnAdicionarURL.Name = "btnAdicionarURL";
            btnAdicionarURL.Size = new Size(38, 38);
            btnAdicionarURL.TabIndex = 1020;
            toolTip1.SetToolTip(btnAdicionarURL, "Adicionar link na lista");
            btnAdicionarURL.UseVisualStyleBackColor = true;
            btnAdicionarURL.Click += btnAdicionarURL_Click;
            // 
            // cmbVideoQuality
            // 
            cmbVideoQuality.CornerRoundingRadius = 20F;
            cmbVideoQuality.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVideoQuality.DropDownWidth = 185;
            cmbVideoQuality.IntegralHeight = false;
            cmbVideoQuality.Location = new Point(95, 151);
            cmbVideoQuality.Name = "cmbVideoQuality";
            cmbVideoQuality.Size = new Size(165, 35);
            cmbVideoQuality.StateActive.ComboBox.Back.Color1 = Color.FromArgb(8, 142, 254);
            cmbVideoQuality.StateActive.ComboBox.Border.Color1 = Color.FromArgb(6, 174, 244);
            cmbVideoQuality.StateActive.ComboBox.Border.Color2 = Color.FromArgb(8, 142, 254);
            cmbVideoQuality.StateActive.ComboBox.Border.ColorAngle = 45F;
            cmbVideoQuality.StateActive.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbVideoQuality.StateActive.ComboBox.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            cmbVideoQuality.StateActive.ComboBox.Border.Rounding = 20F;
            cmbVideoQuality.StateActive.ComboBox.Border.Width = 1;
            cmbVideoQuality.StateActive.ComboBox.Content.Color1 = Color.White;
            cmbVideoQuality.StateActive.ComboBox.Content.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbVideoQuality.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(8, 142, 254);
            cmbVideoQuality.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(6, 174, 244);
            cmbVideoQuality.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(8, 142, 254);
            cmbVideoQuality.StateCommon.ComboBox.Border.ColorAngle = 45F;
            cmbVideoQuality.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbVideoQuality.StateCommon.ComboBox.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            cmbVideoQuality.StateCommon.ComboBox.Border.Rounding = 20F;
            cmbVideoQuality.StateCommon.ComboBox.Border.Width = 1;
            cmbVideoQuality.StateCommon.ComboBox.Content.Color1 = Color.FromArgb(8, 142, 254);
            cmbVideoQuality.StateCommon.ComboBox.Content.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbVideoQuality.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbVideoQuality.StateCommon.DropBack.Color1 = Color.FromArgb(8, 142, 254);
            cmbVideoQuality.StateCommon.DropBack.Color2 = Color.FromArgb(8, 142, 254);
            cmbVideoQuality.StateCommon.Item.Back.Color1 = Color.Orange;
            cmbVideoQuality.StateCommon.Item.Border.Color1 = Color.FromArgb(6, 174, 244);
            cmbVideoQuality.StateCommon.Item.Border.Color2 = Color.FromArgb(8, 142, 254);
            cmbVideoQuality.StateCommon.Item.Border.ColorAngle = 45F;
            cmbVideoQuality.StateCommon.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbVideoQuality.StateCommon.Item.Border.Rounding = 20F;
            cmbVideoQuality.StateCommon.Item.Border.Width = 1;
            cmbVideoQuality.StateCommon.Item.Content.ShortText.Color1 = Color.White;
            cmbVideoQuality.StateNormal.ComboBox.Back.Color1 = Color.FromArgb(8, 142, 254);
            cmbVideoQuality.StateNormal.ComboBox.Content.Color1 = Color.White;
            cmbVideoQuality.TabIndex = 1021;
            cmbVideoQuality.SelectedIndexChanged += cmbVideoQuality_SelectedIndexChanged;
            // 
            // lblVideoQuality
            // 
            lblVideoQuality.Location = new Point(0, 158);
            lblVideoQuality.Name = "lblVideoQuality";
            lblVideoQuality.Size = new Size(94, 21);
            lblVideoQuality.StateCommon.ShortText.Color1 = Color.FromArgb(6, 128, 254);
            lblVideoQuality.StateCommon.ShortText.Color2 = Color.FromArgb(6, 128, 254);
            lblVideoQuality.StateCommon.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVideoQuality.TabIndex = 1022;
            lblVideoQuality.Values.Text = "Vídeo Quality:";
            // 
            // lblAudioQuality
            // 
            lblAudioQuality.Location = new Point(266, 158);
            lblAudioQuality.Name = "lblAudioQuality";
            lblAudioQuality.Size = new Size(95, 21);
            lblAudioQuality.StateCommon.ShortText.Color1 = Color.FromArgb(6, 128, 254);
            lblAudioQuality.StateCommon.ShortText.Color2 = Color.FromArgb(6, 128, 254);
            lblAudioQuality.StateCommon.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAudioQuality.TabIndex = 1024;
            lblAudioQuality.Values.Text = "Audio Quality:";
            // 
            // cmbAudioQuality
            // 
            cmbAudioQuality.CornerRoundingRadius = 20F;
            cmbAudioQuality.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAudioQuality.DropDownWidth = 185;
            cmbAudioQuality.IntegralHeight = false;
            cmbAudioQuality.Location = new Point(363, 151);
            cmbAudioQuality.Name = "cmbAudioQuality";
            cmbAudioQuality.Size = new Size(163, 35);
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
            cmbAudioQuality.StateCommon.DropBack.Color1 = Color.FromArgb(8, 142, 254);
            cmbAudioQuality.StateCommon.DropBack.Color2 = Color.FromArgb(8, 142, 254);
            cmbAudioQuality.StateCommon.Item.Back.Color1 = Color.Orange;
            cmbAudioQuality.StateCommon.Item.Border.Color1 = Color.FromArgb(6, 174, 244);
            cmbAudioQuality.StateCommon.Item.Border.Color2 = Color.FromArgb(8, 142, 254);
            cmbAudioQuality.StateCommon.Item.Border.ColorAngle = 45F;
            cmbAudioQuality.StateCommon.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbAudioQuality.StateCommon.Item.Border.Rounding = 20F;
            cmbAudioQuality.StateCommon.Item.Border.Width = 1;
            cmbAudioQuality.StateCommon.Item.Content.ShortText.Color1 = Color.White;
            cmbAudioQuality.StateNormal.ComboBox.Back.Color1 = Color.FromArgb(8, 142, 254);
            cmbAudioQuality.StateNormal.ComboBox.Content.Color1 = Color.White;
            cmbAudioQuality.TabIndex = 1023;
            cmbAudioQuality.SelectedIndexChanged += cmbAudioQuality_SelectedIndexChanged;
            // 
            // chkAudioOnly
            // 
            chkAudioOnly.Location = new Point(541, 158);
            chkAudioOnly.Name = "chkAudioOnly";
            chkAudioOnly.Size = new Size(85, 20);
            chkAudioOnly.TabIndex = 1025;
            chkAudioOnly.Values.Text = "Audio Only";
            // 
            // lblDestino
            // 
            lblDestino.Location = new Point(-3, 198);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(59, 21);
            lblDestino.StateCommon.ShortText.Color1 = Color.FromArgb(6, 128, 254);
            lblDestino.StateCommon.ShortText.Color2 = Color.FromArgb(6, 128, 254);
            lblDestino.StateCommon.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDestino.TabIndex = 1027;
            lblDestino.Values.Text = "Destino:";
            // 
            // txtFilePath
            // 
            txtFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFilePath.Location = new Point(57, 195);
            txtFilePath.Margin = new Padding(4, 3, 4, 3);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(569, 30);
            txtFilePath.StateCommon.Back.Color1 = Color.White;
            txtFilePath.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtFilePath.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtFilePath.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtFilePath.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtFilePath.StateCommon.Border.Rounding = 20F;
            txtFilePath.StateCommon.Border.Width = 1;
            txtFilePath.StateCommon.Content.Color1 = Color.Gray;
            txtFilePath.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtFilePath.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtFilePath.TabIndex = 1026;
            // 
            // ListBoxURL
            // 
            ListBoxURL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListBoxURL.Location = new Point(57, 234);
            ListBoxURL.Name = "ListBoxURL";
            ListBoxURL.Size = new Size(569, 88);
            ListBoxURL.TabIndex = 1028;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            btnBrowse.IconColor = Color.FromArgb(6, 128, 254);
            btnBrowse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBrowse.IconSize = 42;
            btnBrowse.Location = new Point(631, 191);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(42, 42);
            btnBrowse.TabIndex = 1029;
            toolTip1.SetToolTip(btnBrowse, "Escolher local para salvar");
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
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
            btnExcluirSelecionados.Location = new Point(635, 288);
            btnExcluirSelecionados.Name = "btnExcluirSelecionados";
            btnExcluirSelecionados.Size = new Size(42, 42);
            btnExcluirSelecionados.TabIndex = 1031;
            toolTip1.SetToolTip(btnExcluirSelecionados, "Excluir link selecionado");
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
            btnLimparLista.Location = new Point(635, 238);
            btnLimparLista.Name = "btnLimparLista";
            btnLimparLista.Size = new Size(42, 42);
            btnLimparLista.TabIndex = 1030;
            toolTip1.SetToolTip(btnLimparLista, "Limpar lista");
            btnLimparLista.UseVisualStyleBackColor = true;
            btnLimparLista.Click += btnLimparLista_Click;
            // 
            // lblAnalisando
            // 
            lblAnalisando.AutoSize = true;
            lblAnalisando.BackColor = Color.FromArgb(170, 204, 255);
            lblAnalisando.Font = new Font("Microsoft Sans Serif", 12F);
            lblAnalisando.ForeColor = Color.Silver;
            lblAnalisando.Location = new Point(266, 260);
            lblAnalisando.Margin = new Padding(4, 0, 4, 0);
            lblAnalisando.Name = "lblAnalisando";
            lblAnalisando.Size = new Size(100, 20);
            lblAnalisando.TabIndex = 1032;
            lblAnalisando.Text = "Analisando...";
            lblAnalisando.Visible = false;
            // 
            // progressBarVideo
            // 
            progressBarVideo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBarVideo.Location = new Point(57, 341);
            progressBarVideo.Name = "progressBarVideo";
            progressBarVideo.Size = new Size(561, 10);
            progressBarVideo.TabIndex = 1033;
            progressBarVideo.UseKrypton = true;
            // 
            // btnDownload
            // 
            btnDownload.Anchor = AnchorStyles.Bottom;
            btnDownload.FlatAppearance.BorderSize = 0;
            btnDownload.FlatStyle = FlatStyle.Flat;
            btnDownload.IconChar = FontAwesome.Sharp.IconChar.Download;
            btnDownload.IconColor = Color.FromArgb(6, 128, 254);
            btnDownload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDownload.IconSize = 42;
            btnDownload.Location = new Point(396, 361);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(42, 42);
            btnDownload.TabIndex = 1035;
            toolTip1.SetToolTip(btnDownload, "Iniciar Download");
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
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
            btnCancelar.Location = new Point(346, 361);
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
            btnPausar.Location = new Point(296, 361);
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
            btnContinuar.Location = new Point(246, 361);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(42, 42);
            btnContinuar.TabIndex = 1038;
            toolTip1.SetToolTip(btnContinuar, "Continuar");
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus, toolStripStatusLabel1, lblStatusContagem });
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
            // progressBarTotal
            // 
            progressBarTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBarTotal.Location = new Point(57, 328);
            progressBarTotal.Name = "progressBarTotal";
            progressBarTotal.Size = new Size(561, 10);
            progressBarTotal.Style = ProgressBarStyle.Continuous;
            progressBarTotal.TabIndex = 1042;
            progressBarTotal.UseKrypton = true;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(10, 17);
            toolStripStatusLabel1.Text = "|";
            // 
            // lblStatusContagem
            // 
            lblStatusContagem.Name = "lblStatusContagem";
            lblStatusContagem.Size = new Size(98, 17);
            lblStatusContagem.Text = "Status Contagem";
            // 
            // FrmDownload
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 252);
            ClientSize = new Size(683, 424);
            Controls.Add(progressBarTotal);
            Controls.Add(statusStrip1);
            Controls.Add(btnContinuar);
            Controls.Add(btnPausar);
            Controls.Add(btnCancelar);
            Controls.Add(btnDownload);
            Controls.Add(progressBarVideo);
            Controls.Add(lblAnalisando);
            Controls.Add(btnExcluirSelecionados);
            Controls.Add(btnLimparLista);
            Controls.Add(btnBrowse);
            Controls.Add(ListBoxURL);
            Controls.Add(lblDestino);
            Controls.Add(txtFilePath);
            Controls.Add(chkAudioOnly);
            Controls.Add(lblAudioQuality);
            Controls.Add(cmbAudioQuality);
            Controls.Add(lblVideoQuality);
            Controls.Add(cmbVideoQuality);
            Controls.Add(btnAdicionarURL);
            Controls.Add(lblTitulo);
            Controls.Add(txtTitle);
            Controls.Add(panel1);
            Controls.Add(lblLink);
            Controls.Add(txtUrl);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDownload";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            Text = "Download Vídeo do Youtube";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbVideoQuality).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbAudioQuality).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public Krypton.Toolkit.KryptonTextBox txtUrl;
        private Krypton.Toolkit.KryptonLabel lblLink;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnFechar;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        public Krypton.Toolkit.KryptonTextBox txtTitle;
        private FontAwesome.Sharp.IconButton btnAdicionarURL;
        public Krypton.Toolkit.KryptonComboBox cmbVideoQuality;
        private Krypton.Toolkit.KryptonLabel lblVideoQuality;
        private Krypton.Toolkit.KryptonLabel lblAudioQuality;
        public Krypton.Toolkit.KryptonComboBox cmbAudioQuality;
        private Krypton.Toolkit.KryptonCheckBox chkAudioOnly;
        private Krypton.Toolkit.KryptonLabel lblDestino;
        public Krypton.Toolkit.KryptonTextBox txtFilePath;
        private Krypton.Toolkit.KryptonListBox ListBoxURL;
        private FontAwesome.Sharp.IconButton btnBrowse;
        private FontAwesome.Sharp.IconButton btnExcluirSelecionados;
        private FontAwesome.Sharp.IconButton btnLimparLista;
        private Label lblAnalisando;
        private Krypton.Toolkit.KryptonProgressBar progressBarVideo;
        private FontAwesome.Sharp.IconButton btnDownload;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnPausar;
        private FontAwesome.Sharp.IconButton btnContinuar;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private FontAwesome.Sharp.IconButton btnSair;
        private ToolTip toolTip1;
        private Krypton.Toolkit.KryptonProgressBar progressBarTotal;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblStatusContagem;
    }
}
