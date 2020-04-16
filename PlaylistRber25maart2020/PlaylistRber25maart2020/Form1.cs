using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
//Audio DLL import
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaylistRber25maart2020
{

    public partial class Form1 : Form
    {
        string songPathRber = "";
        string songNameRber = "";
        int songNumberRber = 0;
        int lineNumberRber = 0;

        SongRber[] songArrayRber = new SongRber[30];

        List<string> songListRber = new List<string>();

        StreamReader readerRber = null;

        int songCounterRber = 0;
        string searchSongRber = "";

        #region SoundStuff
        [DllImport("winmm.dll")]
        //default audio handling code
        private static extern long mciSendString(
        string strCommand,
        StringBuilder strReturn,
        int iReturnLength,
        IntPtr hwndCallback);
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddSongRber_Click(object sender, EventArgs e)
        {
            AddSongRber();
        }

        private void btnStopSongRber_Click(object sender, EventArgs e)
        {
            //audio stopt
            mciSendString("close MediaFile", null, 0, IntPtr.Zero);
        }

        private void btnPlaySongRber_Click(object sender, EventArgs e)
        {
            try
            {
                //nr afspelen dat in de txb is ingevoegd
                songPathRber = songArrayRber[lineNumberRber].GetSongPathRber();
                PlayAudioRber();
            }

            catch
            {
                MessageBox.Show("Selecteer een nummer.");
            }
        }

        private void lbxListBoxRber_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                //nr afspelen dat in de txb is ingevoegd
                songPathRber = songArrayRber[lineNumberRber].GetSongPathRber();
                PlayAudioRber();
            }

            catch
            {
                MessageBox.Show("Klik op een nummer of op play song.");
            }
        }

        private void PlayAudioRber() //method van playaudio
        {
            //audio stopt
            mciSendString("close MediaFile", null, 0, IntPtr.Zero);

            //audio speelt af
            mciSendString("open \""
                    + songPathRber
                    + "\" "
                    + "type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
            mciSendString("play MediaFile", null, 0, IntPtr.Zero);
        }

        private void AddSongRber() //method van addsong
        {
            //windows verkenner openen
            ofdDialogRber.ShowDialog();

            //geselecteerde path bewaren
            songNameRber = ofdDialogRber.SafeFileName;
            songPathRber = ofdDialogRber.FileName;

            SongRber newSongObjectRber = new SongRber(songNameRber, songPathRber);
            songArrayRber[songNumberRber] = newSongObjectRber;
            songNumberRber++;

            //path in listbox zetten
            lbxListBoxRber.Items.Add(songNumberRber + " " + songNameRber + "\n");
        }

        private void btnSaveSonglistRber_Click(object sender, EventArgs e)
        {
            songNameRber = lbxListBoxRber.Text;

            StreamWriter writerRber = new StreamWriter("playlist.txt", true);

            using (writerRber)
            {
                writerRber.WriteLine(songNameRber + "\n");
            }

            lbxListBoxRber.Text = "";
            MessageBox.Show("Saved");
        }

        private void btnLoadsonglistRber_Click(object sender, EventArgs e)
        {
            lbxListBoxRber.ClearSelected();
            ofdDialogRber.ShowDialog();
            readerRber = new StreamReader(ofdDialogRber.FileName);

            using (readerRber)
            {
                while (readerRber.EndOfStream == false)
                {
                    lbxListBoxRber.Items.Add(readerRber.ReadLine() + "\n");
                }
            }
        }

        private void txbSearchRber_TextChanged(object sender, EventArgs e)
        {
            searchSongRber = txbSearchRber.Text;
            lbxListBoxRber.Items.Clear();
            songCounterRber = 0;
            foreach (SongRber item in songArrayRber)
            {
                if (item != null)
                {
                    if (item.GetSongNameRber().ToUpper().IndexOf(searchSongRber.ToUpper()) > -1)
                    {
                        lbxListBoxRber.Items.Add(" " + item.GetSongNameRber() + " " + item);
                    }
                }
                songCounterRber++;
            }
        }

        private void btnPauseSongRber_Click(object sender, EventArgs e)
        {
            mciSendString("pause MediaFile", null, 0, IntPtr.Zero);
        }

        private void btnNextSongRber_Click(object sender, EventArgs e)
        {
            if (lbxListBoxRber.SelectedIndex<lbxListBoxRber.Items.Count-1)
            {
                lbxListBoxRber.SelectedIndex = lbxListBoxRber.SelectedIndex + 1;
                PlayAudioRber();
            }
        }

        private void btnShuffleListRber_Click(object sender, EventArgs e)
        {
            ListBox.ObjectCollection list = lbxListBoxRber.Items;
            Random random = new Random();
            int w = list.Count;
            lbxListBoxRber.BeginUpdate();
            while (w > 1)
            {
                w--;
                int u = random.Next(w + 1);
                object value = list[u];
                list[u] = list[w];
                list[w] = value;
            }
            lbxListBoxRber.EndUpdate();
            lbxListBoxRber.Invalidate();
        }

        private void btnPreviousSongRber_Click(object sender, EventArgs e)
        {
            if (lbxListBoxRber.SelectedIndex < lbxListBoxRber.Items.Count + 1)
            {
                lbxListBoxRber.SelectedIndex = lbxListBoxRber.SelectedIndex - 1;
                PlayAudioRber();
            }
        }

        private void mniExitRber_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmAddSongRber_Click(object sender, EventArgs e)
        {
            AddSongRber();
        }

        private void tsmSavePlaylistRber_Click(object sender, EventArgs e)
        {
            StreamWriter writerRber = new StreamWriter("playlist.txt", true);

            using (writerRber)
            {
                writerRber.WriteLine(lbxListBoxRber + "\n");
            }
            MessageBox.Show("Saved");
        }

        private void tsmLoadPlaylistRber_Click(object sender, EventArgs e)
        {
            lbxListBoxRber.ClearSelected();
            ofdDialogRber.ShowDialog();
            readerRber = new StreamReader(ofdDialogRber.FileName);

            using (readerRber)
            {
                while (readerRber.EndOfStream == false)
                {
                    lbxListBoxRber.Items.Add(readerRber.ReadLine() + "\n");
                }
            }
        }

        private void mniAboutRber_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by: \nRaul Bermudo Avila\n IC.19AO.a");
        }

        private void btnShuffleSongRber_Click(object sender, EventArgs e)
        {
            
        }

        private void lbxListBoxRber_MouseClick(object sender, MouseEventArgs e)
        {
            lblCurrentSongRber.Text = Convert.ToString(lbxListBoxRber.Text);
        }
    }
}
