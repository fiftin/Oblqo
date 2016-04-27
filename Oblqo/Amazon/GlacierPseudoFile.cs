﻿using System;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Oblqo.Amazon
{
    public class GlacierPseudoFile : DriveFile
    {
        private XElement element;

        public GlacierPseudoFile(GlacierPseudoDrive drive, XElement element)
            : base(drive)
        {
            this.element = element;
        }

        public override DateTime CreatedDate
        {
            get
            {
                return DateTime.Parse(element.Attribute("creationDate").Value);
            }
        }

        public override DateTime ModifiedDate
        {
            get
            {
                return CreatedDate;
            }
        }

        public override bool HasChildren => !element.IsEmpty;

        public override string Id => element.Attribute("id").Value;

        public override int ImageHeight => OriginalImageHeight;

        public override int ImageWidth => OriginalImageWidth;

        public override bool IsFolder => element.Name == "folder";

        public override bool IsRoot => element.Document.Root == element;

        public override string MimeType => MimeTypes.GetMimeTypeByExtension(element.Attribute("fileName").Value);

        public override bool IsImage => MimeType.StartsWith("image/");

        public override string Name => element.Attribute("fileName").Value;

        public override long Size => OriginalSize;

        public override int OriginalImageHeight
        {
            get
            {
                return 0;
            }

            set
            {
                throw new NotSupportedException();
            }
        }

        public override int OriginalImageWidth
        {
            get
            {
                return 0;
            }

            set
            {
                throw new NotSupportedException();
            }
        }

        public override long OriginalSize
        {
            get
            {
                return int.Parse(element.Attribute("size").Value);
            }

            set
            {
                throw new NotSupportedException();
            }
        }
        
        public override string GetAttribute(string name)
        {
            throw new NotSupportedException();
        }

        public override Task SetAttributeAsync(string name, string value, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public override Task WriteAsync(byte[] bytes, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}
