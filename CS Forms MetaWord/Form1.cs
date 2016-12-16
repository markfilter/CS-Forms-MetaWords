using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Forms_MetaWord
{
    public partial class Form1 : Form
    {

        private string textEditorContents;



        public Form1()
        {
            InitializeComponent();
            statusLabelWordCount.Text = "Word Count: 0";
            statusLabelCharCount.Text = "Character Count: 0";
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsBtnClear_Click(object sender, EventArgs e)
        {
            rtbTextEditor.Text = "";
            statusLabelWordCount.Text = "Word Count: 0";
            statusLabelCharCount.Text = "Character Count: 0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbTextEditor.Text = "";
            statusLabelWordCount.Text = "Word Count: 0";
            statusLabelCharCount.Text = "Character Count: 0";
        }

        private void rtbTextEditor_TextChanged(object sender, EventArgs e)
        {
            textEditorContents = rtbTextEditor.Text;
            string[] words = textEditorContents.Split(' ');
            statusLabelWordCount.Text = $"Word Count: {words.Length}";
            char[] characters = textEditorContents.ToCharArray();
            statusLabelCharCount.Text = $"Character Count: {characters.Length}";
        }
    }
}
