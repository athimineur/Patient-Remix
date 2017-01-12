namespace Patient_Database.MainFrame
{
    partial class MainFrameUC
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
            this.pBorderTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pBorderRight = new System.Windows.Forms.Panel();
            this.pBorderLeft = new System.Windows.Forms.Panel();
            this.pBorderBottom = new System.Windows.Forms.Panel();
            this.pDisplay = new System.Windows.Forms.Panel();
            this.pBorderTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBorderTop
            // 
            this.pBorderTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBorderTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.pBorderTop.Controls.Add(this.lblTitle);
            this.pBorderTop.Location = new System.Drawing.Point(-6, -2);
            this.pBorderTop.Name = "pBorderTop";
            this.pBorderTop.Size = new System.Drawing.Size(514, 86);
            this.pBorderTop.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(216, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Place Holder";
            // 
            // pBorderRight
            // 
            this.pBorderRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBorderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.pBorderRight.Location = new System.Drawing.Point(481, 84);
            this.pBorderRight.Name = "pBorderRight";
            this.pBorderRight.Size = new System.Drawing.Size(27, 403);
            this.pBorderRight.TabIndex = 2;
            // 
            // pBorderLeft
            // 
            this.pBorderLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pBorderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.pBorderLeft.Location = new System.Drawing.Point(-7, 84);
            this.pBorderLeft.Name = "pBorderLeft";
            this.pBorderLeft.Size = new System.Drawing.Size(19, 404);
            this.pBorderLeft.TabIndex = 3;
            // 
            // pBorderBottom
            // 
            this.pBorderBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBorderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.pBorderBottom.Location = new System.Drawing.Point(12, 461);
            this.pBorderBottom.Name = "pBorderBottom";
            this.pBorderBottom.Size = new System.Drawing.Size(469, 18);
            this.pBorderBottom.TabIndex = 4;
            // 
            // pDisplay
            // 
            this.pDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pDisplay.AutoScroll = true;
            this.pDisplay.Location = new System.Drawing.Point(12, 84);
            this.pDisplay.Name = "pDisplay";
            this.pDisplay.Size = new System.Drawing.Size(469, 377);
            this.pDisplay.TabIndex = 5;
            // 
            // MainFrameUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pDisplay);
            this.Controls.Add(this.pBorderBottom);
            this.Controls.Add(this.pBorderLeft);
            this.Controls.Add(this.pBorderRight);
            this.Controls.Add(this.pBorderTop);
            this.Name = "MainFrameUC";
            this.Size = new System.Drawing.Size(493, 473);
            this.Load += new System.EventHandler(this.MainFrameUC_Load);
            this.pBorderTop.ResumeLayout(false);
            this.pBorderTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pBorderTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pBorderRight;
        private System.Windows.Forms.Panel pBorderLeft;
        private System.Windows.Forms.Panel pBorderBottom;
        private System.Windows.Forms.Panel pDisplay;
    }
}
