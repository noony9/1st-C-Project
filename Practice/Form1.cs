using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Person> p1 = new List<Person>();
            p1.Add(new Person() { Id = 1, Name = "Tim" });
            p1.Add(new Person() { Id = 2, Name = "Bob" });
            dataGridView1.DataSource = p1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
