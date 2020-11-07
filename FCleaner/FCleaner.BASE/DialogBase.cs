using FCleaner.CORE;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FCleaner.BASE
{
    public abstract class DialogBase : Form
    {
        public DialogBase()
        {
        }

        public FolderInfo OpenFolderDialog()
        {
            FolderInfo f = new FolderInfo();
            return f;
        }

        public bool ConfirmDialog(String message)
        {

            return false;
        }

        public void AlertDialog(String message)
        {

        }
    }
}
