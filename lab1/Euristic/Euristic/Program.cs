using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Euristic
{
    class MyProg : Form
    {
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Button button3;
        private Button button4;
        private Button button2;

        public MyProg()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(824, 357);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Згенерувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ширина поля";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(303, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Висота поля";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(609, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Вирішити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 438);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(667, 74);
            this.textBox3.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(685, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "Зберегти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(685, 479);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 33);
            this.button4.TabIndex = 9;
            this.button4.Text = "Зчитати";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // MyProg
            // 
            this.ClientSize = new System.Drawing.Size(848, 524);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MyProg";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int width, height;
            int i, j, k;
            try
            {
                width = Convert.ToInt32(textBox1.Text);
                height = Convert.ToInt32(textBox2.Text);
                if (width < 2 || height < 2 || width > 500 || height > 500)
                {
                    throw new Exception();
                }
            }
            catch
            {
                textBox3.Text += "Неможливо - ширина чи висота введені невірно" + Environment.NewLine;
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            for (i = 0; i < width + 2; i++)
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                dataGridView1.Columns[i].Width = 20;
                dataGridView1.Columns[i].ReadOnly = true;
            }
            for (i = 0; i < height + 2; i++)
            {
                dataGridView1.Rows.Add(new DataGridViewRow());
                dataGridView1.Rows[i].Height = 20;
            }
            for (i = 0; i < width + 2; i++)
            {
                dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.Red;
                dataGridView1.Rows[height + 1].Cells[i].Style.BackColor = Color.Red;
            }
            for (i = 0; i < height + 2; i++)
            {
                dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Red;
                dataGridView1.Rows[i].Cells[width + 1].Style.BackColor = Color.Red;
            }
            dataGridView1.Rows[1].Cells[1].Style.BackColor = Color.Green;
            dataGridView1.Rows[height].Cells[width].Style.BackColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 0)
            {
                textBox3.Text += "Неможливо - спочатку треба створити поле" + Environment.NewLine;
                return;
            }
            int i, j, k;
            int width, height;
            width = dataGridView1.Columns.Count;
            height = dataGridView1.Rows.Count;
            Cell[,] Field = new Cell[height,width];
            for (i = 0; i < height; i++)
            {
                for (j = 0; j < width; j++)
                {
                    Field[i, j] = new Cell(j,i);
                    if (dataGridView1.Rows[i].Cells[j].Style.BackColor == Color.Red)
                    {
                        Field[i, j].Cost = double.PositiveInfinity;
                    }
                    else
                    {
                        if (dataGridView1.Rows[i].Cells[j].Style.BackColor == Color.Yellow)
                        {
                            Field[i, j].Cost = 2;
                        }
                        else
                        {
                            Field[i, j].Cost = 1;
                        }
                    }
                }
            }
            for (i = 1; i < height-1; i++)
            {
                for (j = 1; j < width - 1; j++)
                {
                    if (dataGridView1.Rows[i-1].Cells[j].Style.BackColor != Color.Red)
                    {
                        Field[i, j].NeighBors.Add(Field[i - 1, j]);
                    }
                    if (dataGridView1.Rows[i + 1].Cells[j].Style.BackColor != Color.Red)
                    {
                        Field[i, j].NeighBors.Add(Field[i + 1, j]);
                    }
                    if (dataGridView1.Rows[i].Cells[j-1].Style.BackColor != Color.Red)
                    {
                        Field[i, j].NeighBors.Add(Field[i, j - 1]);
                    }
                    if (dataGridView1.Rows[i].Cells[j+1].Style.BackColor != Color.Red)
                    {
                        Field[i, j].NeighBors.Add(Field[i, j + 1]);
                    }
                }
            }
            bool AnswerFound = false;
            List<Cell> OpenCells = new List<Cell>();
            OpenCells.Add(Field[1,1]);
            Func<double, double, double> Metric = (x,y)=>(Math.Sqrt(x*x+y*y));
            OpenCells[0].Val = Metric(width-3,height-3);
            OpenCells[0].f = 0;
            List<Cell> ClosedCells = new List<Cell>();
            Cell Current;
            Cell Child;
            DateTime a, b;
            a = DateTime.Now;
            while (Field[height - 2, width - 2].Ancestor == null)
            {
                if (OpenCells.Count == 0)
                {
                    textBox3.Text += "Не існує шляху, що проходить від початку до цілі"+ Environment.NewLine;
                    ClosedCells = ClosedCells.OrderBy((x)=>x.Val-x.f).ToList();
                    ///////////
                    if (ClosedCells[0].x == 1 && ClosedCells[0].y == 1)
                    {
                        return;
                    }
                    Child = ClosedCells[0];
                    do
                    {
                        Current = Child;
                        Child = Current.Ancestor;
                        int dx = Current.x - Child.x;
                        int dy = Current.y - Child.y;
                        if (dx != 0)
                        {
                            if (dx > 0)
                            {
                                dataGridView1.Rows[Child.y].Cells[Child.x].Value = "→";
                            }
                            else
                            {
                                dataGridView1.Rows[Child.y].Cells[Child.x].Value = "←";
                            }
                        }
                        else
                        {
                            if (dy > 0)
                            {
                                dataGridView1.Rows[Child.y].Cells[Child.x].Value = "↓";
                            }
                            else
                            {
                                dataGridView1.Rows[Child.y].Cells[Child.x].Value = "↑";
                            }
                        }
                    }
                    while (!((Child.x == Field[1, 1].x) && (Child.y == Field[1, 1].y)));
                    ///////////
                    return;
                }
                OpenCells = OpenCells.OrderBy((x)=>x.Val).ToList();
                for (i = 0; i < OpenCells[0].NeighBors.Count; i++)
                {
                    if (ClosedCells.Contains(OpenCells[0].NeighBors[i]))
                    {
                        if (OpenCells[0].f + OpenCells[0].NeighBors[i].Cost < ClosedCells.First(v => v.Equals(OpenCells[0].NeighBors[i])).f)
                        {
                            Cell Target = ClosedCells.First(v => v.Equals(OpenCells[0].NeighBors[i]));
                            Target.f = OpenCells[0].f + OpenCells[0].NeighBors[i].Cost;
                            Target.Val = Target.f + Metric(height - 2 - Target.x, width - 2 - Target.y);
                            Target.Ancestor = OpenCells[0];
                            OpenCells.Add(Target);
                            ClosedCells.Remove(Target);
                        }
                    }
                    else
                    {
                        if (OpenCells.Contains(OpenCells[0].NeighBors[i]))
                        {
                            if (OpenCells[0].f + OpenCells[0].NeighBors[i].Cost < OpenCells.First(v=>v.Equals(OpenCells[0].NeighBors[i])).f)
                            {
                                Cell Target = OpenCells.First(v => v.Equals(OpenCells[0].NeighBors[i]));
                                Target.f = OpenCells[0].f + OpenCells[0].NeighBors[i].Cost;
                                Target.Val = Target.f + Metric(height - 2 - Target.x, width - 2 - Target.y);
                                Target.Ancestor = OpenCells[0];
                            }
                        }
                        else
                        {
                            OpenCells.Add(OpenCells[0].NeighBors[i]);
                            OpenCells[OpenCells.Count - 1].f = OpenCells[0].f + OpenCells[OpenCells.Count - 1].Cost;
                            OpenCells[OpenCells.Count - 1].Val = OpenCells[OpenCells.Count - 1].f + Metric((height-2- OpenCells[OpenCells.Count - 1].x),(width-2 - OpenCells[OpenCells.Count - 1].y));
                            OpenCells[OpenCells.Count - 1].Ancestor = OpenCells[0];
                        }
                    }
                }
                ClosedCells.Add(OpenCells[0]);
                OpenCells.RemoveAt(0);
            }
            textBox3.Text += "Час виконання -  " + (DateTime.Now - a).TotalSeconds + " секунд" + Environment.NewLine;
            Child = Field[height - 2, width - 2];
            do
            {
                Current = Child;
                Child = Current.Ancestor;
                int dx = Current.x - Child.x;
                int dy = Current.y - Child.y;
                if (dx != 0)
                {
                    if (dx > 0)
                    {
                        dataGridView1.Rows[Child.y].Cells[Child.x].Value = "→";
                    }
                    else
                    {
                        dataGridView1.Rows[Child.y].Cells[Child.x].Value = "←";
                    }
                }
                else
                {
                    if (dy > 0)
                    {
                        dataGridView1.Rows[Child.y].Cells[Child.x].Value = "↓";
                    }
                    else
                    {
                        dataGridView1.Rows[Child.y].Cells[Child.x].Value = "↑";
                    }
                }
            }
            while (!((Child.x == Field[1, 1].x) && (Child.y == Field[1, 1].y)));
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Enter)
            {
                return;
            }
            if (dataGridView1.Columns.Count == 0)
            {
                //textBox3.Text += "Неможливо - спочатку треба створити поле";
                return;
            }
            int it, jt;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = "";
                }
            }
            for (int j = 0; j < dataGridView1.SelectedCells.Count; j++)
            {
                it = dataGridView1.SelectedCells[j].RowIndex;
                jt = dataGridView1.SelectedCells[j].ColumnIndex;
                if (it == 0 || jt == 0 || it == dataGridView1.Rows.Count - 1 || jt == dataGridView1.Columns.Count - 1)
                {
                    dataGridView1.Rows[it].Cells[jt].Value = "";
                    return;
                }
                if ((it == 1 && jt == 1))
                {
                    dataGridView1.Rows[it].Cells[jt].Value = "";
                    return;
                }
                if (it == dataGridView1.Rows.Count - 1 || jt == dataGridView1.Columns.Count - 1)
                {
                    dataGridView1.Rows[it].Cells[jt].Value = "";
                    return;
                }
                if (dataGridView1.Rows[it].Cells[jt].Style.BackColor == Color.Red)
                {
                    dataGridView1.Rows[it].Cells[jt].Style.BackColor = Color.White;
                }
                else
                {
                    if (dataGridView1.Rows[it].Cells[jt].Style.BackColor == Color.Yellow)
                    {
                        dataGridView1.Rows[it].Cells[jt].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        dataGridView1.Rows[it].Cells[jt].Style.BackColor = Color.Yellow;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }

    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyProg Prog = new MyProg();
            Application.Run(Prog);
        }
    }
}
