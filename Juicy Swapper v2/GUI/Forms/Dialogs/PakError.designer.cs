namespace Juicy_Swapper_v2.Forms.Dialogs
{
    partial class PakError
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PakError));
            this.formCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dialogMsgHeaderLabel = new System.Windows.Forms.Label();
            this.formDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dialogMsgTextLabel = new System.Windows.Forms.Label();
            this.confirmBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.confirmBtnCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.openDiscordBtnCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.openDiscordBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dialogMsgHeaderLabelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dialogMsgTextLabelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.closeDialogBtn = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.closeDialogBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // formCurving
            // 
            this.formCurving.ElipseRadius = 7;
            this.formCurving.TargetControl = this;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.Maroon;
            this.Sidebar.GradientBottomRight = System.Drawing.Color.Maroon;
            this.Sidebar.GradientTopLeft = System.Drawing.Color.DarkOrange;
            this.Sidebar.GradientTopRight = System.Drawing.Color.Maroon;
            this.Sidebar.Location = new System.Drawing.Point(-3, -7);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(70, 200);
            this.Sidebar.TabIndex = 1;
            // 
            // dialogMsgHeaderLabel
            // 
            this.dialogMsgHeaderLabel.AutoSize = true;
            this.dialogMsgHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline);
            this.dialogMsgHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.dialogMsgHeaderLabel.Location = new System.Drawing.Point(78, 11);
            this.dialogMsgHeaderLabel.Name = "dialogMsgHeaderLabel";
            this.dialogMsgHeaderLabel.Size = new System.Drawing.Size(215, 25);
            this.dialogMsgHeaderLabel.TabIndex = 3;
            this.dialogMsgHeaderLabel.Text = "Juicy Swapper v2 - Error";
            // 
            // formDragControl
            // 
            this.formDragControl.Fixed = true;
            this.formDragControl.Horizontal = true;
            this.formDragControl.TargetControl = this;
            this.formDragControl.Vertical = true;
            // 
            // dialogMsgTextLabel
            // 
            this.dialogMsgTextLabel.AutoSize = true;
            this.dialogMsgTextLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dialogMsgTextLabel.ForeColor = System.Drawing.Color.White;
            this.dialogMsgTextLabel.Location = new System.Drawing.Point(78, 40);
            this.dialogMsgTextLabel.Name = "dialogMsgTextLabel";
            this.dialogMsgTextLabel.Size = new System.Drawing.Size(311, 84);
            this.dialogMsgTextLabel.TabIndex = 6;
            this.dialogMsgTextLabel.Text = "The path to your .pak directory is incorrect! \r\nPlease change it in the Settings " +
    "tab. If you \r\nneed more help, join our Discord server by\r\nclicking on the \'DISCO" +
    "RD\' button below.";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Activecolor = System.Drawing.Color.Transparent;
            this.confirmBtn.BackColor = System.Drawing.Color.Transparent;
            this.confirmBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmBtn.BackgroundImage")));
            this.confirmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmBtn.BorderRadius = 0;
            this.confirmBtn.ButtonText = "Continue";
            this.confirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmBtn.DisabledColor = System.Drawing.Color.White;
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.confirmBtn.Iconimage = null;
            this.confirmBtn.Iconimage_right = null;
            this.confirmBtn.Iconimage_right_Selected = null;
            this.confirmBtn.Iconimage_Selected = null;
            this.confirmBtn.IconMarginLeft = 0;
            this.confirmBtn.IconMarginRight = 0;
            this.confirmBtn.IconRightVisible = true;
            this.confirmBtn.IconRightZoom = 0D;
            this.confirmBtn.IconVisible = true;
            this.confirmBtn.IconZoom = 50D;
            this.confirmBtn.IsTab = false;
            this.confirmBtn.Location = new System.Drawing.Point(314, 136);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.confirmBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.confirmBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.confirmBtn.selected = false;
            this.confirmBtn.Size = new System.Drawing.Size(76, 26);
            this.confirmBtn.TabIndex = 20;
            this.confirmBtn.Text = "Continue";
            this.confirmBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.confirmBtn.Textcolor = System.Drawing.Color.White;
            this.confirmBtn.TextFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // confirmBtnCurving
            // 
            this.confirmBtnCurving.ElipseRadius = 7;
            this.confirmBtnCurving.TargetControl = this.confirmBtn;
            // 
            // openDiscordBtnCurving
            // 
            this.openDiscordBtnCurving.ElipseRadius = 7;
            this.openDiscordBtnCurving.TargetControl = this.openDiscordBtn;
            // 
            // openDiscordBtn
            // 
            this.openDiscordBtn.Activecolor = System.Drawing.Color.Transparent;
            this.openDiscordBtn.BackColor = System.Drawing.Color.Transparent;
            this.openDiscordBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openDiscordBtn.BackgroundImage")));
            this.openDiscordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openDiscordBtn.BorderRadius = 0;
            this.openDiscordBtn.ButtonText = "Discord";
            this.openDiscordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openDiscordBtn.DisabledColor = System.Drawing.Color.White;
            this.openDiscordBtn.ForeColor = System.Drawing.Color.White;
            this.openDiscordBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.openDiscordBtn.Iconimage = null;
            this.openDiscordBtn.Iconimage_right = null;
            this.openDiscordBtn.Iconimage_right_Selected = null;
            this.openDiscordBtn.Iconimage_Selected = null;
            this.openDiscordBtn.IconMarginLeft = 0;
            this.openDiscordBtn.IconMarginRight = 0;
            this.openDiscordBtn.IconRightVisible = true;
            this.openDiscordBtn.IconRightZoom = 0D;
            this.openDiscordBtn.IconVisible = true;
            this.openDiscordBtn.IconZoom = 50D;
            this.openDiscordBtn.IsTab = false;
            this.openDiscordBtn.Location = new System.Drawing.Point(231, 136);
            this.openDiscordBtn.Name = "openDiscordBtn";
            this.openDiscordBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.openDiscordBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.openDiscordBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.openDiscordBtn.selected = false;
            this.openDiscordBtn.Size = new System.Drawing.Size(76, 26);
            this.openDiscordBtn.TabIndex = 21;
            this.openDiscordBtn.Text = "Discord";
            this.openDiscordBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.openDiscordBtn.Textcolor = System.Drawing.Color.White;
            this.openDiscordBtn.TextFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.openDiscordBtn.Click += new System.EventHandler(this.discordButton_Click);
            // 
            // dialogMsgHeaderLabelDragControl
            // 
            this.dialogMsgHeaderLabelDragControl.Fixed = true;
            this.dialogMsgHeaderLabelDragControl.Horizontal = true;
            this.dialogMsgHeaderLabelDragControl.TargetControl = this.dialogMsgHeaderLabel;
            this.dialogMsgHeaderLabelDragControl.Vertical = true;
            // 
            // dialogMsgTextLabelDragControl
            // 
            this.dialogMsgTextLabelDragControl.Fixed = true;
            this.dialogMsgTextLabelDragControl.Horizontal = true;
            this.dialogMsgTextLabelDragControl.TargetControl = this.dialogMsgTextLabel;
            this.dialogMsgTextLabelDragControl.Vertical = true;
            // 
            // closeDialogBtn
            // 
            this.closeDialogBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeDialogBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeDialogBtn.Image")));
            this.closeDialogBtn.ImageActive = null;
            this.closeDialogBtn.Location = new System.Drawing.Point(369, 12);
            this.closeDialogBtn.Name = "closeDialogBtn";
            this.closeDialogBtn.Size = new System.Drawing.Size(21, 14);
            this.closeDialogBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeDialogBtn.TabIndex = 23;
            this.closeDialogBtn.TabStop = false;
            this.closeDialogBtn.Zoom = 10;
            this.closeDialogBtn.Click += new System.EventHandler(this.closeDialogBtn_Click);
            // 
            // PakError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(402, 174);
            this.Controls.Add(this.closeDialogBtn);
            this.Controls.Add(this.openDiscordBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.dialogMsgTextLabel);
            this.Controls.Add(this.dialogMsgHeaderLabel);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PakError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juicy Swapper v2 - Error";
            ((System.ComponentModel.ISupportInitialize)(this.closeDialogBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse formCurving;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private System.Windows.Forms.Label dialogMsgHeaderLabel;
        private Bunifu.Framework.UI.BunifuDragControl formDragControl;
        private System.Windows.Forms.Label dialogMsgTextLabel;
        private Bunifu.Framework.UI.BunifuFlatButton confirmBtn;
        private Bunifu.Framework.UI.BunifuElipse confirmBtnCurving;
        private Bunifu.Framework.UI.BunifuElipse openDiscordBtnCurving;
        private Bunifu.Framework.UI.BunifuFlatButton openDiscordBtn;
        private Bunifu.Framework.UI.BunifuDragControl dialogMsgHeaderLabelDragControl;
        private Bunifu.Framework.UI.BunifuDragControl dialogMsgTextLabelDragControl;
        private Bunifu.Framework.UI.BunifuImageButton closeDialogBtn;
    }
}