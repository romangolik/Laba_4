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
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static List<Warehouse> warehouses = new List<Warehouse>();
        public static Warehouse elementOfWarehouses = new Warehouse();

        public Form1()
        {
            InitializeComponent();
        }

        public void RefreshInfo()
        {
            listOfWarehouses.Items.Clear();
            listOfWarehouses.Items.AddRange(warehouses.ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Warehouse warehouse = new Warehouse();
            for (int i = 0; i < Directory.GetFiles("store/warehouses").Length; i++)
            {
                if (File.Exists(Directory.GetFiles("store/warehouses")[i]))
                {
                    warehouses.Add(warehouse.GetAll(Directory.GetFiles("store/warehouses")[i]));
                }
            }
            RefreshInfo();
        }

        private void btnAddWarehouse_Click(object sender, EventArgs e)
        {
            NewWarehouse newWarehouse = new NewWarehouse();
            newWarehouse.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshInfo();
            btnEdit.Enabled = false;
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            InfoAboutWarehouse infoAboutWarehouse = new InfoAboutWarehouse();
            int index = listOfWarehouses.SelectedIndex;
            if (index == -1)
            {
                index = warehouses.Count - 1;
            }
            infoAboutWarehouse.Text = "Warehouse number " + warehouses[index].Number;
            infoAboutWarehouse.IndexOfWarehouse = index;
            infoAboutWarehouse.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NewWarehouse newWarehouse = new NewWarehouse();
            int index = listOfWarehouses.SelectedIndex;
            if (index == -1)
            {   
                index = warehouses.Count - 1;
            }
            newWarehouse.warehouseNumberTextBox.Text = warehouses[index].Number.ToString();
            newWarehouse.costOfServiceTextBox.Text = warehouses[index].CostOfService.ToString();
            newWarehouse.EditItemIndex = index;
            File.Delete("store/warehouses/warehouse_" + warehouses[index].Number + ".xml");
            newWarehouse.Editable = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnShowShortInfo.Enabled = false;
            newWarehouse.Show();
        }

        private void listOfWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            btnShowInfo.Enabled = true;
            btnDelete.Enabled = true;
            btnShowShortInfo.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = listOfWarehouses.SelectedIndex;
            if (index == -1)
            {
                index = warehouses.Count - 1;
            }
            File.Delete("store/warehouses/warehouse_" + warehouses[index].Number + ".xml");
            warehouses.Remove(warehouses[index]);
            RefreshInfo();
            btnEdit.Enabled = false;
            btnShowInfo.Enabled = false;
            btnShowShortInfo.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnShowShortInfo_Click(object sender, EventArgs e)
        {
            int index = listOfWarehouses.SelectedIndex;
            if (index == -1)
            {
                index = warehouses.Count - 1;
            }
            MessageBox.Show(warehouses[index].ToShortString(), "Short information");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < warehouses.Count; i++)
            {
                warehouses[i].WriteToFile("store/warehouses/warehouse_" + warehouses[i].Number + ".xml");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < warehouses.Count; i++)
            {
                warehouses[i].WriteToFile("store/warehouses/warehouse_" + warehouses[i].Number + ".xml");
            }
        }
    }
}
