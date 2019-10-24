using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace samplevisualstudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s1 = "Prashant Kadam";
            MessageBox.Show("Hello World" + s1);

            GetData();
            // This is the comment
        }

        private void GetData()
        {
            MessageBox.Show($"Hello World");
        }
    }
}
