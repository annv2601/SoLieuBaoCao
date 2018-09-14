using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ptItem> lst = new List<ptItem>();
            ptItem pt;
            string[] _dsMa = txtCT.Text.Trim().Split('+');
            for (int i=0;i<_dsMa.Length;i++)
            {
                pt = new ptItem();
                pt.ID = int.Parse(txtID.Text.Trim());
                pt.Ma = _dsMa[i];
                lst.Add(pt);
            }

            dgv.DataSource = lst;
        }
    }

    public class ptItem
    {
        private int _ID;

        private string _Ma;

        public int ID { get => _ID; set => _ID = value; }
        public string Ma { get => _Ma; set => _Ma = value; }
    }
}
