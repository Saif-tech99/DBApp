
namespace DBApp.frmReco
{
    partial class frmRecordesInfo
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
            this.btnClose = new System.Windows.Forms.Button();
            this.grdRecoInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecoInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(338, 621);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(663, 65);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grdRecoInfo
            // 
            this.grdRecoInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdRecoInfo.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grdRecoInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRecoInfo.GridColor = System.Drawing.Color.MediumBlue;
            this.grdRecoInfo.Location = new System.Drawing.Point(-3, 2);
            this.grdRecoInfo.Name = "grdRecoInfo";
            this.grdRecoInfo.RowHeadersWidth = 62;
            this.grdRecoInfo.RowTemplate.Height = 28;
            this.grdRecoInfo.Size = new System.Drawing.Size(1337, 613);
            this.grdRecoInfo.TabIndex = 2;
            // 
            // frmRecordesInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1334, 690);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grdRecoInfo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmRecordesInfo";
            this.Text = "frmRecordesInfo";
            this.Load += new System.EventHandler(this.frmRecordesInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdRecoInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView grdRecoInfo;
    }
}