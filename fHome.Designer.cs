namespace PROFILE_MANAGEMENT
{
    partial class fHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHome));
            this.btnstart = new System.Windows.Forms.Button();
            this.btnexxit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.Transparent;
            this.btnstart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnstart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstart.FlatAppearance.BorderSize = 0;
            this.btnstart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnstart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstart.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.ForeColor = System.Drawing.Color.SeaShell;
            this.btnstart.Location = new System.Drawing.Point(495, 352);
            this.btnstart.Margin = new System.Windows.Forms.Padding(4);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(215, 75);
            this.btnstart.TabIndex = 2;
            this.btnstart.Text = "MANAGE";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
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
            this.btnexxit.Font = new System.Drawing.Font("Nirmala UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexxit.ForeColor = System.Drawing.Color.Maroon;
            this.btnexxit.Location = new System.Drawing.Point(1108, 21);
            this.btnexxit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexxit.Name = "btnexxit";
            this.btnexxit.Size = new System.Drawing.Size(69, 75);
            this.btnexxit.TabIndex = 3;
            this.btnexxit.Text = "X";
            this.btnexxit.UseVisualStyleBackColor = false;
            this.btnexxit.Click += new System.EventHandler(this.btnexxit_Click);
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.btnexxit);
            this.Controls.Add(this.btnstart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fHome";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnexxit;
    }
}

