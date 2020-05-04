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
            vegetablesListBox.Items.AddRange(InfoAboutWarehouse.Vegetables.ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Vegetable newVegetable = new Vegetable();
            NewOrEditVegetable newOrEditVegetable = new NewOrEditVegetable(newVegetable);
            if (newOrEditVegetable.ShowDialog() == DialogResult.OK)
            {
                vegetablesListBox.Items.Add(newVegetable.ToString());
                InfoAboutWarehouse.Vegetables.Add(newVegetable);
                newVegetable.WriteToFile("store/all_vegetables.xml");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Vegetable vegetable = new Vegetable();
            int index = vegetablesListBox.SelectedIndex;
            if (index == -1)
            {
                index = InfoAboutWarehouse.Vegetables.Count - 1;
            }
            InfoAboutWarehouse.Vegetables.Remove(InfoAboutWarehouse.Vegetables[index]);
            RefreshInfo();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            File.Delete("store/all_vegetables.xml");
            for (int i = 0; i < InfoAboutWarehouse.Vegetables.Count; i++)
            {
                InfoAboutWarehouse.Vegetables[i].WriteToFile("store/all_vegetables.xml");
            }
        }

        private void vegetablesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = vegetablesListBox.SelectedIndex;
            if (index == -1)
            {
                index = InfoAboutWarehouse.Vegetables.Count - 1;
            }
            NewOrEditVegetable newOrEditVegetable = new NewOrEditVegetable(InfoAboutWarehouse.Vegetables[index]);
            if (newOrEditVegetable.ShowDialog() == DialogResult.OK)
            {
                vegetablesListBox.Items[index] = InfoAboutWarehouse.Vegetables[vegetablesListBox.SelectedIndex].ToString();
                File.Delete("store/all_vegetables.xml");
                for (int i = 0; i < InfoAboutWarehouse.Vegetables.Count; i++)
                {
                    InfoAboutWarehouse.Vegetables[i].WriteToFile("store/all_vegetables.xml");
                }
            }
        }

        private void ListOfVegetables_Load(object sender, EventArgs e)
        {
            if (File.Exists("store/all_vegetables.xml"))
            {
                Vegetable vegetable = new Vegetable();
                InfoAboutWarehouse.Vegetables = vegetable.GetAll("store/all_vegetables.xml");
                vegetablesListBox.Items.AddRange(InfoAboutWarehouse.Vegetables.ToArray());
            }
        }
    }
}
