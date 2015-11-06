using System;
using System.Collections.ObjectModel;

namespace LEMP3.Model
{
    public class PlayList
    {
        public string Name { get; private set;}
        public ObservableCollection<Music> MusicList { get; private set; }

        public PlayList(string playListName, ObservableCollection<Music> musicList)
        {
            this.MusicList = musicList;
            this.Name = playListName;
        }
    }
}
