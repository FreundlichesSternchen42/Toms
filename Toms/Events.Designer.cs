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
            this.tbEventTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAddEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBackToMenu
            // 
            this.btBackToMenu.BackColor = System.Drawing.Color.Transparent;
            this.btBackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackToMenu.ForeColor = System.Drawing.Color.Black;
            this.btBackToMenu.Location = new System.Drawing.Point(928, 775);
            this.btBackToMenu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btBackToMenu.Name = "btBackToMenu";
            this.btBackToMenu.Size = new System.Drawing.Size(274, 56);
            this.btBackToMenu.TabIndex = 2;
            this.btBackToMenu.Text = "Back to Menu";
            this.btBackToMenu.UseVisualStyleBackColor = false;
            this.btBackToMenu.Click += new System.EventHandler(this.BtBackToMenu_Click);
            // 
            // lbEvents
            // 
            this.lbEvents.AutoSize = true;
            this.lbEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEvents.Location = new System.Drawing.Point(483, 14);
            this.lbEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(235, 73);
            this.lbEvents.TabIndex = 3;
            this.lbEvents.Text = "Events";
            // 
            // tbEventTitle
            // 
            this.tbEventTitle.Location = new System.Drawing.Point(470, 412);
            this.tbEventTitle.Name = "tbEventTitle";
            this.tbEventTitle.Size = new System.Drawing.Size(500, 31);
            this.tbEventTitle.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // btAddEvent
            // 
            this.btAddEvent.Location = new System.Drawing.Point(1021, 412);
            this.btAddEvent.Name = "btAddEvent";
            this.btAddEvent.Size = new System.Drawing.Size(145, 51);
            this.btAddEvent.TabIndex = 6;
            this.btAddEvent.Text = "button1";
            this.btAddEvent.UseVisualStyleBackColor = true;
            this.btAddEvent.Click += new System.EventHandler(this.btAddEvent_Click);
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 853);
            this.Controls.Add(this.btAddEvent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEventTitle);
            this.Controls.Add(this.lbEvents);
            this.Controls.Add(this.btBackToMenu);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBackToMenu;
        private System.Windows.Forms.Label lbEvents;
        private System.Windows.Forms.TextBox tbEventTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAddEvent;
    }
}