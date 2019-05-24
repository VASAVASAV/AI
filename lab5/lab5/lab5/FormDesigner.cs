using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class FormDesigner : Form
    {
        public bool Istaught = false;
        public double[,] W;
        DataGridView[] Arr;

        public FormDesigner()
        {
            Istaught = false;
            InitializeComponent();
            int NumOfShapes;
            NumOfShapes = Convert.ToInt32(textBox1.Text);
            tabControl2.TabPages.Clear();
            Arr = new DataGridView[NumOfShapes];
            /////////////////
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.CellClick += Temp_CellClick;
            TabPage dataGridView1Page = new TabPage();
            for (int j = 0; j < 10; j++)
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                dataGridView1.Columns[j].ReadOnly = true;
                dataGridView1.Columns[j].Width = 30;
            }
            for (int j = 0; j < 10; j++)
            {
                dataGridView1.Rows.Add();
            }
            dataGridView1.Height = 300;
            dataGridView1.Width = 375;
            /////////////////
            for (int i = 0; i < NumOfShapes; i++)
            {
                DataGridView Temp = new DataGridView();
                Temp.AllowUserToAddRows = false;
                Temp.AllowUserToDeleteRows = false;
                Temp.AllowUserToOrderColumns = false;
                Temp.CellClick += Temp_CellClick;
                TabPage TempPage = new TabPage();
                for (int j = 0; j < 10; j++)
                {
                    Temp.Columns.Add(new DataGridViewTextBoxColumn());
                    Temp.Columns[j].ReadOnly = true;
                    Temp.Columns[j].Width = 30;
                }
                for (int j = 0; j < 10; j++)
                {
                    Temp.Rows.Add();
                }
                Temp.Height = 300;
                Temp.Width = 375;
                TempPage.Controls.Add(Temp);
                Arr[i] = Temp;
                TempPage.Text = "Образ номер " + (i+1);
                tabControl2.TabPages.Add(TempPage);
            }

            Arr[0].Rows[4].Cells[2].Style.BackColor = Color.Black;
            Arr[0].Rows[4].Cells[3].Style.BackColor = Color.Black;
            Arr[0].Rows[4].Cells[4].Style.BackColor = Color.Black;
            Arr[0].Rows[4].Cells[5].Style.BackColor = Color.Black;
            Arr[0].Rows[4].Cells[6].Style.BackColor = Color.Black;
            Arr[0].Rows[3].Cells[2].Style.BackColor = Color.Black;
            Arr[0].Rows[5].Cells[2].Style.BackColor = Color.Black;
            Arr[0].Rows[2].Cells[2].Style.BackColor = Color.Black;
            Arr[0].Rows[6].Cells[2].Style.BackColor = Color.Black;
            Arr[0].Rows[1].Cells[3].Style.BackColor = Color.Black;
            Arr[0].Rows[7].Cells[3].Style.BackColor = Color.Black;
            Arr[0].Rows[0].Cells[4].Style.BackColor = Color.Black;
            Arr[0].Rows[8].Cells[4].Style.BackColor = Color.Black;
            Arr[0].Rows[0].Cells[5].Style.BackColor = Color.Black;
            Arr[0].Rows[8].Cells[5].Style.BackColor = Color.Black;
            Arr[0].Rows[0].Cells[6].Style.BackColor = Color.Black;
            Arr[0].Rows[8].Cells[6].Style.BackColor = Color.Black;
            /////////////////////////////
            Arr[1].Rows[1].Cells[2].Style.BackColor = Color.Black;
            Arr[1].Rows[1].Cells[3].Style.BackColor = Color.Black;
            Arr[1].Rows[1].Cells[4].Style.BackColor = Color.Black;
            Arr[1].Rows[1].Cells[5].Style.BackColor = Color.Black;
            Arr[1].Rows[1].Cells[6].Style.BackColor = Color.Black;
            Arr[1].Rows[1].Cells[7].Style.BackColor = Color.Black;
            Arr[1].Rows[2].Cells[2].Style.BackColor = Color.Black;
            Arr[1].Rows[2].Cells[7].Style.BackColor = Color.Black;
            Arr[1].Rows[3].Cells[2].Style.BackColor = Color.Black;
            Arr[1].Rows[3].Cells[7].Style.BackColor = Color.Black;
            Arr[1].Rows[4].Cells[2].Style.BackColor = Color.Black;
            Arr[1].Rows[4].Cells[7].Style.BackColor = Color.Black;
            Arr[1].Rows[5].Cells[2].Style.BackColor = Color.Black;
            Arr[1].Rows[5].Cells[7].Style.BackColor = Color.Black;
            Arr[1].Rows[6].Cells[2].Style.BackColor = Color.Black;
            Arr[1].Rows[6].Cells[7].Style.BackColor = Color.Black;
            Arr[1].Rows[7].Cells[2].Style.BackColor = Color.Black;
            Arr[1].Rows[7].Cells[7].Style.BackColor = Color.Black;
            Arr[1].Rows[8].Cells[2].Style.BackColor = Color.Black;
            Arr[1].Rows[8].Cells[7].Style.BackColor = Color.Black;
            ///////////////////////////////
            Arr[2].Rows[4].Cells[2].Style.BackColor = Color.Black;
            Arr[2].Rows[4].Cells[3].Style.BackColor = Color.Black;
            Arr[2].Rows[4].Cells[4].Style.BackColor = Color.Black;
            Arr[2].Rows[3].Cells[2].Style.BackColor = Color.Black;
            Arr[2].Rows[2].Cells[2].Style.BackColor = Color.Black;
            Arr[2].Rows[1].Cells[2].Style.BackColor = Color.Black;
            Arr[2].Rows[5].Cells[2].Style.BackColor = Color.Black;
            Arr[2].Rows[6].Cells[2].Style.BackColor = Color.Black;
            Arr[2].Rows[7].Cells[2].Style.BackColor = Color.Black;
            Arr[2].Rows[3].Cells[4].Style.BackColor = Color.Black;
            Arr[2].Rows[5].Cells[4].Style.BackColor = Color.Black;
            Arr[2].Rows[2].Cells[5].Style.BackColor = Color.Black;
            Arr[2].Rows[6].Cells[5].Style.BackColor = Color.Black;
            Arr[2].Rows[1].Cells[6].Style.BackColor = Color.Black;
            Arr[2].Rows[7].Cells[6].Style.BackColor = Color.Black;
            Arr[2].Rows[1].Cells[7].Style.BackColor = Color.Black;
            Arr[2].Rows[7].Cells[7].Style.BackColor = Color.Black;
            Arr[2].Rows[2].Cells[8].Style.BackColor = Color.Black;
            Arr[2].Rows[6].Cells[8].Style.BackColor = Color.Black;
            Arr[2].Rows[3].Cells[9].Style.BackColor = Color.Black;
            Arr[2].Rows[5].Cells[9].Style.BackColor = Color.Black;
            Arr[2].Rows[4].Cells[9].Style.BackColor = Color.Black;
        }

        private void Temp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = ((sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].InheritedStyle.BackColor==Color.Black)?(Color.White):(Color.Black);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Istaught = false;
            int NumOfShapes;
            NumOfShapes = Convert.ToInt32(textBox1.Text);
            tabControl2.TabPages.Clear();
            Arr = new DataGridView[NumOfShapes];
            /////////////////
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.CellClick += Temp_CellClick;
            TabPage dataGridView1Page = new TabPage();
            for (int j = 0; j < 10; j++)
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                dataGridView1.Columns[j].ReadOnly = true;
                dataGridView1.Columns[j].Width = 30;
            }
            for (int j = 0; j < 10; j++)
            {
                dataGridView1.Rows.Add();
            }
            dataGridView1.Height = 300;
            dataGridView1.Width = 375;
            /////////////////
            for (int i = 0; i < NumOfShapes; i++)
            {
                DataGridView Temp = new DataGridView();
                Temp.AllowUserToAddRows = false;
                Temp.AllowUserToDeleteRows = false;
                Temp.AllowUserToOrderColumns = false;
                Temp.CellClick += Temp_CellClick;
                TabPage TempPage = new TabPage();
                for (int j = 0; j < 10; j++)
                {
                    Temp.Columns.Add(new DataGridViewTextBoxColumn());
                    Temp.Columns[j].ReadOnly = true;
                    Temp.Columns[j].Width = 30;
                }
                for (int j = 0; j < 10; j++)
                {
                    Temp.Rows.Add();
                }
                Temp.Height = 300;
                Temp.Width = 375;
                Arr[i] = Temp;
                TempPage.Controls.Add(Temp);
                TempPage.Text = "Образ номер " + (i + 1);
                tabControl2.TabPages.Add(TempPage);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Istaught = true;
            int NumOfShapes;
            NumOfShapes = Convert.ToInt32(textBox1.Text);
            double[,] Input = new double[100, NumOfShapes];
            int i, j, k;
            for (i = 0; i < NumOfShapes; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    for (k = 0; k < 10; k++)
                    {
                        Input[j * 10 + k, i] = (Arr[i].Rows[j].Cells[k].Style.BackColor == Color.Black) ? (1) : (-1);
                    }
                }
            }
            W = new double[100, 100];
            double Temp;
            for (j = 0; j < 100; j++)
            {
                for (k = 0; k < 100; k++)
                {
                    Temp = 0;
                    for (i = 0; i < NumOfShapes; i++)
                    {
                        Temp += Input[j, i] * Input[k, i];
                    }
                    Temp /= 100;
                    W[j, k] = Temp;
                }
            }
            for (j = 0; j < 100; j++)
            {
                for (k = 0; k < 100; k++)
                {
                    if(W[i,j]!=0)
                        Console.WriteLine("" + j + " " + k + " " + W[j,k]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Istaught == false)
            {
                textBox2.Text += "Спочатку треба навчити мережу" + Environment.NewLine;
            }
            int NumOfShapes;
            NumOfShapes = Convert.ToInt32(textBox1.Text);
            double[,] Shapes = new double[NumOfShapes, 100];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double alfa;
            try
            {
                alfa = Convert.ToDouble(textBox3.Text);
                if (alfa < 0 || alfa > 1)
                {
                    throw new Exception();
                }
            }
            catch
            {
                alfa = 0.05;
                textBox3.Text = "0,05";
            }
            Random a = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (a.NextDouble() < alfa)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = (dataGridView1.Rows[i].Cells[j].Style.BackColor==Color.Black)?(Color.White):(Color.Black);
                    }
                }
            }
        }
    }
}
