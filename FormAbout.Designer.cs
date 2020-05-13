namespace WinecranFormsApp
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAbout = new System.Windows.Forms.PictureBox();
            this.buttonAboutOK = new System.Windows.Forms.Button();
            this.textBoxAbout = new System.Windows.Forms.TextBox();
            this.labelAchatAbout = new System.Windows.Forms.Label();
            this.linkLabelAchat = new System.Windows.Forms.LinkLabel();
            this.labelContactAbout = new System.Windows.Forms.Label();
            this.linkLabelContact = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAbout
            // 
            this.pictureBoxAbout.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAbout.Image")));
            this.pictureBoxAbout.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAbout.Name = "pictureBoxAbout";
            this.pictureBoxAbout.Size = new System.Drawing.Size(424, 52);
            this.pictureBoxAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAbout.TabIndex = 0;
            this.pictureBoxAbout.TabStop = false;
            // 
            // buttonAboutOK
            // 
            this.buttonAboutOK.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonAboutOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAboutOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAboutOK.Location = new System.Drawing.Point(366, 333);
            this.buttonAboutOK.Name = "buttonAboutOK";
            this.buttonAboutOK.Size = new System.Drawing.Size(70, 32);
            this.buttonAboutOK.TabIndex = 1;
            this.buttonAboutOK.Text = "OK";
            this.buttonAboutOK.UseVisualStyleBackColor = false;
            this.buttonAboutOK.Click += new System.EventHandler(this.buttonAboutOK_Click);
            // 
            // textBoxAbout
            // 
            this.textBoxAbout.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAbout.Location = new System.Drawing.Point(12, 78);
            this.textBoxAbout.Multiline = true;
            this.textBoxAbout.Name = "textBoxAbout";
            this.textBoxAbout.ReadOnly = true;
            this.textBoxAbout.Size = new System.Drawing.Size(424, 192);
            this.textBoxAbout.TabIndex = 2;
            this.textBoxAbout.Text = resources.GetString("textBoxAbout.Text");
            this.textBoxAbout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAchatAbout
            // 
            this.labelAchatAbout.AutoSize = true;
            this.labelAchatAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAchatAbout.Location = new System.Drawing.Point(9, 281);
            this.labelAchatAbout.Name = "labelAchatAbout";
            this.labelAchatAbout.Size = new System.Drawing.Size(110, 15);
            this.labelAchatAbout.TabIndex = 3;
            this.labelAchatAbout.Text = "Acheter WinEcran :";
            // 
            // linkLabelAchat
            // 
            this.linkLabelAchat.AutoSize = true;
            this.linkLabelAchat.Location = new System.Drawing.Point(120, 282);
            this.linkLabelAchat.Name = "linkLabelAchat";
            this.linkLabelAchat.Size = new System.Drawing.Size(306, 13);
            this.linkLabelAchat.TabIndex = 4;
            this.linkLabelAchat.TabStop = true;
            this.linkLabelAchat.Text = "https://winecran.pagesperso-orange.fr/services/download.html";
            this.linkLabelAchat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAchat_LinkClicked);
            // 
            // labelContactAbout
            // 
            this.labelContactAbout.AutoSize = true;
            this.labelContactAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactAbout.Location = new System.Drawing.Point(9, 307);
            this.labelContactAbout.Name = "labelContactAbout";
            this.labelContactAbout.Size = new System.Drawing.Size(109, 15);
            this.labelContactAbout.TabIndex = 5;
            this.labelContactAbout.Text = "Contacter l\'auteur :";
            // 
            // linkLabelContact
            // 
            this.linkLabelContact.AutoSize = true;
            this.linkLabelContact.Location = new System.Drawing.Point(120, 308);
            this.linkLabelContact.Name = "linkLabelContact";
            this.linkLabelContact.Size = new System.Drawing.Size(241, 13);
            this.linkLabelContact.TabIndex = 6;
            this.linkLabelContact.TabStop = true;
            this.linkLabelContact.Text = "https://winecran.pagesperso-orange.fr/index.html";
            this.linkLabelContact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelContact_LinkClicked);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(452, 377);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabelContact);
            this.Controls.Add(this.labelContactAbout);
            this.Controls.Add(this.linkLabelAchat);
            this.Controls.Add(this.labelAchatAbout);
            this.Controls.Add(this.textBoxAbout);
            this.Controls.Add(this.buttonAboutOK);
            this.Controls.Add(this.pictureBoxAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormAbout";
            this.Text = "A propos de WinEcran";
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.FormAbout_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAbout;
        private System.Windows.Forms.Button buttonAboutOK;
        private System.Windows.Forms.TextBox textBoxAbout;
        private System.Windows.Forms.Label labelAchatAbout;
        private System.Windows.Forms.LinkLabel linkLabelAchat;
        private System.Windows.Forms.Label labelContactAbout;
        private System.Windows.Forms.LinkLabel linkLabelContact;
    }
}