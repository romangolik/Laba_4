using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NewVegetable : Form
    {
        public NewVegetable()
        {
            InitializeComponent();
        }

        private bool editable = false;
        public bool Editable
        {
            get
            {
                return editable;
            }
            set
            {
                editable = value;
            }
        }

        private int editItemIndex;
        public int EditItemIndex
        {
            get
            {
                return editItemIndex;
            }
            set
            {
                editItemIndex = value;
            }
        }

        private void SaveInfo()
        {
            Vegetable vegetable = new Vegetable();
            vegetable.Name = nameTextBox.Text;
            vegetable.Country = countryTextBox.Text;
            vegetable.NumberSeasonOfMaturation = int.Parse(seasonTextBox.Text);

            if (editable)
            {
                InfoAboutWarehouse.vegetables[EditItemIndex] = vegetable;
                File.Delete("store/all_vegetables.xml");
                for (int i = 0; i < InfoAboutWarehouse.vegetables.Count; i++)
                {
                    InfoAboutWarehouse.vegetables[i].WriteToFile("store/all_vegetables.xml");
                }
                editable = false;
            }
            else
            {
                InfoAboutWarehouse.vegetables.Add(vegetable);
                vegetable.WriteToFile("store/all_vegetables.xml");
            }
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SaveChanges saveChanges = new SaveChanges();

            if (saveChanges.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SaveInfo();
            }
            else
            {
                this.Close();
            }
        }
    }
}
