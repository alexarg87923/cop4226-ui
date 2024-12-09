 namespace BookCollection
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
            resetDatabaseToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button20 = new Button();
            button13 = new Button();
            button11 = new Button();
            button12 = new Button();
            Authors = new ListBox();
            label8 = new Label();
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tabPage2 = new TabPage();
            listBox1 = new ListBox();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            button4 = new Button();
            button3 = new Button();
            label13 = new Label();
            label9 = new Label();
            groupBox3 = new GroupBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            tabPage3 = new TabPage();
            button19 = new Button();
            button18 = new Button();
            button17 = new Button();
            label14 = new Label();
            button5 = new Button();
            button6 = new Button();
            textBox8 = new TextBox();
            label18 = new Label();
            groupBox4 = new GroupBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            tabPage4 = new TabPage();
            groupBox6 = new GroupBox();
            dataGridView2 = new DataGridView();
            STitle = new DataGridViewTextBoxColumn();
            SAuthor = new DataGridViewTextBoxColumn();
            SISBN = new DataGridViewTextBoxColumn();
            SOwner = new DataGridViewTextBoxColumn();
            groupBox5 = new GroupBox();
            dataGridView1 = new DataGridView();
            FTitle = new DataGridViewTextBoxColumn();
            FAuthor = new DataGridViewTextBoxColumn();
            FISBN = new DataGridViewTextBoxColumn();
            FOwner = new DataGridViewTextBoxColumn();
            label20 = new Label();
            label19 = new Label();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox4.SuspendLayout();
            tabPage4.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 0;
            label1.Text = "Book Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 36);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 1, 0, 1);
            menuStrip1.Size = new Size(514, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { resetDatabaseToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(67, 22);
            fileToolStripMenuItem.Text = "Database";
            // 
            // resetDatabaseToolStripMenuItem
            // 
            resetDatabaseToolStripMenuItem.Name = "resetDatabaseToolStripMenuItem";
            resetDatabaseToolStripMenuItem.Size = new Size(153, 22);
            resetDatabaseToolStripMenuItem.Text = "Reset Database";
            resetDatabaseToolStripMenuItem.Click += resetDatabaseToolStripMenuItem_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 32);
            tabControl1.Margin = new Padding(2, 1, 2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(462, 513);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button20);
            tabPage1.Controls.Add(button13);
            tabPage1.Controls.Add(button11);
            tabPage1.Controls.Add(button12);
            tabPage1.Controls.Add(Authors);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2, 1, 2, 1);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 1, 2, 1);
            tabPage1.Size = new Size(454, 485);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Books";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            button20.Location = new Point(85, 300);
            button20.Margin = new Padding(2, 1, 2, 1);
            button20.Name = "button20";
            button20.Size = new Size(93, 22);
            button20.TabIndex = 11;
            button20.Text = "Select";
            button20.UseVisualStyleBackColor = true;
            button20.Click += SelectAuthors;
            // 
            // button13
            // 
            button13.Location = new Point(15, 438);
            button13.Margin = new Padding(2, 1, 2, 1);
            button13.Name = "button13";
            button13.Size = new Size(93, 22);
            button13.TabIndex = 10;
            button13.Text = "New Book";
            button13.UseVisualStyleBackColor = true;
            button13.Click += NewBook;
            // 
            // button11
            // 
            button11.Location = new Point(183, 8);
            button11.Margin = new Padding(2, 1, 2, 1);
            button11.Name = "button11";
            button11.Size = new Size(93, 22);
            button11.TabIndex = 9;
            button11.Text = "Prev";
            button11.UseVisualStyleBackColor = true;
            button11.Click += BookPrev;
            // 
            // button12
            // 
            button12.Location = new Point(293, 8);
            button12.Margin = new Padding(2, 1, 2, 1);
            button12.Name = "button12";
            button12.Size = new Size(93, 22);
            button12.TabIndex = 8;
            button12.Text = "Next";
            button12.UseVisualStyleBackColor = true;
            button12.Click += BookNext;
            // 
            // Authors
            // 
            Authors.FormattingEnabled = true;
            Authors.ItemHeight = 15;
            Authors.Location = new Point(15, 326);
            Authors.Margin = new Padding(2, 1, 2, 1);
            Authors.Name = "Authors";
            Authors.Size = new Size(373, 94);
            Authors.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 303);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 3;
            label8.Text = "Authors";
            // 
            // button2
            // 
            button2.Location = new Point(255, 438);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(93, 22);
            button2.TabIndex = 5;
            button2.Text = "Delete Book";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(127, 438);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(93, 22);
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
            groupBox2.Location = new Point(15, 151);
            groupBox2.Margin = new Padding(2, 1, 2, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 1, 2, 1);
            groupBox2.Size = new Size(371, 137);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Book Properties";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(146, 103);
            textBox6.Margin = new Padding(2, 1, 2, 1);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(189, 23);
            textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(146, 68);
            textBox5.Margin = new Padding(2, 1, 2, 1);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(189, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(146, 33);
            textBox4.Margin = new Padding(2, 1, 2, 1);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(189, 23);
            textBox4.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 103);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 2;
            label7.Text = "Publication Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 68);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 1;
            label6.Text = "Genre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 34);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 0;
            label5.Text = "ISBN:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(15, 36);
            groupBox1.Margin = new Padding(2, 1, 2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 1, 2, 1);
            groupBox1.Size = new Size(371, 99);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Base Properties";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 63);
            textBox2.Margin = new Padding(2, 1, 2, 1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 25);
            textBox1.Margin = new Padding(2, 1, 2, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 23);
            textBox1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 63);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 1;
            label4.Text = "Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 25);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 0;
            label3.Text = "ID:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listBox1);
            tabPage2.Controls.Add(button16);
            tabPage2.Controls.Add(button15);
            tabPage2.Controls.Add(button14);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2, 1, 2, 1);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 1, 2, 1);
            tabPage2.Size = new Size(454, 485);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Authors";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(4, 219);
            listBox1.Margin = new Padding(2, 1, 2, 1);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(414, 139);
            listBox1.TabIndex = 9;
            // 
            // button16
            // 
            button16.Location = new Point(316, 12);
            button16.Margin = new Padding(2, 1, 2, 1);
            button16.Name = "button16";
            button16.Size = new Size(111, 22);
            button16.TabIndex = 8;
            button16.Text = "Next";
            button16.UseVisualStyleBackColor = true;
            button16.Click += AuthorNext;
            // 
            // button15
            // 
            button15.Location = new Point(193, 12);
            button15.Margin = new Padding(2, 1, 2, 1);
            button15.Name = "button15";
            button15.Size = new Size(111, 22);
            button15.TabIndex = 7;
            button15.Text = "Prev";
            button15.UseVisualStyleBackColor = true;
            button15.Click += AuthorPrev;
            // 
            // button14
            // 
            button14.Location = new Point(3, 358);
            button14.Margin = new Padding(2, 1, 2, 1);
            button14.Name = "button14";
            button14.Size = new Size(111, 22);
            button14.TabIndex = 6;
            button14.Text = "New Author";
            button14.UseVisualStyleBackColor = true;
            button14.Click += NewAuthor;
            // 
            // button4
            // 
            button4.Location = new Point(251, 358);
            button4.Margin = new Padding(2, 1, 2, 1);
            button4.Name = "button4";
            button4.Size = new Size(111, 22);
            button4.TabIndex = 5;
            button4.Text = "Delete Author";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(128, 358);
            button3.Margin = new Padding(2, 1, 2, 1);
            button3.Name = "button3";
            button3.Size = new Size(111, 22);
            button3.TabIndex = 4;
            button3.Text = "Save Author";
            button3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(4, 193);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(87, 15);
            label13.TabIndex = 2;
            label13.Text = "Author's Books";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(4, 7);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(154, 21);
            label9.TabIndex = 1;
            label9.Text = "Author Management";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox11);
            groupBox3.Controls.Add(textBox10);
            groupBox3.Controls.Add(textBox9);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(4, 36);
            groupBox3.Margin = new Padding(2, 1, 2, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 1, 2, 1);
            groupBox3.Size = new Size(412, 141);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Author Details";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(121, 106);
            textBox11.Margin = new Padding(2, 1, 2, 1);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(212, 23);
            textBox11.TabIndex = 5;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(121, 71);
            textBox10.Margin = new Padding(2, 1, 2, 1);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(212, 23);
            textBox10.TabIndex = 4;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(121, 32);
            textBox9.Margin = new Padding(2, 1, 2, 1);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(212, 23);
            textBox9.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 106);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(62, 15);
            label12.TabIndex = 2;
            label12.Text = "Birth Date:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(38, 71);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 1;
            label11.Text = "Name:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 32);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 0;
            label10.Text = "Author ID:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button19);
            tabPage3.Controls.Add(button18);
            tabPage3.Controls.Add(button17);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(textBox8);
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(groupBox4);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(2, 1, 2, 1);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2, 1, 2, 1);
            tabPage3.Size = new Size(454, 485);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Collections";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            button19.Location = new Point(312, 12);
            button19.Margin = new Padding(2, 1, 2, 1);
            button19.Name = "button19";
            button19.Size = new Size(111, 22);
            button19.TabIndex = 14;
            button19.Text = "Next";
            button19.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Location = new Point(197, 12);
            button18.Margin = new Padding(2, 1, 2, 1);
            button18.Name = "button18";
            button18.Size = new Size(111, 22);
            button18.TabIndex = 13;
            button18.Text = "Prev";
            button18.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Location = new Point(4, 358);
            button17.Margin = new Padding(2, 1, 2, 1);
            button17.Name = "button17";
            button17.Size = new Size(111, 22);
            button17.TabIndex = 12;
            button17.Text = "New Collection";
            button17.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(4, 7);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(175, 21);
            label14.TabIndex = 7;
            label14.Text = "Collection Management";
            // 
            // button5
            // 
            button5.Location = new Point(271, 358);
            button5.Margin = new Padding(2, 1, 2, 1);
            button5.Name = "button5";
            button5.Size = new Size(111, 22);
            button5.TabIndex = 11;
            button5.Text = "Delete Collection";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(135, 358);
            button6.Margin = new Padding(2, 1, 2, 1);
            button6.Name = "button6";
            button6.Size = new Size(111, 22);
            button6.TabIndex = 10;
            button6.Text = "Save Collection";
            button6.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(4, 218);
            textBox8.Margin = new Padding(2, 1, 2, 1);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(414, 110);
            textBox8.TabIndex = 9;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(4, 193);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(109, 15);
            label18.TabIndex = 8;
            label18.Text = "Books in Collection";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox12);
            groupBox4.Controls.Add(textBox13);
            groupBox4.Controls.Add(textBox14);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label17);
            groupBox4.Location = new Point(4, 36);
            groupBox4.Margin = new Padding(2, 1, 2, 1);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2, 1, 2, 1);
            groupBox4.Size = new Size(412, 141);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Collection Details";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(131, 108);
            textBox12.Margin = new Padding(2, 1, 2, 1);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(144, 23);
            textBox12.TabIndex = 8;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(131, 71);
            textBox13.Margin = new Padding(2, 1, 2, 1);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(144, 23);
            textBox13.TabIndex = 7;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(131, 32);
            textBox14.Margin = new Padding(2, 1, 2, 1);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(144, 23);
            textBox14.TabIndex = 6;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(54, 108);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(45, 15);
            label15.TabIndex = 2;
            label15.Text = "Owner:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(58, 71);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(42, 15);
            label16.TabIndex = 1;
            label16.Text = "Name:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(18, 32);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(78, 15);
            label17.TabIndex = 0;
            label17.Text = "Collection ID:";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(groupBox6);
            tabPage4.Controls.Add(groupBox5);
            tabPage4.Controls.Add(label20);
            tabPage4.Controls.Add(label19);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(2, 1, 2, 1);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(2, 1, 2, 1);
            tabPage4.Size = new Size(454, 485);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Collections Management";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dataGridView2);
            groupBox6.Location = new Point(4, 241);
            groupBox6.Margin = new Padding(2, 1, 2, 1);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(2, 1, 2, 1);
            groupBox6.Size = new Size(431, 155);
            groupBox6.TabIndex = 10;
            groupBox6.TabStop = false;
            groupBox6.Text = "Science Collection";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { STitle, SAuthor, SISBN, SOwner });
            dataGridView2.Location = new Point(0, 54);
            dataGridView2.Margin = new Padding(2, 1, 2, 1);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.Size = new Size(431, 101);
            dataGridView2.TabIndex = 3;
            // 
            // STitle
            // 
            STitle.HeaderText = "Title";
            STitle.MinimumWidth = 10;
            STitle.Name = "STitle";
            STitle.ReadOnly = true;
            STitle.Width = 200;
            // 
            // SAuthor
            // 
            SAuthor.HeaderText = "Author";
            SAuthor.MinimumWidth = 10;
            SAuthor.Name = "SAuthor";
            SAuthor.ReadOnly = true;
            SAuthor.Width = 200;
            // 
            // SISBN
            // 
            SISBN.HeaderText = "ISBN";
            SISBN.MinimumWidth = 10;
            SISBN.Name = "SISBN";
            SISBN.ReadOnly = true;
            SISBN.Width = 200;
            // 
            // SOwner
            // 
            SOwner.HeaderText = "Owner";
            SOwner.MinimumWidth = 10;
            SOwner.Name = "SOwner";
            SOwner.ReadOnly = true;
            SOwner.Width = 200;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView1);
            groupBox5.Location = new Point(4, 49);
            groupBox5.Margin = new Padding(2, 1, 2, 1);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2, 1, 2, 1);
            groupBox5.Size = new Size(431, 176);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Fiction Collection";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FTitle, FAuthor, FISBN, FOwner });
            dataGridView1.Location = new Point(0, 50);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(431, 126);
            dataGridView1.TabIndex = 2;
            // 
            // FTitle
            // 
            FTitle.HeaderText = "Title";
            FTitle.MinimumWidth = 10;
            FTitle.Name = "FTitle";
            FTitle.ReadOnly = true;
            FTitle.Width = 200;
            // 
            // FAuthor
            // 
            FAuthor.HeaderText = "Author";
            FAuthor.MinimumWidth = 10;
            FAuthor.Name = "FAuthor";
            FAuthor.ReadOnly = true;
            FAuthor.Width = 200;
            // 
            // FISBN
            // 
            FISBN.HeaderText = "ISBN";
            FISBN.MinimumWidth = 10;
            FISBN.Name = "FISBN";
            FISBN.ReadOnly = true;
            FISBN.Width = 200;
            // 
            // FOwner
            // 
            FOwner.HeaderText = "Owner";
            FOwner.MinimumWidth = 10;
            FOwner.Name = "FOwner";
            FOwner.ReadOnly = true;
            FOwner.Width = 200;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F);
            label20.Location = new Point(4, 7);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(149, 21);
            label20.TabIndex = 8;
            label20.Text = "Collection Overview";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(0, 0);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(0, 15);
            label19.TabIndex = 0;
            // 
            // BookManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 606);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 1, 2, 1);
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
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
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
        private Button button4;
        private Button button3;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private Label label14;
        private Button button5;
        private Button button6;
        private TextBox textBox8;
        private Label label18;
        private GroupBox groupBox4;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private Label label20;
        private Label label19;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn STitle;
        private DataGridViewTextBoxColumn SAuthor;
        private DataGridViewTextBoxColumn SISBN;
        private DataGridViewTextBoxColumn SOwner;
        private DataGridViewTextBoxColumn FTitle;
        private DataGridViewTextBoxColumn FAuthor;
        private DataGridViewTextBoxColumn FISBN;
        private DataGridViewTextBoxColumn FOwner;
        private ToolStripMenuItem resetDatabaseToolStripMenuItem;
        private Button button13;
        private Button button11;
        private Button button12;
        private ListBox Authors;
        private Button button14;
        private Button button16;
        private Button button15;
        private Button button19;
        private Button button18;
        private Button button17;
        private Button button20;
        private ListBox listBox1;
    }
}
