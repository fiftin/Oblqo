﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblakoo.Tasks
{
    public class DownloadFolderFromStorageTask : DownloadFolderTask
    {

        public AccountFile Folder;

        public DownloadFolderFromStorageTask(Account account, string accountName, int priority, AsyncTask[] parent, AccountFile folder, string destFolder) 
            : base(account, accountName, priority, parent, destFolder, true)
        {
            Folder = folder;
        }

        protected override async Task StartAsync2()
        {
            var folder = OnlyContent ? DestFolder : Common.AppendFolderToPath(DestFolder, Folder.Name);
            Directory.CreateDirectory(folder);
            await EnumerateFilesRecursiveAsync(Folder.DriveFile, folder);
        }

        protected override DownloadFileTask CreateDownloadFileTask(Account account, string accountName, int priority, AsyncTask[] parent,
            AccountFile file, string destFolder)
        {
            return new DownloadFileFromStorageTask(account, accountName, priority, parent, file, destFolder);
        }
    }
}
