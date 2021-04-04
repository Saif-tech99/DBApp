using DBApp.frmReco;
using DBApp.SerFrm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBApp
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void hideSubMenu()
        {
            if (pnlRicSubMenu.Visible == true)
            {
                pnlRicSubMenu.Visible = false;
            }
            if (pnlServicesSubMenu.Visible == true)
            {
                pnlServicesSubMenu.Visible = false;
            }
            if (pnlConsSubMenu.Visible == true)
            {
                pnlConsSubMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subPnl)
        {
            if (subPnl.Visible == false)
            {
                hideSubMenu();
                subPnl.Visible = true;
            }
            else
            {
                subPnl.Visible = false;
            }
        }


        #region RicMng

        private void btnRicMngSubMenu_Click_1(object sender, EventArgs e)
        {
            showSubMenu(pnlRicSubMenu);
        }

        private void btnAddResidence_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormRicAddRe());
            hideSubMenu();
        }

        private void btnAddPeople_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormRicAddPeo());
            hideSubMenu();
        }

        private void btnRicMngInfo_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormRicInfo());
            hideSubMenu();
        }
        #endregion

        #region Services

        private void btnServicesSubMenu_Click_1(object sender, EventArgs e)
        {
            showSubMenu(pnlServicesSubMenu);
        }

        private void btnAddServices_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAddServ());
            hideSubMenu();
        }

        private void btnEditServices_Click_1(object sender, EventArgs e)
        {
            // code
            hideSubMenu();
        }

        private void btnServicesInfo_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSrvInfo());
            hideSubMenu();
        }
        #endregion
        #region Cons

        private void btnConsSubMenu_Click_1(object sender, EventArgs e)
        {
            showSubMenu(pnlConsSubMenu);
        }

        private void btnAddRecordes_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new AddRecordes());
            hideSubMenu();
        }

        private void btnEditRecordes_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmRecordesInfoEdit());
            hideSubMenu();
        }

        private void btnRecordesInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRecordesInfo());
            hideSubMenu();
        }
        #endregion

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlHome.Controls.Add(childForm);
            pnlHome.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
