using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDocument
{
    public partial class FormDocument : Form
    {
        public FormDocument()
        {
            InitializeComponent();
        }

        private void buttonCloseChildren_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void edicionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        /* private void FormDocument_Load(object sender, EventArgs e)
         {
             Console.WriteLine(this.Text);
         }*/
    }
}
