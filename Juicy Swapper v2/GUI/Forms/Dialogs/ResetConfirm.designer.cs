namespace Juicy_Swapper_v2.Forms.Dialogs
{
    partial class ResetConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetConfirm));
            this.formCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dialogMsgHeaderLabel = new System.Windows.Forms.Label();
            this.formDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dialogMsgTextLabel = new System.Windows.Forms.Label();
            this.confirmBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cancelBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.confirmBtnCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cancelBtnCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dialogMsgHeaderLabelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dialogMsgTextLabelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
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
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.DarkOrange;
            this.Sidebar.GradientBottomRight = System.Drawing.Color.DarkOrange;
            this.Sidebar.GradientTopLeft = System.Drawing.Color.Orchid;
            this.Sidebar.GradientTopRight = System.Drawing.Color.DarkOrange;
            this.Sidebar.Location = new System.Drawing.Point(-3, -7);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(70, 186);
            this.Sidebar.TabIndex = 1;
            // 
            // dialogMsgHeaderLabel
            // 
            this.dialogMsgHeaderLabel.AutoSize = true;
            this.dialogMsgHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline);
            this.dialogMsgHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.dialogMsgHeaderLabel.Location = new System.Drawing.Point(78, 11);
            this.dialogMsgHeaderLabel.Name = "dialogMsgHeaderLabel";
            this.dialogMsgHeaderLabel.Size = new System.Drawing.Size(247, 25);
            this.dialogMsgHeaderLabel.TabIndex = 3;
            this.dialogMsgHeaderLabel.Text = "Juicy Swapper v2 - Message";
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
            this.dialogMsgTextLabel.Size = new System.Drawing.Size(326, 63);
            this.dialogMsgTextLabel.TabIndex = 6;
            this.dialogMsgTextLabel.Text = "Are you sure you want to reset your swapper \r\nconfiguration? Doing so will reset " +
    "all item\r\nstates and all swapped items will be removed.";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Activecolor = System.Drawing.Color.Transparent;
            this.confirmBtn.BackColor = System.Drawing.Color.Transparent;
            this.confirmBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmBtn.BackgroundImage")));
            this.confirmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmBtn.BorderRadius = 0;
            this.confirmBtn.ButtonText = "Confirm";
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
            this.confirmBtn.Location = new System.Drawing.Point(328, 122);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.confirmBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.confirmBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.confirmBtn.selected = false;
            this.confirmBtn.Size = new System.Drawing.Size(76, 26);
            this.confirmBtn.TabIndex = 20;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.confirmBtn.Textcolor = System.Drawing.Color.White;
            this.confirmBtn.TextFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.confirmBtn.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Activecolor = System.Drawing.Color.Transparent;
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.BackgroundImage")));
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelBtn.BorderRadius = 0;
            this.cancelBtn.ButtonText = "Cancel";
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.DisabledColor = System.Drawing.Color.White;
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.cancelBtn.Iconimage = null;
            this.cancelBtn.Iconimage_right = null;
            this.cancelBtn.Iconimage_right_Selected = null;
            this.cancelBtn.Iconimage_Selected = null;
            this.cancelBtn.IconMarginLeft = 0;
            this.cancelBtn.IconMarginRight = 0;
            this.cancelBtn.IconRightVisible = true;
            this.cancelBtn.IconRightZoom = 0D;
            this.cancelBtn.IconVisible = true;
            this.cancelBtn.IconZoom = 50D;
            this.cancelBtn.IsTab = false;
            this.cancelBtn.Location = new System.Drawing.Point(246, 122);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.cancelBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.cancelBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.cancelBtn.selected = false;
            this.cancelBtn.Size = new System.Drawing.Size(76, 26);
            this.cancelBtn.TabIndex = 21;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelBtn.Textcolor = System.Drawing.Color.White;
            this.cancelBtn.TextFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cancelBtn.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmBtnCurving
            // 
            this.confirmBtnCurving.ElipseRadius = 7;
            this.confirmBtnCurving.TargetControl = this.confirmBtn;
            // 
            // cancelBtnCurving
            // 
            this.cancelBtnCurving.ElipseRadius = 7;
            this.cancelBtnCurving.TargetControl = this.cancelBtn;
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
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(383, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 14);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 23;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 10;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ResetConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(416, 160);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.dialogMsgTextLabel);
            this.Controls.Add(this.dialogMsgHeaderLabel);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResetConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juicy Swapper v2 - Message";
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
        private Bunifu.Framework.UI.BunifuFlatButton confirmBtn;
        private Bunifu.Framework.UI.BunifuFlatButton cancelBtn;
        private Bunifu.Framework.UI.BunifuElipse confirmBtnCurving;
        private Bunifu.Framework.UI.BunifuElipse cancelBtnCurving;
        private Bunifu.Framework.UI.BunifuDragControl dialogMsgHeaderLabelDragControl;
        private Bunifu.Framework.UI.BunifuDragControl dialogMsgTextLabelDragControl;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
    }
}