using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charts
{
    public class StorageExplorer : ObservableSubject
    {
        public string RootPath { get; set; }

        private Dictionary<string, long> fileSizes = new Dictionary<string, long>();
        private Dictionary<string, long> folderSizes = new Dictionary<string, long>();

        public List<string> GetAllFolders()
        {
            List<string> folders = new List<string>();
            GetAllFoldersRecursive(RootPath, folders);
            return folders;
        }

        private void GetAllFoldersRecursive(string directoryPath, List<string> folders)
        {
            folders.Add(directoryPath);

            var subdirectoryEntries = Directory.GetDirectories(directoryPath);
            foreach (string subdirectory in subdirectoryEntries)
                GetAllFoldersRecursive(subdirectory, folders);
        }

        public List<string> GetAllFiles()
        {
            List<string> files = new List<string>();
            GetAllFilesRecursive(RootPath, files);
            return files;
        }

        private void GetAllFilesRecursive(string directoryPath, List<string> files)
        {
            files.AddRange(Directory.GetFiles(directoryPath));

            var subdirectoryEntries = Directory.GetDirectories(directoryPath);
            foreach (string subdirectory in subdirectoryEntries)
                GetAllFilesRecursive(subdirectory, files);
        }

        public StorageExplorer(string rootPath)
        {
            RootPath = rootPath;
            UpdateSizes();

        }

        private void UpdateSizes()
        {
            fileSizes.Clear();
            folderSizes.Clear();

            var allFiles = Directory.GetFiles(RootPath, "D:\\PROIECTE METODE AVANSATE DE PROGRAMARE\\ObserverApp", SearchOption.AllDirectories);
            foreach (var file in allFiles)
            {
                var fileInfo = new FileInfo(file);
                var extension = fileInfo.Extension.ToLower();
                var size = fileInfo.Length;

                if (fileSizes.ContainsKey(extension))
                {
                    fileSizes[extension] += size;
                }
                else
                {
                    fileSizes.Add(extension, size);
                }

                var directory = Path.GetDirectoryName(file);
                if (folderSizes.ContainsKey(directory))
                {
                    folderSizes[directory] += size;
                }
                else
                {
                    folderSizes.Add(directory, size);
                }
            }

            NotifyObservers();
        }

        public Dictionary<string, long> GetFileSizes()
        {
            var fileSizes = new Dictionary<string, long>();

            foreach (var filePath in GetAllFiles())
            {
                var fileInfo = new FileInfo(filePath);
                var extension = fileInfo.Extension.ToLower();

                if (!fileSizes.ContainsKey(extension))
                    fileSizes[extension] = 0;

                fileSizes[extension] += fileInfo.Length;
            }
            return fileSizes;
        }

        public Dictionary<string, long> GetFolderSizes()
        {
            var folderSizes = new Dictionary<string, long>();

            foreach (var folderPath in GetAllFolders())
            {
                var folderInfo = new DirectoryInfo(folderPath);
                var folderSize = GetFolderSize(folderInfo);

                folderSizes[folderPath] = folderSize;
            }
            return folderSizes;
        }

        private long GetFolderSize(DirectoryInfo folderInfo)
        {
            long size = 0;

            foreach (var fileInfo in folderInfo.GetFiles())
            {
                size += fileInfo.Length;
            }

            foreach (var subfolderInfo in folderInfo.GetDirectories())
            {
                size += GetFolderSize(subfolderInfo);
            }

            return size;
        }

        protected void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(this, null);
            }
        }


    }

}
