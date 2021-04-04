
namespace DBApp.frmReco
{
    partial class AddRecordes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdRecordes = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.lblServeceProviderId = new System.Windows.Forms.Label();
            this.txtServProId = new System.Windows.Forms.TextBox();
            this.txtFirstConMng = new System.Windows.Forms.TextBox();
            this.lblFirstReading = new System.Windows.Forms.Label();
            this.txtDateOfFirstReading = new System.Windows.Forms.TextBox();
            this.lblDateOfFirstReading = new System.Windows.Forms.Label();
            this.txtSecondReading = new System.Windows.Forms.TextBox();
            this.lblSeconfReading = new System.Windows.Forms.Label();
            this.txtDateOfSecondReading = new System.Windows.Forms.TextBox();
            this.lblDateOfSecondReading = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.radWater = new System.Windows.Forms.RadioButton();
            this.radElectricity = new System.Windows.Forms.RadioButton();
            this.radFuel = new System.Windows.Forms.RadioButton();
            this.radGas = new System.Windows.Forms.RadioButton();
            this.txtRicId = new System.Windows.Forms.TextBox();
            this.lblRicId = new System.Windows.Forms.Label();
            this.lstViw = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecordes)).BeginInit();
            this.SuspendLayout();
            // 
            // grdRecordes
            // 
            this.grdRecordes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdRecordes.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.grdRecordes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRecordes.Location = new System.Drawing.Point(285, 202);
            this.grdRecordes.Name = "grdRecordes";
            this.grdRecordes.RowHeadersWidth = 62;
            this.grdRecordes.RowTemplate.Height = 28;
            this.grdRecordes.Size = new System.Drawing.Size(1040, 534);
            this.grdRecordes.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Black;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Red;
            this.lblId.Location = new System.Drawing.Point(12, 70);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(36, 29);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID";
            this.lblId.Visible = false;
            // 
            // lblServeceProviderId
            // 
            this.lblServeceProviderId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblServeceProviderId.AutoSize = true;
            this.lblServeceProviderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServeceProviderId.ForeColor = System.Drawing.Color.Crimson;
            this.lblServeceProviderId.Location = new System.Drawing.Point(7, 156);
            this.lblServeceProviderId.Name = "lblServeceProviderId";
            this.lblServeceProviderId.Size = new System.Drawing.Size(219, 29);
            this.lblServeceProviderId.TabIndex = 2;
            this.lblServeceProviderId.Text = "Servece ProviderId";
            // 
            // txtServProId
            // 
            this.txtServProId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtServProId.Location = new System.Drawing.Point(12, 188);
            this.txtServProId.Name = "txtServProId";
            this.txtServProId.Size = new System.Drawing.Size(239, 26);
            this.txtServProId.TabIndex = 3;
            // 
            // txtFirstConMng
            // 
            this.txtFirstConMng.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFirstConMng.Location = new System.Drawing.Point(12, 252);
            this.txtFirstConMng.Name = "txtFirstConMng";
            this.txtFirstConMng.Size = new System.Drawing.Size(239, 26);
            this.txtFirstConMng.TabIndex = 5;
            // 
            // lblFirstReading
            // 
            this.lblFirstReading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFirstReading.AutoSize = true;
            this.lblFirstReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstReading.ForeColor = System.Drawing.Color.Crimson;
            this.lblFirstReading.Location = new System.Drawing.Point(7, 220);
            this.lblFirstReading.Name = "lblFirstReading";
            this.lblFirstReading.Size = new System.Drawing.Size(157, 29);
            this.lblFirstReading.TabIndex = 4;
            this.lblFirstReading.Text = "First Reading";
            // 
            // txtDateOfFirstReading
            // 
            this.txtDateOfFirstReading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDateOfFirstReading.Location = new System.Drawing.Point(12, 321);
            this.txtDateOfFirstReading.Name = "txtDateOfFirstReading";
            this.txtDateOfFirstReading.Size = new System.Drawing.Size(239, 26);
            this.txtDateOfFirstReading.TabIndex = 7;
            // 
            // lblDateOfFirstReading
            // 
            this.lblDateOfFirstReading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDateOfFirstReading.AutoSize = true;
            this.lblDateOfFirstReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfFirstReading.ForeColor = System.Drawing.Color.Crimson;
            this.lblDateOfFirstReading.Location = new System.Drawing.Point(7, 289);
            this.lblDateOfFirstReading.Name = "lblDateOfFirstReading";
            this.lblDateOfFirstReading.Size = new System.Drawing.Size(244, 29);
            this.lblDateOfFirstReading.TabIndex = 6;
            this.lblDateOfFirstReading.Text = "Date Of First Reading";
            // 
            // txtSecondReading
            // 
            this.txtSecondReading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSecondReading.Location = new System.Drawing.Point(12, 382);
            this.txtSecondReading.Name = "txtSecondReading";
            this.txtSecondReading.Size = new System.Drawing.Size(239, 26);
            this.txtSecondReading.TabIndex = 9;
            // 
            // lblSeconfReading
            // 
            this.lblSeconfReading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSeconfReading.AutoSize = true;
            this.lblSeconfReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconfReading.ForeColor = System.Drawing.Color.Crimson;
            this.lblSeconfReading.Location = new System.Drawing.Point(7, 350);
            this.lblSeconfReading.Name = "lblSeconfReading";
            this.lblSeconfReading.Size = new System.Drawing.Size(193, 29);
            this.lblSeconfReading.TabIndex = 8;
            this.lblSeconfReading.Text = "Second Reading";
            // 
            // txtDateOfSecondReading
            // 
            this.txtDateOfSecondReading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDateOfSecondReading.Location = new System.Drawing.Point(12, 447);
            this.txtDateOfSecondReading.Name = "txtDateOfSecondReading";
            this.txtDateOfSecondReading.Size = new System.Drawing.Size(239, 26);
            this.txtDateOfSecondReading.TabIndex = 11;
            // 
            // lblDateOfSecondReading
            // 
            this.lblDateOfSecondReading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDateOfSecondReading.AutoSize = true;
            this.lblDateOfSecondReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfSecondReading.ForeColor = System.Drawing.Color.Crimson;
            this.lblDateOfSecondReading.Location = new System.Drawing.Point(7, 415);
            this.lblDateOfSecondReading.Name = "lblDateOfSecondReading";
            this.lblDateOfSecondReading.Size = new System.Drawing.Size(280, 29);
            this.lblDateOfSecondReading.TabIndex = 10;
            this.lblDateOfSecondReading.Text = "Date Of Second Reading";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Crimson;
            this.btnAdd.Location = new System.Drawing.Point(15, 658);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(217, 56);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add Recorde";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Crimson;
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 45);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // radWater
            // 
            this.radWater.AutoSize = true;
            this.radWater.FlatAppearance.BorderSize = 0;
            this.radWater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radWater.ForeColor = System.Drawing.Color.Crimson;
            this.radWater.Location = new System.Drawing.Point(14, 565);
            this.radWater.Name = "radWater";
            this.radWater.Size = new System.Drawing.Size(75, 24);
            this.radWater.TabIndex = 14;
            this.radWater.TabStop = true;
            this.radWater.Text = "Water";
            this.radWater.UseVisualStyleBackColor = true;
            // 
            // radElectricity
            // 
            this.radElectricity.AutoSize = true;
            this.radElectricity.FlatAppearance.BorderSize = 0;
            this.radElectricity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radElectricity.ForeColor = System.Drawing.Color.Crimson;
            this.radElectricity.Location = new System.Drawing.Point(115, 565);
            this.radElectricity.Name = "radElectricity";
            this.radElectricity.Size = new System.Drawing.Size(99, 24);
            this.radElectricity.TabIndex = 21;
            this.radElectricity.TabStop = true;
            this.radElectricity.Text = "Electricity";
            this.radElectricity.UseVisualStyleBackColor = true;
            // 
            // radFuel
            // 
            this.radFuel.AutoSize = true;
            this.radFuel.FlatAppearance.BorderSize = 0;
            this.radFuel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radFuel.ForeColor = System.Drawing.Color.Crimson;
            this.radFuel.Location = new System.Drawing.Point(115, 595);
            this.radFuel.Name = "radFuel";
            this.radFuel.Size = new System.Drawing.Size(63, 24);
            this.radFuel.TabIndex = 22;
            this.radFuel.TabStop = true;
            this.radFuel.Text = "Fuel";
            this.radFuel.UseVisualStyleBackColor = true;
            // 
            // radGas
            // 
            this.radGas.AutoSize = true;
            this.radGas.FlatAppearance.BorderSize = 0;
            this.radGas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radGas.ForeColor = System.Drawing.Color.Crimson;
            this.radGas.Location = new System.Drawing.Point(14, 595);
            this.radGas.Name = "radGas";
            this.radGas.Size = new System.Drawing.Size(62, 24);
            this.radGas.TabIndex = 23;
            this.radGas.TabStop = true;
            this.radGas.Text = "Gas";
            this.radGas.UseVisualStyleBackColor = true;
            // 
            // txtRicId
            // 
            this.txtRicId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRicId.Location = new System.Drawing.Point(12, 513);
            this.txtRicId.Name = "txtRicId";
            this.txtRicId.Size = new System.Drawing.Size(239, 26);
            this.txtRicId.TabIndex = 25;
            // 
            // lblRicId
            // 
            this.lblRicId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRicId.AutoSize = true;
            this.lblRicId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRicId.ForeColor = System.Drawing.Color.Crimson;
            this.lblRicId.Location = new System.Drawing.Point(7, 481);
            this.lblRicId.Name = "lblRicId";
            this.lblRicId.Size = new System.Drawing.Size(68, 29);
            this.lblRicId.TabIndex = 24;
            this.lblRicId.Text = "RicId";
            // 
            // lstViw
            // 
            this.lstViw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstViw.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lstViw.FormattingEnabled = true;
            this.lstViw.ItemHeight = 20;
            this.lstViw.Location = new System.Drawing.Point(285, 12);
            this.lstViw.Name = "lstViw";
            this.lstViw.Size = new System.Drawing.Size(1341, 184);
            this.lstViw.TabIndex = 26;
            // 
            // AddRecordes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1326, 732);
            this.Controls.Add(this.lstViw);
            this.Controls.Add(this.txtRicId);
            this.Controls.Add(this.lblRicId);
            this.Controls.Add(this.radGas);
            this.Controls.Add(this.radFuel);
            this.Controls.Add(this.radElectricity);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.radWater);
            this.Controls.Add(this.txtDateOfSecondReading);
            this.Controls.Add(this.lblDateOfSecondReading);
            this.Controls.Add(this.txtSecondReading);
            this.Controls.Add(this.lblSeconfReading);
            this.Controls.Add(this.txtDateOfFirstReading);
            this.Controls.Add(this.lblDateOfFirstReading);
            this.Controls.Add(this.txtFirstConMng);
            this.Controls.Add(this.lblFirstReading);
            this.Controls.Add(this.txtServProId);
            this.Controls.Add(this.lblServeceProviderId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.grdRecordes);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "AddRecordes";
            this.Text = "AddRecordes";
            this.Load += new System.EventHandler(this.AddRecordes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdRecordes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdRecordes;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblServeceProviderId;
        private System.Windows.Forms.TextBox txtServProId;
        private System.Windows.Forms.TextBox txtFirstConMng;
        private System.Windows.Forms.Label lblFirstReading;
        private System.Windows.Forms.TextBox txtDateOfFirstReading;
        private System.Windows.Forms.Label lblDateOfFirstReading;
        private System.Windows.Forms.TextBox txtSecondReading;
        private System.Windows.Forms.Label lblSeconfReading;
        private System.Windows.Forms.TextBox txtDateOfSecondReading;
        private System.Windows.Forms.Label lblDateOfSecondReading;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton radWater;
        private System.Windows.Forms.RadioButton radElectricity;
        private System.Windows.Forms.RadioButton radFuel;
        private System.Windows.Forms.RadioButton radGas;
        private System.Windows.Forms.TextBox txtRicId;
        private System.Windows.Forms.Label lblRicId;
        private System.Windows.Forms.ListBox lstViw;
    }
}