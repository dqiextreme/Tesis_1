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
    public partial class Laberinto2 : UserControl
    {
        public class Grid_0
        {
            public int a { get; set; }
            public int b { get; set; }
            public bool v { get; set; }
            public string r { get; set; }
        }

        List<Grid_0> gr1 = new List<Grid_0>();
        List<string> gr2 = new List<string>();
        PictureBox CartasJuego;

        public Laberinto2()
        {
            InitializeComponent();
            Gen_Lab();
        }

        public PictureBox pb()
        {
            CartasJuego = new PictureBox();
            CartasJuego.Dock = DockStyle.Fill;
            CartasJuego.SizeMode = PictureBoxSizeMode.StretchImage;
            CartasJuego.Cursor = Cursors.Hand;
            CartasJuego.MouseEnter += BT1_Me;
            return CartasJuego;
        }

        private void BT1_Me(object sender, EventArgs e)
        {
            var result = sender.GetType().GetProperties().Single(x => x.Name == "Name").GetValue(sender, null).ToString();

            var res1 = result.ToCharArray()[0].ToString();
            var res2 = result.ToCharArray()[1].ToString();

            var newpb = (PictureBox)sender;
            if (gr2.Contains(result) && verificacion(res1, res2))
            {
                newpb.BackColor = Color.Green;
                //err = 0;
            }
            else
            {
                err++;
                if (err >= 5)
                {
                    MessageBox.Show("Muchos errores");

                    Gen_Lab(); 
                }
                newpb.BackColor = Color.Red;
            }

        }
        int err = 0;

        public bool verificacion(string a1, string a2)
        {
            var mast = a1 + a2;

            var r1 = a1 + Convert.ToString(Convert.ToInt32(a2) - 1);
            var r3 = a1 + Convert.ToString(Convert.ToInt32(a2) + 1);
            var r2 = Convert.ToString(Convert.ToInt32(a1) + 1) + a2;
            var r4 = Convert.ToString(Convert.ToInt32(a1) - 1) + a2;
            List<string> l1 = new List<string>();
            l1.Add(r1);
            l1.Add(r2);
            l1.Add(r3);
            l1.Add(r4);
            
            //------

            var Mcon = panel1.Controls[0].Controls;

            List<bool> lb = new List<bool>();

            l1.ForEach(x =>
            {
                if ((Mcon.ContainsKey(x.ToString())) && (Mcon[mast].BackColor == Mcon[x.ToString()].BackColor))
                {
                    lb.Add(true);
                }
                else
                {
                    lb.Add(false);
                }

            });

            var fin = lb.All(x => x == true);
            var fin2 = lb.Count(x => x == true);

            bool ret = false;
            if (fin2 <= 1)
            {
                ret = true;
            }
            return ret;
        }

        public void Des_Lab()
        {
            gr1.Clear();
            gr1.Add(new Grid_0 { a = 0, b = 0, v = true, r = "00" }); gr1.Add(new Grid_0 { a = 1, b = 0, v = false, r = "10" }); gr1.Add(new Grid_0 { a = 2, b = 0, v = false, r = "20" }); gr1.Add(new Grid_0 { a = 3, b = 0, v = false, r = "30" }); gr1.Add(new Grid_0 { a = 4, b = 0, v = true, r = "40" }); gr1.Add(new Grid_0 { a = 5, b = 0, v = false, r = "50" }); gr1.Add(new Grid_0 { a = 6, b = 0, v = false, r = "60" }); gr1.Add(new Grid_0 { a = 7, b = 0, v = true, r = "70" }); gr1.Add(new Grid_0 { a = 8, b = 0, v = true, r = "80" }); gr1.Add(new Grid_0 { a = 9, b = 0, v = true, r = "90" });
            gr1.Add(new Grid_0 { a = 0, b = 1, v = true, r = "01" }); gr1.Add(new Grid_0 { a = 1, b = 1, v = true, r = "11" }); gr1.Add(new Grid_0 { a = 2, b = 1, v = true, r = "21" }); gr1.Add(new Grid_0 { a = 3, b = 1, v = false, r = "31" }); gr1.Add(new Grid_0 { a = 4, b = 1, v = true, r = "41" }); gr1.Add(new Grid_0 { a = 5, b = 1, v = true, r = "51" }); gr1.Add(new Grid_0 { a = 6, b = 1, v = false, r = "61" }); gr1.Add(new Grid_0 { a = 7, b = 1, v = true, r = "71" }); gr1.Add(new Grid_0 { a = 8, b = 1, v = false, r = "81" }); gr1.Add(new Grid_0 { a = 9, b = 1, v = true, r = "91" });
            gr1.Add(new Grid_0 { a = 0, b = 2, v = false, r = "02" }); gr1.Add(new Grid_0 { a = 1, b = 2, v = false, r = "12" }); gr1.Add(new Grid_0 { a = 2, b = 2, v = true, r = "22" }); gr1.Add(new Grid_0 { a = 3, b = 2, v = false, r = "32" }); gr1.Add(new Grid_0 { a = 4, b = 2, v = false, r = "42" }); gr1.Add(new Grid_0 { a = 5, b = 2, v = true, r = "52" }); gr1.Add(new Grid_0 { a = 6, b = 2, v = true, r = "62" }); gr1.Add(new Grid_0 { a = 7, b = 2, v = true, r = "72" }); gr1.Add(new Grid_0 { a = 8, b = 2, v = false, r = "82" }); gr1.Add(new Grid_0 { a = 9, b = 2, v = true, r = "92" });
            gr1.Add(new Grid_0 { a = 0, b = 3, v = true, r = "03" }); gr1.Add(new Grid_0 { a = 1, b = 3, v = true, r = "13" }); gr1.Add(new Grid_0 { a = 2, b = 3, v = true, r = "23" }); gr1.Add(new Grid_0 { a = 3, b = 3, v = false, r = "33" }); gr1.Add(new Grid_0 { a = 4, b = 3, v = false, r = "43" }); gr1.Add(new Grid_0 { a = 5, b = 3, v = false, r = "53" }); gr1.Add(new Grid_0 { a = 6, b = 3, v = false, r = "63" }); gr1.Add(new Grid_0 { a = 7, b = 3, v = false, r = "73" }); gr1.Add(new Grid_0 { a = 8, b = 3, v = false, r = "83" }); gr1.Add(new Grid_0 { a = 9, b = 3, v = true, r = "93" });
            gr1.Add(new Grid_0 { a = 0, b = 4, v = true, r = "04" }); gr1.Add(new Grid_0 { a = 1, b = 4, v = false, r = "14" }); gr1.Add(new Grid_0 { a = 2, b = 4, v = false, r = "24" }); gr1.Add(new Grid_0 { a = 3, b = 4, v = false, r = "34" }); gr1.Add(new Grid_0 { a = 4, b = 4, v = true, r = "44" }); gr1.Add(new Grid_0 { a = 5, b = 4, v = true, r = "54" }); gr1.Add(new Grid_0 { a = 6, b = 4, v = true, r = "64" }); gr1.Add(new Grid_0 { a = 7, b = 4, v = false, r = "74" }); gr1.Add(new Grid_0 { a = 8, b = 4, v = false, r = "84" }); gr1.Add(new Grid_0 { a = 9, b = 4, v = true, r = "94" });
            gr1.Add(new Grid_0 { a = 0, b = 5, v = true, r = "05" }); gr1.Add(new Grid_0 { a = 1, b = 5, v = true, r = "15" }); gr1.Add(new Grid_0 { a = 2, b = 5, v = true, r = "25" }); gr1.Add(new Grid_0 { a = 3, b = 5, v = true, r = "35" }); gr1.Add(new Grid_0 { a = 4, b = 5, v = true, r = "45" }); gr1.Add(new Grid_0 { a = 5, b = 5, v = false, r = "55" }); gr1.Add(new Grid_0 { a = 6, b = 5, v = true, r = "65" }); gr1.Add(new Grid_0 { a = 7, b = 5, v = false, r = "75" }); gr1.Add(new Grid_0 { a = 8, b = 5, v = false, r = "85" }); gr1.Add(new Grid_0 { a = 9, b = 5, v = true, r = "95" });
            gr1.Add(new Grid_0 { a = 0, b = 6, v = false, r = "06" }); gr1.Add(new Grid_0 { a = 1, b = 6, v = false, r = "16" }); gr1.Add(new Grid_0 { a = 2, b = 6, v = false, r = "26" }); gr1.Add(new Grid_0 { a = 3, b = 6, v = false, r = "36" }); gr1.Add(new Grid_0 { a = 4, b = 6, v = false, r = "46" }); gr1.Add(new Grid_0 { a = 5, b = 6, v = false, r = "56" }); gr1.Add(new Grid_0 { a = 6, b = 6, v = true, r = "66" }); gr1.Add(new Grid_0 { a = 7, b = 6, v = false, r = "76" }); gr1.Add(new Grid_0 { a = 8, b = 6, v = false, r = "86" }); gr1.Add(new Grid_0 { a = 9, b = 6, v = true, r = "96" });
            gr1.Add(new Grid_0 { a = 0, b = 7, v = true, r = "07" }); gr1.Add(new Grid_0 { a = 1, b = 7, v = true, r = "17" }); gr1.Add(new Grid_0 { a = 2, b = 7, v = true, r = "27" }); gr1.Add(new Grid_0 { a = 3, b = 7, v = true, r = "37" }); gr1.Add(new Grid_0 { a = 4, b = 7, v = true, r = "47" }); gr1.Add(new Grid_0 { a = 5, b = 7, v = true, r = "57" }); gr1.Add(new Grid_0 { a = 6, b = 7, v = true, r = "67" }); gr1.Add(new Grid_0 { a = 7, b = 7, v = false, r = "77" }); gr1.Add(new Grid_0 { a = 8, b = 7, v = false, r = "87" }); gr1.Add(new Grid_0 { a = 9, b = 7, v = true, r = "97" });
            gr1.Add(new Grid_0 { a = 0, b = 8, v = true, r = "08" }); gr1.Add(new Grid_0 { a = 1, b = 8, v = false, r = "18" }); gr1.Add(new Grid_0 { a = 2, b = 8, v = false, r = "28" }); gr1.Add(new Grid_0 { a = 3, b = 8, v = false, r = "38" }); gr1.Add(new Grid_0 { a = 4, b = 8, v = false, r = "48" }); gr1.Add(new Grid_0 { a = 5, b = 8, v = false, r = "58" }); gr1.Add(new Grid_0 { a = 6, b = 8, v = false, r = "68" }); gr1.Add(new Grid_0 { a = 7, b = 8, v = false, r = "78" }); gr1.Add(new Grid_0 { a = 8, b = 8, v = false, r = "88" }); gr1.Add(new Grid_0 { a = 9, b = 8, v = true, r = "98" });
            gr1.Add(new Grid_0 { a = 0, b = 9, v = true, r = "09" }); gr1.Add(new Grid_0 { a = 1, b = 9, v = true, r = "19" }); gr1.Add(new Grid_0 { a = 2, b = 9, v = true, r = "29" }); gr1.Add(new Grid_0 { a = 3, b = 9, v = true, r = "39" }); gr1.Add(new Grid_0 { a = 4, b = 9, v = true, r = "49" }); gr1.Add(new Grid_0 { a = 5, b = 9, v = true, r = "59" }); gr1.Add(new Grid_0 { a = 6, b = 9, v = true, r = "69" }); gr1.Add(new Grid_0 { a = 7, b = 9, v = true, r = "79" }); gr1.Add(new Grid_0 { a = 8, b = 9, v = true, r = "89" }); gr1.Add(new Grid_0 { a = 9, b = 9, v = true, r = "99" });
        }

        public void Gen_Lab()
        {
            err = 0;
            Des_Lab();
            TableLayoutPanel tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = 10;
            tablaPanel.ColumnCount = 10;
            for (int i = 0; i < 10; i++)
            {
                var Porcentaje = 150f / (float)10 - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));
            }
            //----
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
    }
}
