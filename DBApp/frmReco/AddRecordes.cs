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
    public partial class AddRecordes : Form
    {
        public AddRecordes()
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
        private void AddRecordes_Load(object sender, EventArgs e)
        {
            ProId();
            LoadRecordes();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Recordes recordes = new Recordes();
            DBRepo repo = new DBRepo();

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
            var total = int.Parse(txtFirstConMng.Text) - int.Parse(txtSecondReading.Text);
            recordes.TotalCon = Math.Abs(total);

            repo.AddRecordes(recordes);
            LoadRecordes();
        }
    }
}
