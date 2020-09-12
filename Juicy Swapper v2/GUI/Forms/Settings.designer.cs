namespace Juicy_Swapper_v2.Forms
{
    partial class SettingsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsMenu));
            this.formCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pakLabel = new System.Windows.Forms.Label();
            this.selectPakPathButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.formDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.resetConfigBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.restartSwapperBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pakPathTextbox = new System.Windows.Forms.TextBox();
            this.restartSwapperBtnCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.resetCfgBtnCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.getConvertedBtnCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.getConvertedBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.launchFortniteBtnCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.launchFortniteBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.headerDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dialogMsgHeaderLabel = new System.Windows.Forms.Label();
            this.pakLabelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.openPakDirBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.checkPakDirBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.checkPakDirBtnCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.openPakDirBtnCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.selectPakPathButton)).BeginInit();
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
            this.Sidebar.Size = new System.Drawing.Size(70, 205);
            this.Sidebar.TabIndex = 1;
            // 
            // pakLabel
            // 
            this.pakLabel.AutoSize = true;
            this.pakLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pakLabel.ForeColor = System.Drawing.Color.White;
            this.pakLabel.Location = new System.Drawing.Point(78, 39);
            this.pakLabel.Name = "pakLabel";
            this.pakLabel.Size = new System.Drawing.Size(142, 21);
            this.pakLabel.TabIndex = 3;
            this.pakLabel.Text = "Path to paks folder:";
            // 
            // selectPakPathButton
            // 
            this.selectPakPathButton.BackColor = System.Drawing.Color.Transparent;
            this.selectPakPathButton.Image = ((System.Drawing.Image)(resources.GetObject("selectPakPathButton.Image")));
            this.selectPakPathButton.ImageActive = null;
            this.selectPakPathButton.Location = new System.Drawing.Point(447, 63);
            this.selectPakPathButton.Name = "selectPakPathButton";
            this.selectPakPathButton.Size = new System.Drawing.Size(40, 34);
            this.selectPakPathButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectPakPathButton.TabIndex = 4;
            this.selectPakPathButton.TabStop = false;
            this.selectPakPathButton.Zoom = 0;
            this.selectPakPathButton.Click += new System.EventHandler(this.selectPakPathButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(465, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 14);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 5;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 10;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // formDragControl
            // 
            this.formDragControl.Fixed = true;
            this.formDragControl.Horizontal = true;
            this.formDragControl.TargetControl = this;
            this.formDragControl.Vertical = true;
            // 
            // resetConfigBtn
            // 
            this.resetConfigBtn.Activecolor = System.Drawing.Color.Transparent;
            this.resetConfigBtn.BackColor = System.Drawing.Color.Transparent;
            this.resetConfigBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetConfigBtn.BackgroundImage")));
            this.resetConfigBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetConfigBtn.BorderRadius = 0;
            this.resetConfigBtn.ButtonText = "Reset Config";
            this.resetConfigBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetConfigBtn.DisabledColor = System.Drawing.Color.White;
            this.resetConfigBtn.ForeColor = System.Drawing.Color.White;
            this.resetConfigBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.resetConfigBtn.Iconimage = null;
            this.resetConfigBtn.Iconimage_right = null;
            this.resetConfigBtn.Iconimage_right_Selected = null;
            this.resetConfigBtn.Iconimage_Selected = null;
            this.resetConfigBtn.IconMarginLeft = 0;
            this.resetConfigBtn.IconMarginRight = 0;
            this.resetConfigBtn.IconRightVisible = true;
            this.resetConfigBtn.IconRightZoom = 0D;
            this.resetConfigBtn.IconVisible = true;
            this.resetConfigBtn.IconZoom = 50D;
            this.resetConfigBtn.IsTab = false;
            this.resetConfigBtn.Location = new System.Drawing.Point(212, 137);
            this.resetConfigBtn.Name = "resetConfigBtn";
            this.resetConfigBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.resetConfigBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.resetConfigBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.resetConfigBtn.selected = false;
            this.resetConfigBtn.Size = new System.Drawing.Size(124, 26);
            this.resetConfigBtn.TabIndex = 17;
            this.resetConfigBtn.Text = "Reset Config";
            this.resetConfigBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resetConfigBtn.Textcolor = System.Drawing.Color.White;
            this.resetConfigBtn.TextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetConfigBtn.Click += new System.EventHandler(this.resetConfigButton_Click);
            // 
            // restartSwapperBtn
            // 
            this.restartSwapperBtn.Activecolor = System.Drawing.Color.Transparent;
            this.restartSwapperBtn.BackColor = System.Drawing.Color.Transparent;
            this.restartSwapperBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("restartSwapperBtn.BackgroundImage")));
            this.restartSwapperBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.restartSwapperBtn.BorderRadius = 0;
            this.restartSwapperBtn.ButtonText = "Restart Swapper";
            this.restartSwapperBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartSwapperBtn.DisabledColor = System.Drawing.Color.White;
            this.restartSwapperBtn.ForeColor = System.Drawing.Color.White;
            this.restartSwapperBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.restartSwapperBtn.Iconimage = null;
            this.restartSwapperBtn.Iconimage_right = null;
            this.restartSwapperBtn.Iconimage_right_Selected = null;
            this.restartSwapperBtn.Iconimage_Selected = null;
            this.restartSwapperBtn.IconMarginLeft = 0;
            this.restartSwapperBtn.IconMarginRight = 0;
            this.restartSwapperBtn.IconRightVisible = true;
            this.restartSwapperBtn.IconRightZoom = 0D;
            this.restartSwapperBtn.IconVisible = true;
            this.restartSwapperBtn.IconZoom = 50D;
            this.restartSwapperBtn.IsTab = false;
            this.restartSwapperBtn.Location = new System.Drawing.Point(82, 105);
            this.restartSwapperBtn.Name = "restartSwapperBtn";
            this.restartSwapperBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.restartSwapperBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.restartSwapperBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.restartSwapperBtn.selected = false;
            this.restartSwapperBtn.Size = new System.Drawing.Size(124, 26);
            this.restartSwapperBtn.TabIndex = 19;
            this.restartSwapperBtn.Text = "Restart Swapper";
            this.restartSwapperBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.restartSwapperBtn.Textcolor = System.Drawing.Color.White;
            this.restartSwapperBtn.TextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartSwapperBtn.Click += new System.EventHandler(this.restartSwapperBtn_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.bunifuSeparator1.LineThickness = 4;
            this.bunifuSeparator1.Location = new System.Drawing.Point(82, 89);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(364, 10);
            this.bunifuSeparator1.TabIndex = 20;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // pakPathTextbox
            // 
            this.pakPathTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.pakPathTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pakPathTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pakPathTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pakPathTextbox.ForeColor = System.Drawing.Color.White;
            this.pakPathTextbox.Location = new System.Drawing.Point(82, 72);
            this.pakPathTextbox.Name = "pakPathTextbox";
            this.pakPathTextbox.ReadOnly = true;
            this.pakPathTextbox.Size = new System.Drawing.Size(364, 16);
            this.pakPathTextbox.TabIndex = 21;
            // 
            // restartSwapperBtnCurving
            // 
            this.restartSwapperBtnCurving.ElipseRadius = 7;
            this.restartSwapperBtnCurving.TargetControl = this.restartSwapperBtn;
            // 
            // resetCfgBtnCurving
            // 
            this.resetCfgBtnCurving.ElipseRadius = 7;
            this.resetCfgBtnCurving.TargetControl = this.resetConfigBtn;
            // 
            // getConvertedBtnCurving
            // 
            this.getConvertedBtnCurving.ElipseRadius = 7;
            this.getConvertedBtnCurving.TargetControl = this.getConvertedBtn;
            // 
            // getConvertedBtn
            // 
            this.getConvertedBtn.Activecolor = System.Drawing.Color.Transparent;
            this.getConvertedBtn.BackColor = System.Drawing.Color.Transparent;
            this.getConvertedBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("getConvertedBtn.BackgroundImage")));
            this.getConvertedBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.getConvertedBtn.BorderRadius = 0;
            this.getConvertedBtn.ButtonText = "Get Converted Items";
            this.getConvertedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getConvertedBtn.DisabledColor = System.Drawing.Color.White;
            this.getConvertedBtn.ForeColor = System.Drawing.Color.White;
            this.getConvertedBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.getConvertedBtn.Iconimage = null;
            this.getConvertedBtn.Iconimage_right = null;
            this.getConvertedBtn.Iconimage_right_Selected = null;
            this.getConvertedBtn.Iconimage_Selected = null;
            this.getConvertedBtn.IconMarginLeft = 0;
            this.getConvertedBtn.IconMarginRight = 0;
            this.getConvertedBtn.IconRightVisible = true;
            this.getConvertedBtn.IconRightZoom = 0D;
            this.getConvertedBtn.IconVisible = true;
            this.getConvertedBtn.IconZoom = 50D;
            this.getConvertedBtn.IsTab = false;
            this.getConvertedBtn.Location = new System.Drawing.Point(82, 137);
            this.getConvertedBtn.Name = "getConvertedBtn";
            this.getConvertedBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.getConvertedBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.getConvertedBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.getConvertedBtn.selected = false;
            this.getConvertedBtn.Size = new System.Drawing.Size(124, 26);
            this.getConvertedBtn.TabIndex = 18;
            this.getConvertedBtn.Text = "Get Converted Items";
            this.getConvertedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.getConvertedBtn.Textcolor = System.Drawing.Color.White;
            this.getConvertedBtn.TextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getConvertedBtn.Click += new System.EventHandler(this.convertedItemsButton_Click);
            // 
            // launchFortniteBtnCurving
            // 
            this.launchFortniteBtnCurving.ElipseRadius = 7;
            this.launchFortniteBtnCurving.TargetControl = this.launchFortniteBtn;
            // 
            // launchFortniteBtn
            // 
            this.launchFortniteBtn.Activecolor = System.Drawing.Color.Transparent;
            this.launchFortniteBtn.BackColor = System.Drawing.Color.Transparent;
            this.launchFortniteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("launchFortniteBtn.BackgroundImage")));
            this.launchFortniteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.launchFortniteBtn.BorderRadius = 0;
            this.launchFortniteBtn.ButtonText = "Launch Fortnite";
            this.launchFortniteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.launchFortniteBtn.DisabledColor = System.Drawing.Color.White;
            this.launchFortniteBtn.ForeColor = System.Drawing.Color.White;
            this.launchFortniteBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.launchFortniteBtn.Iconimage = null;
            this.launchFortniteBtn.Iconimage_right = null;
            this.launchFortniteBtn.Iconimage_right_Selected = null;
            this.launchFortniteBtn.Iconimage_Selected = null;
            this.launchFortniteBtn.IconMarginLeft = 0;
            this.launchFortniteBtn.IconMarginRight = 0;
            this.launchFortniteBtn.IconRightVisible = true;
            this.launchFortniteBtn.IconRightZoom = 0D;
            this.launchFortniteBtn.IconVisible = true;
            this.launchFortniteBtn.IconZoom = 50D;
            this.launchFortniteBtn.IsTab = false;
            this.launchFortniteBtn.Location = new System.Drawing.Point(342, 137);
            this.launchFortniteBtn.Name = "launchFortniteBtn";
            this.launchFortniteBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.launchFortniteBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.launchFortniteBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.launchFortniteBtn.selected = false;
            this.launchFortniteBtn.Size = new System.Drawing.Size(124, 26);
            this.launchFortniteBtn.TabIndex = 23;
            this.launchFortniteBtn.Text = "Launch Fortnite";
            this.launchFortniteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.launchFortniteBtn.Textcolor = System.Drawing.Color.White;
            this.launchFortniteBtn.TextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchFortniteBtn.Click += new System.EventHandler(this.launchFortniteBtn_Click);
            // 
            // headerDragControl
            // 
            this.headerDragControl.Fixed = true;
            this.headerDragControl.Horizontal = true;
            this.headerDragControl.TargetControl = this.dialogMsgHeaderLabel;
            this.headerDragControl.Vertical = true;
            // 
            // dialogMsgHeaderLabel
            // 
            this.dialogMsgHeaderLabel.AutoSize = true;
            this.dialogMsgHeaderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialogMsgHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.dialogMsgHeaderLabel.Location = new System.Drawing.Point(77, 9);
            this.dialogMsgHeaderLabel.Name = "dialogMsgHeaderLabel";
            this.dialogMsgHeaderLabel.Size = new System.Drawing.Size(246, 25);
            this.dialogMsgHeaderLabel.TabIndex = 22;
            this.dialogMsgHeaderLabel.Text = "Juicy Swapper v2 - Settings";
            // 
            // pakLabelDragControl
            // 
            this.pakLabelDragControl.Fixed = true;
            this.pakLabelDragControl.Horizontal = true;
            this.pakLabelDragControl.TargetControl = this.pakLabel;
            this.pakLabelDragControl.Vertical = true;
            // 
            // openPakDirBtn
            // 
            this.openPakDirBtn.Activecolor = System.Drawing.Color.Transparent;
            this.openPakDirBtn.BackColor = System.Drawing.Color.Transparent;
            this.openPakDirBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openPakDirBtn.BackgroundImage")));
            this.openPakDirBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openPakDirBtn.BorderRadius = 0;
            this.openPakDirBtn.ButtonText = "Open Pak Directory";
            this.openPakDirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openPakDirBtn.DisabledColor = System.Drawing.Color.White;
            this.openPakDirBtn.ForeColor = System.Drawing.Color.White;
            this.openPakDirBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.openPakDirBtn.Iconimage = null;
            this.openPakDirBtn.Iconimage_right = null;
            this.openPakDirBtn.Iconimage_right_Selected = null;
            this.openPakDirBtn.Iconimage_Selected = null;
            this.openPakDirBtn.IconMarginLeft = 0;
            this.openPakDirBtn.IconMarginRight = 0;
            this.openPakDirBtn.IconRightVisible = true;
            this.openPakDirBtn.IconRightZoom = 0D;
            this.openPakDirBtn.IconVisible = true;
            this.openPakDirBtn.IconZoom = 50D;
            this.openPakDirBtn.IsTab = false;
            this.openPakDirBtn.Location = new System.Drawing.Point(212, 105);
            this.openPakDirBtn.Name = "openPakDirBtn";
            this.openPakDirBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.openPakDirBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.openPakDirBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.openPakDirBtn.selected = false;
            this.openPakDirBtn.Size = new System.Drawing.Size(124, 26);
            this.openPakDirBtn.TabIndex = 25;
            this.openPakDirBtn.Text = "Open Pak Directory";
            this.openPakDirBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.openPakDirBtn.Textcolor = System.Drawing.Color.White;
            this.openPakDirBtn.TextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPakDirBtn.Click += new System.EventHandler(this.openPakDirBtn_Click);
            // 
            // checkPakDirBtn
            // 
            this.checkPakDirBtn.Activecolor = System.Drawing.Color.Transparent;
            this.checkPakDirBtn.BackColor = System.Drawing.Color.Transparent;
            this.checkPakDirBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkPakDirBtn.BackgroundImage")));
            this.checkPakDirBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkPakDirBtn.BorderRadius = 0;
            this.checkPakDirBtn.ButtonText = "Check Pak Directory";
            this.checkPakDirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkPakDirBtn.DisabledColor = System.Drawing.Color.White;
            this.checkPakDirBtn.ForeColor = System.Drawing.Color.White;
            this.checkPakDirBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.checkPakDirBtn.Iconimage = null;
            this.checkPakDirBtn.Iconimage_right = null;
            this.checkPakDirBtn.Iconimage_right_Selected = null;
            this.checkPakDirBtn.Iconimage_Selected = null;
            this.checkPakDirBtn.IconMarginLeft = 0;
            this.checkPakDirBtn.IconMarginRight = 0;
            this.checkPakDirBtn.IconRightVisible = true;
            this.checkPakDirBtn.IconRightZoom = 0D;
            this.checkPakDirBtn.IconVisible = true;
            this.checkPakDirBtn.IconZoom = 50D;
            this.checkPakDirBtn.IsTab = false;
            this.checkPakDirBtn.Location = new System.Drawing.Point(342, 105);
            this.checkPakDirBtn.Name = "checkPakDirBtn";
            this.checkPakDirBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.checkPakDirBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.checkPakDirBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.checkPakDirBtn.selected = false;
            this.checkPakDirBtn.Size = new System.Drawing.Size(124, 26);
            this.checkPakDirBtn.TabIndex = 24;
            this.checkPakDirBtn.Text = "Check Pak Directory";
            this.checkPakDirBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkPakDirBtn.Textcolor = System.Drawing.Color.White;
            this.checkPakDirBtn.TextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPakDirBtn.Click += new System.EventHandler(this.checkPakDirBtn_Click);
            // 
            // checkPakDirBtnCurving
            // 
            this.checkPakDirBtnCurving.ElipseRadius = 7;
            this.checkPakDirBtnCurving.TargetControl = this.checkPakDirBtn;
            // 
            // openPakDirBtnCurving
            // 
            this.openPakDirBtnCurving.ElipseRadius = 5;
            this.openPakDirBtnCurving.TargetControl = this.openPakDirBtn;
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(498, 179);
            this.Controls.Add(this.openPakDirBtn);
            this.Controls.Add(this.checkPakDirBtn);
            this.Controls.Add(this.launchFortniteBtn);
            this.Controls.Add(this.dialogMsgHeaderLabel);
            this.Controls.Add(this.pakPathTextbox);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.restartSwapperBtn);
            this.Controls.Add(this.getConvertedBtn);
            this.Controls.Add(this.resetConfigBtn);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.selectPakPathButton);
            this.Controls.Add(this.pakLabel);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Juicy Swapper v2 - Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectPakPathButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse formCurving;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private System.Windows.Forms.Label pakLabel;
        private Bunifu.Framework.UI.BunifuImageButton selectPakPathButton;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private Bunifu.Framework.UI.BunifuDragControl formDragControl;
        private Bunifu.Framework.UI.BunifuFlatButton restartSwapperBtn;
        private Bunifu.Framework.UI.BunifuFlatButton resetConfigBtn;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.TextBox pakPathTextbox;
        private Bunifu.Framework.UI.BunifuElipse restartSwapperBtnCurving;
        private Bunifu.Framework.UI.BunifuElipse resetCfgBtnCurving;
        private Bunifu.Framework.UI.BunifuElipse getConvertedBtnCurving;
        private Bunifu.Framework.UI.BunifuElipse launchFortniteBtnCurving;
        private Bunifu.Framework.UI.BunifuDragControl headerDragControl;
        private System.Windows.Forms.Label dialogMsgHeaderLabel;
        private Bunifu.Framework.UI.BunifuFlatButton launchFortniteBtn;
        private Bunifu.Framework.UI.BunifuDragControl pakLabelDragControl;
        private Bunifu.Framework.UI.BunifuFlatButton openPakDirBtn;
        private Bunifu.Framework.UI.BunifuFlatButton checkPakDirBtn;
        private Bunifu.Framework.UI.BunifuElipse checkPakDirBtnCurving;
        private Bunifu.Framework.UI.BunifuElipse openPakDirBtnCurving;
        private Bunifu.Framework.UI.BunifuFlatButton getConvertedBtn;
    }
}