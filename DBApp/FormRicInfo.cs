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

namespace DBApp
{
    public partial class FormRicInfo : Form
    {
        public FormRicInfo()
        {
            InitializeComponent();
        }

        private void ShowInfo()
        {
            DBRepo repo = new DBRepo();

            grdShow.DataSource = null;
            grdShow.DataSource = repo.GetPeoples();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRicInfo_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }
    }
}
