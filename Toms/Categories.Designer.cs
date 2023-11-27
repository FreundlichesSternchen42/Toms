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
            this.components = new System.ComponentModel.Container();
            this.btBackToMenu = new System.Windows.Forms.Button();
            this.lbCategories = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trbRed = new System.Windows.Forms.TrackBar();
            this.trbGreen = new System.Windows.Forms.TrackBar();
            this.trbBlue = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbColorView = new System.Windows.Forms.PictureBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btSafeC = new System.Windows.Forms.Button();
            this.tmUpdate = new System.Windows.Forms.Timer(this.components);
            this.tbRed = new System.Windows.Forms.TextBox();
            this.tbGreen = new System.Windows.Forms.TextBox();
            this.tbBlue = new System.Windows.Forms.TextBox();
            this.btDeleteC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorView)).BeginInit();
            this.SuspendLayout();
            // 
            // btBackToMenu
            // 
            this.btBackToMenu.BackColor = System.Drawing.Color.Transparent;
            this.btBackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackToMenu.ForeColor = System.Drawing.Color.Black;
            this.btBackToMenu.Location = new System.Drawing.Point(810, 845);
            this.btBackToMenu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btBackToMenu.Name = "btBackToMenu";
            this.btBackToMenu.Size = new System.Drawing.Size(274, 56);
            this.btBackToMenu.TabIndex = 3;
            this.btBackToMenu.Text = "Back to Menu";
            this.btBackToMenu.UseVisualStyleBackColor = false;
            this.btBackToMenu.Click += new System.EventHandler(this.BtBackToMenu_Click);
            // 
            // lbCategories
            // 
            this.lbCategories.AutoSize = true;
            this.lbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategories.Location = new System.Drawing.Point(348, 14);
            this.lbCategories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(353, 73);
            this.lbCategories.TabIndex = 4;
            this.lbCategories.Text = "Categories";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Color:";
            // 
            // trbRed
            // 
            this.trbRed.Cursor = System.Windows.Forms.Cursors.Default;
            this.trbRed.LargeChange = 20;
            this.trbRed.Location = new System.Drawing.Point(156, 306);
            this.trbRed.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.trbRed.Maximum = 255;
            this.trbRed.Name = "trbRed";
            this.trbRed.Size = new System.Drawing.Size(500, 90);
            this.trbRed.SmallChange = 10;
            this.trbRed.TabIndex = 7;
            this.trbRed.TickFrequency = 15;
            this.trbRed.Scroll += new System.EventHandler(this.trbRed_Scroll);
            // 
            // trbGreen
            // 
            this.trbGreen.Location = new System.Drawing.Point(156, 428);
            this.trbGreen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.trbGreen.Maximum = 255;
            this.trbGreen.Name = "trbGreen";
            this.trbGreen.Size = new System.Drawing.Size(500, 90);
            this.trbGreen.TabIndex = 8;
            this.trbGreen.TickFrequency = 15;
            this.trbGreen.Scroll += new System.EventHandler(this.trbGreen_Scroll);
            // 
            // trbBlue
            // 
            this.trbBlue.Location = new System.Drawing.Point(156, 528);
            this.trbBlue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.trbBlue.Maximum = 255;
            this.trbBlue.Name = "trbBlue";
            this.trbBlue.Size = new System.Drawing.Size(500, 90);
            this.trbBlue.TabIndex = 9;
            this.trbBlue.TickFrequency = 15;
            this.trbBlue.Scroll += new System.EventHandler(this.trbBlue_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 428);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Green";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 528);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Blue";
            // 
            // pbColorView
            // 
            this.pbColorView.Location = new System.Drawing.Point(782, 409);
            this.pbColorView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pbColorView.Name = "pbColorView";
            this.pbColorView.Size = new System.Drawing.Size(156, 106);
            this.pbColorView.TabIndex = 13;
            this.pbColorView.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(174, 144);
            this.tbName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(478, 31);
            this.tbName.TabIndex = 14;
            // 
            // btSafeC
            // 
            this.btSafeC.Location = new System.Drawing.Point(156, 628);
            this.btSafeC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btSafeC.Name = "btSafeC";
            this.btSafeC.Size = new System.Drawing.Size(592, 64);
            this.btSafeC.TabIndex = 15;
            this.btSafeC.Text = "Save Category";
            this.btSafeC.UseVisualStyleBackColor = true;
            this.btSafeC.Click += new System.EventHandler(this.btSafe_Click);
            // 
            // tmUpdate
            // 
            this.tmUpdate.Enabled = true;
            this.tmUpdate.Tick += new System.EventHandler(this.tmUpdate_Tick);
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(668, 306);
            this.tbRed.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(80, 31);
            this.tbRed.TabIndex = 16;
            this.tbRed.TextChanged += new System.EventHandler(this.tbRed_TextChanged);
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(670, 428);
            this.tbGreen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(78, 31);
            this.tbGreen.TabIndex = 17;
            this.tbGreen.TextChanged += new System.EventHandler(this.tbGreen_TextChanged);
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(668, 528);
            this.tbBlue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(80, 31);
            this.tbBlue.TabIndex = 18;
            this.tbBlue.TextChanged += new System.EventHandler(this.tbBlue_TextChanged);
            // 
            // btDeleteC
            // 
            this.btDeleteC.Location = new System.Drawing.Point(156, 736);
            this.btDeleteC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btDeleteC.Name = "btDeleteC";
            this.btDeleteC.Size = new System.Drawing.Size(592, 64);
            this.btDeleteC.TabIndex = 19;
            this.btDeleteC.Text = "delete Category";
            this.btDeleteC.UseVisualStyleBackColor = true;
            this.btDeleteC.Click += new System.EventHandler(this.btDeleteC_Click);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 922);
            this.Controls.Add(this.btDeleteC);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.btSafeC);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.pbColorView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trbBlue);
            this.Controls.Add(this.trbGreen);
            this.Controls.Add(this.trbRed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCategories);
            this.Controls.Add(this.btBackToMenu);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Categories_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBackToMenu;
        private System.Windows.Forms.Label lbCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trbRed;
        private System.Windows.Forms.TrackBar trbGreen;
        private System.Windows.Forms.TrackBar trbBlue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbColorView;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btSafeC;
        private System.Windows.Forms.Timer tmUpdate;
        private System.Windows.Forms.TextBox tbRed;
        private System.Windows.Forms.TextBox tbGreen;
        private System.Windows.Forms.TextBox tbBlue;
        private System.Windows.Forms.Button btDeleteC;
    }
}