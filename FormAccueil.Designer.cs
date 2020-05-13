namespace WinecranFormsApp
{
    partial class FormAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccueil));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.jouerItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirEcranMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questRepMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decouverteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creerItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creerEcranMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenceItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBoutons = new System.Windows.Forms.Panel();
            this.sauverEcranButton = new System.Windows.Forms.Button();
            this.creerEcranButton = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.decouverteButton = new System.Windows.Forms.Button();
            this.aideButton = new System.Windows.Forms.Button();
            this.questionnerButton = new System.Windows.Forms.Button();
            this.ouvrirEcranButton = new System.Windows.Forms.Button();
            this.openFile_CZS = new System.Windows.Forms.OpenFileDialog();
            this.toolTipMenu = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog_BMP = new System.Windows.Forms.OpenFileDialog();
            this.openDialogSonShape = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxEcran = new System.Windows.Forms.PictureBox();
            this.MainMenu.SuspendLayout();
            this.panelBoutons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEcran)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jouerItem,
            this.creerItem,
            this.licenceItem,
            this.aideItem,
            this.aProposItem,
            this.quitterItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(680, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // jouerItem
            // 
            this.jouerItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirEcranMenuItem,
            this.questRepMenuItem,
            this.decouverteMenuItem,
            this.toolStripSeparator1,
            this.quitterMenuItem});
            this.jouerItem.Name = "jouerItem";
            this.jouerItem.Size = new System.Drawing.Size(48, 20);
            this.jouerItem.Text = "Jouer";
            // 
            // ouvrirEcranMenuItem
            // 
            this.ouvrirEcranMenuItem.Name = "ouvrirEcranMenuItem";
            this.ouvrirEcranMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ouvrirEcranMenuItem.Text = "Ouvrir un écran";
            this.ouvrirEcranMenuItem.Click += new System.EventHandler(this.chargerUnEcran_Click);
            // 
            // questRepMenuItem
            // 
            this.questRepMenuItem.Enabled = false;
            this.questRepMenuItem.Name = "questRepMenuItem";
            this.questRepMenuItem.Size = new System.Drawing.Size(201, 22);
            this.questRepMenuItem.Text = "Mode question/réponse";
            this.questRepMenuItem.Click += new System.EventHandler(this.questionnerClick);
            // 
            // decouverteMenuItem
            // 
            this.decouverteMenuItem.Enabled = false;
            this.decouverteMenuItem.Name = "decouverteMenuItem";
            this.decouverteMenuItem.Size = new System.Drawing.Size(201, 22);
            this.decouverteMenuItem.Text = "Mode découverte";
            this.decouverteMenuItem.Click += new System.EventHandler(this.StopQuestButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // quitterMenuItem
            // 
            this.quitterMenuItem.Name = "quitterMenuItem";
            this.quitterMenuItem.Size = new System.Drawing.Size(201, 22);
            this.quitterMenuItem.Text = "Quitter WinEcran";
            this.quitterMenuItem.Click += new System.EventHandler(this.quitterItem_Click);
            // 
            // creerItem
            // 
            this.creerItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creerEcranMenuItem,
            this.sauvegarderMenuItem});
            this.creerItem.Name = "creerItem";
            this.creerItem.Size = new System.Drawing.Size(46, 20);
            this.creerItem.Text = "Créer";
            // 
            // creerEcranMenuItem
            // 
            this.creerEcranMenuItem.Name = "creerEcranMenuItem";
            this.creerEcranMenuItem.Size = new System.Drawing.Size(178, 22);
            this.creerEcranMenuItem.Text = "Créer un écran";
            this.creerEcranMenuItem.Click += new System.EventHandler(this.creerEcranButton_Click);
            // 
            // sauvegarderMenuItem
            // 
            this.sauvegarderMenuItem.Enabled = false;
            this.sauvegarderMenuItem.Name = "sauvegarderMenuItem";
            this.sauvegarderMenuItem.Size = new System.Drawing.Size(178, 22);
            this.sauvegarderMenuItem.Text = "Sauvegarder l\'écran";
            this.sauvegarderMenuItem.Click += new System.EventHandler(this.sauverEcranButton_Click);
            // 
            // licenceItem
            // 
            this.licenceItem.Name = "licenceItem";
            this.licenceItem.Size = new System.Drawing.Size(59, 20);
            this.licenceItem.Text = "Licence";
            this.licenceItem.Click += new System.EventHandler(this.licenceItem_Click);
            // 
            // aideItem
            // 
            this.aideItem.Name = "aideItem";
            this.aideItem.Size = new System.Drawing.Size(43, 20);
            this.aideItem.Text = "&Aide";
            this.aideItem.Click += new System.EventHandler(this.aideItem_Click);
            // 
            // aProposItem
            // 
            this.aProposItem.Name = "aProposItem";
            this.aProposItem.Size = new System.Drawing.Size(76, 20);
            this.aProposItem.Text = "A propos...";
            this.aProposItem.Click += new System.EventHandler(this.aProposItem_Click);
            // 
            // quitterItem
            // 
            this.quitterItem.Name = "quitterItem";
            this.quitterItem.Size = new System.Drawing.Size(56, 20);
            this.quitterItem.Text = "Quitter";
            this.quitterItem.Click += new System.EventHandler(this.quitterItem_Click);
            // 
            // panelBoutons
            // 
            this.panelBoutons.AutoSize = true;
            this.panelBoutons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBoutons.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelBoutons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBoutons.Controls.Add(this.sauverEcranButton);
            this.panelBoutons.Controls.Add(this.creerEcranButton);
            this.panelBoutons.Controls.Add(this.labelScore);
            this.panelBoutons.Controls.Add(this.textBoxScore);
            this.panelBoutons.Controls.Add(this.decouverteButton);
            this.panelBoutons.Controls.Add(this.aideButton);
            this.panelBoutons.Controls.Add(this.questionnerButton);
            this.panelBoutons.Controls.Add(this.ouvrirEcranButton);
            this.panelBoutons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBoutons.Location = new System.Drawing.Point(0, 24);
            this.panelBoutons.Name = "panelBoutons";
            this.panelBoutons.Size = new System.Drawing.Size(680, 47);
            this.panelBoutons.TabIndex = 2;
            // 
            // sauverEcranButton
            // 
            this.sauverEcranButton.BackColor = System.Drawing.SystemColors.Control;
            this.sauverEcranButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sauverEcranButton.Enabled = false;
            this.sauverEcranButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sauverEcranButton.FlatAppearance.BorderSize = 0;
            this.sauverEcranButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.sauverEcranButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sauverEcranButton.Image = global::WinecranFormsApp.Properties.Resources.savefile;
            this.sauverEcranButton.Location = new System.Drawing.Point(243, 2);
            this.sauverEcranButton.Margin = new System.Windows.Forms.Padding(2, 2, 20, 2);
            this.sauverEcranButton.Name = "sauverEcranButton";
            this.sauverEcranButton.Size = new System.Drawing.Size(38, 38);
            this.sauverEcranButton.TabIndex = 8;
            this.toolTipMenu.SetToolTip(this.sauverEcranButton, "Sauvegarder l\'écran");
            this.sauverEcranButton.UseVisualStyleBackColor = false;
            this.sauverEcranButton.Click += new System.EventHandler(this.sauverEcranButton_Click);
            // 
            // creerEcranButton
            // 
            this.creerEcranButton.BackColor = System.Drawing.SystemColors.Control;
            this.creerEcranButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.creerEcranButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.creerEcranButton.FlatAppearance.BorderSize = 0;
            this.creerEcranButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.creerEcranButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creerEcranButton.Image = global::WinecranFormsApp.Properties.Resources.dessiner;
            this.creerEcranButton.Location = new System.Drawing.Point(197, 2);
            this.creerEcranButton.Margin = new System.Windows.Forms.Padding(2, 2, 20, 2);
            this.creerEcranButton.Name = "creerEcranButton";
            this.creerEcranButton.Size = new System.Drawing.Size(38, 38);
            this.creerEcranButton.TabIndex = 7;
            this.toolTipMenu.SetToolTip(this.creerEcranButton, "Créer un écran");
            this.creerEcranButton.UseVisualStyleBackColor = false;
            this.creerEcranButton.Click += new System.EventHandler(this.creerEcranButton_Click);
            // 
            // labelScore
            // 
            this.labelScore.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelScore.AutoSize = true;
            this.labelScore.Enabled = false;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(423, 11);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(60, 24);
            this.labelScore.TabIndex = 6;
            this.labelScore.Text = "Score";
            this.labelScore.Visible = false;
            // 
            // textBoxScore
            // 
            this.textBoxScore.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxScore.BackColor = System.Drawing.Color.LightGray;
            this.textBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScore.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBoxScore.Location = new System.Drawing.Point(488, 2);
            this.textBoxScore.MaxLength = 10;
            this.textBoxScore.Multiline = true;
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.ReadOnly = true;
            this.textBoxScore.Size = new System.Drawing.Size(101, 38);
            this.textBoxScore.TabIndex = 5;
            this.textBoxScore.TabStop = false;
            this.textBoxScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxScore.Visible = false;
            // 
            // decouverteButton
            // 
            this.decouverteButton.AccessibleDescription = "";
            this.decouverteButton.BackColor = System.Drawing.SystemColors.Control;
            this.decouverteButton.Enabled = false;
            this.decouverteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.decouverteButton.FlatAppearance.BorderSize = 0;
            this.decouverteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.decouverteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decouverteButton.Image = global::WinecranFormsApp.Properties.Resources.decouverte;
            this.decouverteButton.Location = new System.Drawing.Point(127, 2);
            this.decouverteButton.Margin = new System.Windows.Forms.Padding(2, 2, 10, 2);
            this.decouverteButton.Name = "decouverteButton";
            this.decouverteButton.Size = new System.Drawing.Size(38, 38);
            this.decouverteButton.TabIndex = 4;
            this.toolTipMenu.SetToolTip(this.decouverteButton, "Mode découverte");
            this.decouverteButton.UseVisualStyleBackColor = false;
            this.decouverteButton.Click += new System.EventHandler(this.StopQuestButton_Click);
            // 
            // aideButton
            // 
            this.aideButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.aideButton.BackColor = System.Drawing.SystemColors.Control;
            this.aideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aideButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.aideButton.FlatAppearance.BorderSize = 0;
            this.aideButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.aideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aideButton.Image = global::WinecranFormsApp.Properties.Resources.aide;
            this.aideButton.Location = new System.Drawing.Point(625, 2);
            this.aideButton.Margin = new System.Windows.Forms.Padding(2, 2, 20, 2);
            this.aideButton.Name = "aideButton";
            this.aideButton.Size = new System.Drawing.Size(38, 38);
            this.aideButton.TabIndex = 2;
            this.toolTipMenu.SetToolTip(this.aideButton, "Aide WinEcran");
            this.aideButton.UseVisualStyleBackColor = false;
            this.aideButton.Click += new System.EventHandler(this.aideItem_Click);
            // 
            // questionnerButton
            // 
            this.questionnerButton.AccessibleDescription = "";
            this.questionnerButton.BackColor = System.Drawing.SystemColors.Control;
            this.questionnerButton.Enabled = false;
            this.questionnerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.questionnerButton.FlatAppearance.BorderSize = 0;
            this.questionnerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.questionnerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questionnerButton.Image = global::WinecranFormsApp.Properties.Resources.questions;
            this.questionnerButton.Location = new System.Drawing.Point(83, 2);
            this.questionnerButton.Margin = new System.Windows.Forms.Padding(2, 2, 10, 2);
            this.questionnerButton.Name = "questionnerButton";
            this.questionnerButton.Size = new System.Drawing.Size(38, 38);
            this.questionnerButton.TabIndex = 1;
            this.toolTipMenu.SetToolTip(this.questionnerButton, "Mode question/réponse");
            this.questionnerButton.UseVisualStyleBackColor = false;
            this.questionnerButton.Click += new System.EventHandler(this.questionnerClick);
            // 
            // ouvrirEcranButton
            // 
            this.ouvrirEcranButton.BackColor = System.Drawing.SystemColors.Control;
            this.ouvrirEcranButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ouvrirEcranButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ouvrirEcranButton.FlatAppearance.BorderSize = 0;
            this.ouvrirEcranButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.ouvrirEcranButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ouvrirEcranButton.Image = global::WinecranFormsApp.Properties.Resources.jouer;
            this.ouvrirEcranButton.Location = new System.Drawing.Point(12, 2);
            this.ouvrirEcranButton.Margin = new System.Windows.Forms.Padding(2, 2, 20, 2);
            this.ouvrirEcranButton.Name = "ouvrirEcranButton";
            this.ouvrirEcranButton.Size = new System.Drawing.Size(38, 38);
            this.ouvrirEcranButton.TabIndex = 0;
            this.toolTipMenu.SetToolTip(this.ouvrirEcranButton, "Ouvrir un écran");
            this.ouvrirEcranButton.UseVisualStyleBackColor = false;
            this.ouvrirEcranButton.Click += new System.EventHandler(this.chargerUnEcran_Click);
            // 
            // openFile_CZS
            // 
            this.openFile_CZS.DefaultExt = "CZS";
            this.openFile_CZS.Filter = "Fichiers CZS | *.czs";
            // 
            // openFileDialog_BMP
            // 
            this.openFileDialog_BMP.Filter = "Fichiers BMP|*.bmp|Fichiers JPG|*.jpg";
            // 
            // openDialogSonShape
            // 
            this.openDialogSonShape.AddExtension = false;
            this.openDialogSonShape.CheckFileExists = false;
            this.openDialogSonShape.CheckPathExists = false;
            this.openDialogSonShape.Title = "Fichier son à associer";
            // 
            // pictureBoxEcran
            // 
            this.pictureBoxEcran.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEcran.Image")));
            this.pictureBoxEcran.InitialImage = null;
            this.pictureBoxEcran.Location = new System.Drawing.Point(0, 72);
            this.pictureBoxEcran.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxEcran.Name = "pictureBoxEcran";
            this.pictureBoxEcran.Size = new System.Drawing.Size(815, 525);
            this.pictureBoxEcran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEcran.TabIndex = 0;
            this.pictureBoxEcran.TabStop = false;
            this.pictureBoxEcran.WaitOnLoad = true;
            this.pictureBoxEcran.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBoxEcran.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBoxEcran.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // FormAccueil
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(680, 357);
            this.Controls.Add(this.panelBoutons);
            this.Controls.Add(this.pictureBoxEcran);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinEcran";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAccueil_FormClosing);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.FormAccueil_Layout);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.panelBoutons.ResumeLayout(false);
            this.panelBoutons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEcran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem jouerItem;
        private System.Windows.Forms.ToolStripMenuItem creerItem;
        private System.Windows.Forms.ToolStripMenuItem aideItem;
        private System.Windows.Forms.ToolStripMenuItem quitterItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirEcranMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questRepMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decouverteMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitterMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creerEcranMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderMenuItem;
        private System.Windows.Forms.Panel panelBoutons;
        private System.Windows.Forms.Button ouvrirEcranButton;
        private System.Windows.Forms.Button questionnerButton;
        private System.Windows.Forms.Button aideButton;
        private System.Windows.Forms.OpenFileDialog openFile_CZS;
        private System.Windows.Forms.Button decouverteButton;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.TextBox textBoxScore;
        public System.Windows.Forms.ToolStripMenuItem aProposItem;
        private System.Windows.Forms.ToolTip toolTipMenu;
        private System.Windows.Forms.Button creerEcranButton;
        private System.Windows.Forms.Button sauverEcranButton;
        public System.Windows.Forms.ToolStripMenuItem licenceItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog_BMP;
        private System.Windows.Forms.OpenFileDialog openDialogSonShape;
        public System.Windows.Forms.PictureBox pictureBoxEcran;
    }
}

