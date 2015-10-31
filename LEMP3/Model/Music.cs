using System;

namespace LEMP3.Model
{
    public class Music
    {
        public Uri FilePath { get; private set; }

        public Music(string filePath)
        {
            this.FilePath = new Uri(filePath);
        }
    }
}
