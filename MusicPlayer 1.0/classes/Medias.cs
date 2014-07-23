using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicPlayer_1._0.classes
{
    public class Medias
    {
        public String fileNameNumber { get; set; }
        public String fileName { get; set; }
        public String fileFullPath { get; set; }

        public Medias(String fileNameNumber, String fileName, String fileFullPath)
        {
            this.fileNameNumber = fileNameNumber;
            this.fileName = fileName;
            this.fileFullPath = fileFullPath;
        }
    }
}
