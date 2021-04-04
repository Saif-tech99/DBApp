
namespace DBApp
{
    partial class FormRicAddRe
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
            this.lblAddress = new System.Windows.Forms.Label();
            this.grvRec = new System.Windows.Forms.DataGridView();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.comRicType = new System.Windows.Forms.ComboBox();
            this.lstRec = new System.Windows.Forms.ListBox();
            this.btnAddRe = new System.Windows.Forms.Button();
            this.btnUpdateResidence = new System.Windows.Forms.Button();
            this.btnDeleteResidence = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTypeList = new System.Windows.Forms.Label();
            this.radHouse = new System.Windows.Forms.RadioButton();
            this.radApartement = new System.Windows.Forms.RadioButton();
            this.radStudio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grvRec)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Gold;
            this.lblId.Location = new System.Drawing.Point(12, 83);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(44, 36);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            this.lblId.Visible = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Gold;
            this.lblAddress.Location = new System.Drawing.Point(6, 344);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(126, 36);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address";
            // 
            // grvRec
            // 
            this.grvRec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvRec.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.grvRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvRec.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grvRec.Location = new System.Drawing.Point(319, 276);
            this.grvRec.Name = "grvRec";
            this.grvRec.RowHeadersWidth = 62;
            this.grvRec.RowTemplate.Height = 28;
            this.grvRec.Size = new System.Drawing.Size(1008, 410);
            this.grvRec.TabIndex = 2;
            this.grvRec.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvRec_CellDoubleClick);
            // 
            // txtAddress
            // 
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(12, 400);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(301, 26);
            this.txtAddress.TabIndex = 3;
            // 
            // comRicType
            // 
            this.comRicType.FormattingEnabled = true;
            this.comRicType.Location = new System.Drawing.Point(12, 193);
            this.comRicType.Name = "comRicType";
            this.comRicType.Size = new System.Drawing.Size(301, 28);
            this.comRicType.TabIndex = 4;
            // 
            // lstRec
            // 
            this.lstRec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRec.BackColor = System.Drawing.Color.Chocolate;
            this.lstRec.ForeColor = System.Drawing.Color.Chartreuse;
            this.lstRec.FormattingEnabled = true;
            this.lstRec.ItemHeight = 20;
            this.lstRec.Location = new System.Drawing.Point(319, -4);
            this.lstRec.Name = "lstRec";
            this.lstRec.Size = new System.Drawing.Size(1481, 284);
            this.lstRec.TabIndex = 5;
            // 
            // btnAddRe
            // 
            this.btnAddRe.BackColor = System.Drawing.Color.Transparent;
            this.btnAddRe.FlatAppearance.BorderSize = 0;
            this.btnAddRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRe.ForeColor = System.Drawing.Color.Gold;
            this.btnAddRe.Location = new System.Drawing.Point(12, 471);
            this.btnAddRe.Name = "btnAddRe";
            this.btnAddRe.Size = new System.Drawing.Size(159, 36);
            this.btnAddRe.TabIndex = 6;
            this.btnAddRe.Text = "Add Residence";
            this.btnAddRe.UseVisualStyleBackColor = false;
            this.btnAddRe.Click += new System.EventHandler(this.btnAddRe_Click);
            // 
            // btnUpdateResidence
            // 
            this.btnUpdateResidence.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateResidence.FlatAppearance.BorderSize = 0;
            this.btnUpdateResidence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateResidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateResidence.ForeColor = System.Drawing.Color.Gold;
            this.btnUpdateResidence.Location = new System.Drawing.Point(12, 513);
            this.btnUpdateResidence.Name = "btnUpdateResidence";
            this.btnUpdateResidence.Size = new System.Drawing.Size(159, 36);
            this.btnUpdateResidence.TabIndex = 12;
            this.btnUpdateResidence.Text = "Update Residence";
            this.btnUpdateResidence.UseVisualStyleBackColor = false;
            this.btnUpdateResidence.Click += new System.EventHandler(this.btnUpdateResidence_Click);
            // 
            // btnDeleteResidence
            // 
            this.btnDeleteResidence.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteResidence.FlatAppearance.BorderSize = 0;
            this.btnDeleteResidence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteResidence.ForeColor = System.Drawing.Color.Gold;
            this.btnDeleteResidence.Location = new System.Drawing.Point(12, 555);
            this.btnDeleteResidence.Name = "btnDeleteResidence";
            this.btnDeleteResidence.Size = new System.Drawing.Size(159, 36);
            this.btnDeleteResidence.TabIndex = 13;
            this.btnDeleteResidence.Text = "Delete Residence";
            this.btnDeleteResidence.UseVisualStyleBackColor = false;
            this.btnDeleteResidence.Click += new System.EventHandler(this.btnDeleteResidence_Click);
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
            this.btnClose.Size = new System.Drawing.Size(77, 44);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTypeList
            // 
            this.lblTypeList.AutoSize = true;
            this.lblTypeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeList.ForeColor = System.Drawing.Color.Gold;
            this.lblTypeList.Location = new System.Drawing.Point(12, 146);
            this.lblTypeList.Name = "lblTypeList";
            this.lblTypeList.Size = new System.Drawing.Size(202, 29);
            this.lblTypeList.TabIndex = 15;
            this.lblTypeList.Text = "Residence Types";
            // 
            // radHouse
            // 
            this.radHouse.AutoSize = true;
            this.radHouse.BackColor = System.Drawing.Color.Transparent;
            this.radHouse.FlatAppearance.BorderSize = 9;
            this.radHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHouse.ForeColor = System.Drawing.Color.Chartreuse;
            this.radHouse.Location = new System.Drawing.Point(188, 481);
            this.radHouse.Name = "radHouse";
            this.radHouse.Size = new System.Drawing.Size(85, 26);
            this.radHouse.TabIndex = 16;
            this.radHouse.TabStop = true;
            this.radHouse.Text = "House";
            this.radHouse.UseVisualStyleBackColor = false;
            // 
            // radApartement
            // 
            this.radApartement.AutoSize = true;
            this.radApartement.BackColor = System.Drawing.Color.Transparent;
            this.radApartement.FlatAppearance.BorderSize = 9;
            this.radApartement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radApartement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radApartement.ForeColor = System.Drawing.Color.Chartreuse;
            this.radApartement.Location = new System.Drawing.Point(188, 565);
            this.radApartement.Name = "radApartement";
            this.radApartement.Size = new System.Drawing.Size(125, 26);
            this.radApartement.TabIndex = 17;
            this.radApartement.TabStop = true;
            this.radApartement.Text = "Apartement";
            this.radApartement.UseVisualStyleBackColor = false;
            // 
            // radStudio
            // 
            this.radStudio.AutoSize = true;
            this.radStudio.BackColor = System.Drawing.Color.Transparent;
            this.radStudio.FlatAppearance.BorderSize = 9;
            this.radStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radStudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radStudio.ForeColor = System.Drawing.Color.Chartreuse;
            this.radStudio.Location = new System.Drawing.Point(188, 523);
            this.radStudio.Name = "radStudio";
            this.radStudio.Size = new System.Drawing.Size(84, 26);
            this.radStudio.TabIndex = 18;
            this.radStudio.TabStop = true;
            this.radStudio.Text = "Studio";
            this.radStudio.UseVisualStyleBackColor = false;
            // 
            // FormRicAddRe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(1321, 681);
            this.Controls.Add(this.radStudio);
            this.Controls.Add(this.radApartement);
            this.Controls.Add(this.radHouse);
            this.Controls.Add(this.lblTypeList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteResidence);
            this.Controls.Add(this.btnUpdateResidence);
            this.Controls.Add(this.btnAddRe);
            this.Controls.Add(this.lstRec);
            this.Controls.Add(this.comRicType);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.grvRec);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblId);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormRicAddRe";
            this.Text = "FormRic";
            this.Load += new System.EventHandler(this.FormRicAddRe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvRec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.DataGridView grvRec;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox comRicType;
        private System.Windows.Forms.ListBox lstRec;
        private System.Windows.Forms.Button btnAddRe;
        private System.Windows.Forms.Button btnUpdateResidence;
        private System.Windows.Forms.Button btnDeleteResidence;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTypeList;
        private System.Windows.Forms.RadioButton radHouse;
        private System.Windows.Forms.RadioButton radApartement;
        private System.Windows.Forms.RadioButton radStudio;
    }
}