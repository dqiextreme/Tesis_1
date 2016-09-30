using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesis_1.Control;

namespace Tesis_1
{
    public partial class MDIParent1 : Form
    {
        public static int Grid_Size = 4;
        
        
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void memoramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form frmM = this;
            //mctrl.Location = new Point(0, 0);
            //mctrl.Name = "mem_Ctrl1";
            //mctrl.Size = new Size(450, 300);
            //Controls.Add(mctrl);
            t1();
        }
        Memorama2 mctrl;// = new Memorama2(Grid_Size);
        public void t1()
        {
            Controls.RemoveByKey("Memorama");
            mctrl = new Memorama2(Grid_Size);
            Form frmM = this;
            mctrl.Dock = DockStyle.Fill;
            mctrl.Name = "Memorama";
            Controls.Add(mctrl);
        }

        private void removToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Controls.RemoveByKey("Memorama");
            mctrl.Dispose();
        }

        

        


        
    }
}
