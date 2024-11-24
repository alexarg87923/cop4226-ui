﻿namespace BookCollection
{
    partial class BookManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            eToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label8 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            groupBox3 = new GroupBox();
            label9 = new Label();
            label10 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            textBox7 = new TextBox();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(6, 14);
            label1.Name = "label1";
            label1.Size = new Size(290, 45);
            label1.TabIndex = 0;
            label1.Text = "Book Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 76);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, eToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(850, 40);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(71, 36);
            fileToolStripMenuItem.Text = "File";
            // 
            // eToolStripMenuItem
            // 
            eToolStripMenuItem.Name = "eToolStripMenuItem";
            eToolStripMenuItem.Size = new Size(74, 36);
            eToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(85, 36);
            viewToolStripMenuItem.Text = "View";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 69);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(858, 1095);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(842, 1041);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Books";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 646);
            label8.Name = "label8";
            label8.Size = new Size(97, 32);
            label8.TabIndex = 3;
            label8.Text = "Authors";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(27, 697);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(689, 191);
            textBox3.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(214, 935);
            button2.Name = "button2";
            button2.Size = new Size(172, 46);
            button2.TabIndex = 5;
            button2.Text = "Delete Book";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(27, 935);
            button1.Name = "button1";
            button1.Size = new Size(172, 46);
            button1.TabIndex = 4;
            button1.Text = "Save Book";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(27, 322);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(689, 292);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Book Properties";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 220);
            label7.Name = "label7";
            label7.Size = new Size(123, 32);
            label7.TabIndex = 2;
            label7.Text = "Language:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 146);
            label6.Name = "label6";
            label6.Size = new Size(83, 32);
            label6.TabIndex = 1;
            label6.Text = "Genre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 72);
            label5.Name = "label5";
            label5.Size = new Size(70, 32);
            label5.TabIndex = 0;
            label5.Text = "ISBN:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(27, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(689, 211);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Base Properties";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(208, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(208, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 137);
            label4.Name = "label4";
            label4.Size = new Size(65, 32);
            label4.TabIndex = 1;
            label4.Text = "Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 53);
            label3.Name = "label3";
            label3.Size = new Size(42, 32);
            label3.TabIndex = 0;
            label3.Text = "ID:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(842, 1041);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Authors";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(8, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(842, 1041);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Collections";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(8, 77);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(765, 326);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Author Details";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(8, 15);
            label9.Name = "label9";
            label9.Size = new Size(316, 45);
            label9.TabIndex = 1;
            label9.Text = "Author Management";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(54, 88);
            label10.Name = "label10";
            label10.Size = new Size(122, 32);
            label10.TabIndex = 0;
            label10.Text = "Author ID:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(208, 72);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 39);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(208, 146);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 39);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(208, 220);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(200, 39);
            textBox6.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(97, 170);
            label11.Name = "label11";
            label11.Size = new Size(83, 32);
            label11.TabIndex = 1;
            label11.Text = "Name:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(54, 246);
            label12.Name = "label12";
            label12.Size = new Size(126, 32);
            label12.TabIndex = 2;
            label12.Text = "Birth Date:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(8, 452);
            label13.Name = "label13";
            label13.Size = new Size(174, 32);
            label13.TabIndex = 2;
            label13.Text = "Author's Books";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(8, 504);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(765, 230);
            textBox7.TabIndex = 3;
            // 
            // BookManagement
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 1158);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "BookManagement";
            Text = "BookManagement";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem eToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private Button button2;
        private Button button1;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox3;
        private Label label8;
        private Label label9;
        private GroupBox groupBox3;
        private Label label10;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox textBox7;
    }
}
