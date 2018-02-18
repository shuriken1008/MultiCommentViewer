﻿using SitePlugin;
namespace YouTubeLiveSitePlugin.Test2
{
    class MessageImage : IMessageImage
    {
        public int? Width { get; set; }

        public int? Height { get; set; }

        public string Url { get; set; }

        public string Alt { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj is MessageImage image)
            {
                return this.Url.Equals(image.Url) && this.Alt.Equals(image.Alt);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Url.GetHashCode() ^ Alt.GetHashCode();
        }
    }
}
