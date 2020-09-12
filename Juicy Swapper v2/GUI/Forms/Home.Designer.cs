namespace Juicy_Swapper_v2.Forms
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.sidebarWrapper = new System.Windows.Forms.Panel();
            this.formSidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.displayItemShopFormBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.userWelcomeLabel = new System.Windows.Forms.Label();
            this.iconJuicyIndustries = new Bunifu.Framework.UI.BunifuImageButton();
            this.displaySettingsFormBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.displayMiscPanelTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.displayEmotesPanelBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.displayPickaxesPanelBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.displayBackblingsPanelBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.displaySkinsPanelBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.displayDashPanelBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sidebarSeparator = new Bunifu.Framework.UI.BunifuSeparator();
            this.labelJuicySwapper = new System.Windows.Forms.Label();
            this.formWrapper = new System.Windows.Forms.Panel();
            this.sidebarCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.formDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.formCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.swapperLabelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.welcomeLabelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.sidebarDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.sidebarWrapper.SuspendLayout();
            this.formSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconJuicyIndustries)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarWrapper
            // 
            this.sidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.sidebarWrapper.Controls.Add(this.formSidebar);
            this.sidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarWrapper.Location = new System.Drawing.Point(0, 0);
            this.sidebarWrapper.Name = "sidebarWrapper";
            this.sidebarWrapper.Size = new System.Drawing.Size(272, 609);
            this.sidebarWrapper.TabIndex = 1;
            // 
            // formSidebar
            // 
            this.formSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.formSidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("formSidebar.BackgroundImage")));
            this.formSidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.formSidebar.Controls.Add(this.displayItemShopFormBtn);
            this.formSidebar.Controls.Add(this.userWelcomeLabel);
            this.formSidebar.Controls.Add(this.iconJuicyIndustries);
            this.formSidebar.Controls.Add(this.displaySettingsFormBtn);
            this.formSidebar.Controls.Add(this.displayMiscPanelTab);
            this.formSidebar.Controls.Add(this.displayEmotesPanelBtn);
            this.formSidebar.Controls.Add(this.displayPickaxesPanelBtn);
            this.formSidebar.Controls.Add(this.displayBackblingsPanelBtn);
            this.formSidebar.Controls.Add(this.displaySkinsPanelBtn);
            this.formSidebar.Controls.Add(this.displayDashPanelBtn);
            this.formSidebar.Controls.Add(this.sidebarSeparator);
            this.formSidebar.Controls.Add(this.labelJuicySwapper);
            this.formSidebar.GradientBottomLeft = System.Drawing.Color.DarkOrange;
            this.formSidebar.GradientBottomRight = System.Drawing.Color.DarkOrange;
            this.formSidebar.GradientTopLeft = System.Drawing.Color.Orchid;
            this.formSidebar.GradientTopRight = System.Drawing.Color.DarkOrange;
            this.formSidebar.Location = new System.Drawing.Point(16, 19);
            this.formSidebar.Name = "formSidebar";
            this.formSidebar.Quality = 10;
            this.formSidebar.Size = new System.Drawing.Size(249, 573);
            this.formSidebar.TabIndex = 0;
            // 
            // displayItemShopFormBtn
            // 
            this.displayItemShopFormBtn.Activecolor = System.Drawing.Color.Transparent;
            this.displayItemShopFormBtn.BackColor = System.Drawing.Color.Transparent;
            this.displayItemShopFormBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displayItemShopFormBtn.BorderRadius = 0;
            this.displayItemShopFormBtn.ButtonText = "      ITEM SHOP";
            this.displayItemShopFormBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displayItemShopFormBtn.DisabledColor = System.Drawing.Color.Gray;
            this.displayItemShopFormBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.displayItemShopFormBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("displayItemShopFormBtn.Iconimage")));
            this.displayItemShopFormBtn.Iconimage_right = null;
            this.displayItemShopFormBtn.Iconimage_right_Selected = null;
            this.displayItemShopFormBtn.Iconimage_Selected = null;
            this.displayItemShopFormBtn.IconMarginLeft = 0;
            this.displayItemShopFormBtn.IconMarginRight = 0;
            this.displayItemShopFormBtn.IconRightVisible = true;
            this.displayItemShopFormBtn.IconRightZoom = 0D;
            this.displayItemShopFormBtn.IconVisible = true;
            this.displayItemShopFormBtn.IconZoom = 50D;
            this.displayItemShopFormBtn.IsTab = false;
            this.displayItemShopFormBtn.Location = new System.Drawing.Point(9, 451);
            this.displayItemShopFormBtn.Name = "displayItemShopFormBtn";
            this.displayItemShopFormBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.displayItemShopFormBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.displayItemShopFormBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.displayItemShopFormBtn.selected = false;
            this.displayItemShopFormBtn.Size = new System.Drawing.Size(252, 51);
            this.displayItemShopFormBtn.TabIndex = 16;
            this.displayItemShopFormBtn.Text = "      ITEM SHOP";
            this.displayItemShopFormBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displayItemShopFormBtn.Textcolor = System.Drawing.Color.White;
            this.displayItemShopFormBtn.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayItemShopFormBtn.Click += new System.EventHandler(this.displayItemShopFormBtn_Click);
            // 
            // userWelcomeLabel
            // 
            this.userWelcomeLabel.AutoSize = true;
            this.userWelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.userWelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userWelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.userWelcomeLabel.Location = new System.Drawing.Point(64, 36);
            this.userWelcomeLabel.Name = "userWelcomeLabel";
            this.userWelcomeLabel.Size = new System.Drawing.Size(63, 15);
            this.userWelcomeLabel.TabIndex = 15;
            this.userWelcomeLabel.Text = "Welcome, ";
            // 
            // iconJuicyIndustries
            // 
            this.iconJuicyIndustries.BackColor = System.Drawing.Color.Transparent;
            this.iconJuicyIndustries.Image = ((System.Drawing.Image)(resources.GetObject("iconJuicyIndustries.Image")));
            this.iconJuicyIndustries.ImageActive = null;
            this.iconJuicyIndustries.Location = new System.Drawing.Point(13, 13);
            this.iconJuicyIndustries.Name = "iconJuicyIndustries";
            this.iconJuicyIndustries.Size = new System.Drawing.Size(40, 40);
            this.iconJuicyIndustries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconJuicyIndustries.TabIndex = 1;
            this.iconJuicyIndustries.TabStop = false;
            this.iconJuicyIndustries.Zoom = 10;
            // 
            // displaySettingsFormBtn
            // 
            this.displaySettingsFormBtn.Activecolor = System.Drawing.Color.Transparent;
            this.displaySettingsFormBtn.BackColor = System.Drawing.Color.Transparent;
            this.displaySettingsFormBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displaySettingsFormBtn.BorderRadius = 0;
            this.displaySettingsFormBtn.ButtonText = "      SETTINGS";
            this.displaySettingsFormBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displaySettingsFormBtn.DisabledColor = System.Drawing.Color.Gray;
            this.displaySettingsFormBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.displaySettingsFormBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("displaySettingsFormBtn.Iconimage")));
            this.displaySettingsFormBtn.Iconimage_right = null;
            this.displaySettingsFormBtn.Iconimage_right_Selected = null;
            this.displaySettingsFormBtn.Iconimage_Selected = null;
            this.displaySettingsFormBtn.IconMarginLeft = 0;
            this.displaySettingsFormBtn.IconMarginRight = 0;
            this.displaySettingsFormBtn.IconRightVisible = true;
            this.displaySettingsFormBtn.IconRightZoom = 0D;
            this.displaySettingsFormBtn.IconVisible = true;
            this.displaySettingsFormBtn.IconZoom = 50D;
            this.displaySettingsFormBtn.IsTab = false;
            this.displaySettingsFormBtn.Location = new System.Drawing.Point(9, 512);
            this.displaySettingsFormBtn.Name = "displaySettingsFormBtn";
            this.displaySettingsFormBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.displaySettingsFormBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.displaySettingsFormBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.displaySettingsFormBtn.selected = false;
            this.displaySettingsFormBtn.Size = new System.Drawing.Size(252, 51);
            this.displaySettingsFormBtn.TabIndex = 14;
            this.displaySettingsFormBtn.Text = "      SETTINGS";
            this.displaySettingsFormBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displaySettingsFormBtn.Textcolor = System.Drawing.Color.White;
            this.displaySettingsFormBtn.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaySettingsFormBtn.Click += new System.EventHandler(this.displaySettingsFormBtn_Click);
            // 
            // displayMiscPanelTab
            // 
            this.displayMiscPanelTab.Activecolor = System.Drawing.Color.Transparent;
            this.displayMiscPanelTab.BackColor = System.Drawing.Color.Transparent;
            this.displayMiscPanelTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displayMiscPanelTab.BorderRadius = 0;
            this.displayMiscPanelTab.ButtonText = "      MISCELLANEOUS";
            this.displayMiscPanelTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displayMiscPanelTab.DisabledColor = System.Drawing.Color.Gray;
            this.displayMiscPanelTab.Iconcolor = System.Drawing.Color.Transparent;
            this.displayMiscPanelTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("displayMiscPanelTab.Iconimage")));
            this.displayMiscPanelTab.Iconimage_right = null;
            this.displayMiscPanelTab.Iconimage_right_Selected = null;
            this.displayMiscPanelTab.Iconimage_Selected = null;
            this.displayMiscPanelTab.IconMarginLeft = 0;
            this.displayMiscPanelTab.IconMarginRight = 0;
            this.displayMiscPanelTab.IconRightVisible = true;
            this.displayMiscPanelTab.IconRightZoom = 0D;
            this.displayMiscPanelTab.IconVisible = true;
            this.displayMiscPanelTab.IconZoom = 50D;
            this.displayMiscPanelTab.IsTab = false;
            this.displayMiscPanelTab.Location = new System.Drawing.Point(9, 390);
            this.displayMiscPanelTab.Name = "displayMiscPanelTab";
            this.displayMiscPanelTab.Normalcolor = System.Drawing.Color.Transparent;
            this.displayMiscPanelTab.OnHovercolor = System.Drawing.Color.Transparent;
            this.displayMiscPanelTab.OnHoverTextColor = System.Drawing.Color.White;
            this.displayMiscPanelTab.selected = false;
            this.displayMiscPanelTab.Size = new System.Drawing.Size(252, 51);
            this.displayMiscPanelTab.TabIndex = 13;
            this.displayMiscPanelTab.Text = "      MISCELLANEOUS";
            this.displayMiscPanelTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displayMiscPanelTab.Textcolor = System.Drawing.Color.White;
            this.displayMiscPanelTab.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayMiscPanelTab.Click += new System.EventHandler(this.displayMiscPanelTab_Click);
            // 
            // displayEmotesPanelBtn
            // 
            this.displayEmotesPanelBtn.Activecolor = System.Drawing.Color.Transparent;
            this.displayEmotesPanelBtn.BackColor = System.Drawing.Color.Transparent;
            this.displayEmotesPanelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displayEmotesPanelBtn.BorderRadius = 0;
            this.displayEmotesPanelBtn.ButtonText = "      EMOTES";
            this.displayEmotesPanelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displayEmotesPanelBtn.DisabledColor = System.Drawing.Color.Gray;
            this.displayEmotesPanelBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.displayEmotesPanelBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("displayEmotesPanelBtn.Iconimage")));
            this.displayEmotesPanelBtn.Iconimage_right = null;
            this.displayEmotesPanelBtn.Iconimage_right_Selected = null;
            this.displayEmotesPanelBtn.Iconimage_Selected = null;
            this.displayEmotesPanelBtn.IconMarginLeft = 0;
            this.displayEmotesPanelBtn.IconMarginRight = 0;
            this.displayEmotesPanelBtn.IconRightVisible = true;
            this.displayEmotesPanelBtn.IconRightZoom = 0D;
            this.displayEmotesPanelBtn.IconVisible = true;
            this.displayEmotesPanelBtn.IconZoom = 50D;
            this.displayEmotesPanelBtn.IsTab = false;
            this.displayEmotesPanelBtn.Location = new System.Drawing.Point(9, 329);
            this.displayEmotesPanelBtn.Name = "displayEmotesPanelBtn";
            this.displayEmotesPanelBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.displayEmotesPanelBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.displayEmotesPanelBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.displayEmotesPanelBtn.selected = false;
            this.displayEmotesPanelBtn.Size = new System.Drawing.Size(252, 51);
            this.displayEmotesPanelBtn.TabIndex = 12;
            this.displayEmotesPanelBtn.Text = "      EMOTES";
            this.displayEmotesPanelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displayEmotesPanelBtn.Textcolor = System.Drawing.Color.White;
            this.displayEmotesPanelBtn.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayEmotesPanelBtn.Click += new System.EventHandler(this.displayEmotesPanelBtn_Click);
            // 
            // displayPickaxesPanelBtn
            // 
            this.displayPickaxesPanelBtn.Activecolor = System.Drawing.Color.Transparent;
            this.displayPickaxesPanelBtn.BackColor = System.Drawing.Color.Transparent;
            this.displayPickaxesPanelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displayPickaxesPanelBtn.BorderRadius = 0;
            this.displayPickaxesPanelBtn.ButtonText = "      PICKAXES";
            this.displayPickaxesPanelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displayPickaxesPanelBtn.DisabledColor = System.Drawing.Color.Gray;
            this.displayPickaxesPanelBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.displayPickaxesPanelBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("displayPickaxesPanelBtn.Iconimage")));
            this.displayPickaxesPanelBtn.Iconimage_right = null;
            this.displayPickaxesPanelBtn.Iconimage_right_Selected = null;
            this.displayPickaxesPanelBtn.Iconimage_Selected = null;
            this.displayPickaxesPanelBtn.IconMarginLeft = 0;
            this.displayPickaxesPanelBtn.IconMarginRight = 0;
            this.displayPickaxesPanelBtn.IconRightVisible = true;
            this.displayPickaxesPanelBtn.IconRightZoom = 0D;
            this.displayPickaxesPanelBtn.IconVisible = true;
            this.displayPickaxesPanelBtn.IconZoom = 50D;
            this.displayPickaxesPanelBtn.IsTab = false;
            this.displayPickaxesPanelBtn.Location = new System.Drawing.Point(9, 268);
            this.displayPickaxesPanelBtn.Name = "displayPickaxesPanelBtn";
            this.displayPickaxesPanelBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.displayPickaxesPanelBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.displayPickaxesPanelBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.displayPickaxesPanelBtn.selected = false;
            this.displayPickaxesPanelBtn.Size = new System.Drawing.Size(252, 51);
            this.displayPickaxesPanelBtn.TabIndex = 11;
            this.displayPickaxesPanelBtn.Text = "      PICKAXES";
            this.displayPickaxesPanelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displayPickaxesPanelBtn.Textcolor = System.Drawing.Color.White;
            this.displayPickaxesPanelBtn.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayPickaxesPanelBtn.Click += new System.EventHandler(this.displayPickaxesPanelBtn_Click);
            // 
            // displayBackblingsPanelBtn
            // 
            this.displayBackblingsPanelBtn.Activecolor = System.Drawing.Color.Transparent;
            this.displayBackblingsPanelBtn.BackColor = System.Drawing.Color.Transparent;
            this.displayBackblingsPanelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displayBackblingsPanelBtn.BorderRadius = 0;
            this.displayBackblingsPanelBtn.ButtonText = "      BACKBLINGS";
            this.displayBackblingsPanelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displayBackblingsPanelBtn.DisabledColor = System.Drawing.Color.Gray;
            this.displayBackblingsPanelBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.displayBackblingsPanelBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("displayBackblingsPanelBtn.Iconimage")));
            this.displayBackblingsPanelBtn.Iconimage_right = null;
            this.displayBackblingsPanelBtn.Iconimage_right_Selected = null;
            this.displayBackblingsPanelBtn.Iconimage_Selected = null;
            this.displayBackblingsPanelBtn.IconMarginLeft = 0;
            this.displayBackblingsPanelBtn.IconMarginRight = 0;
            this.displayBackblingsPanelBtn.IconRightVisible = true;
            this.displayBackblingsPanelBtn.IconRightZoom = 0D;
            this.displayBackblingsPanelBtn.IconVisible = true;
            this.displayBackblingsPanelBtn.IconZoom = 50D;
            this.displayBackblingsPanelBtn.IsTab = false;
            this.displayBackblingsPanelBtn.Location = new System.Drawing.Point(9, 207);
            this.displayBackblingsPanelBtn.Name = "displayBackblingsPanelBtn";
            this.displayBackblingsPanelBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.displayBackblingsPanelBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.displayBackblingsPanelBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.displayBackblingsPanelBtn.selected = false;
            this.displayBackblingsPanelBtn.Size = new System.Drawing.Size(252, 51);
            this.displayBackblingsPanelBtn.TabIndex = 10;
            this.displayBackblingsPanelBtn.Text = "      BACKBLINGS";
            this.displayBackblingsPanelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displayBackblingsPanelBtn.Textcolor = System.Drawing.Color.White;
            this.displayBackblingsPanelBtn.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBackblingsPanelBtn.Click += new System.EventHandler(this.displayBackblingsPanelBtn_Click);
            // 
            // displaySkinsPanelBtn
            // 
            this.displaySkinsPanelBtn.Activecolor = System.Drawing.Color.Transparent;
            this.displaySkinsPanelBtn.BackColor = System.Drawing.Color.Transparent;
            this.displaySkinsPanelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displaySkinsPanelBtn.BorderRadius = 0;
            this.displaySkinsPanelBtn.ButtonText = "      SKINS";
            this.displaySkinsPanelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displaySkinsPanelBtn.DisabledColor = System.Drawing.Color.Gray;
            this.displaySkinsPanelBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.displaySkinsPanelBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("displaySkinsPanelBtn.Iconimage")));
            this.displaySkinsPanelBtn.Iconimage_right = null;
            this.displaySkinsPanelBtn.Iconimage_right_Selected = null;
            this.displaySkinsPanelBtn.Iconimage_Selected = null;
            this.displaySkinsPanelBtn.IconMarginLeft = 0;
            this.displaySkinsPanelBtn.IconMarginRight = 0;
            this.displaySkinsPanelBtn.IconRightVisible = true;
            this.displaySkinsPanelBtn.IconRightZoom = 0D;
            this.displaySkinsPanelBtn.IconVisible = true;
            this.displaySkinsPanelBtn.IconZoom = 50D;
            this.displaySkinsPanelBtn.IsTab = false;
            this.displaySkinsPanelBtn.Location = new System.Drawing.Point(9, 146);
            this.displaySkinsPanelBtn.Name = "displaySkinsPanelBtn";
            this.displaySkinsPanelBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.displaySkinsPanelBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.displaySkinsPanelBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.displaySkinsPanelBtn.selected = false;
            this.displaySkinsPanelBtn.Size = new System.Drawing.Size(252, 51);
            this.displaySkinsPanelBtn.TabIndex = 9;
            this.displaySkinsPanelBtn.Text = "      SKINS";
            this.displaySkinsPanelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displaySkinsPanelBtn.Textcolor = System.Drawing.Color.White;
            this.displaySkinsPanelBtn.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaySkinsPanelBtn.Click += new System.EventHandler(this.displaySkinsPanelBtn_Click);
            // 
            // displayDashPanelBtn
            // 
            this.displayDashPanelBtn.Activecolor = System.Drawing.Color.Transparent;
            this.displayDashPanelBtn.BackColor = System.Drawing.Color.Transparent;
            this.displayDashPanelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displayDashPanelBtn.BorderRadius = 0;
            this.displayDashPanelBtn.ButtonText = "      DASHBOARD";
            this.displayDashPanelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displayDashPanelBtn.DisabledColor = System.Drawing.Color.Gray;
            this.displayDashPanelBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.displayDashPanelBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("displayDashPanelBtn.Iconimage")));
            this.displayDashPanelBtn.Iconimage_right = null;
            this.displayDashPanelBtn.Iconimage_right_Selected = null;
            this.displayDashPanelBtn.Iconimage_Selected = null;
            this.displayDashPanelBtn.IconMarginLeft = 0;
            this.displayDashPanelBtn.IconMarginRight = 0;
            this.displayDashPanelBtn.IconRightVisible = true;
            this.displayDashPanelBtn.IconRightZoom = 0D;
            this.displayDashPanelBtn.IconVisible = true;
            this.displayDashPanelBtn.IconZoom = 50D;
            this.displayDashPanelBtn.IsTab = false;
            this.displayDashPanelBtn.Location = new System.Drawing.Point(9, 85);
            this.displayDashPanelBtn.Name = "displayDashPanelBtn";
            this.displayDashPanelBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.displayDashPanelBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.displayDashPanelBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.displayDashPanelBtn.selected = false;
            this.displayDashPanelBtn.Size = new System.Drawing.Size(252, 51);
            this.displayDashPanelBtn.TabIndex = 8;
            this.displayDashPanelBtn.Text = "      DASHBOARD";
            this.displayDashPanelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displayDashPanelBtn.Textcolor = System.Drawing.Color.White;
            this.displayDashPanelBtn.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayDashPanelBtn.Click += new System.EventHandler(this.displayDashPanelBtn_Click);
            // 
            // sidebarSeparator
            // 
            this.sidebarSeparator.BackColor = System.Drawing.Color.Transparent;
            this.sidebarSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sidebarSeparator.LineThickness = 1;
            this.sidebarSeparator.Location = new System.Drawing.Point(6, 66);
            this.sidebarSeparator.Name = "sidebarSeparator";
            this.sidebarSeparator.Size = new System.Drawing.Size(235, 10);
            this.sidebarSeparator.TabIndex = 7;
            this.sidebarSeparator.Transparency = 255;
            this.sidebarSeparator.Vertical = false;
            // 
            // labelJuicySwapper
            // 
            this.labelJuicySwapper.AutoSize = true;
            this.labelJuicySwapper.BackColor = System.Drawing.Color.Transparent;
            this.labelJuicySwapper.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJuicySwapper.ForeColor = System.Drawing.Color.White;
            this.labelJuicySwapper.Location = new System.Drawing.Point(63, 13);
            this.labelJuicySwapper.Name = "labelJuicySwapper";
            this.labelJuicySwapper.Size = new System.Drawing.Size(138, 23);
            this.labelJuicySwapper.TabIndex = 6;
            this.labelJuicySwapper.Text = "Juicy Swapper v2";
            // 
            // formWrapper
            // 
            this.formWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.formWrapper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.formWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formWrapper.Location = new System.Drawing.Point(272, 0);
            this.formWrapper.Name = "formWrapper";
            this.formWrapper.Size = new System.Drawing.Size(727, 609);
            this.formWrapper.TabIndex = 2;
            // 
            // sidebarCurving
            // 
            this.sidebarCurving.ElipseRadius = 7;
            this.sidebarCurving.TargetControl = this.formSidebar;
            // 
            // formDragControl
            // 
            this.formDragControl.Fixed = true;
            this.formDragControl.Horizontal = true;
            this.formDragControl.TargetControl = this.formSidebar;
            this.formDragControl.Vertical = true;
            // 
            // formCurving
            // 
            this.formCurving.ElipseRadius = 7;
            this.formCurving.TargetControl = this;
            // 
            // swapperLabelDragControl
            // 
            this.swapperLabelDragControl.Fixed = true;
            this.swapperLabelDragControl.Horizontal = true;
            this.swapperLabelDragControl.TargetControl = this.labelJuicySwapper;
            this.swapperLabelDragControl.Vertical = true;
            // 
            // welcomeLabelDragControl
            // 
            this.welcomeLabelDragControl.Fixed = true;
            this.welcomeLabelDragControl.Horizontal = true;
            this.welcomeLabelDragControl.TargetControl = this.userWelcomeLabel;
            this.welcomeLabelDragControl.Vertical = true;
            // 
            // sidebarDragControl
            // 
            this.sidebarDragControl.Fixed = true;
            this.sidebarDragControl.Horizontal = true;
            this.sidebarDragControl.TargetControl = this.sidebarWrapper;
            this.sidebarDragControl.Vertical = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(999, 609);
            this.Controls.Add(this.formWrapper);
            this.Controls.Add(this.sidebarWrapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juicy Swapper v2 - Home";
            this.sidebarWrapper.ResumeLayout(false);
            this.formSidebar.ResumeLayout(false);
            this.formSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconJuicyIndustries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidebarWrapper;
        private System.Windows.Forms.Panel formWrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel formSidebar;
        private Bunifu.Framework.UI.BunifuFlatButton displayEmotesPanelBtn;
        private Bunifu.Framework.UI.BunifuFlatButton displayPickaxesPanelBtn;
        private Bunifu.Framework.UI.BunifuFlatButton displayBackblingsPanelBtn;
        private Bunifu.Framework.UI.BunifuFlatButton displaySkinsPanelBtn;
        private Bunifu.Framework.UI.BunifuFlatButton displayDashPanelBtn;
        private Bunifu.Framework.UI.BunifuSeparator sidebarSeparator;
        private System.Windows.Forms.Label labelJuicySwapper;
        private Bunifu.Framework.UI.BunifuElipse sidebarCurving;
        private Bunifu.Framework.UI.BunifuFlatButton displaySettingsFormBtn;
        private Bunifu.Framework.UI.BunifuFlatButton displayMiscPanelTab;
        private Bunifu.Framework.UI.BunifuImageButton iconJuicyIndustries;
        private Bunifu.Framework.UI.BunifuDragControl formDragControl;
        private Bunifu.Framework.UI.BunifuElipse formCurving;
        private System.Windows.Forms.Label userWelcomeLabel;
        private Bunifu.Framework.UI.BunifuFlatButton displayItemShopFormBtn;
        private Bunifu.Framework.UI.BunifuDragControl swapperLabelDragControl;
        private Bunifu.Framework.UI.BunifuDragControl welcomeLabelDragControl;
        private Bunifu.Framework.UI.BunifuDragControl sidebarDragControl;
    }
}

