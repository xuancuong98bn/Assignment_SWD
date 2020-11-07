using FCleaner.BASE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FCleaner.UI
{
    public partial class HomeForm : ControllerBase
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScanForm scan = new ScanForm();
            scan.Show();
            this.Hide();
        }
    }
}
