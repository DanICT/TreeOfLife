using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeOfLife.Model
{
    class Category
    {
        private string categoryName { get; set; }
        private string description { get; set; }
        private List<Category> subCategories { get; set; }
        private List<Organism> organisms { get; set; }

        public Category(string CategoryName, string Description)
        {
            this.categoryName = CategoryName;
            this.description = Description;
            this.subCategories = new List<Category>();
            this.organisms = new List<Organism>();
        }

        public bool AddCategory(Category newCategory)
        {
            if (newCategory != null)
            {
                this.subCategories.Add(newCategory);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddOrganism(Organism newOrganism)
        {
            if (newOrganism != null)
            {
                this.organisms.Add(newOrganism);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
