using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace materi_pertemuan_4
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
            MessageBox.Show ("Hello World " + this.textBox1.Text);
        }
    }
}
