using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tesis_1.Control
{
    public partial class Laberinto : UserControl
    {
        public Laberinto()
        {
            InitializeComponent();
            t1();
            pan2();
        }
        
        public class Grid_0
        {
            public int a { get; set; }
            public int b { get; set; }
            public bool v { get; set; }
            public string r { get; set; }
        }

        List<Grid_0> gr1 = new List<Grid_0>();
        List<string> gr2 = new List<string>();

        public void t1()
        {
            gr1.Clear();
            gr1.Add(new Grid_0 { a = 0, b = 0, v = true, r = "00" });
            gr1.Add(new Grid_0 { a = 0, b = 1, v = true, r = "01" });
            gr1.Add(new Grid_0 { a = 0, b = 2, v = false, r = "02" });
            gr1.Add(new Grid_0 { a = 0, b = 3, v = false, r = "03" });

            gr1.Add(new Grid_0 { a = 1, b = 0, v = false, r = "10" });
            gr1.Add(new Grid_0 { a = 1, b = 1, v = true, r = "11" });
            gr1.Add(new Grid_0 { a = 1, b = 2, v = true, r = "12" });
            gr1.Add(new Grid_0 { a = 1, b = 3, v = false, r = "13" });

            gr1.Add(new Grid_0 { a = 2, b = 0, v = false, r = "20" });
            gr1.Add(new Grid_0 { a = 2, b = 1, v = false, r = "21" });
            gr1.Add(new Grid_0 { a = 2, b = 2, v = true, r = "22" });
            gr1.Add(new Grid_0 { a = 2, b = 3, v = true, r = "23" });

            gr1.Add(new Grid_0 { a = 3, b = 0, v = false, r = "30" });
            gr1.Add(new Grid_0 { a = 3, b = 1, v = false, r = "31" });
            gr1.Add(new Grid_0 { a = 3, b = 2, v = false, r = "32" });
            gr1.Add(new Grid_0 { a = 3, b = 3, v = true, r = "33" });
        }

        public PictureBox pb()
        {
            var CartasJuego = new PictureBox();
            CartasJuego.Dock = DockStyle.Fill;
            CartasJuego.SizeMode = PictureBoxSizeMode.StretchImage;
            CartasJuego.Cursor = Cursors.Hand;
            CartasJuego.MouseEnter += BT1_Me;
            return CartasJuego;
        }

        public void pan2()
        {
            TableLayoutPanel tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = 4;
            tablaPanel.ColumnCount = 4;
            for (int i = 0; i < 4; i++)
            {
                var Porcentaje = 100;//150f / (float)Grid_Size - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));
            }
            
            foreach (var item in gr1)
            {
                var cj1 = pb();
                cj1.Name = item.r.ToString();
                //si pongo este valor como true toma el mouseenter en false lo ignora
                //cj1.Enabled = !item.v;
                //si pongo este valor como true toma el mouseenter en false lo ignora
                if (item.v)
                {
                    cj1.BackColor = Color.White;
                    gr2.Add(item.r);
                }
                else
                {
                    cj1.BackColor = Color.Black;
                }
                tablaPanel.Controls.Add(cj1, item.a, item.b);
            }
            tablaPanel.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(tablaPanel);
        }

        private void BT1_Me(object sender, EventArgs e)
        {
            var result = sender.GetType().GetProperties().Single(x => x.Name == "Name").GetValue(sender, null);
            /*
            //cambio el color del picturebox seleccionado
            var newpb = (PictureBox)sender;
            newpb.BackColor = Color.Yellow;
            */
            var a = gr2.Contains(result);

            var newpb = (PictureBox)sender;
            if (gr2.Contains(result))
            {
                newpb.BackColor = Color.Green;
            }
            else
            {
                newpb.BackColor = Color.Red;
                t1();
                pan2();
            }
        }
        
    }
}
