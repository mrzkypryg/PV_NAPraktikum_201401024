/*
 * Created by SharpDevelop.
 * User: user
 * Date: 5/3/2022
 * Time: 11:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NilaiAkhirMhs
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox NAMA;
		private System.Windows.Forms.TextBox NIM;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox ABSENSI;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox UTS;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox KETERANGAN;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TUGAS;
		private System.Windows.Forms.TextBox UAS;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox HASIL;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox GRADE;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox KELAS;
		private System.Windows.Forms.Button BtnHitung;
		private System.Windows.Forms.Button BtnSimpan;
		private System.Windows.Forms.Button BtnUpdate;
		private System.Windows.Forms.Button BtnReset;
		private System.Windows.Forms.Button BtnHapus;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox pencarian;
		private System.Windows.Forms.TextBox kotakcari;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.NAMA = new System.Windows.Forms.TextBox();
			this.NIM = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ABSENSI = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.UTS = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.KETERANGAN = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.TUGAS = new System.Windows.Forms.TextBox();
			this.UAS = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.HASIL = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.GRADE = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.KELAS = new System.Windows.Forms.ComboBox();
			this.BtnHitung = new System.Windows.Forms.Button();
			this.BtnSimpan = new System.Windows.Forms.Button();
			this.BtnUpdate = new System.Windows.Forms.Button();
			this.BtnReset = new System.Windows.Forms.Button();
			this.BtnHapus = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.pencarian = new System.Windows.Forms.GroupBox();
			this.kotakcari = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.pencarian.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(26, 591);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowTemplate.Height = 28;
			this.dataGridView.Size = new System.Drawing.Size(1145, 323);
			this.dataGridView.TabIndex = 1;
			this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(14, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nama Mahasiswa";
			// 
			// NAMA
			// 
			this.NAMA.Location = new System.Drawing.Point(14, 66);
			this.NAMA.Name = "NAMA";
			this.NAMA.Size = new System.Drawing.Size(227, 26);
			this.NAMA.TabIndex = 3;
			// 
			// NIM
			// 
			this.NIM.Location = new System.Drawing.Point(14, 134);
			this.NIM.Name = "NIM";
			this.NIM.Size = new System.Drawing.Size(227, 26);
			this.NIM.TabIndex = 5;
			this.NIM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NIMKeyPress);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(14, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "NIM";
			// 
			// ABSENSI
			// 
			this.ABSENSI.Location = new System.Drawing.Point(18, 66);
			this.ABSENSI.Name = "ABSENSI";
			this.ABSENSI.Size = new System.Drawing.Size(100, 26);
			this.ABSENSI.TabIndex = 7;
			this.ABSENSI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ABSENSIKeyPress);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(18, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Nilai Absensi";
			// 
			// UTS
			// 
			this.UTS.Location = new System.Drawing.Point(18, 134);
			this.UTS.Name = "UTS";
			this.UTS.Size = new System.Drawing.Size(100, 26);
			this.UTS.TabIndex = 9;
			this.UTS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UTSKeyPress);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(18, 107);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Nilai UTS";
			// 
			// KETERANGAN
			// 
			this.KETERANGAN.BackColor = System.Drawing.Color.Violet;
			this.KETERANGAN.Location = new System.Drawing.Point(15, 202);
			this.KETERANGAN.Name = "KETERANGAN";
			this.KETERANGAN.Size = new System.Drawing.Size(189, 26);
			this.KETERANGAN.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(15, 173);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Keterangan";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(156, 39);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Nilai Tugas";
			// 
			// TUGAS
			// 
			this.TUGAS.Location = new System.Drawing.Point(156, 65);
			this.TUGAS.Name = "TUGAS";
			this.TUGAS.Size = new System.Drawing.Size(100, 26);
			this.TUGAS.TabIndex = 11;
			this.TUGAS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TUGASKeyPress);
			// 
			// UAS
			// 
			this.UAS.Location = new System.Drawing.Point(156, 134);
			this.UAS.Name = "UAS";
			this.UAS.Size = new System.Drawing.Size(100, 26);
			this.UAS.TabIndex = 13;
			this.UAS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UASKeyPress);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(156, 107);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "Nilai UAS";
			// 
			// HASIL
			// 
			this.HASIL.BackColor = System.Drawing.Color.Gold;
			this.HASIL.Location = new System.Drawing.Point(15, 64);
			this.HASIL.Name = "HASIL";
			this.HASIL.Size = new System.Drawing.Size(189, 26);
			this.HASIL.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(15, 39);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "Nilai Akhir";
			// 
			// GRADE
			// 
			this.GRADE.BackColor = System.Drawing.Color.Chartreuse;
			this.GRADE.Location = new System.Drawing.Point(15, 132);
			this.GRADE.Name = "GRADE";
			this.GRADE.Size = new System.Drawing.Size(189, 26);
			this.GRADE.TabIndex = 17;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(15, 105);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 16;
			this.label9.Text = "Grade";
			// 
			// KELAS
			// 
			this.KELAS.FormattingEnabled = true;
			this.KELAS.Location = new System.Drawing.Point(14, 202);
			this.KELAS.Name = "KELAS";
			this.KELAS.Size = new System.Drawing.Size(121, 28);
			this.KELAS.TabIndex = 19;
			// 
			// BtnHitung
			// 
			this.BtnHitung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.BtnHitung.Location = new System.Drawing.Point(87, 185);
			this.BtnHitung.Name = "BtnHitung";
			this.BtnHitung.Size = new System.Drawing.Size(108, 42);
			this.BtnHitung.TabIndex = 20;
			this.BtnHitung.Text = "Hitung";
			this.BtnHitung.UseVisualStyleBackColor = false;
			this.BtnHitung.Click += new System.EventHandler(this.BtnHitungClick);
			// 
			// BtnSimpan
			// 
			this.BtnSimpan.BackColor = System.Drawing.SystemColors.Info;
			this.BtnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnSimpan.Location = new System.Drawing.Point(867, 252);
			this.BtnSimpan.Name = "BtnSimpan";
			this.BtnSimpan.Size = new System.Drawing.Size(131, 54);
			this.BtnSimpan.TabIndex = 21;
			this.BtnSimpan.Text = "SIMPAN";
			this.BtnSimpan.UseVisualStyleBackColor = false;
			this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpanClick);
			// 
			// BtnUpdate
			// 
			this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnUpdate.Location = new System.Drawing.Point(1026, 252);
			this.BtnUpdate.Name = "BtnUpdate";
			this.BtnUpdate.Size = new System.Drawing.Size(131, 54);
			this.BtnUpdate.TabIndex = 22;
			this.BtnUpdate.Text = "UPDATE";
			this.BtnUpdate.UseVisualStyleBackColor = false;
			this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
			// 
			// BtnReset
			// 
			this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnReset.Location = new System.Drawing.Point(868, 332);
			this.BtnReset.Name = "BtnReset";
			this.BtnReset.Size = new System.Drawing.Size(131, 54);
			this.BtnReset.TabIndex = 23;
			this.BtnReset.Text = "RESET";
			this.BtnReset.UseVisualStyleBackColor = false;
			this.BtnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// BtnHapus
			// 
			this.BtnHapus.BackColor = System.Drawing.Color.Red;
			this.BtnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnHapus.Location = new System.Drawing.Point(1026, 332);
			this.BtnHapus.Name = "BtnHapus";
			this.BtnHapus.Size = new System.Drawing.Size(131, 54);
			this.BtnHapus.TabIndex = 24;
			this.BtnHapus.Text = "HAPUS";
			this.BtnHapus.UseVisualStyleBackColor = false;
			this.BtnHapus.Click += new System.EventHandler(this.BtnHapusClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.MaximumSize = new System.Drawing.Size(1200, 180);
			this.pictureBox1.MinimumSize = new System.Drawing.Size(1200, 180);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1200, 180);
			this.pictureBox1.TabIndex = 25;
			this.pictureBox1.TabStop = false;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.DarkSlateGray;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(221, 55);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(742, 75);
			this.label10.TabIndex = 26;
			this.label10.Text = "NILAI AKHIR PRAKTIKUM";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(14, 173);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 27;
			this.label11.Text = "Lab";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.NAMA);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.NIM);
			this.groupBox1.Controls.Add(this.KELAS);
			this.groupBox1.Location = new System.Drawing.Point(26, 200);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(273, 248);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Identitas Praktikan";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.TUGAS);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.ABSENSI);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.UTS);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.BtnHitung);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.UAS);
			this.groupBox2.Location = new System.Drawing.Point(317, 200);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(273, 248);
			this.groupBox2.TabIndex = 29;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Nilai Praktikan";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.GRADE);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.KETERANGAN);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.HASIL);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Location = new System.Drawing.Point(608, 200);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(240, 248);
			this.groupBox3.TabIndex = 30;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Hasil Akhir Praktikan";
			// 
			// pencarian
			// 
			this.pencarian.Controls.Add(this.kotakcari);
			this.pencarian.Location = new System.Drawing.Point(26, 475);
			this.pencarian.Name = "pencarian";
			this.pencarian.Size = new System.Drawing.Size(1145, 92);
			this.pencarian.TabIndex = 31;
			this.pencarian.TabStop = false;
			this.pencarian.Text = "Pencarian Data Nilai Akhir Praktikan";
			// 
			// kotakcari
			// 
			this.kotakcari.Location = new System.Drawing.Point(14, 38);
			this.kotakcari.Name = "kotakcari";
			this.kotakcari.Size = new System.Drawing.Size(1117, 26);
			this.kotakcari.TabIndex = 28;
			this.kotakcari.TextChanged += new System.EventHandler(this.KotakcariTextChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1183, 944);
			this.Controls.Add(this.pencarian);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.BtnHapus);
			this.Controls.Add(this.BtnReset);
			this.Controls.Add(this.BtnUpdate);
			this.Controls.Add(this.BtnSimpan);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.MaximumSize = new System.Drawing.Size(1205, 1000);
			this.MinimumSize = new System.Drawing.Size(1205, 1000);
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Aplikasi Nilai Akhir Praktikum";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.pencarian.ResumeLayout(false);
			this.pencarian.PerformLayout();
			this.ResumeLayout(false);

		}
		}
		}
	

