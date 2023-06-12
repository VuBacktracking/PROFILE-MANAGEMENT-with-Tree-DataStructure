namespace PROFILE_MANAGEMENT
{
    partial class fSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSearch));
            this.btnexxit = new System.Windows.Forms.Button();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.tbname = new System.Windows.Forms.TextBox();
            this.btnimport = new System.Windows.Forms.Button();
            this.btnsetting = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnnamesearch = new System.Windows.Forms.Button();
            this.btndatesearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.btnexxit.TabIndex = 4;
            this.btnexxit.Text = "X";
            this.btnexxit.UseVisualStyleBackColor = false;
            this.btnexxit.Click += new System.EventHandler(this.btnexxit_Click);
            // 
            // dtpfrom
            // 
            this.dtpfrom.Location = new System.Drawing.Point(874, 318);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(251, 22);
            this.dtpfrom.TabIndex = 15;
            // 
            // dtpto
            // 
            this.dtpto.Location = new System.Drawing.Point(874, 386);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(251, 22);
            this.dtpto.TabIndex = 16;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(874, 178);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(186, 22);
            this.tbname.TabIndex = 17;
            // 
            // btnimport
            // 
            this.btnimport.BackColor = System.Drawing.Color.Transparent;
            this.btnimport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnimport.BackgroundImage")));
            this.btnimport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnimport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnimport.FlatAppearance.BorderSize = 0;
            this.btnimport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnimport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnimport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimport.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimport.ForeColor = System.Drawing.Color.White;
            this.btnimport.Location = new System.Drawing.Point(907, 475);
            this.btnimport.Margin = new System.Windows.Forms.Padding(4);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(69, 75);
            this.btnimport.TabIndex = 18;
            this.btnimport.UseVisualStyleBackColor = false;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // btnsetting
            // 
            this.btnsetting.BackColor = System.Drawing.Color.Transparent;
            this.btnsetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsetting.BackgroundImage")));
            this.btnsetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsetting.FlatAppearance.BorderSize = 0;
            this.btnsetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsetting.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsetting.ForeColor = System.Drawing.Color.White;
            this.btnsetting.Location = new System.Drawing.Point(797, 475);
            this.btnsetting.Margin = new System.Windows.Forms.Padding(4);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Size = new System.Drawing.Size(69, 75);
            this.btnsetting.TabIndex = 19;
            this.btnsetting.UseVisualStyleBackColor = false;
            this.btnsetting.Click += new System.EventHandler(this.btnsetting_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(696, 449);
            this.dataGridView1.TabIndex = 20;
            // 
            // btnnamesearch
            // 
            this.btnnamesearch.BackColor = System.Drawing.Color.Transparent;
            this.btnnamesearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnamesearch.BackgroundImage")));
            this.btnnamesearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnamesearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnamesearch.FlatAppearance.BorderSize = 0;
            this.btnnamesearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnnamesearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnnamesearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnamesearch.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnamesearch.ForeColor = System.Drawing.Color.White;
            this.btnnamesearch.Location = new System.Drawing.Point(1090, 167);
            this.btnnamesearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnnamesearch.Name = "btnnamesearch";
            this.btnnamesearch.Size = new System.Drawing.Size(42, 42);
            this.btnnamesearch.TabIndex = 21;
            this.btnnamesearch.UseVisualStyleBackColor = false;
            this.btnnamesearch.Click += new System.EventHandler(this.btnnamesearch_Click);
            // 
            // btndatesearch
            // 
            this.btndatesearch.BackColor = System.Drawing.Color.Transparent;
            this.btndatesearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndatesearch.BackgroundImage")));
            this.btndatesearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndatesearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndatesearch.FlatAppearance.BorderSize = 0;
            this.btndatesearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btndatesearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btndatesearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndatesearch.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndatesearch.ForeColor = System.Drawing.Color.White;
            this.btndatesearch.Location = new System.Drawing.Point(1089, 445);
            this.btndatesearch.Margin = new System.Windows.Forms.Padding(4);
            this.btndatesearch.Name = "btndatesearch";
            this.btndatesearch.Size = new System.Drawing.Size(45, 45);
            this.btndatesearch.TabIndex = 22;
            this.btndatesearch.UseVisualStyleBackColor = false;
            this.btndatesearch.Click += new System.EventHandler(this.btndatesearch_Click);
            // 
            // fSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.btndatesearch);
            this.Controls.Add(this.btnnamesearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsetting);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.dtpto);
            this.Controls.Add(this.dtpfrom);
            this.Controls.Add(this.btnexxit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fSearch";
            this.Load += new System.EventHandler(this.fSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexxit;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        private System.Windows.Forms.DateTimePicker dtpto;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.Button btnsetting;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnnamesearch;
        private System.Windows.Forms.Button btndatesearch;
    }
}