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
            this.rtbPopup = new System.Windows.Forms.RichTextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.tbIDInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancelP
            // 
            this.btCancelP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lbSafe.Location = new System.Drawing.Point(249, 7);
            this.lbSafe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSafe.Name = "lbSafe";
            this.lbSafe.Size = new System.Drawing.Size(125, 37);
            this.lbSafe.TabIndex = 3;
            this.lbSafe.Text = "Popup ";
            // 
            // rtbPopup
            // 
            this.rtbPopup.Location = new System.Drawing.Point(38, 47);
            this.rtbPopup.Name = "rtbPopup";
            this.rtbPopup.ReadOnly = true;
            this.rtbPopup.Size = new System.Drawing.Size(521, 252);
            this.rtbPopup.TabIndex = 4;
            this.rtbPopup.Text = "";
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(287, 330);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(87, 23);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "delete event";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // tbIDInput
            // 
            this.tbIDInput.Location = new System.Drawing.Point(234, 333);
            this.tbIDInput.Name = "tbIDInput";
            this.tbIDInput.Size = new System.Drawing.Size(28, 20);
            this.tbIDInput.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Index Number: ";
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIDInput);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.rtbPopup);
            this.Controls.Add(this.lbSafe);
            this.Controls.Add(this.btCancelP);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Popup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Popup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Popup_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelP;
        private System.Windows.Forms.Label lbSafe;
        private System.Windows.Forms.RichTextBox rtbPopup;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox tbIDInput;
        private System.Windows.Forms.Label label1;
    }
}