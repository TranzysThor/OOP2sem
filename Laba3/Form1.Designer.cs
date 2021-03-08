using System.Windows.Forms;

namespace Laba3
{
    partial class Form1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gPAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseSortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSortedByGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSortedByCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Timers.Timer();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextInput);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(34, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(34, 81);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextInput);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(34, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patronymic";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(34, 122);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextInput);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(34, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Age";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(34, 162);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(57, 17);
            this.listBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(33, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date of Birth";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 244);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(33, 268);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Course";
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(34, 284);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(22, 14);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(62, 284);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(22, 14);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(88, 284);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(22, 14);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.Location = new System.Drawing.Point(116, 284);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(34, 14);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(33, 301);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Group";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(30, 358);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "GPA";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(34, 375);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.MaxLength = 3;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(57, 20);
            this.textBox4.TabIndex = 19;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitInput);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(30, 399);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 14);
            this.label9.TabIndex = 23;
            this.label9.Text = "Sex";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(34, 187);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Speciality";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(34, 203);
            this.listBox3.Margin = new System.Windows.Forms.Padding(2);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(57, 17);
            this.listBox3.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(34, 440);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 23);
            this.label11.TabIndex = 26;
            this.label11.Text = "Address";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(34, 465);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(156, 20);
            this.textBox5.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 496);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 37);
            this.button2.TabIndex = 29;
            this.button2.Text = "Save Object";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SerializeStudent);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(326, 496);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 37);
            this.button3.TabIndex = 30;
            this.button3.Text = "Output Object";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OutputStudentsInfo);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(34, 324);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Maximum = 12;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(174, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(34, 415);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(78, 17);
            this.listBox2.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 496);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 37);
            this.button1.TabIndex = 28;
            this.button1.Text = "Create Object";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CreateObjectInstance);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(225, 18);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(361, 464);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(470, 496);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 37);
            this.button4.TabIndex = 33;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ClearField);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.aboutToolStripMenuItem, this.functionsToolStripMenuItem, this.saveSortedByGroupToolStripMenuItem, this.saveSortedByCourseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(596, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.About);
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.searchToolStripMenuItem, this.sortByToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.functionsToolStripMenuItem.Text = "Functions";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fIOToolStripMenuItem, this.specialityToolStripMenuItem, this.courseToolStripMenuItem, this.gPAToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.searchToolStripMenuItem.Text = "Search By...";
            // 
            // fIOToolStripMenuItem
            // 
            this.fIOToolStripMenuItem.Name = "fIOToolStripMenuItem";
            this.fIOToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.fIOToolStripMenuItem.Text = "FIO";
            this.fIOToolStripMenuItem.Click += new System.EventHandler(this.FullnameSearch);
            // 
            // specialityToolStripMenuItem
            // 
            this.specialityToolStripMenuItem.Name = "specialityToolStripMenuItem";
            this.specialityToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.specialityToolStripMenuItem.Text = "Speciality";
            this.specialityToolStripMenuItem.Click += new System.EventHandler(this.SpecialitySearch);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.courseToolStripMenuItem.Text = "Course";
            this.courseToolStripMenuItem.Click += new System.EventHandler(this.CourseSearch);
            // 
            // gPAToolStripMenuItem
            // 
            this.gPAToolStripMenuItem.Name = "gPAToolStripMenuItem";
            this.gPAToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.gPAToolStripMenuItem.Text = "GPA";
            this.gPAToolStripMenuItem.Click += new System.EventHandler(this.GpaSearch);
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.groupSortToolStripMenuItem, this.courseSortToolStripMenuItem1});
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.sortByToolStripMenuItem.Text = "Sort By...";
            // 
            // groupSortToolStripMenuItem
            // 
            this.groupSortToolStripMenuItem.Name = "groupSortToolStripMenuItem";
            this.groupSortToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.groupSortToolStripMenuItem.Text = "Group";
            this.groupSortToolStripMenuItem.Click += new System.EventHandler(this.SortByGroup);
            // 
            // courseSortToolStripMenuItem1
            // 
            this.courseSortToolStripMenuItem1.Name = "courseSortToolStripMenuItem1";
            this.courseSortToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.courseSortToolStripMenuItem1.Text = "Course";
            this.courseSortToolStripMenuItem1.Click += new System.EventHandler(this.SortByCourse);
            // 
            // saveSortedByGroupToolStripMenuItem
            // 
            this.saveSortedByGroupToolStripMenuItem.Name = "saveSortedByGroupToolStripMenuItem";
            this.saveSortedByGroupToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.saveSortedByGroupToolStripMenuItem.Text = "Save Sorted By Group";
            this.saveSortedByGroupToolStripMenuItem.Click += new System.EventHandler(this.SaveSortedByGroup);
            // 
            // saveSortedByCourseToolStripMenuItem
            // 
            this.saveSortedByCourseToolStripMenuItem.Name = "saveSortedByCourseToolStripMenuItem";
            this.saveSortedByCourseToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.saveSortedByCourseToolStripMenuItem.Text = "Save Sorted By Course";
            this.saveSortedByCourseToolStripMenuItem.Click += new System.EventHandler(this.SaveSortedByCourse);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label12.Location = new System.Drawing.Point(0, 534);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Amount of Objects: ";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label13.Location = new System.Drawing.Point(184, 535);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(257, 21);
            this.label13.TabIndex = 36;
            this.label13.Text = "Previous Action: ";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label14.Location = new System.Drawing.Point(471, 536);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "0.0.0 00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(596, 554);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(15, 15);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label14;

        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.Label label12;
        private System.Timers.Timer timer1;

        private System.Windows.Forms.ToolStripMenuItem saveSortedByCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSortedByGroupToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem gPAToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem fIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialityToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem groupSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseSortToolStripMenuItem1;

        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.RichTextBox richTextBox1;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.ListBox listBox2;

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;

        private System.Windows.Forms.ListBox listBox3;

        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TrackBar trackBar1;

        #endregion
    }
}