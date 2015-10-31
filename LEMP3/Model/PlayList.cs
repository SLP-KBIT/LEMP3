using System;
using System.Collections.ObjectModel;

namespace LEMP3.Model
{
    public class PlayList
    {
        public string Name { get; private set;}
        public Collection<Music> MusicList { get; private set; }

        public PlayList(string playListName, Collection<Music> musicList)
        {
            this.MusicList = musicList;
            this.Name = playListName;
        }
    }
}
