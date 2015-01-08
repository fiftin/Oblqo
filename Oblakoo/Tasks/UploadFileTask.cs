﻿using System.Threading.Tasks;

namespace Oblakoo.Tasks
{
    public class UploadFileTask : AsyncTask
    {
        public string FileName { get; private set; }
        public AccountFile DestFolder { get; private set; }

        public UploadFileTask(Account account, string accountName, int priority, AsyncTask parent, string fileName, AccountFile destFolder)
            : base(account, accountName, priority, parent)
        {
            FileName = fileName;
            DestFolder = destFolder;
        }

        protected override async Task StartAsync2()
        {
            await Account.UploadFileAsync(FileName, DestFolder, CancellationTokenSource.Token);
        }
    }
}
