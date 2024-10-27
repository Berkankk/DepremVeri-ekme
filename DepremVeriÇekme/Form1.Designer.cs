namespace DepremVeriÇekme
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_latidude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(422, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Son Depremler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_date,
            this.Col_latidude,
            this.Col_Longitude,
            this.Col_Depth,
            this.col_type,
            this.col_size,
            this.col_location});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(41, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1408, 1057);
            this.dataGridView1.TabIndex = 1;
            // 
            // col_date
            // 
            this.col_date.HeaderText = "Date";
            this.col_date.MinimumWidth = 8;
            this.col_date.Name = "col_date";
            this.col_date.Width = 170;
            // 
            // Col_latidude
            // 
            this.Col_latidude.HeaderText = "Latidude";
            this.Col_latidude.MinimumWidth = 8;
            this.Col_latidude.Name = "Col_latidude";
            this.Col_latidude.Width = 80;
            // 
            // Col_Longitude
            // 
            this.Col_Longitude.HeaderText = "Longitude";
            this.Col_Longitude.MinimumWidth = 8;
            this.Col_Longitude.Name = "Col_Longitude";
            this.Col_Longitude.Width = 85;
            // 
            // Col_Depth
            // 
            this.Col_Depth.HeaderText = "Depth";
            this.Col_Depth.MinimumWidth = 8;
            this.Col_Depth.Name = "Col_Depth";
            this.Col_Depth.Width = 80;
            // 
            // col_type
            // 
            this.col_type.HeaderText = "Type";
            this.col_type.MinimumWidth = 8;
            this.col_type.Name = "col_type";
            this.col_type.Width = 70;
            // 
            // col_size
            // 
            this.col_size.HeaderText = "Size";
            this.col_size.MinimumWidth = 8;
            this.col_size.Name = "col_size";
            this.col_size.Width = 90;
            // 
            // col_location
            // 
            this.col_location.HeaderText = "Location";
            this.col_location.MinimumWidth = 8;
            this.col_location.Name = "col_location";
            this.col_location.Width = 350;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(2137, 1148);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Son Depremler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_latidude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Longitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_location;
    }
}

