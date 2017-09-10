using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mato.Sample.Model;

namespace Mato.Sample.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {

        public MainPageViewModel()
        {
            this.Musics = new List<MusicInfo>()
            {
                
                new MusicInfo(){AlbumTitle = "意外",Artist = "薛之谦",Title = "丑八怪",Url = ""},
                new MusicInfo(){AlbumTitle = "七里香",Artist = "周杰伦",Title = "搁浅",Url = ""},
                new MusicInfo(){AlbumTitle = "七里香",Artist = "周杰伦",Title = "简单爱",Url = ""},
                new MusicInfo(){AlbumTitle = "Stuttering",Artist = "Fefe Dobson",Title = "Stuttering",Url = ""},
                new MusicInfo(){AlbumTitle = "AlbumA",Artist = "ArtistA",Title = "TitleA",Url = ""},
                new MusicInfo(){AlbumTitle = "Pistal",Artist = "Frame",Title = "Review fill",Url = ""},
                new MusicInfo(){AlbumTitle = "Cood",Artist = "BattleField",Title = "Session",Url = ""},
                new MusicInfo(){AlbumTitle = "Scan",Artist = "Bill Acess",Title = "Length",Url = ""},
            };


        }
        private List<MusicInfo> _musics;

        public List<MusicInfo> Musics
        {
            get
            {

                return _musics;

            }
            set
            {
                _musics = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Musics)));
            }
        }

        private MusicInfo _selectedItem;


        public MusicInfo SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedItem)));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
