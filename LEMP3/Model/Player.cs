using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;

namespace LEMP3.Model
{
    public class Player
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();
        private Task GetPositionTask;
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
            GetPositionTask = new Task(() =>
                {
                    PlayingPosition = mediaPlayer.Position.ToString(@"mm\:ss");
                });
            this.Volume = 100;
        }

        public int Volume { set; get; }

        public string PlayingPosition { get; private set; }

        public void ChangeVolume()
        {
            mediaPlayer.Volume = (double) (this.Volume / 100f);
        }

        public void Play()
        {
            mediaPlayer.Play();
            GetPositionTask.Start();
        }

        public void Pause()
        {
            mediaPlayer.Pause();
            GetPositionTask.Wait();
        }

        private void Open(Uri uri)
        {
            mediaPlayer.Open(uri);
        }

    }
}
