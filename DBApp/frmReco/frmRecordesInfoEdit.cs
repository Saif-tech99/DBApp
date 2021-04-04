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

namespace DBApp.frmReco
{
    public partial class frmRecordesInfoEdit : Form
    {
        public frmRecordesInfoEdit()
        {
            InitializeComponent();
        }

        private void LoadRecordes()
        {
            DBRepo repo = new DBRepo();

            grdRecordes.DataSource = null;
            grdRecordes.DataSource = repo.GetRecordes();
        }

        private void ProId()
        {
            DBRepo repo = new DBRepo();

            lstViw.DisplayMember = "CoName";
            lstViw.DataSource = repo.GetSrvs();
        }
        private void frmRecordesInfo_Load(object sender, EventArgs e)
        {
            LoadRecordes();
            ProId();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Recordes recordes = new Recordes();
            DBRepo repo = new DBRepo();

            recordes.Id = int.Parse(lblId.Text);
            recordes.ServProId = int.Parse(txtServProId.Text);
            if (radWater.Checked)
            {
                recordes.Type = "Water";
            }
            if (radElectricity.Checked)
            {
                recordes.Type = "Electricity";
            }
            if (radGas.Checked)
            {
                recordes.Type = "Gas";
            }
            if (radFuel.Checked)
            {
                recordes.Type = "Fuel";
            }
            recordes.FirstConMng = int.Parse(txtFirstConMng.Text);
            recordes.FirstCheckDate = DateTime.Parse(txtDateOfFirstReading.Text);
            recordes.SecondConMng = int.Parse(txtSecondReading.Text);
            recordes.SecondCheckDate = DateTime.Parse(txtDateOfSecondReading.Text);
            recordes.RicId = int.Parse(txtRicId.Text);
            var total = int.Parse(txtSecondReading.Text) - int.Parse(txtFirstConMng.Text);
            recordes.TotalCon = total;

            repo.UpdateRecordes(recordes);
            LoadRecordes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Recordes recordes = new Recordes();
            DBRepo repo = new DBRepo();

            recordes.Id = int.Parse(lblId.Text);
            recordes.ServProId = int.Parse(txtServProId.Text);
            if (radWater.Checked)
            {
                recordes.Type = "Water";
            }
            if (radElectricity.Checked)
            {
                recordes.Type = "Electricity";
            }
            if (radGas.Checked)
            {
                recordes.Type = "Gas";
            }
            if (radFuel.Checked)
            {
                recordes.Type = "Fuel";
            }
            recordes.FirstConMng = int.Parse(txtFirstConMng.Text);
            recordes.FirstCheckDate = DateTime.Parse(txtDateOfFirstReading.Text);
            recordes.SecondConMng = int.Parse(txtSecondReading.Text);
            recordes.SecondCheckDate = DateTime.Parse(txtDateOfSecondReading.Text);
            recordes.RicId = int.Parse(txtRicId.Text);
            var total = int.Parse(txtSecondReading.Text) - int.Parse(txtFirstConMng.Text);
            recordes.TotalCon = Math.Abs(total);
            lblTotal.Text = total.ToString();

            repo.DeleteRecordes(recordes.Id);
            LoadRecordes();
        }

        private void grdRecordes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = grdRecordes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtServProId.Text = grdRecordes.Rows[e.RowIndex].Cells[1].Value.ToString();
            radWater.Text = grdRecordes.Rows[e.RowIndex].Cells[2].Value.ToString();
            //radElectricity.Text = grdRecordes.Rows[e.RowIndex].Cells[2].Value.ToString();
            //radGas.Text = grdRecordes.Rows[e.RowIndex].Cells[2].Value.ToString();
            //radFuel.Text = grdRecordes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtFirstConMng.Text = grdRecordes.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDateOfFirstReading.Text = grdRecordes.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSecondReading.Text = grdRecordes.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtDateOfSecondReading.Text = grdRecordes.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtRicId.Text = grdRecordes.Rows[e.RowIndex].Cells[7].Value.ToString();
            lblTotal.Text = grdRecordes.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
    }
}
