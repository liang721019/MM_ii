namespace MM_ii
{
    partial class MM_ii_QueryDGV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MM_ii_QueryDGV加入button = new System.Windows.Forms.Button();
            this.MM_ii_QueryDGV查詢button = new System.Windows.Forms.Button();
            this.MM_ii_QueryDGV_PID_Value = new System.Windows.Forms.TextBox();
            this.MM_ii_QueryDGV_PID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MM_ii_QdataGridView1 = new System.Windows.Forms.DataGridView();
            this.MM_QDGV_Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MM_ii_QdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MM_ii_QueryDGV加入button);
            this.panel1.Controls.Add(this.MM_ii_QueryDGV查詢button);
            this.panel1.Controls.Add(this.MM_ii_QueryDGV_PID_Value);
            this.panel1.Controls.Add(this.MM_ii_QueryDGV_PID);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 51);
            this.panel1.TabIndex = 3;
            // 
            // MM_ii_QueryDGV加入button
            // 
            this.MM_ii_QueryDGV加入button.Location = new System.Drawing.Point(538, 12);
            this.MM_ii_QueryDGV加入button.Name = "MM_ii_QueryDGV加入button";
            this.MM_ii_QueryDGV加入button.Size = new System.Drawing.Size(75, 29);
            this.MM_ii_QueryDGV加入button.TabIndex = 3;
            this.MM_ii_QueryDGV加入button.Text = "加入";
            this.MM_ii_QueryDGV加入button.UseVisualStyleBackColor = true;
            this.MM_ii_QueryDGV加入button.Click += new System.EventHandler(this.MM_ii_QueryDGV加入button_Click);
            // 
            // MM_ii_QueryDGV查詢button
            // 
            this.MM_ii_QueryDGV查詢button.Location = new System.Drawing.Point(619, 12);
            this.MM_ii_QueryDGV查詢button.Name = "MM_ii_QueryDGV查詢button";
            this.MM_ii_QueryDGV查詢button.Size = new System.Drawing.Size(75, 29);
            this.MM_ii_QueryDGV查詢button.TabIndex = 2;
            this.MM_ii_QueryDGV查詢button.Text = "查詢";
            this.MM_ii_QueryDGV查詢button.UseVisualStyleBackColor = true;
            this.MM_ii_QueryDGV查詢button.Click += new System.EventHandler(this.MM_ii_QueryDGV查詢button_Click);
            // 
            // MM_ii_QueryDGV_PID_Value
            // 
            this.MM_ii_QueryDGV_PID_Value.Location = new System.Drawing.Point(98, 12);
            this.MM_ii_QueryDGV_PID_Value.Name = "MM_ii_QueryDGV_PID_Value";
            this.MM_ii_QueryDGV_PID_Value.Size = new System.Drawing.Size(159, 29);
            this.MM_ii_QueryDGV_PID_Value.TabIndex = 1;
            // 
            // MM_ii_QueryDGV_PID
            // 
            this.MM_ii_QueryDGV_PID.AutoSize = true;
            this.MM_ii_QueryDGV_PID.Location = new System.Drawing.Point(15, 15);
            this.MM_ii_QueryDGV_PID.Name = "MM_ii_QueryDGV_PID";
            this.MM_ii_QueryDGV_PID.Size = new System.Drawing.Size(77, 20);
            this.MM_ii_QueryDGV_PID.TabIndex = 0;
            this.MM_ii_QueryDGV_PID.Text = "商品編號:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.MM_ii_QdataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 464);
            this.panel2.TabIndex = 4;
            // 
            // MM_ii_QdataGridView1
            // 
            this.MM_ii_QdataGridView1.AllowUserToAddRows = false;
            this.MM_ii_QdataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MM_ii_QdataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MM_ii_QdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MM_ii_QdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MM_QDGV_Column1});
            this.MM_ii_QdataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MM_ii_QdataGridView1.Location = new System.Drawing.Point(0, 0);
            this.MM_ii_QdataGridView1.Name = "MM_ii_QdataGridView1";
            this.MM_ii_QdataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MM_ii_QdataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.MM_ii_QdataGridView1.RowTemplate.Height = 24;
            this.MM_ii_QdataGridView1.Size = new System.Drawing.Size(708, 464);
            this.MM_ii_QdataGridView1.TabIndex = 0;
            this.MM_ii_QdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MM_ii_QdataGridView1_CellContentClick);
            this.MM_ii_QdataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MM_ii_QdataGridView1_CellMouseDoubleClick);
            // 
            // MM_QDGV_Column1
            // 
            this.MM_QDGV_Column1.FalseValue = "0";
            this.MM_QDGV_Column1.HeaderText = "選取";
            this.MM_QDGV_Column1.Name = "MM_QDGV_Column1";
            this.MM_QDGV_Column1.ReadOnly = true;
            this.MM_QDGV_Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MM_QDGV_Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MM_QDGV_Column1.TrueValue = "1";
            this.MM_QDGV_Column1.Width = 80;
            // 
            // MM_ii_QueryDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(732, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MM_ii_QueryDGV";
            this.Text = "MM_ii_QueryDGV";
            this.Load += new System.EventHandler(this.MM_ii_QueryDGV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MM_ii_QdataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MM_ii_QueryDGV查詢button;
        private System.Windows.Forms.TextBox MM_ii_QueryDGV_PID_Value;
        private System.Windows.Forms.Label MM_ii_QueryDGV_PID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MM_ii_QueryDGV加入button;
        public System.Windows.Forms.DataGridView MM_ii_QdataGridView1;
        public System.Windows.Forms.DataGridViewCheckBoxColumn MM_QDGV_Column1;
    }
}