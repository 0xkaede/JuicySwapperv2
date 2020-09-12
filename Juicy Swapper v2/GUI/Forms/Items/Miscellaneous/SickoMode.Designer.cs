namespace Juicy_Swapper_v2.GUI.Forms.Items.Miscellaneous
{
    partial class SickoMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SickoMode));
            this.formCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.itemDialogHeaderLabel = new System.Windows.Forms.Label();
            this.formDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.itemDialogTextBox = new System.Windows.Forms.RichTextBox();
            this.itemDialogPictureBox = new System.Windows.Forms.PictureBox();
            this.convertBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.convertBtnCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.itemDialogPictureBoxDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.itemDialogHeaderLabelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.previewBtnCurving = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.previewBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDialogPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // formCurving
            // 
            this.formCurving.ElipseRadius = 7;
            this.formCurving.TargetControl = this;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(335, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(21, 14);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 24;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // itemDialogHeaderLabel
            // 
            this.itemDialogHeaderLabel.AutoSize = true;
            this.itemDialogHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDialogHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.itemDialogHeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.itemDialogHeaderLabel.Name = "itemDialogHeaderLabel";
            this.itemDialogHeaderLabel.Size = new System.Drawing.Size(108, 21);
            this.itemDialogHeaderLabel.TabIndex = 23;
            this.itemDialogHeaderLabel.Text = "SICKO MODE";
            // 
            // formDragControl
            // 
            this.formDragControl.Fixed = true;
            this.formDragControl.Horizontal = true;
            this.formDragControl.TargetControl = this;
            this.formDragControl.Vertical = true;
            // 
            // itemDialogTextBox
            // 
            this.itemDialogTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.itemDialogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemDialogTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.itemDialogTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDialogTextBox.ForeColor = System.Drawing.Color.White;
            this.itemDialogTextBox.Location = new System.Drawing.Point(160, 37);
            this.itemDialogTextBox.Name = "itemDialogTextBox";
            this.itemDialogTextBox.ReadOnly = true;
            this.itemDialogTextBox.Size = new System.Drawing.Size(195, 138);
            this.itemDialogTextBox.TabIndex = 28;
            this.itemDialogTextBox.Text = "";
            // 
            // itemDialogPictureBox
            // 
            this.itemDialogPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("itemDialogPictureBox.Image")));
            this.itemDialogPictureBox.Location = new System.Drawing.Point(16, 37);
            this.itemDialogPictureBox.Name = "itemDialogPictureBox";
            this.itemDialogPictureBox.Size = new System.Drawing.Size(138, 138);
            this.itemDialogPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemDialogPictureBox.TabIndex = 27;
            this.itemDialogPictureBox.TabStop = false;
            this.itemDialogPictureBox.MouseEnter += new System.EventHandler(this.itemDialogPictureBox_MouseEnter);
            this.itemDialogPictureBox.MouseLeave += new System.EventHandler(this.itemDialogPictureBox_MouseLeave);
            // 
            // convertBtn
            // 
            this.convertBtn.Activecolor = System.Drawing.Color.Transparent;
            this.convertBtn.BackColor = System.Drawing.Color.Transparent;
            this.convertBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("convertBtn.BackgroundImage")));
            this.convertBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.convertBtn.BorderRadius = 0;
            this.convertBtn.ButtonText = "Convert";
            this.convertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.convertBtn.DisabledColor = System.Drawing.Color.White;
            this.convertBtn.ForeColor = System.Drawing.Color.White;
            this.convertBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.convertBtn.Iconimage = null;
            this.convertBtn.Iconimage_right = null;
            this.convertBtn.Iconimage_right_Selected = null;
            this.convertBtn.Iconimage_Selected = null;
            this.convertBtn.IconMarginLeft = 0;
            this.convertBtn.IconMarginRight = 0;
            this.convertBtn.IconRightVisible = true;
            this.convertBtn.IconRightZoom = 0D;
            this.convertBtn.IconVisible = true;
            this.convertBtn.IconZoom = 50D;
            this.convertBtn.IsTab = false;
            this.convertBtn.Location = new System.Drawing.Point(279, 185);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.convertBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.convertBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.convertBtn.selected = false;
            this.convertBtn.Size = new System.Drawing.Size(76, 26);
            this.convertBtn.TabIndex = 25;
            this.convertBtn.Text = "Convert";
            this.convertBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.convertBtn.Textcolor = System.Drawing.Color.White;
            this.convertBtn.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // convertBtnCurving
            // 
            this.convertBtnCurving.ElipseRadius = 7;
            this.convertBtnCurving.TargetControl = this.convertBtn;
            // 
            // itemDialogPictureBoxDragControl
            // 
            this.itemDialogPictureBoxDragControl.Fixed = true;
            this.itemDialogPictureBoxDragControl.Horizontal = true;
            this.itemDialogPictureBoxDragControl.TargetControl = this.itemDialogPictureBox;
            this.itemDialogPictureBoxDragControl.Vertical = true;
            // 
            // itemDialogHeaderLabelDragControl
            // 
            this.itemDialogHeaderLabelDragControl.Fixed = true;
            this.itemDialogHeaderLabelDragControl.Horizontal = true;
            this.itemDialogHeaderLabelDragControl.TargetControl = this.itemDialogHeaderLabel;
            this.itemDialogHeaderLabelDragControl.Vertical = true;
            // 
            // previewBtnCurving
            // 
            this.previewBtnCurving.ElipseRadius = 7;
            this.previewBtnCurving.TargetControl = this.previewBtn;
            // 
            // previewBtn
            // 
            this.previewBtn.Activecolor = System.Drawing.Color.Transparent;
            this.previewBtn.BackColor = System.Drawing.Color.Transparent;
            this.previewBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previewBtn.BackgroundImage")));
            this.previewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previewBtn.BorderRadius = 0;
            this.previewBtn.ButtonText = "Preview";
            this.previewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previewBtn.DisabledColor = System.Drawing.Color.White;
            this.previewBtn.ForeColor = System.Drawing.Color.White;
            this.previewBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.previewBtn.Iconimage = null;
            this.previewBtn.Iconimage_right = null;
            this.previewBtn.Iconimage_right_Selected = null;
            this.previewBtn.Iconimage_Selected = null;
            this.previewBtn.IconMarginLeft = 0;
            this.previewBtn.IconMarginRight = 0;
            this.previewBtn.IconRightVisible = true;
            this.previewBtn.IconRightZoom = 0D;
            this.previewBtn.IconVisible = true;
            this.previewBtn.IconZoom = 50D;
            this.previewBtn.IsTab = false;
            this.previewBtn.Location = new System.Drawing.Point(197, 185);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.previewBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.previewBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.previewBtn.selected = false;
            this.previewBtn.Size = new System.Drawing.Size(76, 26);
            this.previewBtn.TabIndex = 26;
            this.previewBtn.Text = "Preview";
            this.previewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.previewBtn.Textcolor = System.Drawing.Color.White;
            this.previewBtn.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewBtn.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // SickoMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(22)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(368, 222);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.itemDialogHeaderLabel);
            this.Controls.Add(this.itemDialogTextBox);
            this.Controls.Add(this.itemDialogPictureBox);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.previewBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SickoMode";
            this.Text = "Juicy Swapper v2 - SICKO MODE";
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDialogPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse formCurving;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private System.Windows.Forms.Label itemDialogHeaderLabel;
        private System.Windows.Forms.RichTextBox itemDialogTextBox;
        private System.Windows.Forms.PictureBox itemDialogPictureBox;
        private Bunifu.Framework.UI.BunifuFlatButton convertBtn;
        private Bunifu.Framework.UI.BunifuFlatButton previewBtn;
        private Bunifu.Framework.UI.BunifuDragControl formDragControl;
        private Bunifu.Framework.UI.BunifuElipse convertBtnCurving;
        private Bunifu.Framework.UI.BunifuDragControl itemDialogPictureBoxDragControl;
        private Bunifu.Framework.UI.BunifuDragControl itemDialogHeaderLabelDragControl;
        private Bunifu.Framework.UI.BunifuElipse previewBtnCurving;
    }
}