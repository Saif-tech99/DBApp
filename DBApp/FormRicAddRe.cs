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
    public partial class FormRicAddRe : Form
    {
        public FormRicAddRe()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadReic()
        {
            DBRepo repo = new DBRepo();
            grvRec.DataSource = null;
            //List<Residence> re = repo.GetResidences();
            grvRec.DataSource = repo.GetResidences();
        }

        private void ShowTypes()
        {
            DBRepo repo = new DBRepo();

            // code to be done
        }

        private void btnAddRe_Click(object sender, EventArgs e)
        {
            Residence residence = new Residence();

            residence.Address = txtAddress.Text;
            residence.House = radHouse.Checked;
            residence.Apartement = radApartement.Checked;
            residence.Studio = radStudio.Checked;

            DBRepo repo = new DBRepo();
            repo.AddRic(residence);
            LoadReic();
        }

        private void btnUpdateResidence_Click(object sender, EventArgs e)
        {
            Residence residence = new Residence();
            DBRepo dBRepo = new DBRepo();

            residence.Id = int.Parse(lblId.Text);
            residence.Address = txtAddress.Text;
            residence.House = radHouse.Checked;
            residence.Apartement = radApartement.Checked;
            residence.Studio = radStudio.Checked;
            dBRepo.UpdateRic(residence);


            LoadReic();
        }

        private void btnDeleteResidence_Click(object sender, EventArgs e)
        {
            Residence residence = new Residence();
            DBRepo dBRepo = new DBRepo();

            residence.Id = int.Parse(lblId.Text);
            residence.Address = txtAddress.Text;
            residence.House = radHouse.Checked;
            residence.Apartement = radApartement.Checked;
            residence.Studio = radStudio.Checked;
            dBRepo.DeleteRicById(residence.Id);
            LoadReic();
        }

        private void grvRec_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = grvRec.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAddress.Text = grvRec.Rows[e.RowIndex].Cells[1].Value.ToString();
            radHouse.Text = grvRec.Rows[e.RowIndex].Cells[2].Value.ToString();
            radApartement.Text = grvRec.Rows[e.RowIndex].Cells[3].Value.ToString();
            radStudio.Text = grvRec.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void FormRicAddRe_Load(object sender, EventArgs e)
        {
            LoadReic();
        }
    }
}
