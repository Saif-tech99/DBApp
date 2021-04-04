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
    public partial class FormRicAddPeo : Form
    {
        public FormRicAddPeo()
        {
            InitializeComponent();
        }

        private void LoadPep()
        {
            DBRepo repo = new DBRepo();

            grdPep.DataSource = null;
            grdPep.DataSource = repo.GetPeoples();
        }

        private void PupPep()
        {
            DBRepo repo = new DBRepo();
            comPep.DisplayMember = "Address";
            comPep.ValueMember = "Id";
            comPep.DataSource = repo.GetResidences();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            People people = new People();
            DBRepo repo = new DBRepo();

            people.Name = txtName.Text;
            people.Male = redMale.Checked;
            people.Female = redFemale.Checked;
            people.ResidenceId = int.Parse(txtRicResId.Text);
            people.Owner = chkOwner.Checked;
            people.Tenant = chkTenant.Checked;
            repo.AddPep(people);
            LoadPep();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            People people = new People();
            DBRepo repo = new DBRepo();

            people.Id = int.Parse(lblId.Text);
            people.Name = txtName.Text;
            people.Male = redMale.Checked;
            people.Female = redFemale.Checked;
            people.ResidenceId = int.Parse(txtRicResId.Text);
            people.Owner = chkOwner.Checked;
            people.Tenant = chkTenant.Checked;
            repo.UpdatePep(people);
            LoadPep();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            People people = new People();
            DBRepo repo = new DBRepo();

            people.Id = int.Parse(lblId.Text);
            people.Name = txtName.Text;
            people.Male = redMale.Checked;
            people.Female = redFemale.Checked;
            people.ResidenceId = int.Parse(txtRicResId.Text);
            people.Owner = chkOwner.Checked;
            people.Tenant = chkTenant.Checked;
            repo.DeletePepById(people.Id);
            LoadPep();
        }

        private void FormRicAddPeo_Load(object sender, EventArgs e)
        {
            PupPep();
            LoadPep();
        }

        private void grdPep_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = grdPep.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = grdPep.Rows[e.RowIndex].Cells[1].Value.ToString();
            redMale.Text = grdPep.Rows[e.RowIndex].Cells[2].Value.ToString();
            redFemale.Text = grdPep.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtRicResId.Text = grdPep.Rows[e.RowIndex].Cells[4].Value.ToString();
            chkOwner.Text = grdPep.Rows[e.RowIndex].Cells[5].Value.ToString();
            chkTenant.Text = grdPep.Rows[e.RowIndex].Cells[6].Value.ToString();
            //var ResidenceId = grdPep.Rows[e.RowIndex].Cells[7].Value.ToString();
            //comPep.SelectedIndex = Convert.ToInt32(ResidenceId) - 1;
        }

        private void comPep_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBRepo repo = new DBRepo();
            string value = comPep.SelectedValue.ToString();
            var lst = repo.GetPeoplesRicId(Convert.ToInt32(value));
            lstPep.DisplayMember = "Name";
            lstPep.DataSource = lst;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
