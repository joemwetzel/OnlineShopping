namespace CCclient
{
    partial class Form1
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
            this.tmrSurf = new System.Windows.Forms.Timer(this.components);
            this.wbSurf = new System.Windows.Forms.WebBrowser();
            this.lblProcessing = new System.Windows.Forms.Label();
            this.tmrCC = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrSurf
            // 
            this.tmrSurf.Enabled = true;
            this.tmrSurf.Interval = 10000;
            this.tmrSurf.Tick += new System.EventHandler(this.tmrSurf_Tick);
            // 
            // wbSurf
            // 
            this.wbSurf.Location = new System.Drawing.Point(0, 54);
            this.wbSurf.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbSurf.Name = "wbSurf";
            this.wbSurf.Size = new System.Drawing.Size(1081, 809);
            this.wbSurf.TabIndex = 0;
            // 
            // lblProcessing
            // 
            this.lblProcessing.BackColor = System.Drawing.Color.White;
            this.lblProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessing.ForeColor = System.Drawing.Color.Red;
            this.lblProcessing.Location = new System.Drawing.Point(0, -4);
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(1048, 62);
            this.lblProcessing.TabIndex = 1;
            this.lblProcessing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrCC
            // 
            this.tmrCC.Enabled = true;
            this.tmrCC.Interval = 30000;
            this.tmrCC.Tick += new System.EventHandler(this.tmrCC_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 851);
            this.Controls.Add(this.lblProcessing);
            this.Controls.Add(this.wbSurf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Online Shopping";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrSurf;
        private System.Windows.Forms.WebBrowser wbSurf;
        private System.Windows.Forms.Label lblProcessing;
        private System.Windows.Forms.Timer tmrCC;
    }
}

