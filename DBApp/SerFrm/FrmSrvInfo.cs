using DBAppCodeLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBApp.SerFrm
{
    public partial class FrmSrvInfo : Form
    {
        public FrmSrvInfo()
        {
            InitializeComponent();
        }

        private void LoadSrv()
        {
            DBRepo repo = new DBRepo();
            grdSrvInfo.DataSource = null;
            grdSrvInfo.DataSource = repo.GetSrvs();
        }

        private void FrmSrvInfo_Load(object sender, EventArgs e)
        {
            LoadSrv();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
