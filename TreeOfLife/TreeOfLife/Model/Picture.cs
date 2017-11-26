using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeOfLife.Model
{
    class Picture
    {
        private string pictureName { get; }
        private string pictureURL { get; }
        private string locationTaken { get; set; }
        private DateTime dateTaken { get; set; }

        public Picture(string PictureName, string PictureURL, string LocationTaken, DateTime DateTaken)
        {
            this.pictureName = PictureName;
            this.pictureURL = PictureURL;
            this.locationTaken = LocationTaken;
            this.dateTaken = DateTaken;
        }
    }
}
