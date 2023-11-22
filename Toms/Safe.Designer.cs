namespace Toms
{
    partial class Safe
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
            this.btBackToMenu = new System.Windows.Forms.Button();
            this.btSafe = new System.Windows.Forms.Button();
            this.lbSafe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBackToMenu
            // 
            this.btBackToMenu.BackColor = System.Drawing.Color.Transparent;
            this.btBackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackToMenu.ForeColor = System.Drawing.Color.Black;
            this.btBackToMenu.Location = new System.Drawing.Point(454, 326);
            this.btBackToMenu.Name = "btBackToMenu";
            this.btBackToMenu.Size = new System.Drawing.Size(137, 29);
            this.btBackToMenu.TabIndex = 1;
            this.btBackToMenu.Text = "Back to Menu";
            this.btBackToMenu.UseVisualStyleBackColor = false;
            this.btBackToMenu.Click += new System.EventHandler(this.bt_backToMenu_Click);
            // 
            // btSafe
            // 
            this.btSafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSafe.Location = new System.Drawing.Point(248, 214);
            this.btSafe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSafe.Name = "btSafe";
            this.btSafe.Size = new System.Drawing.Size(74, 31);
            this.btSafe.TabIndex = 2;
            this.btSafe.Text = "Safe";
            this.btSafe.UseVisualStyleBackColor = true;
            this.btSafe.Click += new System.EventHandler(this.bt_safe_Click);
            // 
            // lbSafe
            // 
            this.lbSafe.AutoSize = true;
            this.lbSafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSafe.Location = new System.Drawing.Point(253, 7);
            this.lbSafe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSafe.Name = "lbSafe";
            this.lbSafe.Size = new System.Drawing.Size(86, 37);
            this.lbSafe.TabIndex = 3;
            this.lbSafe.Text = "Safe";
            // 
            // Safe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lbSafe);
            this.Controls.Add(this.btSafe);
            this.Controls.Add(this.btBackToMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Safe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Safe";
            this.Load += new System.EventHandler(this.Safe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBackToMenu;
        private System.Windows.Forms.Button btSafe;
        private System.Windows.Forms.Label lbSafe;
    }
}