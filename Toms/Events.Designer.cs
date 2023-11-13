namespace Toms
{
    partial class Events
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
            this.lbEvents = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBackToMenu
            // 
            this.btBackToMenu.BackColor = System.Drawing.Color.Transparent;
            this.btBackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackToMenu.ForeColor = System.Drawing.Color.Black;
            this.btBackToMenu.Location = new System.Drawing.Point(619, 496);
            this.btBackToMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btBackToMenu.Name = "btBackToMenu";
            this.btBackToMenu.Size = new System.Drawing.Size(183, 36);
            this.btBackToMenu.TabIndex = 2;
            this.btBackToMenu.Text = "Back to Menu";
            this.btBackToMenu.UseVisualStyleBackColor = false;
            this.btBackToMenu.Click += new System.EventHandler(this.BtBackToMenu_Click);
            // 
            // lbEvents
            // 
            this.lbEvents.AutoSize = true;
            this.lbEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEvents.Location = new System.Drawing.Point(322, 9);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(147, 46);
            this.lbEvents.TabIndex = 3;
            this.lbEvents.Text = "Events";
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 546);
            this.Controls.Add(this.lbEvents);
            this.Controls.Add(this.btBackToMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBackToMenu;
        private System.Windows.Forms.Label lbEvents;
    }
}