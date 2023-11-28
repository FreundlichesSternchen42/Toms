namespace Toms
{
    partial class Popup
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
            this.btCancelP = new System.Windows.Forms.Button();
            this.lbSafe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancelP
            // 
            this.btCancelP.BackColor = System.Drawing.Color.Transparent;
            this.btCancelP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelP.ForeColor = System.Drawing.Color.Black;
            this.btCancelP.Location = new System.Drawing.Point(454, 326);
            this.btCancelP.Name = "btCancelP";
            this.btCancelP.Size = new System.Drawing.Size(137, 29);
            this.btCancelP.TabIndex = 1;
            this.btCancelP.Text = "Cancel";
            this.btCancelP.UseVisualStyleBackColor = false;
            this.btCancelP.Click += new System.EventHandler(this.bt_backToMenu_Click);
            // 
            // lbSafe
            // 
            this.lbSafe.AutoSize = true;
            this.lbSafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSafe.Location = new System.Drawing.Point(253, 7);
            this.lbSafe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSafe.Name = "lbSafe";
            this.lbSafe.Size = new System.Drawing.Size(125, 37);
            this.lbSafe.TabIndex = 3;
            this.lbSafe.Text = "Popup ";
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lbSafe);
            this.Controls.Add(this.btCancelP);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Popup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Safe_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Popup_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelP;
        private System.Windows.Forms.Label lbSafe;
    }
}