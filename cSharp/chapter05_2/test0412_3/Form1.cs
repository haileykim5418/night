using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0412_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            List<string> lang = new List<string>();

            lang.Add("하기시러");
            lang.Add("싫다고");
            lang.Add("실타");
            lang.Add("실타래");
            

            for (int i = 0; i < lang.Count; i++)
            {
                MessageBox.Show(lang[i]);
            }

        }
    }
}
