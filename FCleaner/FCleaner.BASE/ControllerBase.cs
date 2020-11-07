using FCleaner.CORE;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FCleaner.BASE
{
    public abstract class ControllerBase : DialogBase
    {
        private FolderInfo folderInfo;
        private Form form;

        public FolderInfo FolderInfo { get => folderInfo; set => folderInfo = value; }
        public Form Form { get => form; set => form = value; }

        //Khởi tạo form mà controller quản lý tương ứng
        public abstract void InitializeForm();
        //Thêm action cho form
        public abstract void AddAction();
    }
}
