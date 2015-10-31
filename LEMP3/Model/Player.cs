using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace LEMP3.Model
{
    public class Player
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();
        // TODO:
        // private PlayList playList = new PlayList();

        public Player()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.";
            if (openFileDialog.ShowDialog() == true)
            {
                mediaPlayer.Open(new Uri(openFileDialog.FileName));
            }
        }

        public int Volume { set; get; }

        public string PlayingPosition
        {
            get
            {
                return mediaPlayer.Position.ToString(@"mm\:ss");
            }
        }

        public void ChangeVolume()
        {
            mediaPlayer.Volume = this.Volume;
        }

        public void Play()
        {
            mediaPlayer.Play();
        }

        public void Pause()
        {
            mediaPlayer.Pause();
        }

        private void Open(Uri uri)
        {
            mediaPlayer.Open(uri);
        }
    }
}
