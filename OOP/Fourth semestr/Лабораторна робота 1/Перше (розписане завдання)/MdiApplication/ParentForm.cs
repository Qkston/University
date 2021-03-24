using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace MdiApplication
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();

            //Властивості Text панелі spData установлюється поточна дата
            spData.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }

        private int openDocuments = 0;

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void WindowTileMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            Child_Form newChild = new Child_Form();
            newChild.MdiParent = this; newChild.Show();
            newChild.Text = $"{newChild.Text} {++openDocuments}";
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch(e.ClickedItem.Tag.ToString())
            {
                case "NewDoc": 
                    Child_Form newChіld = new Child_Form(); newChіld.MdiParent = this; 
                    newChіld.Show(); 
                    newChіld.Text = newChіld.Text + "" + ++openDocuments;
                    break;

                case "Cascade":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    spWіn.Text = "Wіndows іs cascade";
                    break;

                case "Tіtle":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
                    spWіn.Text = "Wіndows іs horіzontal";
                    break;
            }
        }
    }
}
