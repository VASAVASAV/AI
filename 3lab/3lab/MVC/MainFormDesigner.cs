using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Args;
using wnd;
using Logger;

namespace _3lab
{
    partial class MainForm : Form
    {
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private ComboBox comboBox5;
        private Label label4;
        private Label label1;
        private ComboBox comboBox3;
        private TextBox textBox3;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboBox7;
        private Label label2;
        private ComboBox comboBox2;
        private Label label3;
        private ComboBox comboBox1;
        private Button button6;
        private Button button5;
        private Button button4;
        private TextBox textBox4;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button button9;
        private Button button10;
        private Button button8;
        private Button button7;
        private ComboBox comboBox4;
        private Button button11;
        private Button button12;
        private Label label13;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TabControl tabControl2;
        private TabPage tabPage5;
        private TabControl tabControl3;
        private TabPage tabPage8;
        private Button button13;
        private Label label14;
        private TextBox textBox8;
        private TabPage tabPage9;
        private Button button15;
        private Label label16;
        private TextBox textBox10;
        private TabPage tabPage14;
        private Button button14;
        private Label label15;
        private TextBox textBox9;
        private TabPage tabPage15;
        private TextBox textBox18;
        private Label label24;
        private Button button22;
        private Label label23;
        private TextBox textBox17;
        private TabPage tabPage6;
        private TabControl tabControl4;
        private TabPage tabPage10;
        private Button button16;
        private Label label17;
        private TextBox textBox11;
        private TabPage tabPage11;
        private Button button17;
        private Label label18;
        private TextBox textBox12;
        private TabPage tabPage16;
        private Button button18;
        private Label label19;
        private TextBox textBox13;
        private TabPage tabPage17;
        private TextBox textBox19;
        private Label label25;
        private Button button23;
        private Label label26;
        private TextBox textBox20;
        private TabPage tabPage7;
        private TabControl tabControl5;
        private TabPage tabPage12;
        private Button button19;
        private Label label20;
        private TextBox textBox14;
        private TabPage tabPage13;
        private Button button20;
        private Label label21;
        private TextBox textBox15;
        private TabPage tabPage18;
        private Button button21;
        private Label label22;
        private TextBox textBox16;
        private TabPage tabPage19;
        private TextBox textBox21;
        private Label label27;
        private Button button24;
        private Label label28;
        private TextBox textBox22;
        private GroupBox groupBox1;

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.button15 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.button14 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.button22 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.button16 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.button17 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.button18 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.button23 = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.button19 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.button20 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.tabPage18 = new System.Windows.Forms.TabPage();
            this.button21 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.tabPage19 = new System.Windows.Forms.TabPage();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.button24 = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage14.SuspendLayout();
            this.tabPage15.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.tabPage16.SuspendLayout();
            this.tabPage17.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabControl5.SuspendLayout();
            this.tabPage12.SuspendLayout();
            this.tabPage13.SuspendLayout();
            this.tabPage18.SuspendLayout();
            this.tabPage19.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(862, 515);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.comboBox5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.comboBox4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(854, 489);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Міста";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(415, 198);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(92, 23);
            this.button9.TabIndex = 14;
            this.button9.Text = "Видалити";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(314, 198);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(92, 23);
            this.button10.TabIndex = 13;
            this.button10.Text = "Додати";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(110, 198);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "Видалити";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(9, 198);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "Додати";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(510, 426);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 57);
            this.button6.TabIndex = 10;
            this.button6.Text = "Зруйнувати місто";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(706, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(628, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Заснований:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Зберігаються:";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(386, 154);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Народилися:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(81, 154);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Назва міста";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(386, 6);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.TextChanged += new System.EventHandler(this.comboBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Заснувати місто";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.button11);
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.comboBox7);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(854, 489);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Автори";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(414, 205);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 19;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(116, 231);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(92, 23);
            this.button11.TabIndex = 18;
            this.button11.Text = "Видалити";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(15, 231);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(92, 23);
            this.button12.TabIndex = 17;
            this.button12.Text = "Додати";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(510, 426);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 57);
            this.button5.TabIndex = 16;
            this.button5.Text = "Вбити автора";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(706, 203);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(634, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Народився:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Місце народження";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Створив";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(87, 204);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ім\'я";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(375, 6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.TextChanged += new System.EventHandler(this.comboBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(682, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Додати автора";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox7);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(854, 489);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Шедеври";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(404, 234);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(808, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "році";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(120, 234);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(513, 429);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 57);
            this.button4.TabIndex = 22;
            this.button4.Text = "Спалити шедевр";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(702, 234);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(608, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "був створений у";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(301, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Місце зберігання:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Створений ким";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Назва шедевру";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(372, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(685, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 57);
            this.button3.TabIndex = 1;
            this.button3.Text = "Додати шедевр";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tabControl2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(854, 489);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Запити";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(4, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(847, 482);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tabControl3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(839, 456);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Міста";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage8);
            this.tabControl3.Controls.Add(this.tabPage9);
            this.tabControl3.Controls.Add(this.tabPage14);
            this.tabControl3.Controls.Add(this.tabPage15);
            this.tabControl3.Location = new System.Drawing.Point(4, 4);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(832, 446);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.button13);
            this.tabPage8.Controls.Add(this.label14);
            this.tabPage8.Controls.Add(this.textBox8);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(824, 420);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "Назва";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(20, 101);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(158, 37);
            this.button13.TabIndex = 2;
            this.button13.Text = "Перевірити";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Значення";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(78, 56);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 0;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.button15);
            this.tabPage9.Controls.Add(this.label16);
            this.tabPage9.Controls.Add(this.textBox10);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(824, 420);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Народилися";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(23, 100);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(158, 37);
            this.button15.TabIndex = 5;
            this.button15.Text = "Перевірити";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Значення";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(81, 55);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 3;
            // 
            // tabPage14
            // 
            this.tabPage14.Controls.Add(this.button14);
            this.tabPage14.Controls.Add(this.label15);
            this.tabPage14.Controls.Add(this.textBox9);
            this.tabPage14.Location = new System.Drawing.Point(4, 22);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Size = new System.Drawing.Size(824, 420);
            this.tabPage14.TabIndex = 2;
            this.tabPage14.Text = "Зберігаються";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(26, 98);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(158, 37);
            this.button14.TabIndex = 5;
            this.button14.Text = "Перевірити";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Значення";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(84, 53);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 3;
            // 
            // tabPage15
            // 
            this.tabPage15.Controls.Add(this.textBox18);
            this.tabPage15.Controls.Add(this.label24);
            this.tabPage15.Controls.Add(this.button22);
            this.tabPage15.Controls.Add(this.label23);
            this.tabPage15.Controls.Add(this.textBox17);
            this.tabPage15.Location = new System.Drawing.Point(4, 22);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Size = new System.Drawing.Size(824, 420);
            this.tabPage15.TabIndex = 3;
            this.tabPage15.Text = "Заснований";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(216, 59);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 20);
            this.textBox18.TabIndex = 7;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(191, 62);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(19, 13);
            this.label24.TabIndex = 6;
            this.label24.Text = "до";
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(27, 106);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(158, 37);
            this.button22.TabIndex = 5;
            this.button22.Text = "Перевірити";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 62);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 13);
            this.label23.TabIndex = 4;
            this.label23.Text = "Значення від";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(85, 59);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 20);
            this.textBox17.TabIndex = 3;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tabControl4);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(839, 456);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Автори";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage10);
            this.tabControl4.Controls.Add(this.tabPage11);
            this.tabControl4.Controls.Add(this.tabPage16);
            this.tabControl4.Controls.Add(this.tabPage17);
            this.tabControl4.Location = new System.Drawing.Point(3, 5);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(832, 446);
            this.tabControl4.TabIndex = 1;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.button16);
            this.tabPage10.Controls.Add(this.label17);
            this.tabPage10.Controls.Add(this.textBox11);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(824, 420);
            this.tabPage10.TabIndex = 0;
            this.tabPage10.Text = "Ім\'я";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(14, 94);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(158, 37);
            this.button16.TabIndex = 5;
            this.button16.Text = "Перевірити";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Значення";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(72, 49);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 3;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.button17);
            this.tabPage11.Controls.Add(this.label18);
            this.tabPage11.Controls.Add(this.textBox12);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(824, 420);
            this.tabPage11.TabIndex = 1;
            this.tabPage11.Text = "Створив";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(14, 97);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(158, 37);
            this.button17.TabIndex = 5;
            this.button17.Text = "Перевірити";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Значення";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(72, 52);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 3;
            // 
            // tabPage16
            // 
            this.tabPage16.Controls.Add(this.button18);
            this.tabPage16.Controls.Add(this.label19);
            this.tabPage16.Controls.Add(this.textBox13);
            this.tabPage16.Location = new System.Drawing.Point(4, 22);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Size = new System.Drawing.Size(824, 420);
            this.tabPage16.TabIndex = 2;
            this.tabPage16.Text = "Народився";
            this.tabPage16.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(13, 92);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(158, 37);
            this.button18.TabIndex = 5;
            this.button18.Text = "Перевірити";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Значення";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(71, 47);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 3;
            // 
            // tabPage17
            // 
            this.tabPage17.Controls.Add(this.textBox19);
            this.tabPage17.Controls.Add(this.label25);
            this.tabPage17.Controls.Add(this.button23);
            this.tabPage17.Controls.Add(this.label26);
            this.tabPage17.Controls.Add(this.textBox20);
            this.tabPage17.Location = new System.Drawing.Point(4, 22);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Size = new System.Drawing.Size(824, 420);
            this.tabPage17.TabIndex = 3;
            this.tabPage17.Text = "Рік народження";
            this.tabPage17.UseVisualStyleBackColor = true;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(218, 54);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(100, 20);
            this.textBox19.TabIndex = 12;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(193, 57);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(19, 13);
            this.label25.TabIndex = 11;
            this.label25.Text = "до";
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(29, 101);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(158, 37);
            this.button23.TabIndex = 10;
            this.button23.Text = "Перевірити";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(9, 57);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(72, 13);
            this.label26.TabIndex = 9;
            this.label26.Text = "Значення від";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(87, 54);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(100, 20);
            this.textBox20.TabIndex = 8;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.tabControl5);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(839, 456);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Шедеври";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.tabPage12);
            this.tabControl5.Controls.Add(this.tabPage13);
            this.tabControl5.Controls.Add(this.tabPage18);
            this.tabControl5.Controls.Add(this.tabPage19);
            this.tabControl5.Location = new System.Drawing.Point(3, 5);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(832, 446);
            this.tabControl5.TabIndex = 1;
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.button19);
            this.tabPage12.Controls.Add(this.label20);
            this.tabPage12.Controls.Add(this.textBox14);
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(824, 420);
            this.tabPage12.TabIndex = 0;
            this.tabPage12.Text = "Назва";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(13, 99);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(158, 37);
            this.button19.TabIndex = 5;
            this.button19.Text = "Перевірити";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(10, 57);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "Значення";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(71, 54);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 3;
            // 
            // tabPage13
            // 
            this.tabPage13.Controls.Add(this.button20);
            this.tabPage13.Controls.Add(this.label21);
            this.tabPage13.Controls.Add(this.textBox15);
            this.tabPage13.Location = new System.Drawing.Point(4, 22);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(824, 420);
            this.tabPage13.TabIndex = 1;
            this.tabPage13.Text = "Написаний ким";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(12, 102);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(158, 37);
            this.button20.TabIndex = 5;
            this.button20.Text = "Перевірити";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 60);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "Значення";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(70, 57);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 3;
            // 
            // tabPage18
            // 
            this.tabPage18.Controls.Add(this.button21);
            this.tabPage18.Controls.Add(this.label22);
            this.tabPage18.Controls.Add(this.textBox16);
            this.tabPage18.Location = new System.Drawing.Point(4, 22);
            this.tabPage18.Name = "tabPage18";
            this.tabPage18.Size = new System.Drawing.Size(824, 420);
            this.tabPage18.TabIndex = 2;
            this.tabPage18.Text = "Зберігається де";
            this.tabPage18.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(18, 98);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(158, 37);
            this.button21.TabIndex = 5;
            this.button21.Text = "Перевірити";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 56);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 13);
            this.label22.TabIndex = 4;
            this.label22.Text = "Значення";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(76, 53);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 20);
            this.textBox16.TabIndex = 3;
            // 
            // tabPage19
            // 
            this.tabPage19.Controls.Add(this.textBox21);
            this.tabPage19.Controls.Add(this.label27);
            this.tabPage19.Controls.Add(this.button24);
            this.tabPage19.Controls.Add(this.label28);
            this.tabPage19.Controls.Add(this.textBox22);
            this.tabPage19.Location = new System.Drawing.Point(4, 22);
            this.tabPage19.Name = "tabPage19";
            this.tabPage19.Size = new System.Drawing.Size(824, 420);
            this.tabPage19.TabIndex = 3;
            this.tabPage19.Text = "Створений коли";
            this.tabPage19.UseVisualStyleBackColor = true;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(217, 60);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(100, 20);
            this.textBox21.TabIndex = 12;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(192, 63);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(19, 13);
            this.label27.TabIndex = 11;
            this.label27.Text = "до";
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(28, 107);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(158, 37);
            this.button24.TabIndex = 10;
            this.button24.Text = "Перевірити";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(8, 63);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 13);
            this.label28.TabIndex = 9;
            this.label28.Text = "Значення від";
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(86, 60);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(100, 20);
            this.textBox22.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 490);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(881, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 515);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Журнал";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1110, 540);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage14.ResumeLayout(false);
            this.tabPage14.PerformLayout();
            this.tabPage15.ResumeLayout(false);
            this.tabPage15.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            this.tabPage16.ResumeLayout(false);
            this.tabPage16.PerformLayout();
            this.tabPage17.ResumeLayout(false);
            this.tabPage17.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabControl5.ResumeLayout(false);
            this.tabPage12.ResumeLayout(false);
            this.tabPage12.PerformLayout();
            this.tabPage13.ResumeLayout(false);
            this.tabPage13.PerformLayout();
            this.tabPage18.ResumeLayout(false);
            this.tabPage18.PerformLayout();
            this.tabPage19.ResumeLayout(false);
            this.tabPage19.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            string val = textBox8.Text;
            if (MyCont.MyModel.GetCityByName(val) == null)
            {
                ShowMessage("Нічого не знайдено");
            }
            else
            {
                ShowMessage("Існує місто з такою назвою");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string val = textBox11.Text;
            if (MyCont.MyModel.GetAuthorByName(val) == null)
            {
                ShowMessage("Нікого не знайдено");
            }
            else
            {
                ShowMessage("Існує автор з таким іменем");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string val = textBox14.Text;
            if (MyCont.MyModel.GetPieceByName(val) == null)
            {
                ShowMessage("Нічого не знайдено");
            }
            else
            {
                ShowMessage("Існує шедевр з такою назвою");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string val = textBox10.Text;
            if (MyCont.MyModel.GetCityByName(val) == null)
            {
                ShowMessage("Нічого не знайдено");
            }
            else
            {
                ShowMessage("У цьому місті народилися :");
                var Target = MyCont.MyModel.GetCityByName(val);
                for (int i = 0; i < Target.ArtistCitizens.Count; i++)
                {
                    ShowMessage(Target.ArtistCitizens[i].Name);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string val = textBox9.Text;
            if (MyCont.MyModel.GetCityByName(val) == null)
            {
                ShowMessage("Нічого не знайдено");
            }
            else
            {
                ShowMessage("У цьому місті зберігаються :");
                var Target = MyCont.MyModel.GetCityByName(val);
                for (int i = 0; i < Target.ArtworksStored.Count; i++)
                {
                    ShowMessage(Target.ArtworksStored[i].Title);
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string val = textBox12.Text;
            if (MyCont.MyModel.GetAuthorByName(val) == null)
            {
                ShowMessage("Нікого не знайдено");
            }
            else
            {
                ShowMessage("Цей автор створив :");
                var Target = MyCont.MyModel.GetAuthorByName(val);
                for (int i = 0; i < Target.ArtWorks.Count; i++)
                {
                    ShowMessage(Target.ArtWorks[i].Title);
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string val = textBox13.Text;
            if (MyCont.MyModel.GetAuthorByName(val) == null)
            {
                ShowMessage("Нікого не знайдено");
            }
            else
            {
                ShowMessage("Цей автора народився у місті :");
                ShowMessage(""+ MyCont.MyModel.GetAuthorByName(val).GetBirthPlace());
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string val = textBox15.Text;
            if (MyCont.MyModel.GetPieceByName(val) == null)
            {
                ShowMessage("Нічого не знайдено");
            }
            else
            {
                ShowMessage("Цей шедевр був створений :");
                ShowMessage("" + MyCont.MyModel.GetPieceByName(val).GetAuthor());
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string val = textBox16.Text;
            if (MyCont.MyModel.GetPieceByName(val) == null)
            {
                ShowMessage("Нічого не знайдено");
            }
            else
            {
                ShowMessage("Цей шедевр зберігається у :");
                ShowMessage("" + MyCont.MyModel.GetPieceByName(val).Storage.CityName);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double val1;
            double val2;
            try
            {
                val1 = Convert.ToDouble(textBox17.Text);
            }
            catch
            {
                val1 = double.NegativeInfinity;
            }
            try
            {
                val2 = Convert.ToDouble(textBox18.Text);
            }
            catch
            {
                val2 = double.PositiveInfinity;
            }
            ShowMessage("У цей період було засновані міста :");
            for (int i = 0; i < MyCont.MyModel.Cities.Count; i++)
            {
                if (MyCont.MyModel.Cities[i].FoundationTime > val1 && MyCont.MyModel.Cities[i].FoundationTime < val2)
                {
                    ShowMessage(""+ MyCont.MyModel.Cities[i].CityName);
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double val1;
            double val2;
            try
            {
                val1 = Convert.ToDouble(textBox20.Text);
            }
            catch
            {
                val1 = double.NegativeInfinity;
            }
            try
            {
                val2 = Convert.ToDouble(textBox19.Text);
            }
            catch
            {
                val2 = double.PositiveInfinity;
            }
            ShowMessage("У цей період народилися люди :");
            for (int i = 0; i < MyCont.MyModel.Authors.Count; i++)
            {
                if (MyCont.MyModel.Authors[i].DateOfBirth > val1 && MyCont.MyModel.Authors[i].DateOfBirth < val2)
                {
                    ShowMessage("" + MyCont.MyModel.Authors[i].Name);
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double val1;
            double val2;
            try
            {
                val1 = Convert.ToDouble(textBox22.Text);
            }
            catch
            {
                val1 = double.NegativeInfinity;
            }
            try
            {
                val2 = Convert.ToDouble(textBox21.Text);
            }
            catch
            {
                val2 = double.PositiveInfinity;
            }
            ShowMessage("У цей період були створені шедеври :");
            for (int i = 0; i < MyCont.MyModel.Artworks.Count; i++)
            {
                if (MyCont.MyModel.Artworks[i].CreationDate > val1 && MyCont.MyModel.Artworks[i].CreationDate < val2)
                {
                    ShowMessage("" + MyCont.MyModel.Artworks[i].Title);
                }
            }
        }
    }
}
