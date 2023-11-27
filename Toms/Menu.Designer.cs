﻿namespace Toms
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btCalender = new System.Windows.Forms.Button();
            this.btEvents = new System.Windows.Forms.Button();
            this.btCategories = new System.Windows.Forms.Button();
            this.btNextE = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(444, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 128);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // btCalender
            // 
            this.btCalender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalender.Location = new System.Drawing.Point(464, 231);
            this.btCalender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCalender.Name = "btCalender";
            this.btCalender.Size = new System.Drawing.Size(254, 60);
            this.btCalender.TabIndex = 3;
            this.btCalender.Text = "Calender ";
            this.btCalender.UseVisualStyleBackColor = true;
            this.btCalender.Click += new System.EventHandler(this.BtCalender_Click);
            // 
            // btEvents
            // 
            this.btEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEvents.Location = new System.Drawing.Point(464, 319);
            this.btEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEvents.Name = "btEvents";
            this.btEvents.Size = new System.Drawing.Size(254, 62);
            this.btEvents.TabIndex = 4;
            this.btEvents.Text = "Events ";
            this.btEvents.UseVisualStyleBackColor = true;
            this.btEvents.Click += new System.EventHandler(this.BtEvent_Click);
            // 
            // btCategories
            // 
            this.btCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCategories.Location = new System.Drawing.Point(464, 406);
            this.btCategories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCategories.Name = "btCategories";
            this.btCategories.Size = new System.Drawing.Size(254, 60);
            this.btCategories.TabIndex = 5;
            this.btCategories.Text = "Categories";
            this.btCategories.UseVisualStyleBackColor = true;
            this.btCategories.Click += new System.EventHandler(this.BtCategories_Click);
            // 
            // btNextE
            // 
            this.btNextE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNextE.Location = new System.Drawing.Point(464, 500);
            this.btNextE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btNextE.Name = "btNextE";
            this.btNextE.Size = new System.Drawing.Size(254, 56);
            this.btNextE.TabIndex = 6;
            this.btNextE.Text = "Next Events";
            this.btNextE.UseVisualStyleBackColor = true;
            this.btNextE.Click += new System.EventHandler(this.bt_safe_Click);
            // 
            // btEnd
            // 
            this.btEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnd.Location = new System.Drawing.Point(1028, 621);
            this.btEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(154, 63);
            this.btEnd.TabIndex = 7;
            this.btEnd.Text = "END";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.bt_end_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 704);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btNextE);
            this.Controls.Add(this.btCategories);
            this.Controls.Add(this.btEvents);
            this.Controls.Add(this.btCalender);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCalender;
        private System.Windows.Forms.Button btEvents;
        private System.Windows.Forms.Button btCategories;
        private System.Windows.Forms.Button btNextE;
        private System.Windows.Forms.Button btEnd;
    }
}