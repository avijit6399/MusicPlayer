using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MusicPlayer_1._0.classes
{
    public class Utility
    {
        public static void stopPlayer(frmMain frm)
        {
            frm.mPlayer.Ctlcontrols.stop();
        }

        public static String getFileNameFromFilePath(String fileFullPath){
            return Path.GetFileName(fileFullPath);
        }

        public static int getListBoxItemCount(ListBox lb)
        {
            return lb.Items.Count;
        }

        public static int getListBoxSelectedIndex(ListBox lb)
        {
            return lb.SelectedIndex;
        }

        public static String getSelectedValueInListBox(ListBox lb, int selectedIndex)
        {
            lb.SelectedIndex = selectedIndex;
            return lb.SelectedValue.ToString();
        }

        public static String getSelectedDisplayNameInListBox(ListBox lb, int selectedIndex)
        {
            lb.SelectedIndex = selectedIndex;
            return ((Medias)lb.SelectedItem).fileName;
        }

        public static void removeAllItemFromListBox(ListBox lb)
        {
            DialogResult dr = MessageBox.Show("Do you want to remove all media from Playlist?", "Removing media from Playlist", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                lb.DataSource = null;
                lb.Items.Clear();
            }
            
        }

        public static void selectSongIndex(ListBox lb, int index)
        {
            int count = getListBoxItemCount(lb);
            if(count>0 && count -1 >= index){
                lb.SelectedIndex = index;
            }
        }
    }
}
