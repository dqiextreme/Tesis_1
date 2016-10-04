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
    public partial class Form1 : Form
    {
        public static int Grid_Size = 4;

        public Form1()
        {
            InitializeComponent();
        }

        Memorama3 mctrl3;
        Logica J_Log;
        Laberinto2 J_Lab;

        //--------------------------------------------------

        public void Memor()
        {
            mctrl3 = new Memorama3(Grid_Size);
            mctrl3.Dock = DockStyle.Fill;
            mctrl3.Name = "Memorama";
            tabPage2.Controls.Add(mctrl3);
        }

        public void Logi()
        {
            J_Log = new Logica();
            J_Log.Dock = DockStyle.Fill;
            J_Log.Name = "Logica";
            tabPage2.Controls.Add(J_Log);
        }

        public void Laber()
        {
            J_Lab = new Laberinto2();
            J_Lab.Dock = DockStyle.Fill;
            J_Lab.Name = "Laberinto";
            tabPage2.Controls.Add(J_Lab);
        }

        //------------------------------------------------

        public void Remov()
        {
            tabPage2.Controls.RemoveByKey("Memorama");
            tabPage2.Controls.RemoveByKey("Logica");
            tabPage2.Controls.RemoveByKey("Laberinto");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Remov();
            Memor();
            tabControl1.SelectedTab = tabPage2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Remov();
            Logi();
            tabControl1.SelectedTab = tabPage2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Remov();
            Laber();
            tabControl1.SelectedTab = tabPage2;

        }
    }
}
