using System;
using Args;
using wnd;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace _3lab
{
    partial class MainForm
    {
        public Controller MyCont;
        public MainForm()
        {
            InitializeComponent();
        }

        public void AddCityName(string Name)
        {
            if(!comboBox3.Items.Contains(Name))
                comboBox3.Items.Add(Name);
        }

        public void AddAuthorName(string Name)
        {
            if (!comboBox2.Items.Contains(Name))
                comboBox2.Items.Add(Name);
        }

        public void AddPieceName(string Name)
        {
            if (!comboBox1.Items.Contains(Name))
                comboBox1.Items.Add(Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArgStr Type = new ArgStr("", "p", "Ім'я нового міста", "Напишіть назву міста, що бажаєте заснувати", "");
            ArgInt CreationDate = new ArgInt(1000, "p", "Дата заснування", "Рік, у якому було засноване місто", "");
            OkCancelDlg it = new OkCancelDlg("Заснування міста", null, Type, CreationDate);
            DialogResult rc = it.ShowDialog();
            if (rc == DialogResult.OK)
            {
                MyCont.FoundCity(Type,CreationDate);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArgStr Type = new ArgStr("", "p", "І'мя  великої людини", "Напишіть і'мя  великої людини, якого бажаєте створити", "");
            ArgStr BirthPlace = new ArgStr("", "p", "Місце народження", "Виберіть місто, у якому народилася ця людина", "",MyCont.CitiesArr);
            ArgInt BirthDate = new ArgInt(1000, "p", "Дата народження", "Рік, у якому ця людина народилася", "");
            OkCancelDlg it = new OkCancelDlg("Народження великої людини", null, Type,BirthPlace, BirthDate);
            DialogResult rc = it.ShowDialog();
            if (!MyCont.CitiesArr.ToList().Contains(BirthPlace))
            {
                textBox1.Text += "Such town doesnt exist" + Environment.NewLine;
                return;
            }
            if (rc == DialogResult.OK)
            {
                MyCont.BirthOfMan(Type, BirthPlace, BirthDate);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArgStr Type = new ArgStr("", "p", "Назва нового шедевру", "Напишіть назву шедевру, що бажаєте створити", "");
            ArgStr CreationPlace = new ArgStr("", "p", "Місце створення", "Виберіть місто, у якому було створено цей шедевр", "", MyCont.CitiesArr);
            ArgStr Author = new ArgStr("", "p", "Автора шедевру", "Виберіть людину, яка створила цей шедевр", "", MyCont.AuthorsArr);
            ArgInt Year = new ArgInt(1000, "p", "Дата створення", "Рік, у який було сворено цей шедевр", "");
            OkCancelDlg it = new OkCancelDlg("Створення шедевру", null, Type, CreationPlace, Author,Year);
            DialogResult rc = it.ShowDialog();
            if (!MyCont.CitiesArr.ToList().Contains(CreationPlace)||!MyCont.AuthorsArr.ToList().Contains(Author))
            {
                textBox1.Text += "Such town or author doesnt exist" + Environment.NewLine;
                return;
            }
            if (rc == DialogResult.OK)
            {
                MyCont.CreationOfMasterpiece(Type, CreationPlace, Author,Year);
            }
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            if (!comboBox3.Items.Contains(comboBox3.Text))
            {
                comboBox3.Text = "";
                return;
            }
            Tuple<List<string>,List<string>,int> Target = MyCont.GetCityInf(comboBox3.Text);
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            textBox2.Text = ""+Target.Item3;
            for (int i = 0; i < (Target.Item2 as List<string>).Count; i++)
            {
                comboBox5.Items.Add((Target.Item2 as List<string>)[i]);
            }
            for (int i = 0; i < (Target.Item1 as List<string>).Count; i++)
            {
                comboBox4.Items.Add((Target.Item1 as List<string>)[i]);
            }
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            if (!comboBox2.Items.Contains(comboBox2.Text))
            {
                comboBox2.Text = "";
                return;
            }
            Tuple<List<string>, string, int> Target = MyCont.GetAuthorInf(comboBox2.Text);
            comboBox7.Items.Clear();
            textBox3.Text = "" + Target.Item3;
            textBox6.Text = "" + Target.Item2;
            for (int i = 0; i < (Target.Item1 as List<string>).Count; i++)
            {
                comboBox7.Items.Add((Target.Item1 as List<string>)[i]);
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (!comboBox1.Items.Contains(comboBox1.Text))
            {
                comboBox1.Text = "";
                return;
            }
            Tuple<string, string, int> Target = MyCont.GetPieceInf(comboBox1.Text);
            comboBox7.Items.Clear();
            textBox5.Text = "" + Target.Item1;
            textBox7.Text = "" + Target.Item2;
            textBox4.Text = "" + Target.Item3;
        }

        public void ShowMessage(string MessageToShow)
        {
            textBox1.Text += MessageToShow + Environment.NewLine;
        }
    }
}
