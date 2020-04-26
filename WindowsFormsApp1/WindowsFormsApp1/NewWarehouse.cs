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
    public partial class NewWarehouse : Form
    {
        public NewWarehouse()
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
            Warehouse warehouse = new Warehouse();
            warehouse.Number = Int32.Parse(warehouseNumberTextBox.Text);
            warehouse.CostOfService = Int32.Parse(costOfServiceTextBox.Text);
            
            if (editable)
            {
                warehouse.Consignments = Form1.warehouses[EditItemIndex].Consignments;
                Form1.warehouses[EditItemIndex] = warehouse;
                editable = false;
                Form1.warehouses[EditItemIndex].WriteToFile("store/warehouses/warehouse_" + warehouse.Number + ".xml");
            }
            else
            {
                Form1.warehouses.Add(warehouse);
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
