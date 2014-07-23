using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MusicPlayer_1._0.classes;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace MusicPlayer_1._0
{
    public partial class frmMain : Form
    {
        public int currentMediaTotalDuration;
        public int currentMediaPosition;
        public Boolean isTimeSetToTicker = false;
        public List<Medias> mediaList = new List<Medias>();
        public int currentSongIndex = 0;
        public String fastBckwardOrForward="";

        //Media Control class reference
        MediaControl mcl;

        public frmMain()
        {
            InitializeComponent();
            mcl = new MediaControl(this);
            loadSongFromDB();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Multiselect = false;
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr != DialogResult.OK)
            {
                return;
            }

            String fileFullPath = openFileDialog.FileName;
            String fileName = "";

            //Checking if file exists
            if (openFileDialog.CheckFileExists)
            {
                mcl.stopPlayingMedia();
                mcl.getMPlayer().URL = fileFullPath;
                mcl.playMedia();

                //Extract fileName from fileFullPath
                //We want to only show fileName in the listBox
                fileName = Utility.getFileNameFromFilePath(fileFullPath);

                //Calling constructor of the Medias class
                //and adding the new Medias object in the List<Medias>
                int countMediaList = mediaList.Count;
                countMediaList += 1; //Incrementing the count
                mediaList.Add(new Medias(countMediaList + ". " + fileName, fileName, fileFullPath));

                attachMediaListToListBox();

                //Get the last index of List and select it since
                //that song is playing right now
                int totalListBoxSongsCount = listBoxSongs.Items.Count;
                if (totalListBoxSongsCount > 0)
                {
                    listBoxSongs.SelectedIndex = listBoxSongs.Items.Count - 1;
                    currentSongIndex = listBoxSongs.SelectedIndex;
                }

                // Start timer to track the total time in media and current position of the media
                // that is playing
                timer1.Enabled = true;
            }
        }

        //Get duration if first played.  Display in a label
        private void mPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            bool loadingPlayer = true;

            if (loadingPlayer && e.newState == 3)
            {

                //textBox1.Text = mPlayer.currentMedia.durationString;
                //currentMediaDuration = (int)mPlayer.currentMedia.duration;
                //loadingPlayer = false;
                //myPlayer.Ctlcontrols.stop();
            }
        }

        //Get current position
        private void mPlayer_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e)
        {
            textBox1.Text = textBox1.Text + mcl.getMPlayer().Ctlcontrols.currentPosition;
        }

        /**
         * This is a method to close the current Form
         */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to quit?", "Close Player", MessageBoxButtons.YesNo);

            //If user press the yes button then the application will be closed
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }

        }



        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                if (mcl.isMediaPlaying())
                {
                    //Stop backward and forward if any
                    stopFastForwardFastBackward();

                    timer1.Enabled = false;
                    mcl.getMPlayer().Ctlcontrols.currentPosition = trackBar.Value;

                    // Just want to make sure that inside Timer1 the Trackbar will
                    // be refreshed by the required values 
                    isTimeSetToTicker = false;
                    timer1.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                // Stop media if anything is running
                stopMedia();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                currentMediaTotalDuration = (int)mcl.getMPlayer().currentMedia.duration;
                currentMediaPosition = (int)mcl.getMPlayer().Ctlcontrols.currentPosition;

                if (currentMediaTotalDuration > 0 && trackBar.Maximum != currentMediaTotalDuration)
                {
                    trackBar.Minimum = 0;
                    trackBar.Maximum = currentMediaTotalDuration;
                    isTimeSetToTicker = true;
                }

                // If player is playing some media and the Trackbar is already set to
                // it's length then set the current postion to the trackbar
                if (isTimeSetToTicker == true && mcl.isMediaPlaying())
                {
                    trackBar.Value = currentMediaPosition;

                    if (playImage1.Visible == true)
                    {
                        //Show Pause button
                        playImage1.Visible = false;
                        pauseImage1.Visible = true;
                    }
                }

                //if the media is end
                if (currentMediaPosition > 0 && currentMediaPosition >= currentMediaTotalDuration)
                {
                    timer1.Enabled = false;
                    stopFastForwardFastBackward();
                    timer2.Enabled = true;
                    playImage1.Visible = true;
                }
            }
            catch (Exception ex)
            {
                // Stop media if anything is running
                stopMedia();
            }

        }

        private void stopMedia()
        {
            mcl.stopPlayingMedia();
            //classes.Utility.stopPlayer(this);

            //Show Play button
            playImage1.Visible = true;
            pauseImage1.Visible = false;
            forwardImage1.Visible = true;
            forwardImage2.Visible = false;

            timer1.Enabled = false;
            timer2.Enabled = false;
            stopFastForwardFastBackward();

            currentMediaTotalDuration = 0;
            currentMediaPosition = 0;
            isTimeSetToTicker = false;
            trackBar.Value = currentMediaPosition;
        }

        //When the media get done then this timer get enabled.
        //It will execute the same song again if there is nothing
        //on the list or play the next one if there are other 
        //media present. If this is the last media in the list 
        //then it will execute the first one again.
        private void timer2_Tick(object sender, EventArgs e)
        {
            int totalListBoxSongsCount = Utility.getListBoxItemCount(listBoxSongs);
            Boolean isSelected = false;

            stopFastForwardFastBackward();

            //If List is empty then stop Timer1 and Timer2
            if (totalListBoxSongsCount == 0)
            {
                stopMedia();
                return;
            }
            //If there is only one media in the list
            else if (totalListBoxSongsCount == 1)
            {
                isSelected = true;
                currentSongIndex = 0;

            }
            else if (isSelected == false && totalListBoxSongsCount - 1 > 0 && currentSongIndex < totalListBoxSongsCount - 1)
            {
                isSelected = true;
                currentSongIndex += 1;
            }
            //If list is end
            else if (isSelected == false && totalListBoxSongsCount - 1 > 0 && totalListBoxSongsCount - 1 == currentSongIndex)
            {
                currentSongIndex = 0;
            }
            else
            {
                currentSongIndex = 0;
            }

            mcl.getMPlayer().URL = Utility.getSelectedValueInListBox(listBoxSongs, currentSongIndex);
            mcl.playMedia();
            timer1.Enabled = true;
            timer2.Enabled = false;
        }


        private void stopImage1_MouseHover(object sender, EventArgs e)
        {
            stopImage1.Visible = false;
        }

        private void stopImage2_MouseLeave(object sender, EventArgs e)
        {
            stopImage1.Visible = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void stopImage2_Click(object sender, EventArgs e)
        {
            if (mcl.isMediaPlaying() || mcl.isMediaPaused())
            {
                // After stopping the media from playing do some additional steps
                // to reset the media variables.
                stopMedia();
                stopFastForwardFastBackward();
            }

        }

        //Play a song if that is double clicked from Listbox
        private void listBoxSongs_DoubleClick(object sender, EventArgs e)
        {

            playSongThatIsSelected();
        }

        public void playSongThatIsSelected()
        {
            int index = listBoxSongs.SelectedIndex;
            String filePath = "";

            if (index >= 0)
            {
                stopMedia();
                filePath = listBoxSongs.SelectedValue.ToString();
                currentSongIndex = listBoxSongs.SelectedIndex; //Song index updated
                mcl.getMPlayer().URL = filePath;
                mcl.playMedia();
                timer1.Enabled = true;
            }
        }

        private void removeAllSongsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            removeAllSongs();
        }

        private void addSongsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addSongs();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addSongs();
        }

        private void removeAllSongsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            removeAllSongs();
        }

        public void addSongs()
        {
            openFileDialog.Multiselect = true;
            DialogResult userClickedOK = openFileDialog.ShowDialog();

            if (userClickedOK != DialogResult.OK)
            {
                return;
            }

            String[] fileFullPaths = openFileDialog.FileNames;

            foreach (String fileFullPath in fileFullPaths)
            {
                //Extract fileName from fileFullPath
                //We want to only show fileName in the listBox
                String fileName = Utility.getFileNameFromFilePath(fileFullPath);

                //Calling constructor of the Medias class
                //and adding the new Medias object in the List<Medias>
                int countMediaList = mediaList.Count;
                countMediaList += 1; //Incrementing the count
                mediaList.Add(new Medias(countMediaList + ". " + fileName, fileName, fileFullPath));
            }

            attachMediaListToListBox();

            listBoxSongs.SelectedIndex = currentSongIndex;
            Utility.selectSongIndex(listBoxSongs, currentSongIndex);
        }

        public void removeAllSongs()
        {
            Utility.removeAllItemFromListBox(listBoxSongs);
            mediaList.Clear();
        }

        private void removeSelectedSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = Utility.getListBoxSelectedIndex(listBoxSongs);
            removeListBoxSelectedItem(selectedIndex);
        }

        public void removeListBoxSelectedItem(int selectedIndex)
        {
            int count = mediaList.Count;

            //mediaList has at least one media
            if(count > 0)
            {
                //if the index that is playing is more than or equal to
                //the index we are trying to remove from the Listbox then
                //the currentSongIndex should be currentSongIndex -1
                if(currentSongIndex !=0 && currentSongIndex >= selectedIndex)
                {
                    currentSongIndex -= 1;
                }

                mediaList.RemoveAt(selectedIndex);
                rearrangeMediaList(); //Arrange the numbers with FileName in the mediaList object
                attachMediaListToListBox();
                Utility.selectSongIndex(listBoxSongs, selectedIndex -1);
            }

        }

        public void attachMediaListToListBox()
        {
            listBoxSongs.DataSource = null; //Just to reset the listBox data
            listBoxSongs.DataSource = mediaList;
            listBoxSongs.DisplayMember = "fileNameNumber";
            listBoxSongs.ValueMember = "fileFullPath";
        }

        public void rearrangeMediaList()
        {
            int count = mediaList.Count;
            int increment = 0;

            for (int i = 0; i <= count - 1; i++)
            {
                increment += 1;
                mediaList[i].fileNameNumber = increment + ". " + mediaList[i].fileName;
            }
        }

        private void playImage1_Click(object sender, EventArgs e)
        {
            playMediaInForm();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playMediaInForm();
        }

        private void playMediaInForm()
        {
            //stop any fastForward or fastBackward
            stopFastForwardFastBackward();

            // If media is paused then only play it and
            // do nothing
            if (mcl.isMediaPaused())
            {
                mcl.playMedia();
                return;
            }

            int totalListBoxSongsCount = Utility.getListBoxItemCount(listBoxSongs);
            if (totalListBoxSongsCount <= 0)
            {
                return;
            }

            playSongThatIsSelected();
        }

        private void pauseImage1_Click(object sender, EventArgs e)
        {
            pauseMediaInForm();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pauseMediaInForm();
        }

        private void pauseMediaInForm()
        {
            if (mcl.isMediaPlaying())
            {
                // Pause Media
                stopFastForwardFastBackward();

                mcl.pauseMedia();
                playImage1.Visible = true;
                pauseImage1.Visible = false;
            }
        }

        private void forwardImage1_Click(object sender, EventArgs e)
        {
            if(mcl.isMediaPlaying())
            {
                startFastForward();
            }
        }

        private void forwardImage2_Click(object sender, EventArgs e)
        {
            if (mcl.isMediaPlaying())
            {
                stopFastForwardFastBackward();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if(mcl.isMediaPlaying())
            {
                //mcl.getMPlayer().Ctlcontrols.pause();
                currentMediaPosition = (int)mcl.getMPlayer().Ctlcontrols.currentPosition;
                currentMediaTotalDuration=(int)mcl.getMPlayer().currentMedia.duration;

                if(fastBckwardOrForward.Equals("forward"))
                {
                    if ((currentMediaPosition + 2) <= currentMediaTotalDuration)
                    {
                        mcl.getMPlayer().Ctlcontrols.currentPosition = currentMediaPosition + 2;
                        trackBar.Value = currentMediaPosition + 2;

                    }
                    else
                    {
                        stopFastForwardFastBackward();
                    }
                }

                if (fastBckwardOrForward.Equals("backward"))
                {
                    if ((currentMediaPosition - 2) >= 2 )
                    {
                        mcl.getMPlayer().Ctlcontrols.currentPosition = currentMediaPosition - 2;
                        trackBar.Value = currentMediaPosition - 2;

                    }
                    else
                    {
                        stopFastForwardFastBackward();
                    }
                }
                
            }
        }

        private void startFastForward()
        {
            mcl.getMPlayer().settings.mute = true;
            timer3.Enabled = true;
            forwardImage2.Visible = true;
            forwardImage1.Visible = false;
            fastBckwardOrForward = "forward";
        }

        private void stopFastForwardFastBackward()
        {
            mcl.getMPlayer().settings.mute = false;
            timer3.Enabled = false;

            forwardImage1.Visible = true;
            forwardImage2.Visible = false;

            fastBackward1.Visible = true;
            fastBackward2.Visible = false; 
        }

        private void fastBackward1_Click(object sender, EventArgs e)
        {
            if (mcl.isMediaPlaying())
            {
                startFastBackward();
            }
        }

        private void startFastBackward()
        {
            mcl.getMPlayer().settings.mute = true;
            timer3.Enabled = true;

            fastBackward2.Visible = true;
            fastBackward1.Visible = false;

            forwardImage1.Visible = true;
            forwardImage2.Visible = false;
            fastBckwardOrForward = "backward";
        }

        private void fastBackward2_Click(object sender, EventArgs e)
        {
            stopFastForwardFastBackward();
        }

        private void stopImage1_Click(object sender, EventArgs e)
        {

        }

        private void fastForwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mcl.isMediaPlaying())
            {
                startFastForward();
            }
        }

        private void fastBackwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mcl.isMediaPlaying())
            {
                startFastBackward();
            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mcl.isMediaPlaying() || mcl.isMediaPaused())
            {
                // After stopping the media from playing do some additional steps
                // to reset the media variables.
                stopMedia();
                stopFastForwardFastBackward();
            }
        }

        private void savePlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBClass.insertMediaIntoDB(mediaList);
        }

        public void loadSongFromDB()
        {
            DBClass.updateMediaListFromDB(mediaList,Config.USER_ID_NO);
            attachMediaListToListBox();
        }

        private void savePlaylistToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DBClass.insertMediaIntoDB(mediaList);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdatePassword frm = new frmUpdatePassword();
            frm.Show();
        }

        private void addUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Config.USER_NAME.Equals("admin") || Config.USER_NAME.Equals("Avijit"))
            {
                frmAddUser frm = new frmAddUser();
                frm.Show();
            }
            else
            {
                MessageBox.Show("You don't have required permission. Only Admin can add user.");
            }
        }

        private void fullscreenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
