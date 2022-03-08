/*
 * Created by SharpDevelop.
 * User: dk
 * Date: 3/8/2022
 * Time: 2:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tugas2_Andri_Hasudungan_201401036
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Nama;
		private System.Windows.Forms.Label NIM;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox ListBiodata;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.Nama = new System.Windows.Forms.Label();
			this.NIM = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.ListBiodata = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(114, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Biodata";
			// 
			// Nama
			// 
			this.Nama.Location = new System.Drawing.Point(8, 51);
			this.Nama.Name = "Nama";
			this.Nama.Size = new System.Drawing.Size(100, 20);
			this.Nama.TabIndex = 1;
			this.Nama.Text = "Nama";
			// 
			// NIM
			// 
			this.NIM.Location = new System.Drawing.Point(8, 94);
			this.NIM.Name = "NIM";
			this.NIM.Size = new System.Drawing.Size(100, 23);
			this.NIM.TabIndex = 2;
			this.NIM.Text = "NIM";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Kelas";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 184);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Mata Kuliah";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(114, 48);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(119, 20);
			this.textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(114, 91);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(119, 20);
			this.textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(114, 137);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(119, 20);
			this.textBox3.TabIndex = 7;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(114, 181);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(119, 20);
			this.textBox4.TabIndex = 8;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(114, 226);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "Klik Saya";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// ListBiodata
			// 
			this.ListBiodata.FormattingEnabled = true;
			this.ListBiodata.Location = new System.Drawing.Point(332, 48);
			this.ListBiodata.Name = "ListBiodata";
			this.ListBiodata.Size = new System.Drawing.Size(285, 199);
			this.ListBiodata.TabIndex = 10;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(688, 327);
			this.Controls.Add(this.ListBiodata);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.NIM);
			this.Controls.Add(this.Nama);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "tugas2_Andri Hasudungan_201401036";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
