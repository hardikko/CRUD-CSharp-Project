using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_OperationSP_Con
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem newitem = new ListViewItem(textBox1.Text);
            newitem.SubItems.Add(textBox2.Text);
            newitem.SubItems.Add(comboBox1.Text);
            newitem.SubItems.Add(radioButton1.Text);
            newitem.SubItems.Add(dateTimePicker1.Text);
            listView1.Items.Add(newitem);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Product ID", 120);
            listView1.Columns.Add("Item Name", 120);
            listView1.Columns.Add("Color", 100);
            listView1.Columns.Add("Status", 100);
            listView1.Columns.Add("Expiry Date", 120);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            dateTimePicker1.Text = "";
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
                comboBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
                radioButton1.Text = listView1.SelectedItems[0].SubItems[3].Text;
                dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;
            listView1.SelectedItems[0].SubItems[1].Text = textBox2.Text;
            listView1.SelectedItems[0].SubItems[2].Text = comboBox1.Text;
            listView1.SelectedItems[0].SubItems[3].Text = radioButton1.Text;
            listView1.SelectedItems[0].SubItems[4].Text = dateTimePicker1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
