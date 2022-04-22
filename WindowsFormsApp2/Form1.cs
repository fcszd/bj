using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Text files(*.txt)|*.txt";
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                string file = openFileDialog1.FileName;
                Openfile(file);
            }
        }
        void Openfile(string file)
        {
            StreamReader reader = new StreamReader(file);
            string buf = "";
            while (!reader.EndOfStream)
            {
                buf += reader.ReadLine() + "\n";
            }
            reader.Close();
            richTextBox1.Text = buf;
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string filename = "D:\\编程\\C#\\WindowsFormsApp2\\计算结果.txt";
            var reader = new StreamReader(filename);
            Openfile(filename);
            reader.Close();
        }
    }
}
