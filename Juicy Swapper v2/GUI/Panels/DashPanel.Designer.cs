namespace Juicy_Swapper_v2.Panels
{
    partial class DashPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashPanel));
            this.panelCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.contentPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.newsTitleLabel = new System.Windows.Forms.Label();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.currentVersionLabel = new System.Windows.Forms.Label();
            this.newsImagePictureBox = new System.Windows.Forms.PictureBox();
            this.newsTextLabel = new System.Windows.Forms.Label();
            this.newsHeaderText = new System.Windows.Forms.Label();
            this.changelogTextLabel = new System.Windows.Forms.Label();
            this.changelogHeaderText = new System.Windows.Forms.Label();
            this.contentPanelCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.contentPanelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.changelogHeaderDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.changelogTextDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.newsTextDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.newsHeaderDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.versionLabelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.newsImageDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.sidebarCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.labelDashboardDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.newsTitleDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCurving
            // 
            this.panelCurving.ElipseRadius = 7;
            this.panelCurving.TargetControl = this;
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.contentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contentPanel.BackgroundImage")));
            this.contentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contentPanel.Controls.Add(this.closeButton);
            this.contentPanel.Controls.Add(this.newsTitleLabel);
            this.contentPanel.Controls.Add(this.labelDashboard);
            this.contentPanel.Controls.Add(this.currentVersionLabel);
            this.contentPanel.Controls.Add(this.newsImagePictureBox);
            this.contentPanel.Controls.Add(this.newsTextLabel);
            this.contentPanel.Controls.Add(this.newsHeaderText);
            this.contentPanel.Controls.Add(this.changelogTextLabel);
            this.contentPanel.Controls.Add(this.changelogHeaderText);
            this.contentPanel.GradientBottomLeft = System.Drawing.Color.DarkOrange;
            this.contentPanel.GradientBottomRight = System.Drawing.Color.DarkOrange;
            this.contentPanel.GradientTopLeft = System.Drawing.Color.Orchid;
            this.contentPanel.GradientTopRight = System.Drawing.Color.DarkOrange;
            this.contentPanel.Location = new System.Drawing.Point(7, 19);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Quality = 10;
            this.contentPanel.Size = new System.Drawing.Size(704, 573);
            this.contentPanel.TabIndex = 17;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(676, 8);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 14);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 25;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 10;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // newsTitleLabel
            // 
            this.newsTitleLabel.AutoSize = true;
            this.newsTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.newsTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsTitleLabel.ForeColor = System.Drawing.Color.White;
            this.newsTitleLabel.Location = new System.Drawing.Point(12, 281);
            this.newsTitleLabel.Name = "newsTitleLabel";
            this.newsTitleLabel.Size = new System.Drawing.Size(86, 21);
            this.newsTitleLabel.TabIndex = 25;
            this.newsTitleLabel.Text = "News Title";
            // 
            // labelDashboard
            // 
            this.labelDashboard.AutoSize = true;
            this.labelDashboard.BackColor = System.Drawing.Color.Transparent;
            this.labelDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboard.ForeColor = System.Drawing.Color.White;
            this.labelDashboard.Location = new System.Drawing.Point(9, 8);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(149, 37);
            this.labelDashboard.TabIndex = 24;
            this.labelDashboard.Text = "Dashboard";
            // 
            // currentVersionLabel
            // 
            this.currentVersionLabel.AutoSize = true;
            this.currentVersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentVersionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentVersionLabel.ForeColor = System.Drawing.Color.White;
            this.currentVersionLabel.Location = new System.Drawing.Point(11, 532);
            this.currentVersionLabel.Name = "currentVersionLabel";
            this.currentVersionLabel.Size = new System.Drawing.Size(173, 30);
            this.currentVersionLabel.TabIndex = 23;
            this.currentVersionLabel.Text = "Current Version: ";
            // 
            // newsImagePictureBox
            // 
            this.newsImagePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.newsImagePictureBox.Location = new System.Drawing.Point(16, 98);
            this.newsImagePictureBox.Name = "newsImagePictureBox";
            this.newsImagePictureBox.Size = new System.Drawing.Size(320, 180);
            this.newsImagePictureBox.TabIndex = 22;
            this.newsImagePictureBox.TabStop = false;
            // 
            // newsTextLabel
            // 
            this.newsTextLabel.AutoSize = true;
            this.newsTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.newsTextLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsTextLabel.ForeColor = System.Drawing.Color.White;
            this.newsTextLabel.Location = new System.Drawing.Point(12, 304);
            this.newsTextLabel.Name = "newsTextLabel";
            this.newsTextLabel.Size = new System.Drawing.Size(80, 21);
            this.newsTextLabel.TabIndex = 21;
            this.newsTextLabel.Text = "News Text";
            // 
            // newsHeaderText
            // 
            this.newsHeaderText.AutoSize = true;
            this.newsHeaderText.BackColor = System.Drawing.Color.Transparent;
            this.newsHeaderText.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.newsHeaderText.ForeColor = System.Drawing.Color.White;
            this.newsHeaderText.Location = new System.Drawing.Point(10, 59);
            this.newsHeaderText.Name = "newsHeaderText";
            this.newsHeaderText.Size = new System.Drawing.Size(74, 32);
            this.newsHeaderText.TabIndex = 20;
            this.newsHeaderText.Text = "News";
            // 
            // changelogTextLabel
            // 
            this.changelogTextLabel.AutoSize = true;
            this.changelogTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.changelogTextLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changelogTextLabel.ForeColor = System.Drawing.Color.White;
            this.changelogTextLabel.Location = new System.Drawing.Point(352, 98);
            this.changelogTextLabel.Name = "changelogTextLabel";
            this.changelogTextLabel.Size = new System.Drawing.Size(118, 21);
            this.changelogTextLabel.TabIndex = 19;
            this.changelogTextLabel.Text = "Changelog Text";
            // 
            // changelogHeaderText
            // 
            this.changelogHeaderText.AutoSize = true;
            this.changelogHeaderText.BackColor = System.Drawing.Color.Transparent;
            this.changelogHeaderText.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.changelogHeaderText.ForeColor = System.Drawing.Color.White;
            this.changelogHeaderText.Location = new System.Drawing.Point(350, 59);
            this.changelogHeaderText.Name = "changelogHeaderText";
            this.changelogHeaderText.Size = new System.Drawing.Size(132, 32);
            this.changelogHeaderText.TabIndex = 18;
            this.changelogHeaderText.Text = "Changelog";
            // 
            // contentPanelCurving
            // 
            this.contentPanelCurving.ElipseRadius = 7;
            this.contentPanelCurving.TargetControl = this.contentPanel;
            // 
            // panelDragControl
            // 
            this.panelDragControl.Fixed = true;
            this.panelDragControl.Horizontal = true;
            this.panelDragControl.TargetControl = this;
            this.panelDragControl.Vertical = true;
            // 
            // contentPanelDragControl
            // 
            this.contentPanelDragControl.Fixed = true;
            this.contentPanelDragControl.Horizontal = true;
            this.contentPanelDragControl.TargetControl = this.contentPanel;
            this.contentPanelDragControl.Vertical = true;
            // 
            // changelogHeaderDragControl
            // 
            this.changelogHeaderDragControl.Fixed = true;
            this.changelogHeaderDragControl.Horizontal = true;
            this.changelogHeaderDragControl.TargetControl = this.changelogHeaderText;
            this.changelogHeaderDragControl.Vertical = true;
            // 
            // changelogTextDragControl
            // 
            this.changelogTextDragControl.Fixed = true;
            this.changelogTextDragControl.Horizontal = true;
            this.changelogTextDragControl.TargetControl = this.changelogTextLabel;
            this.changelogTextDragControl.Vertical = true;
            // 
            // newsTextDragControl
            // 
            this.newsTextDragControl.Fixed = true;
            this.newsTextDragControl.Horizontal = true;
            this.newsTextDragControl.TargetControl = this.newsTextLabel;
            this.newsTextDragControl.Vertical = true;
            // 
            // newsHeaderDragControl
            // 
            this.newsHeaderDragControl.Fixed = true;
            this.newsHeaderDragControl.Horizontal = true;
            this.newsHeaderDragControl.TargetControl = this.newsHeaderText;
            this.newsHeaderDragControl.Vertical = true;
            // 
            // versionLabelDragControl
            // 
            this.versionLabelDragControl.Fixed = true;
            this.versionLabelDragControl.Horizontal = true;
            this.versionLabelDragControl.TargetControl = this.currentVersionLabel;
            this.versionLabelDragControl.Vertical = true;
            // 
            // newsImageDragControl
            // 
            this.newsImageDragControl.Fixed = true;
            this.newsImageDragControl.Horizontal = true;
            this.newsImageDragControl.TargetControl = this.newsImagePictureBox;
            this.newsImageDragControl.Vertical = true;
            // 
            // sidebarCurving
            // 
            this.sidebarCurving.ElipseRadius = 7;
            this.sidebarCurving.TargetControl = this;
            // 
            // labelDashboardDragControl
            // 
            this.labelDashboardDragControl.Fixed = true;
            this.labelDashboardDragControl.Horizontal = true;
            this.labelDashboardDragControl.TargetControl = this.labelDashboard;
            this.labelDashboardDragControl.Vertical = true;
            // 
            // newsTitleDragControl
            // 
            this.newsTitleDragControl.Fixed = true;
            this.newsTitleDragControl.Horizontal = true;
            this.newsTitleDragControl.TargetControl = this.newsTitleLabel;
            this.newsTitleDragControl.Vertical = true;
            // 
            // DashPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.contentPanel);
            this.Name = "DashPanel";
            this.Size = new System.Drawing.Size(739, 609);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsImagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse panelCurving;
        private Bunifu.Framework.UI.BunifuGradientPanel contentPanel;
        private Bunifu.Framework.UI.BunifuElipse contentPanelCurving;
        private System.Windows.Forms.Label changelogHeaderText;
        private Bunifu.Framework.UI.BunifuDragControl panelDragControl;
        private System.Windows.Forms.Label changelogTextLabel;
        private System.Windows.Forms.PictureBox newsImagePictureBox;
        private System.Windows.Forms.Label newsTextLabel;
        private System.Windows.Forms.Label newsHeaderText;
        private System.Windows.Forms.Label currentVersionLabel;
        private Bunifu.Framework.UI.BunifuDragControl contentPanelDragControl;
        private Bunifu.Framework.UI.BunifuDragControl changelogHeaderDragControl;
        private Bunifu.Framework.UI.BunifuDragControl changelogTextDragControl;
        private Bunifu.Framework.UI.BunifuDragControl newsTextDragControl;
        private Bunifu.Framework.UI.BunifuDragControl newsHeaderDragControl;
        private Bunifu.Framework.UI.BunifuDragControl versionLabelDragControl;
        private Bunifu.Framework.UI.BunifuDragControl newsImageDragControl;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.Label newsTitleLabel;
        private Bunifu.Framework.UI.BunifuElipse sidebarCurving;
        private Bunifu.Framework.UI.BunifuDragControl labelDashboardDragControl;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private Bunifu.Framework.UI.BunifuDragControl newsTitleDragControl;
    }
}
