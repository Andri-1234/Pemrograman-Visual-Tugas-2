/*
 * Created by SharpDevelop.
 * User: dk
 * Date: 3/8/2022
 * Time: 2:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tugas2_Andri_Hasudungan_201401036
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
		ListBiodata.Items.Add("Nama Saya " +textBox1.Text);
		ListBiodata.Items.Add("NIM Saya Adalah"+ textBox2.Text);
		ListBiodata.Items.Add("Saya di Kelas "+textBox3.Text);
		ListBiodata.Items.Add("Mata Kuliah "+textBox4.Text);
		}
		
		
	}
}
