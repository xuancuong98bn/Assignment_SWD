using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FCleaner.CORE
{
    public abstract class FolderBase
    {
        private String path;
        private List<FileInfo> files;

        protected string Path { get => path; set => path = value; }
        protected List<FileInfo> Files { get => files; set => files = value; }

        public FolderBase() { }
        public abstract void Open();
        public abstract void Move();
        public abstract void Copy();
        public abstract void Rename();
        public abstract void Remove();
        public abstract void OpenFile();
        public abstract void CloneFolder();
        public abstract void SaveFolder();
    }
}
