
namespace DBApp
{
    partial class FormRicAddPeo
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
            this.lblId = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRicResId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRicResId = new System.Windows.Forms.TextBox();
            this.redMale = new System.Windows.Forms.RadioButton();
            this.redFemale = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grdPep = new System.Windows.Forms.DataGridView();
            this.comPep = new System.Windows.Forms.ComboBox();
            this.lstPep = new System.Windows.Forms.ListBox();
            this.chkOwner = new System.Windows.Forms.CheckBox();
            this.chkTenant = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdPep)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Gold;
            this.lblId.Location = new System.Drawing.Point(25, 94);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(36, 29);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            this.lblId.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Maroon;
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 37);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Gold;
            this.lblName.Location = new System.Drawing.Point(25, 173);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 29);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblRicResId
            // 
            this.lblRicResId.AutoSize = true;
            this.lblRicResId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRicResId.ForeColor = System.Drawing.Color.Gold;
            this.lblRicResId.Location = new System.Drawing.Point(25, 268);
            this.lblRicResId.Name = "lblRicResId";
            this.lblRicResId.Size = new System.Drawing.Size(149, 29);
            this.lblRicResId.TabIndex = 3;
            this.lblRicResId.Text = "ResidenceId";
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(30, 210);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 26);
            this.txtName.TabIndex = 4;
            // 
            // txtRicResId
            // 
            this.txtRicResId.ForeColor = System.Drawing.Color.Black;
            this.txtRicResId.Location = new System.Drawing.Point(30, 300);
            this.txtRicResId.Name = "txtRicResId";
            this.txtRicResId.Size = new System.Drawing.Size(199, 26);
            this.txtRicResId.TabIndex = 5;
            // 
            // redMale
            // 
            this.redMale.AutoSize = true;
            this.redMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redMale.ForeColor = System.Drawing.Color.Chartreuse;
            this.redMale.Location = new System.Drawing.Point(30, 357);
            this.redMale.Name = "redMale";
            this.redMale.Size = new System.Drawing.Size(73, 26);
            this.redMale.TabIndex = 6;
            this.redMale.TabStop = true;
            this.redMale.Text = "Male";
            this.redMale.UseVisualStyleBackColor = true;
            // 
            // redFemale
            // 
            this.redFemale.AutoSize = true;
            this.redFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redFemale.ForeColor = System.Drawing.Color.Chartreuse;
            this.redFemale.Location = new System.Drawing.Point(136, 357);
            this.redFemale.Name = "redFemale";
            this.redFemale.Size = new System.Drawing.Size(94, 26);
            this.redFemale.TabIndex = 7;
            this.redFemale.TabStop = true;
            this.redFemale.Text = "Female";
            this.redFemale.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Maroon;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Gold;
            this.btnAdd.Location = new System.Drawing.Point(30, 474);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 37);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Gold;
            this.btnUpdate.Location = new System.Drawing.Point(30, 527);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 37);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Gold;
            this.btnDelete.Location = new System.Drawing.Point(30, 581);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 37);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grdPep
            // 
            this.grdPep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPep.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.grdPep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPep.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grdPep.Location = new System.Drawing.Point(247, 200);
            this.grdPep.Name = "grdPep";
            this.grdPep.RowHeadersWidth = 62;
            this.grdPep.RowTemplate.Height = 28;
            this.grdPep.Size = new System.Drawing.Size(1159, 473);
            this.grdPep.TabIndex = 13;
            this.grdPep.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPep_CellDoubleClick);
            // 
            // comPep
            // 
            this.comPep.ForeColor = System.Drawing.Color.Black;
            this.comPep.FormattingEnabled = true;
            this.comPep.Location = new System.Drawing.Point(30, 55);
            this.comPep.Name = "comPep";
            this.comPep.Size = new System.Drawing.Size(200, 28);
            this.comPep.TabIndex = 14;
            this.comPep.SelectedIndexChanged += new System.EventHandler(this.comPep_SelectedIndexChanged);
            // 
            // lstPep
            // 
            this.lstPep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPep.BackColor = System.Drawing.Color.DarkBlue;
            this.lstPep.ForeColor = System.Drawing.Color.Chartreuse;
            this.lstPep.FormattingEnabled = true;
            this.lstPep.ItemHeight = 20;
            this.lstPep.Location = new System.Drawing.Point(247, 0);
            this.lstPep.Name = "lstPep";
            this.lstPep.Size = new System.Drawing.Size(1159, 204);
            this.lstPep.TabIndex = 15;
            // 
            // chkOwner
            // 
            this.chkOwner.AutoSize = true;
            this.chkOwner.FlatAppearance.BorderSize = 0;
            this.chkOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkOwner.ForeColor = System.Drawing.Color.Chartreuse;
            this.chkOwner.Location = new System.Drawing.Point(30, 408);
            this.chkOwner.Name = "chkOwner";
            this.chkOwner.Size = new System.Drawing.Size(76, 24);
            this.chkOwner.TabIndex = 16;
            this.chkOwner.Text = "Owner";
            this.chkOwner.UseVisualStyleBackColor = true;
            // 
            // chkTenant
            // 
            this.chkTenant.AutoSize = true;
            this.chkTenant.FlatAppearance.BorderSize = 0;
            this.chkTenant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTenant.ForeColor = System.Drawing.Color.Chartreuse;
            this.chkTenant.Location = new System.Drawing.Point(136, 408);
            this.chkTenant.Name = "chkTenant";
            this.chkTenant.Size = new System.Drawing.Size(80, 24);
            this.chkTenant.TabIndex = 17;
            this.chkTenant.Text = "Tenant";
            this.chkTenant.UseVisualStyleBackColor = true;
            // 
            // FormRicAddPeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1402, 669);
            this.Controls.Add(this.chkTenant);
            this.Controls.Add(this.chkOwner);
            this.Controls.Add(this.lstPep);
            this.Controls.Add(this.comPep);
            this.Controls.Add(this.grdPep);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.redFemale);
            this.Controls.Add(this.redMale);
            this.Controls.Add(this.txtRicResId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblRicResId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblId);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormRicAddPeo";
            this.Text = "RicPep";
            this.Load += new System.EventHandler(this.FormRicAddPeo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRicResId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRicResId;
        private System.Windows.Forms.RadioButton redMale;
        private System.Windows.Forms.RadioButton redFemale;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView grdPep;
        private System.Windows.Forms.ComboBox comPep;
        private System.Windows.Forms.ListBox lstPep;
        private System.Windows.Forms.CheckBox chkOwner;
        private System.Windows.Forms.CheckBox chkTenant;
    }
}