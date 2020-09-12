namespace Juicy_Swapper_v2.Forms.Dialogs
{
    partial class OfflineMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfflineMode));
            this.formCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dialogMsgHeaderLabel = new System.Windows.Forms.Label();
            this.formDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dialogMsgTextLabel = new System.Windows.Forms.Label();
            this.openStatusBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openStatusBtnCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.openDiscordBtnCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.openDiscordBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.dialogMsgHeaderLabelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dialogMsgTextLabelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
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
            this.Sidebar.Size = new System.Drawing.Size(70, 235);
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
            this.dialogMsgTextLabel.Size = new System.Drawing.Size(324, 105);
            this.dialogMsgTextLabel.TabIndex = 6;
            this.dialogMsgTextLabel.Text = "Juicy Swapper v2 is currently offline, so you\r\naren\'t able to launch the swapper " +
    "at this time.\r\nMake sure to join our Discord for more info.\r\n\r\nReason: yea\r\n";
            // 
            // openStatusBtn
            // 
            this.openStatusBtn.Activecolor = System.Drawing.Color.Transparent;
            this.openStatusBtn.BackColor = System.Drawing.Color.Transparent;
            this.openStatusBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openStatusBtn.BackgroundImage")));
            this.openStatusBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openStatusBtn.BorderRadius = 0;
            this.openStatusBtn.ButtonText = "Status";
            this.openStatusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openStatusBtn.DisabledColor = System.Drawing.Color.White;
            this.openStatusBtn.ForeColor = System.Drawing.Color.White;
            this.openStatusBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.openStatusBtn.Iconimage = null;
            this.openStatusBtn.Iconimage_right = null;
            this.openStatusBtn.Iconimage_right_Selected = null;
            this.openStatusBtn.Iconimage_Selected = null;
            this.openStatusBtn.IconMarginLeft = 0;
            this.openStatusBtn.IconMarginRight = 0;
            this.openStatusBtn.IconRightVisible = true;
            this.openStatusBtn.IconRightZoom = 0D;
            this.openStatusBtn.IconVisible = true;
            this.openStatusBtn.IconZoom = 50D;
            this.openStatusBtn.IsTab = false;
            this.openStatusBtn.Location = new System.Drawing.Point(352, 171);
            this.openStatusBtn.Name = "openStatusBtn";
            this.openStatusBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.openStatusBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.openStatusBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.openStatusBtn.selected = false;
            this.openStatusBtn.Size = new System.Drawing.Size(76, 26);
            this.openStatusBtn.TabIndex = 20;
            this.openStatusBtn.Text = "Status";
            this.openStatusBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.openStatusBtn.Textcolor = System.Drawing.Color.White;
            this.openStatusBtn.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openStatusBtn.Click += new System.EventHandler(this.statusButton_Click);
            // 
            // openStatusBtnCurving
            // 
            this.openStatusBtnCurving.ElipseRadius = 7;
            this.openStatusBtnCurving.TargetControl = this.openStatusBtn;
            // 
            // openDiscordBtnCurving
            // 
            this.openDiscordBtnCurving.ElipseRadius = 5;
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
            this.openDiscordBtn.Location = new System.Drawing.Point(270, 171);
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
            this.openDiscordBtn.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openDiscordBtn.Click += new System.EventHandler(this.discordButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(407, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 14);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 22;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 10;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
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
            // OfflineMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(440, 209);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.openDiscordBtn);
            this.Controls.Add(this.openStatusBtn);
            this.Controls.Add(this.dialogMsgTextLabel);
            this.Controls.Add(this.dialogMsgHeaderLabel);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OfflineMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juicy Swapper v2 - Error";
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse formCurving;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private System.Windows.Forms.Label dialogMsgHeaderLabel;
        private Bunifu.Framework.UI.BunifuDragControl formDragControl;
        private System.Windows.Forms.Label dialogMsgTextLabel;
        private Bunifu.Framework.UI.BunifuFlatButton openStatusBtn;
        private Bunifu.Framework.UI.BunifuElipse openStatusBtnCurving;
        private Bunifu.Framework.UI.BunifuElipse openDiscordBtnCurving;
        private Bunifu.Framework.UI.BunifuFlatButton openDiscordBtn;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private Bunifu.Framework.UI.BunifuDragControl dialogMsgHeaderLabelDragControl;
        private Bunifu.Framework.UI.BunifuDragControl dialogMsgTextLabelDragControl;
    }
}