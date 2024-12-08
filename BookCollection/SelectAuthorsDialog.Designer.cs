namespace BookCollection
{
    partial class SelectAuthorsDialog
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
            listBoxAuthors = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // listBoxAuthors
            // 
            listBoxAuthors.FormattingEnabled = true;
            listBoxAuthors.Location = new Point(37, 12);
            listBoxAuthors.Name = "listBoxAuthors";
            listBoxAuthors.Size = new Size(677, 228);
            listBoxAuthors.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(37, 292);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 1;
            button1.Text = "Select";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonSelect_Click;
            // 
            // button2
            // 
            button2.Location = new Point(280, 292);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 2;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ButtonClear_Click;
            // 
            // button3
            // 
            button3.Location = new Point(504, 292);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 3;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ButtonCancel_Click;
            // 
            // SelectAuthorsDialog
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBoxAuthors);
            Name = "SelectAuthorsDialog";
            Text = "SelectAuthorsDialog";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxAuthors;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}