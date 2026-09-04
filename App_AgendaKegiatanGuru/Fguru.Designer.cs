
namespace App_AgendaKegiatanGuru
{
    partial class Fguru
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTnotelp = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTguru = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTnip = new Guna.UI2.WinForms.Guna2TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CMBjk = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.BTNsimpan = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Nama Guru";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "NIP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXTnotelp
            // 
            this.TXTnotelp.BorderRadius = 10;
            this.TXTnotelp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTnotelp.DefaultText = "";
            this.TXTnotelp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXTnotelp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TXTnotelp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTnotelp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTnotelp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTnotelp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTnotelp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTnotelp.Location = new System.Drawing.Point(658, 90);
            this.TXTnotelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTnotelp.Name = "TXTnotelp";
            this.TXTnotelp.PlaceholderText = "Masukkan No Telepon...";
            this.TXTnotelp.SelectedText = "";
            this.TXTnotelp.Size = new System.Drawing.Size(272, 53);
            this.TXTnotelp.TabIndex = 41;
            this.TXTnotelp.TextChanged += new System.EventHandler(this.TXTnotelp_TextChanged);
            // 
            // TXTguru
            // 
            this.TXTguru.BorderRadius = 10;
            this.TXTguru.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTguru.DefaultText = "";
            this.TXTguru.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXTguru.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TXTguru.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTguru.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTguru.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTguru.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTguru.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTguru.Location = new System.Drawing.Point(353, 181);
            this.TXTguru.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTguru.Name = "TXTguru";
            this.TXTguru.PlaceholderText = "Masukan Nama...";
            this.TXTguru.SelectedText = "";
            this.TXTguru.Size = new System.Drawing.Size(272, 53);
            this.TXTguru.TabIndex = 40;
            this.TXTguru.TextChanged += new System.EventHandler(this.TXTguru_TextChanged);
            // 
            // TXTnip
            // 
            this.TXTnip.BorderRadius = 10;
            this.TXTnip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTnip.DefaultText = "";
            this.TXTnip.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXTnip.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TXTnip.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTnip.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTnip.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTnip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTnip.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTnip.Location = new System.Drawing.Point(353, 90);
            this.TXTnip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTnip.Name = "TXTnip";
            this.TXTnip.PlaceholderText = "Masukkan NIP...";
            this.TXTnip.SelectedText = "";
            this.TXTnip.Size = new System.Drawing.Size(272, 53);
            this.TXTnip.TabIndex = 50;
            this.TXTnip.TextChanged += new System.EventHandler(this.TXTnip_TextChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(185, 446);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(51, 20);
            this.ID.TabIndex = 49;
            this.ID.Text = "label4";
            this.ID.Click += new System.EventHandler(this.label4_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderRadius = 10;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Silver;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(773, 352);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(180, 45);
            this.guna2Button4.TabIndex = 48;
            this.guna2Button4.Text = "Tampil Data";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 10;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(562, 352);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(180, 45);
            this.guna2Button3.TabIndex = 47;
            this.guna2Button3.Text = "Ubah";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Jenis Kelamin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CMBjk
            // 
            this.CMBjk.FormattingEnabled = true;
            this.CMBjk.Location = new System.Drawing.Point(658, 206);
            this.CMBjk.Name = "CMBjk";
            this.CMBjk.Size = new System.Drawing.Size(272, 28);
            this.CMBjk.TabIndex = 44;
            this.CMBjk.DropDown += new System.EventHandler(this.CMBjk_DropDown);
            this.CMBjk.SelectedIndexChanged += new System.EventHandler(this.CMBjk_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column4,
            this.Column3,
            this.Column9,
            this.Column2,
            this.Column15,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(189, 469);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1321, 431);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column10
            // 
            this.Column10.HeaderText = "ID";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "NIP";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nama Guru";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Jenis Kelamin";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "No Telepon";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "";
            this.Column15.MinimumWidth = 8;
            this.Column15.Name = "Column15";
            this.Column15.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // BTNsimpan
            // 
            this.BTNsimpan.BorderRadius = 10;
            this.BTNsimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNsimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNsimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNsimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNsimpan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTNsimpan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNsimpan.ForeColor = System.Drawing.Color.White;
            this.BTNsimpan.Location = new System.Drawing.Point(357, 352);
            this.BTNsimpan.Name = "BTNsimpan";
            this.BTNsimpan.Size = new System.Drawing.Size(180, 45);
            this.BTNsimpan.TabIndex = 42;
            this.BTNsimpan.Text = "Simpan";
            this.BTNsimpan.Click += new System.EventHandler(this.BTNsimpan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(664, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "No Telepon";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Fguru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1662, 1004);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTnotelp);
            this.Controls.Add(this.TXTguru);
            this.Controls.Add(this.TXTnip);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CMBjk);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNsimpan);
            this.Name = "Fguru";
            this.Text = "Fguru";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TXTnotelp;
        private Guna.UI2.WinForms.Guna2TextBox TXTguru;
        private Guna.UI2.WinForms.Guna2TextBox TXTnip;
        private System.Windows.Forms.Label ID;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CMBjk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button BTNsimpan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column15;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
    }
}