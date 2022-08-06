using Arshif.Pages;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arshif
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
            statusDatelbl.Text = DateTime.Now.ToString();
            HomePage homePage = new HomePage();
            LoadPage(homePage);
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {
           
        }

        private void navBarItem1_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            HomePage homePage = new HomePage();
            LoadPage(homePage);
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           
        }

        //This method for loading page to panel container
        private void LoadPage(DevExpress.XtraEditors.XtraUserControl page )
        {
            try
            {
                container.Controls.Clear();
                page.Dock = DockStyle.Fill;
                container.Controls.Add(page);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DepPage depPage = new DepPage();
            LoadPage(depPage);
        }
    }
}