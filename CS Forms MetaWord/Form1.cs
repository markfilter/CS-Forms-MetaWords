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
        // Private Member Variable
        private string textEditorContents;


        // Form Constructor
        public Form1()
        {
            InitializeComponent();
            statusLabelWordCount.Text = "Word Count: 0";
            statusLabelCharCount.Text = "Character Count: 0";
        }

        // File > Quilt
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Tool Strip > Clear
        private void tsBtnClear_Click(object sender, EventArgs e)
        {
            rtbTextEditor.Text = "";
        }

        // Clear Button (bottom of the form)
        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbTextEditor.Text = "";
        }

        // Event: Text Changed
        // updates the word and character count by converting the text
        // into a string array for word count and a character array
        // for a character count.
        private void rtbTextEditor_TextChanged(object sender, EventArgs e)
        {
            if(rtbTextEditor.Text != "")
            {
                textEditorContents = rtbTextEditor.Text;
                string[] words = textEditorContents.Split(' ');
                statusLabelWordCount.Text = $"Word Count: {words.Length}";
                char[] characters = textEditorContents.ToCharArray();
                statusLabelCharCount.Text = $"Character Count: {characters.Length}";
            }
            else
            {
                textEditorContents = rtbTextEditor.Text;
                string[] words = textEditorContents.Split(' ');
                statusLabelWordCount.Text = "Word Count: 0";
                char[] characters = textEditorContents.ToCharArray();
                statusLabelCharCount.Text = "Character Count: 0";
            }
            
        }
    }
}
