﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Oblakoo
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Drive
    {
        public abstract DriveFile RootFolder { get; }

        public virtual async Task<Image> GetImageAsync(DriveFile file, CancellationToken token)
        {
            return Image.FromStream(await ReadFileAsync(file, token));
        }

        public abstract Task DeleteFileAsync(DriveFile driveFile, CancellationToken token);
        public abstract Task EnumerateFilesRecursive(DriveFile driveFolder, Action<DriveFile> action, CancellationToken token);
        public abstract Task DownloadFileAsync(DriveFile driveFile, string destFolder, ActionIfFileExists actionIfFileExists, CancellationToken token);
        public abstract Task<DriveFile> UploadFileAsync(string pathName, DriveFile destFolder, string storageFileId, CancellationToken token);

        public abstract Task<Stream> ReadFileAsync(DriveFile file, CancellationToken token);
        public abstract Task<Image> GetThumbnailAsync(DriveFile file, CancellationToken token);
        public abstract Task<ICollection<DriveFile>> GetFilesAsync(DriveFile folder, CancellationToken token);
        public abstract Task<DriveFile> CreateFolderAsync(string folderName, DriveFile destFolder, CancellationToken token);
        public abstract Task<ICollection<DriveFile>> GetSubfoldersAsync(DriveFile folder, CancellationToken token);

        public abstract Task ClearAsync(CancellationToken token);

        public abstract Task DeleteFolderAsync(DriveFile driveFolder, CancellationToken token);
    }
}
