/*
 * PROJECT UAS PV -APLIKASI NILAI AKHIR MAHASISWA-
 * Nama: Muhammad Rizky Prayoga (201401024) 
 * KOM : A
 */
 
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace NilaiAkhirMhs
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		//Koneksi Ke database
		MySqlConnection conn = new MySqlConnection("Server = localhost; Database = nilaiakhirmahasiswa; Uid = root");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		//Membaca data dari database dan menampilkannya
		public void ReadData(){
			try{
				mycommand.Connection = conn;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from data_mahasiswa";
				DataSet ds = new DataSet();

				if (myadapter.Fill(ds,"dftpesan") > 0){
					dataGridView.DataSource = ds;
					dataGridView.DataMember = "dftpesan";
				}
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		//Menambahkan daftar kelas ke dalam list combobox 'KELAS'
		public void DaftarKelas(){
			KELAS.Items.Add("1");
			KELAS.Items.Add("2");
			KELAS.Items.Add("3");	
			KELAS.Items.Add("4");	
		}
		
		//Menghitung Nilai Akhir Mahasiswa berdasarkan nilai yang diinputkan
		public void HitungNilai(){
			double a,b,c,d,e;
			a = double.Parse(this.ABSENSI.Text);
			b = double.Parse(this.TUGAS.Text);
			c = double.Parse(this.UTS.Text);
			d = double.Parse(this.UAS.Text);
			e = (0.2*a) + (0.2*b) + (0.3*c) + (0.3*d);
			this.HASIL.Text = e.ToString();
		}
		
		//Menghitung Grade Akhir Mahasiswa dan keterangannya berdasarkan nilai akhir yang telah dihitung sebelumnya
		public void HitungGradeKeterangan(){
			double a;
			a = double.Parse(this.HASIL.Text);
	        if (a >= 80) {
	            GRADE.Text = "A";
	            KETERANGAN.Text = "Lulus";
	        }
	        else if (a >= 75) {
	            GRADE.Text = "B+";
	            KETERANGAN.Text = "Lulus";
	        }
	        else if (a >= 70) {
	            GRADE.Text = "B";
	            KETERANGAN.Text = "Lulus";
	        }
	        else if (a >= 65) {
	            GRADE.Text = "C+";
	            KETERANGAN.Text = "Lulus";
	        }
	        else if (a >= 60) {
	            GRADE.Text = "C";
	            KETERANGAN.Text = "Lulus";
	        }
	        else if (a >= 50) {
	            GRADE.Text = "D";
	            KETERANGAN.Text = "Tidak Lulus";
	        }
	        else if (a >= 40) {
	            GRADE.Text = "E";
	            KETERANGAN.Text = "Tidak Lulus";
	        }
	        else  {
	            GRADE.Text = "-";
	            KETERANGAN.Text = "Tidak Lulus";
	        }
	    }
		
		//Memasukkan data ke dalam database
		public void InsertData(){
			try{
				mycommand.Connection=conn;
				mycommand.CommandText="insert into data_mahasiswa values('"+NIM.Text+"','"+NAMA.Text+"','"+KELAS.Text+"','"+ABSENSI.Text+"','"+TUGAS.Text+"','"+UTS.Text+"','"+UAS.Text+"','"+HASIL.Text+"','"+GRADE.Text+"','"+KETERANGAN.Text+"')";
				myadapter.SelectCommand= mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dimasukkan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
				}
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		//Mengubah/mengupdate data yang ada dalam database.
		public void UpdateData(){
			try{
				mycommand.Connection=conn;
				mycommand.CommandText = "update data_mahasiswa set NAMA='"+NAMA.Text+"',LAB='"+KELAS.Text+"',ABSENSI='"+ABSENSI.Text+"',TUGAS='"+TUGAS.Text+"',UTS='"+UTS.Text+"',UAS='"+UAS.Text+"',HASIL='"+HASIL.Text+"',GRADE='"+GRADE.Text+"',KETERANGAN='"+KETERANGAN.Text+"'where NIM ='"+NIM.Text+"' ";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil diperbarui","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
				}
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		//Menghapus data yang ada di dalam database
		public void DeleteData(){
			try{
				mycommand.Connection=conn;
				mycommand.CommandText="delete from data_mahasiswa where NIM ='"+NIM.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
					ResetData();
				}
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		//Mereset kolom-kolom yang ada
		public void ResetData(){
			NIM.Text="";
			NAMA.Text="";
			KELAS.Text="";
			ABSENSI.Text="0";
			TUGAS.Text="0";
			UTS.Text="0";
			UAS.Text="0";
			HASIL.Text="";
			GRADE.Text="";
			KETERANGAN.Text="";
			kotakcari.Text="";
			NIM_Otomatis();
		}
		
		//untuk mencari data mahasiswa berdasarkan nim atau nama 
		public void CariDataMahasiswa(){
	            try
	            {
	            	mycommand.Connection = conn;
					myadapter.SelectCommand = mycommand;
					mycommand.CommandText = "Select * from data_mahasiswa where NIM like '%"+kotakcari.Text+"%' or NAMA like '%"+kotakcari.Text+"%'";               	
					DataSet ds = new DataSet();
					
					if (myadapter.Fill(ds,"dftpesan") > 0){
						dataGridView.DataSource = ds;
						dataGridView.DataMember = "dftpesan";
					}
	            }
	            catch (Exception G)
	            {
	                MessageBox.Show(G.ToString());
	            }
		}
		
		//Membuat NIM otomatis (+1)
		public void NIM_Otomatis(){
			int temp = 0;
			try{
				mycommand.Connection = conn;
				MySqlCommand cmd = conn.CreateCommand();
				string sql = "select max(NIM) from data_mahasiswa";
				cmd.CommandText = sql;
				MySqlDataReader reader = cmd.ExecuteReader();
				while(reader.Read()){
					if(!reader.IsDBNull(0)){
						temp = Convert.ToInt32(reader.GetString(0))+1;
						NIM.Text = temp.ToString();
					}
				}
				reader.Close();
			}
			
			catch (MySqlException error){
				MessageBox.Show(error.ToString());
			}
		}

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			conn.Open();
			ReadData(); //memanggil fungsi untuk menampilkan data
			ResetData();
			DaftarKelas(); //memanggil fungsi untuk menambahkan daftar kelas ke dalam list combobox
			NIM_Otomatis();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//Menampilkan isi database ke dalam kolom-kolom yang tersedia sesuai dengan keterangannya ketika salah satu kolom dalam dataGridView di klik.
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			NIM.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
			NAMA.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
			KELAS.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
			ABSENSI.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
			TUGAS.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
			UTS.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
			UAS.Text = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
			HASIL.Text = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
			GRADE.Text = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
			KETERANGAN.Text = dataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}

		//Tombol Simpan
		void BtnSimpanClick(object sender, EventArgs e)
		{
			if(NAMA.Text.Trim()==""||NIM.Text.Trim()==""||KELAS.Text.Trim()==""||ABSENSI.Text.Trim()==""||TUGAS.Text.Trim()==""||UTS.Text.Trim()==""||UAS.Text.Trim()==""||HASIL.Text.Trim()==""||GRADE.Text.Trim()==""||KETERANGAN.Text.Trim()=="")
			{
				MessageBox.Show("Data Tidak Boleh Kosong!","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
				
			}
			else {
				InsertData();
				ResetData();
			}
		}
		
		//Tombol Update
		void BtnUpdateClick(object sender, EventArgs e)
		{
			string message = "Yakin Ingin Mengubah Data?";  
			string title = "Mengubah Data";  
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;  
			DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);  
			if (result == DialogResult.Yes) {  
				UpdateData();
				ResetData();
			}  
			else {}
		}
		
		//Tombol Reset
		void BtnResetClick(object sender, EventArgs e)
		{
			ResetData();
		}
		
		//Tombol Hapus/Delete
		void BtnHapusClick(object sender, EventArgs e)
		{
			string message = NAMA.Text+", Yakin Ingin Menghapus Data ini?";  
			string title = "Menghapus Data";  
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;  
			DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);  
			if (result == DialogResult.Yes) {  
				DeleteData();
			}  
			else {}
		}
		
		//Tombol Hitung
		void BtnHitungClick(object sender, EventArgs e)
		{
			if(ABSENSI.Text.Trim()==""||TUGAS.Text.Trim()==""||UTS.Text.Trim()==""||UAS.Text.Trim()=="")
			{
				MessageBox.Show("Nilai Tidak Boleh Kosong!","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
				
			}
			else{
				HitungNilai();
				HitungGradeKeterangan();
			}

		}
		
		//Agar kolom-kolom nilai dan nim tidak bisa diisi kecuali dengan menginputkan angka
		void ABSENSIKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar)&& e.KeyChar != (char) Keys.Back;
		}
		void TUGASKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar)&& e.KeyChar != (char) Keys.Back;
		}
		void UTSKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar)&& e.KeyChar != (char) Keys.Back;
		}
		void UASKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar)&& e.KeyChar != (char) Keys.Back;
		}
		void NIMKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar)&& e.KeyChar != (char) Keys.Back;
		}
		void KotakcariTextChanged(object sender, EventArgs e)
		{
			CariDataMahasiswa();
		}
		
	}
}
