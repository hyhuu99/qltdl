namespace qltdl.view
{
    partial class thongketour
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbb1 = new System.Windows.Forms.ComboBox();
            this.dttkt = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dttkt)).BeginInit();
            this.SuspendLayout();
            // 
            // cbb1
            // 
            this.cbb1.FormattingEnabled = true;
            this.cbb1.Location = new System.Drawing.Point(74, 27);
            this.cbb1.Name = "cbb1";
            this.cbb1.Size = new System.Drawing.Size(164, 24);
            this.cbb1.TabIndex = 0;
            this.cbb1.SelectedIndexChanged += new System.EventHandler(this.cbb1_SelectedIndexChanged);
            // 
            // dttkt
            // 
            this.dttkt.AllowUserToAddRows = false;
            this.dttkt.AllowUserToDeleteRows = false;
            this.dttkt.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dttkt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dttkt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dttkt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9});
            this.dttkt.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dttkt.Location = new System.Drawing.Point(4, 58);
            this.dttkt.Margin = new System.Windows.Forms.Padding(4);
            this.dttkt.Name = "dttkt";
            this.dttkt.Size = new System.Drawing.Size(739, 404);
            this.dttkt.TabIndex = 6;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Tentour";
            this.Column7.HeaderText = "Tên tour";
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Tenddl";
            this.Column8.HeaderText = "Tên đoàn du lịch";
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Tienloi";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column9.HeaderText = "Tiền lời";
            this.Column9.Name = "Column9";
            this.Column9.Width = 200;
            // 
            // thongketour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dttkt);
            this.Controls.Add(this.cbb1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "thongketour";
            this.Size = new System.Drawing.Size(820, 462);
            ((System.ComponentModel.ISupportInitialize)(this.dttkt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb1;
        private System.Windows.Forms.DataGridView dttkt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}
