using FCleaner.BASE;
using FCleaner.UI.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FCleaner.UI.Controller
{
    class HomeController : DialogBase
    {
        private Form homeForm;
        public Form HomeForm { get => homeForm; set => homeForm = value; }
        public HomeController()
        {
            homeForm = new HomeForm();
            AddAction();
            homeForm.Show();
        }

        private void AddAction()
        {

        }
        
    }
}
