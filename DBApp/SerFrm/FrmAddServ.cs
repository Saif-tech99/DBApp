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
    public partial class FrmAddServ : Form
    {
        public FrmAddServ()
        {
            InitializeComponent();
        }

        private void LoadSrv()
        {
            DBRepo repo = new DBRepo();
            grdServ.DataSource = null;
            grdServ.DataSource = repo.GetSrvs();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSrv srv = new AddSrv();
            DBRepo dB = new DBRepo();

            srv.Type = txtType.Text;
            srv.CoName = txtCoName.Text;
            srv.SubTotal = decimal.Parse(txtSubTotal.Text);
            srv.RicReId = int.Parse(txtRicReId.Text);
            dB.AddSrv(srv);
            LoadSrv();
        }

        private void GetRicReId()
        {
            DBRepo dBRepo = new DBRepo();

            comRicId.DisplayMember = "Address";
            comRicId.ValueMember = "Id";
            comRicId.DataSource = dBRepo.GetResidences();
            LoadSrv();
        }
        private void FrmAddServ_Load(object sender, EventArgs e)
        {
            GetRicReId();
            LoadSrv();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddSrv srv = new AddSrv();
            DBRepo dB = new DBRepo();

            srv.Id = int.Parse(lblId.Text);
            srv.Type = txtType.Text;
            srv.CoName = txtCoName.Text;
            srv.SubTotal = decimal.Parse(txtSubTotal.Text);
            srv.RicReId = int.Parse(txtRicReId.Text);
            dB.UpdateSrv(srv);
            LoadSrv();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AddSrv srv = new AddSrv();
            DBRepo dB = new DBRepo();

            srv.Id = int.Parse(lblId.Text);
            srv.Type = txtType.Text;
            srv.CoName = txtCoName.Text;
            srv.SubTotal = decimal.Parse(txtSubTotal.Text);
            srv.RicReId = int.Parse(txtRicReId.Text);
            dB.DeleteSrv(srv.Id);
            LoadSrv();
        }

        private void grdServ_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = grdServ.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtType.Text = grdServ.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCoName.Text = grdServ.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSubTotal.Text = grdServ.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtRicReId.Text = grdServ.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comRicId_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBRepo repo = new DBRepo();

            string value = comRicId.SelectedValue.ToString();
            var lst = repo.GetSrv(Convert.ToInt32(value));
            lstCoName.DisplayMember = "CoName";
            lstCoName.DataSource = lst;
        }
    }
}
