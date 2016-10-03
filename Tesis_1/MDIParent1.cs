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

        private void removToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Controls.RemoveByKey("Memorama");
            mctrl.Dispose();
        }

        Memorama2 mctrl;// = new Memorama2(Grid_Size);
        private void memoramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.RemoveByKey("Memorama");
            Controls.RemoveByKey("Logica");
            mctrl = new Memorama2(Grid_Size);
            Form frmM = this;
            mctrl.Dock = DockStyle.Fill;
            mctrl.Name = "Memorama";
            Controls.Add(mctrl);
        }

        Logica J_Log;
        private void logicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.RemoveByKey("Memorama");
            Controls.RemoveByKey("Logica");
            J_Log = new Logica();
            Form frmM = this;
            J_Log.Dock = DockStyle.Fill;
            J_Log.Name = "Logica";
            Controls.Add(J_Log);
        }

        

        


        
    }
}
