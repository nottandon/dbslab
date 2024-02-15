using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textpad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog obj = new FontDialog();
            obj.Font = richTextBox1.SelectionFont;
            obj.Color = richTextBox1.SelectionColor;

            if (obj.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = obj.Color;
                richTextBox1.SelectionFont = obj.Font;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog obj = new ColorDialog();
            obj.ShowDialog();
            richTextBox1.ForeColor = obj.Color;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string fName = saveFileDialog1.FileName;
            StreamWriter sw = new StreamWriter(fName);
            sw.Write(richTextBox1.Text);
            sw.Flush();
            sw.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog obj = new OpenFileDialog();
            obj.ShowDialog();
            StreamReader ob = new StreamReader(File.OpenRead(obj.FileName));
            richTextBox1.Text = ob.ReadToEnd();
        }
    }
}
