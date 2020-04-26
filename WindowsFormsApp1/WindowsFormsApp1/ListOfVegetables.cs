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
    public partial class ListOfVegetables : Form
    {
        public ListOfVegetables()
        {
            InitializeComponent();
        }

        public void RefreshInfo()
        {
            vegetablesListBox.Items.Clear();
            vegetablesListBox.Items.AddRange(InfoAboutWarehouse.vegetables.ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewVegetable newVegetable = new NewVegetable();
            newVegetable.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshInfo();
            btnEdit.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Vegetable vegetable = new Vegetable();
            int index = vegetablesListBox.SelectedIndex;
            if (index == -1)
            {
                index = InfoAboutWarehouse.vegetables.Count - 1;
            }
            InfoAboutWarehouse.vegetables.Remove(InfoAboutWarehouse.vegetables[index]);
            RefreshInfo();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            File.Delete("store/all_vegetables.xml");
            for (int i = 0; i < InfoAboutWarehouse.vegetables.Count; i++)
            {
                InfoAboutWarehouse.vegetables[i].WriteToFile("store/all_vegetables.xml");
            }
        }

        private void vegetablesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NewVegetable newVegetable = new NewVegetable();
            int index = vegetablesListBox.SelectedIndex;
            if (index == -1)
            {
                index = InfoAboutWarehouse.vegetables.Count - 1;
            }
            newVegetable.nameTextBox.Text = InfoAboutWarehouse.vegetables[index].Name;
            newVegetable.countryTextBox.Text = InfoAboutWarehouse.vegetables[index].Country;
            newVegetable.seasonTextBox.Text = InfoAboutWarehouse.vegetables[index].NumberSeasonOfMaturation.ToString();
            newVegetable.EditItemIndex = index;
            newVegetable.Editable = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            newVegetable.Show();
        }

        private void ListOfVegetables_Load(object sender, EventArgs e)
        {
            if (File.Exists("store/all_vegetables.xml"))
            {
                Vegetable vegetable = new Vegetable();
                InfoAboutWarehouse.vegetables = vegetable.GetAll("store/all_vegetables.xml");
                vegetablesListBox.Items.AddRange(InfoAboutWarehouse.vegetables.ToArray());
            }
        }
    }
}
