using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistRber25maart2020
{
    class SongRber
    {
        string songNameRber = "";
        string songPathRber = "";

        public SongRber(string c_songNameRber, string c_songPathRber)
        {
            songNameRber = c_songNameRber;
            songPathRber = c_songPathRber;
        }

        public string GetSongPathRber()
        {
            return songPathRber;
        }

        public string GetSongNameRber()
        {
            return songNameRber;
        }
    }
}
