using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arshif.Pages
{
    public partial class HomePage : DevExpress.XtraEditors.XtraUserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void serchtxt_Click(object sender, EventArgs e)
        {
           if(serchtxt.Text== "إبحث هنا ...")
            {
                serchtxt.Text = "";
                return;

            }
            
        }

        private void serchtxt_DragLeave(object sender, EventArgs e)
        {
            if (serchtxt.Text =="")
            {
                serchtxt.Text = "إبحث هنا ...";
                return;

            }
        }
    }
}
