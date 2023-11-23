namespace Toms
{
    partial class Categories
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
            this.lbCategories = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbColorView = new System.Windows.Forms.PictureBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btSafe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorView)).BeginInit();
            this.SuspendLayout();
            // 
            // btBackToMenu
            // 
            this.btBackToMenu.BackColor = System.Drawing.Color.Transparent;
            this.btBackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackToMenu.ForeColor = System.Drawing.Color.Black;
            this.btBackToMenu.Location = new System.Drawing.Point(377, 378);
            this.btBackToMenu.Name = "btBackToMenu";
            this.btBackToMenu.Size = new System.Drawing.Size(137, 29);
            this.btBackToMenu.TabIndex = 3;
            this.btBackToMenu.Text = "Back to Menu";
            this.btBackToMenu.UseVisualStyleBackColor = false;
            this.btBackToMenu.Click += new System.EventHandler(this.BtBackToMenu_Click);
            // 
            // lbCategories
            // 
            this.lbCategories.AutoSize = true;
            this.lbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategories.Location = new System.Drawing.Point(174, 7);
            this.lbCategories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(181, 37);
            this.lbCategories.TabIndex = 4;
            this.lbCategories.Text = "Categories";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Color:";
            // 
            // tbRed
            // 
            this.tbRed.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbRed.LargeChange = 20;
            this.tbRed.Location = new System.Drawing.Point(78, 159);
            this.tbRed.Maximum = 255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(250, 45);
            this.tbRed.SmallChange = 10;
            this.tbRed.TabIndex = 7;
            this.tbRed.TickFrequency = 15;
            this.tbRed.Scroll += new System.EventHandler(this.tbRed_Scroll);
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(78, 223);
            this.tbGreen.Maximum = 255;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(250, 45);
            this.tbGreen.TabIndex = 8;
            this.tbGreen.TickFrequency = 15;
            this.tbGreen.Scroll += new System.EventHandler(this.tbGreen_Scroll);
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(78, 275);
            this.tbBlue.Maximum = 255;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(250, 45);
            this.tbBlue.TabIndex = 9;
            this.tbBlue.TickFrequency = 15;
            this.tbBlue.Scroll += new System.EventHandler(this.tbBlue_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Green";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Blue";
            // 
            // pbColorView
            // 
            this.pbColorView.Location = new System.Drawing.Point(391, 213);
            this.pbColorView.Name = "pbColorView";
            this.pbColorView.Size = new System.Drawing.Size(78, 55);
            this.pbColorView.TabIndex = 13;
            this.pbColorView.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(87, 75);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(241, 20);
            this.tbName.TabIndex = 14;
            // 
            // btSafe
            // 
            this.btSafe.Location = new System.Drawing.Point(32, 349);
            this.btSafe.Name = "btSafe";
            this.btSafe.Size = new System.Drawing.Size(296, 33);
            this.btSafe.TabIndex = 15;
            this.btSafe.Text = "Save Category";
            this.btSafe.UseVisualStyleBackColor = true;
            this.btSafe.Click += new System.EventHandler(this.btSafe_Click);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 419);
            this.Controls.Add(this.btSafe);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.pbColorView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCategories);
            this.Controls.Add(this.btBackToMenu);
            this.Name = "Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBackToMenu;
        private System.Windows.Forms.Label lbCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbColorView;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btSafe;
    }
}