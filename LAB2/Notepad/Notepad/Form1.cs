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

namespace Notepad
{
    
    public partial class Form1 : Form
    {
        bool saveState;
        public Form1()
        {
            InitializeComponent();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveState)
            {
                saveToolStripMenuItem_Click_1(sender, e);
            }
            richTextBox1.ResetText();
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (saveState)
            {
                saveToolStripMenuItem_Click_1(sender, e);
            }
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open";
            dlg.ShowDialog();
            string fName = dlg.FileName;
            StreamReader sr = new StreamReader(fName);
            richTextBox1.Text = sr.ReadToEnd(); 
            sr.Close();
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!saveState)
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.ShowDialog();
                string fName = dlg.FileName;
                StreamWriter sw = new StreamWriter(fName);
                sw.Write(richTextBox1.Text);
                sw.Flush();
                sw.Close();
                saveState = true;
            }
        }

        

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
            dlg.ShowDialog();
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveState)
            {
                saveToolStripMenuItem_Click_1(sender, e);
            }
            this.Close();
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            saveState = false;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(richTextBox1.SelectedText); 
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(richTextBox1.SelectedText);
            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.IndexOf(richTextBox1.SelectedText), richTextBox1.SelectedText.Length);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Insert(richTextBox1.Text.Length, Clipboard.GetText());
        }

        private void toolStripComboBox5_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog(); 
            fd.Font = richTextBox1.SelectionFont;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font; 
                richTextBox1.SelectionColor = fd.Color;
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = richTextBox1.SelectionColor;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = cd.Color;
            }
        }

        private void toolStripComboBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apparently making notepads is harder than I thought\nMade by Anushri");
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }
    }
}
