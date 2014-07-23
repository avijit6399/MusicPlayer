using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicPlayer_1._0.classes
{
    public class MediaControl
    {
        AxWMPLib.AxWindowsMediaPlayer mPlayer;

        public MediaControl(frmMain frm)
        {
            this.mPlayer = frm.mPlayer;
        }

        public AxWMPLib.AxWindowsMediaPlayer getMPlayer()
        {
            return this.mPlayer;
        }

        public bool isMediaPlaying()
        {
            if (mPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool isMediaPaused()
        {
            if (mPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void playMedia()
        {
            try
            {
                mPlayer.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                //Doing nothing since don't want to throw
                //some exception. You can also put a messagebox
                //over here.
            }
        }

        public void stopPlayingMedia()
        {
            try
            {
                mPlayer.Ctlcontrols.stop();
            }
            catch (Exception ex)
            {
                //Doing nothing since don't want to throw
                //some exception. You can also put a messagebox
                //over here.
            }
        }

        public void pauseMedia()
        {
            try
            {
                mPlayer.Ctlcontrols.pause();
            }
            catch (Exception ex)
            {
                //Doing nothing since don't want to throw
                //some exception. You can also put a messagebox
                //over here.
            }
        }
    }
}
