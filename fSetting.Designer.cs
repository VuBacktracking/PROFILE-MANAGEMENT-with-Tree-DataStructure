namespace PROFILE_MANAGEMENT
{
    partial class fSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSetting));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbctnumber = new System.Windows.Forms.TextBox();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.btnexxit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(696, 449);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(873, 172);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(253, 22);
            this.tbid.TabIndex = 21;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(873, 240);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(253, 22);
            this.tbname.TabIndex = 23;
            // 
            // tbctnumber
            // 
            this.tbctnumber.Location = new System.Drawing.Point(927, 309);
            this.tbctnumber.Name = "tbctnumber";
            this.tbctnumber.Size = new System.Drawing.Size(199, 22);
            this.tbctnumber.TabIndex = 24;
            // 
            // dtpdate
            // 
            this.dtpdate.Location = new System.Drawing.Point(873, 376);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(253, 22);
            this.dtpdate.TabIndex = 25;
            // 
            // btnexxit
            // 
            this.btnexxit.BackColor = System.Drawing.Color.Transparent;
            this.btnexxit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexxit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexxit.FlatAppearance.BorderSize = 0;
            this.btnexxit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnexxit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnexxit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexxit.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexxit.ForeColor = System.Drawing.Color.Maroon;
            this.btnexxit.Location = new System.Drawing.Point(1127, -3);
            this.btnexxit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexxit.Name = "btnexxit";
            this.btnexxit.Size = new System.Drawing.Size(69, 75);
            this.btnexxit.TabIndex = 26;
            this.btnexxit.Text = "X";
            this.btnexxit.UseVisualStyleBackColor = false;
            this.btnexxit.Click += new System.EventHandler(this.btnexxit_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Transparent;
            this.btnadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnadd.BackgroundImage")));
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(799, 475);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(69, 75);
            this.btnadd.TabIndex = 27;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.Transparent;
            this.btnremove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnremove.BackgroundImage")));
            this.btnremove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnremove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnremove.FlatAppearance.BorderSize = 0;
            this.btnremove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnremove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremove.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.ForeColor = System.Drawing.Color.White;
            this.btnremove.Location = new System.Drawing.Point(898, 475);
            this.btnremove.Margin = new System.Windows.Forms.Padding(4);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(69, 75);
            this.btnremove.TabIndex = 28;
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnupdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnupdate.BackgroundImage")));
            this.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(996, 474);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(69, 75);
            this.btnupdate.TabIndex = 29;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // fSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnexxit);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.tbctnumber);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbid);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fSetting";
            this.Load += new System.EventHandler(this.fSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbctnumber;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Button btnexxit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnupdate;
    }
}