using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_KRS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newspaperBindingSource.MoveFirst();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
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
    }
}
