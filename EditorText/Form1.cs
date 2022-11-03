using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorText
{
    public partial class Form1 : Form
    {
        private short openedElements;
        private List<FormDocument.FormDocument> listDocuments;
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
            this.openedElements = 0;
            this.ventanaToolStripMenuItem.Visible = false;
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listDocuments = new List<FormDocument.FormDocument>();
            this.openedElements++;
            this.ventanaToolStripMenuItem.Visible = true;
            FormDocument.FormDocument newForm = new FormDocument.FormDocument();
            newForm.Text = "Documento " + openedElements;
            newForm.Name = "Document" + openedElements;
            newForm.FormClosing += close_mdi;
            newForm.Show();
            newForm.MdiParent = this;
            this.listDocuments.Add(newForm);
            newForm.Activated += (this.selectCurrentActive);
            newForm.edicionToolStripMenuItem.DropDownItemClicked += this.getSelectedEditionOpt;
            this.toolStripStatusLabelDinamic.Text = this.ActiveMdiChild.Text;
        }
        private void selectCurrentActive(object sender, EventArgs e)
        {
            this.toolStripStatusLabelDinamic.Text = this.ActiveMdiChild.Text;
        }
        private void getSelectedEditionOpt(object sender, ToolStripItemClickedEventArgs e)
        {
            this.toolStripStatusLabelOne.Text = e.ClickedItem.Text;
        }
        private void close_mdi(Object sender, FormClosingEventArgs e) {
            MessageBox.Show("Formulario cerrado");
            this.listDocuments.RemoveAll(r => r.Text == this.ActiveMdiChild.Text);
            if (this.listDocuments.Count == 0) this.toolStripStatusLabelDinamic.Text = "";
        }

        private void arrangeIcosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void barraDeEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.statusStripBar.Visible = !this.statusStripBar.Visible;
        }

        private void toolStripStatusLabelDinamic_Click(object sender, EventArgs e)
        {

        }
    }
}
