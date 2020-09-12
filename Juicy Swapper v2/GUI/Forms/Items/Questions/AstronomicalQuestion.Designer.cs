namespace Juicy_Swapper_v2.GUI.Forms.Items.Questions
{
    partial class AstronomicalQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AstronomicalQuestion));
            this.formCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.questionDialogHeaderLabel = new System.Windows.Forms.Label();
            this.formDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.questionDialogHeaderLabelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.sickoModeFormLabel = new System.Windows.Forms.Label();
            this.goosebumpsFormLabel = new System.Windows.Forms.Label();
            this.stargazingFormLabel = new System.Windows.Forms.Label();
            this.cancelBtnCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cancelBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // formCurving
            // 
            this.formCurving.ElipseRadius = 7;
            this.formCurving.TargetControl = this;
            // 
            // questionDialogHeaderLabel
            // 
            this.questionDialogHeaderLabel.AutoSize = true;
            this.questionDialogHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionDialogHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.questionDialogHeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.questionDialogHeaderLabel.Name = "questionDialogHeaderLabel";
            this.questionDialogHeaderLabel.Size = new System.Drawing.Size(287, 25);
            this.questionDialogHeaderLabel.TabIndex = 27;
            this.questionDialogHeaderLabel.Text = "What item do you want to use?";
            // 
            // formDragControl
            // 
            this.formDragControl.Fixed = true;
            this.formDragControl.Horizontal = true;
            this.formDragControl.TargetControl = this;
            this.formDragControl.Vertical = true;
            // 
            // questionDialogHeaderLabelDragControl
            // 
            this.questionDialogHeaderLabelDragControl.Fixed = true;
            this.questionDialogHeaderLabelDragControl.Horizontal = true;
            this.questionDialogHeaderLabelDragControl.TargetControl = this.questionDialogHeaderLabel;
            this.questionDialogHeaderLabelDragControl.Vertical = true;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(401, 19);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 14);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 29;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 10;
            // 
            // sickoModeFormLabel
            // 
            this.sickoModeFormLabel.AutoSize = true;
            this.sickoModeFormLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sickoModeFormLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sickoModeFormLabel.ForeColor = System.Drawing.Color.White;
            this.sickoModeFormLabel.Location = new System.Drawing.Point(12, 46);
            this.sickoModeFormLabel.Name = "sickoModeFormLabel";
            this.sickoModeFormLabel.Size = new System.Drawing.Size(123, 21);
            this.sickoModeFormLabel.TabIndex = 30;
            this.sickoModeFormLabel.Text = " • SICKO MODE";
            this.sickoModeFormLabel.Click += new System.EventHandler(this.sickoModeFormLabel_Click);
            // 
            // goosebumpsFormLabel
            // 
            this.goosebumpsFormLabel.AutoSize = true;
            this.goosebumpsFormLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goosebumpsFormLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goosebumpsFormLabel.ForeColor = System.Drawing.Color.White;
            this.goosebumpsFormLabel.Location = new System.Drawing.Point(12, 83);
            this.goosebumpsFormLabel.Name = "goosebumpsFormLabel";
            this.goosebumpsFormLabel.Size = new System.Drawing.Size(123, 21);
            this.goosebumpsFormLabel.TabIndex = 31;
            this.goosebumpsFormLabel.Text = " • goosebumps";
            this.goosebumpsFormLabel.Click += new System.EventHandler(this.goosebumpsFormLabel_Click);
            // 
            // stargazingFormLabel
            // 
            this.stargazingFormLabel.AutoSize = true;
            this.stargazingFormLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stargazingFormLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stargazingFormLabel.ForeColor = System.Drawing.Color.White;
            this.stargazingFormLabel.Location = new System.Drawing.Point(12, 120);
            this.stargazingFormLabel.Name = "stargazingFormLabel";
            this.stargazingFormLabel.Size = new System.Drawing.Size(174, 21);
            this.stargazingFormLabel.TabIndex = 32;
            this.stargazingFormLabel.Text = " • STARGAZING (pt. II)";
            this.stargazingFormLabel.Click += new System.EventHandler(this.stargazingFormLabel_Click);
            // 
            // cancelBtnCurving
            // 
            this.cancelBtnCurving.ElipseRadius = 7;
            this.cancelBtnCurving.TargetControl = this.cancelBtn;
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
            this.cancelBtn.Location = new System.Drawing.Point(262, 164);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.cancelBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.cancelBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.cancelBtn.selected = false;
            this.cancelBtn.Size = new System.Drawing.Size(76, 26);
            this.cancelBtn.TabIndex = 33;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelBtn.Textcolor = System.Drawing.Color.White;
            this.cancelBtn.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AstronomicalQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(350, 202);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.stargazingFormLabel);
            this.Controls.Add(this.goosebumpsFormLabel);
            this.Controls.Add(this.sickoModeFormLabel);
            this.Controls.Add(this.questionDialogHeaderLabel);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AstronomicalQuestion";
            this.Text = "AstronomicalQuestion";
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse formCurving;
        private System.Windows.Forms.Label questionDialogHeaderLabel;
        private Bunifu.Framework.UI.BunifuDragControl formDragControl;
        private Bunifu.Framework.UI.BunifuDragControl questionDialogHeaderLabelDragControl;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private System.Windows.Forms.Label stargazingFormLabel;
        private System.Windows.Forms.Label goosebumpsFormLabel;
        private System.Windows.Forms.Label sickoModeFormLabel;
        private Bunifu.Framework.UI.BunifuFlatButton cancelBtn;
        private Bunifu.Framework.UI.BunifuElipse cancelBtnCurving;
    }
}