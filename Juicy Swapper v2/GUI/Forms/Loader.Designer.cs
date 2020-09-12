﻿namespace Juicy_Swapper_v2.Forms
{
    partial class Loader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loader));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.formDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.loaderProgressBar = new Guna.UI.WinForms.GunaProgressBar();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // formDragControl
            // 
            this.formDragControl.Fixed = true;
            this.formDragControl.Horizontal = true;
            this.formDragControl.TargetControl = null;
            this.formDragControl.Vertical = true;
            // 
            // loaderProgressBar
            // 
            this.loaderProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.loaderProgressBar.BorderColor = System.Drawing.Color.Black;
            this.loaderProgressBar.ColorStyle = Guna.UI.WinForms.ColorStyle.Transition;
            this.loaderProgressBar.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.loaderProgressBar.Location = new System.Drawing.Point(0, 254);
            this.loaderProgressBar.Name = "loaderProgressBar";
            this.loaderProgressBar.ProgressMaxColor = System.Drawing.Color.DarkOrange;
            this.loaderProgressBar.ProgressMinColor = System.Drawing.Color.DarkOrange;
            this.loaderProgressBar.Size = new System.Drawing.Size(480, 16);
            this.loaderProgressBar.TabIndex = 4;
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 270);
            this.Controls.Add(this.loaderProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juicy Swapper v2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private Bunifu.Framework.UI.BunifuDragControl formDragControl;
        private Guna.UI.WinForms.GunaProgressBar loaderProgressBar;
    }
}