using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeOfLife.Model
{
    abstract class Organism
    {
        private string nameScientific { get; set; }
        private string nameDutch { get; set; }
        private string description { get; set; }
        private List<Picture> pictures { get; set; }

        public Organism(string NameScientific, string NameDutch, string Description, List<Picture> Pictures)
        {
            this.nameScientific = NameScientific;
            this.nameDutch = NameDutch;
            this.description = Description;
            //If not null toevoegen
            this.pictures = Pictures;
        }

        public bool AddPicture(Picture newPicture)
        {
            if (newPicture != null)
            {
                this.pictures.Add(newPicture);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
