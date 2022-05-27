using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_KRS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newspaperBindingSource.MoveFirst();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.typography". При необходимости она может быть перемещена или удалена.
            this.typographyTableAdapter.Fill(this.database1DataSet.typography);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.office". При необходимости она может быть перемещена или удалена.
            this.officeTableAdapter.Fill(this.database1DataSet.office);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.newspaper". При необходимости она может быть перемещена или удалена.
            this.newspaperTableAdapter.Fill(this.database1DataSet.newspaper);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            newspaperBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newspaperBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            newspaperBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            newspaperBindingSource.AddNew();

            idLabel1.Text = newspaperBindingSource.Count.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            newspaperBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.newspaperBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int d = (int)newspaperDataGridView.CurrentCell.RowIndex;
            
            Console.WriteLine(d);
            textBox1.Clear();
            textBox2.Clear();


                    Console.WriteLine(newspaperDataGridView[4, d].Value.ToString());
               
                    if (newspaperDataGridView[7, d].Value.ToString() != "0")
                    {
                        Console.WriteLine(newspaperDataGridView[7, d].Value);
                        textBox1.Text =  "pushkin";
                    }

                    if (newspaperDataGridView[8, d].Value.ToString() != "0")
                    {
                        Console.WriteLine(newspaperDataGridView[8, d].Value);
                        textBox2.Text = "tolstoi";
                    }


        }

        private void newspaperDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(5415151);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int f1 = 0;
            int f2 = 0;
            int f3 = 0;
            textBox3.Clear();
            for(int i = 0; i < newspaperDataGridView.RowCount-1; i =i +1)
            {
                Console.WriteLine(f1);
                Console.WriteLine(f2);
                Console.WriteLine(f3);
                if (newspaperDataGridView[4, i].Value.ToString() != "0")
                {
                    f1 = f1+1;
                }
                if (newspaperDataGridView[5, i].Value.ToString() != "0")
                {
                    f2 = f2+1;
                }
                if (newspaperDataGridView[6, i].Value.ToString() != "0")
                {
                    f3 = f3+1;
                }
            }
            if (f1 >= f2 && f1 >= f3) 
            {
                textBox3.Text = "office_#1 ";
            }
            if (f2 >= f1 && f2 >= f3)
            {
                textBox3.Text = "office_#2 ";
            }
            if (f3 >= f2 && f3 >= f1)
            {
                textBox3.Text = "office_#3 ";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string ii = "";
            int x = 0;
            int xh = 0;
            textBox4.Clear();
            for (int i = 0; i < newspaperDataGridView.RowCount - 1; i = i + 1)
            {
                xh = 0;
                if (newspaperDataGridView[4, i].Value.ToString() != "0")
                {
                    xh = xh + 1;
                }
                if (newspaperDataGridView[5, i].Value.ToString() != "0")
                {
                    xh = xh + 1;
                }
                if (newspaperDataGridView[6, i].Value.ToString() != "0")
                {
                    xh = xh + 1;
                }
                if (newspaperDataGridView[7, i].Value.ToString() != "0")
                {
                    xh = xh + 1;
                }
                if (newspaperDataGridView[8, i].Value.ToString() != "0")
                {
                    xh = xh + 1;
                }
                if(xh > x)
                {
                    Console.WriteLine(xh);
                    ii = newspaperDataGridView[1, i].Value.ToString();
                    x = xh;
                }
                
            }
            
            textBox4.Text = ii;
        }

        private void button11_Click(object sender, EventArgs e)
        {

            string ii = "";
            int x = 0;
            int xh = 0;
            textBox5.Clear();
            for (int i = 0; i < newspaperDataGridView.RowCount - 1; i = i + 1)
            {
                xh = ((int)newspaperDataGridView[7, i].Value + (int)newspaperDataGridView[8, i].Value)* (int)newspaperDataGridView[2, i].Value;

                if( xh > x)
                {
                    Console.WriteLine(xh);
                    ii = newspaperDataGridView[1, i].Value.ToString();
                    x = xh;
                }



            }

            textBox5.Text = ii;
        }

        private void button12_Click(object sender, EventArgs e)
        {

            int d = (int)newspaperDataGridView.CurrentCell.RowIndex;

            Console.WriteLine(d);
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();

            Console.WriteLine(newspaperDataGridView[4, d].Value.ToString());

            if (newspaperDataGridView[4, d].Value.ToString() != "0")
            {
                textBox7.Text = "office_#1";
            }

            if (newspaperDataGridView[5, d].Value.ToString() != "0")
            {
                textBox6.Text = "office_#2";
            }
            if (newspaperDataGridView[6, d].Value.ToString() != "0")
            {
                textBox8.Text = "office_#3";
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {

            int f1 = 0;
            int f2 = 0;
            int f3 = 0;
            textBox10.Clear();
            textBox11.Clear();
            textBox9.Clear();
            for (int i = 0; i < newspaperDataGridView.RowCount - 1; i = i + 1)
            {
                Console.WriteLine(f1);
                Console.WriteLine(f2);
                Console.WriteLine(f3);
                if (newspaperDataGridView[4, i].Value.ToString() != "0")
                {
                    f1 = f1 + (int)newspaperDataGridView[4, i].Value;
                }
                if (newspaperDataGridView[5, i].Value.ToString() != "0")
                {
                    f2 = f2 + (int)newspaperDataGridView[5, i].Value;
                }
                if (newspaperDataGridView[6, i].Value.ToString() != "0")
                {
                    f3 = f3 + (int)newspaperDataGridView[6, i].Value;
                }
            }
            
                textBox10.Text = f1.ToString();
                textBox11.Text = f2.ToString();
                textBox9.Text = f3.ToString();
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
           

                SqlCommand cmd = new SqlCommand("INSERT INTO typography (id,name,adres) VALUES (3,new, atagag) where 1");

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource4_CurrentChanged(object sender, EventArgs e)
        {
            
        }
    }
}
