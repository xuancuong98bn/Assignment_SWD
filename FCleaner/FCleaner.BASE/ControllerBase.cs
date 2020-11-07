using FCleaner.CORE;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FCleaner.BASE
{
    public class ControllerBase : DialogBase
    {
        private FolderInfo folderInfo;

        public FolderInfo FolderInfo { get => folderInfo; set => folderInfo = value; }

    }
}
