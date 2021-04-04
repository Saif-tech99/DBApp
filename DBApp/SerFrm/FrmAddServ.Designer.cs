
namespace DBApp.SerFrm
{
    partial class FrmAddServ
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
            this.grdServ = new System.Windows.Forms.DataGridView();
            this.comRicId = new System.Windows.Forms.ComboBox();
            this.lstCoName = new System.Windows.Forms.ListBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRicAddress = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCoName = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtCoName = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblRicReId = new System.Windows.Forms.Label();
            this.txtRicReId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdServ)).BeginInit();
            this.SuspendLayout();
            // 
            // grdServ
            // 
            this.grdServ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdServ.BackgroundColor = System.Drawing.Color.Navy;
            this.grdServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServ.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grdServ.Location = new System.Drawing.Point(460, 196);
            this.grdServ.Name = "grdServ";
            this.grdServ.RowHeadersWidth = 62;
            this.grdServ.RowTemplate.Height = 28;
            this.grdServ.Size = new System.Drawing.Size(921, 533);
            this.grdServ.TabIndex = 0;
            this.grdServ.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdServ_CellDoubleClick);
            // 
            // comRicId
            // 
            this.comRicId.ForeColor = System.Drawing.Color.Black;
            this.comRicId.FormattingEnabled = true;
            this.comRicId.Location = new System.Drawing.Point(2, 174);
            this.comRicId.Name = "comRicId";
            this.comRicId.Size = new System.Drawing.Size(437, 28);
            this.comRicId.TabIndex = 1;
            this.comRicId.SelectedIndexChanged += new System.EventHandler(this.comRicId_SelectedIndexChanged);
            // 
            // lstCoName
            // 
            this.lstCoName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCoName.BackColor = System.Drawing.Color.DarkBlue;
            this.lstCoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCoName.ForeColor = System.Drawing.Color.Chartreuse;
            this.lstCoName.FormattingEnabled = true;
            this.lstCoName.ItemHeight = 22;
            this.lstCoName.Location = new System.Drawing.Point(460, -2);
            this.lstCoName.Name = "lstCoName";
            this.lstCoName.Size = new System.Drawing.Size(921, 202);
            this.lstCoName.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Gold;
            this.lblId.Location = new System.Drawing.Point(12, 75);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(33, 29);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id";
            this.lblId.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Maroon;
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 60);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRicAddress
            // 
            this.lblRicAddress.AutoSize = true;
            this.lblRicAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRicAddress.ForeColor = System.Drawing.Color.Gold;
            this.lblRicAddress.Location = new System.Drawing.Point(12, 127);
            this.lblRicAddress.Name = "lblRicAddress";
            this.lblRicAddress.Size = new System.Drawing.Size(143, 29);
            this.lblRicAddress.TabIndex = 5;
            this.lblRicAddress.Text = "Ric Address";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.Gold;
            this.lblType.Location = new System.Drawing.Point(12, 254);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(68, 29);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Type";
            // 
            // lblCoName
            // 
            this.lblCoName.AutoSize = true;
            this.lblCoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoName.ForeColor = System.Drawing.Color.Gold;
            this.lblCoName.Location = new System.Drawing.Point(12, 343);
            this.lblCoName.Name = "lblCoName";
            this.lblCoName.Size = new System.Drawing.Size(109, 29);
            this.lblCoName.TabIndex = 7;
            this.lblCoName.Text = "CoName";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.Gold;
            this.lblSubTotal.Location = new System.Drawing.Point(12, 420);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(117, 29);
            this.lblSubTotal.TabIndex = 8;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // txtType
            // 
            this.txtType.ForeColor = System.Drawing.Color.Black;
            this.txtType.Location = new System.Drawing.Point(2, 286);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(319, 26);
            this.txtType.TabIndex = 9;
            // 
            // txtCoName
            // 
            this.txtCoName.ForeColor = System.Drawing.Color.Black;
            this.txtCoName.Location = new System.Drawing.Point(2, 375);
            this.txtCoName.Name = "txtCoName";
            this.txtCoName.Size = new System.Drawing.Size(319, 26);
            this.txtCoName.TabIndex = 10;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.ForeColor = System.Drawing.Color.Black;
            this.txtSubTotal.Location = new System.Drawing.Point(2, 452);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(319, 26);
            this.txtSubTotal.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Maroon;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Gold;
            this.btnAdd.Location = new System.Drawing.Point(14, 639);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 46);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
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
            this.btnUpdate.Location = new System.Drawing.Point(167, 639);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 46);
            this.btnUpdate.TabIndex = 13;
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
            this.btnDelete.Location = new System.Drawing.Point(309, 642);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 40);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblRicReId
            // 
            this.lblRicReId.AutoSize = true;
            this.lblRicReId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRicReId.ForeColor = System.Drawing.Color.Gold;
            this.lblRicReId.Location = new System.Drawing.Point(12, 504);
            this.lblRicReId.Name = "lblRicReId";
            this.lblRicReId.Size = new System.Drawing.Size(99, 29);
            this.lblRicReId.TabIndex = 15;
            this.lblRicReId.Text = "RicReId";
            // 
            // txtRicReId
            // 
            this.txtRicReId.ForeColor = System.Drawing.Color.Black;
            this.txtRicReId.Location = new System.Drawing.Point(2, 536);
            this.txtRicReId.Name = "txtRicReId";
            this.txtRicReId.Size = new System.Drawing.Size(319, 26);
            this.txtRicReId.TabIndex = 16;
            // 
            // FrmAddServ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1379, 726);
            this.Controls.Add(this.txtRicReId);
            this.Controls.Add(this.lblRicReId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtCoName);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblCoName);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblRicAddress);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lstCoName);
            this.Controls.Add(this.comRicId);
            this.Controls.Add(this.grdServ);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmAddServ";
            this.Text = "FrmAddServ";
            this.Load += new System.EventHandler(this.FrmAddServ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdServ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdServ;
        private System.Windows.Forms.ComboBox comRicId;
        private System.Windows.Forms.ListBox lstCoName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRicAddress;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCoName;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtCoName;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblRicReId;
        private System.Windows.Forms.TextBox txtRicReId;
    }
}