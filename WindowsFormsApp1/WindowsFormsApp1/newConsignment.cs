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
    public partial class NewConsignment : Form
    {
        public NewConsignment()
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

        private Delivery[] deliveries;
        private string path = "store/all_vegetables.xml";

        private void SaveInfo()
        {
            Consignment consignment = new Consignment();
            consignment.Delivery = (Delivery)Enum.Parse(typeof(Delivery), deliveryComboBox.SelectedItem.ToString());
            consignment.Vegetable = (Vegetable)vegetableComboBox.SelectedItem;
            consignment.DateOfDelivery = dateOfDeliveryPicker.Value;
            consignment.Count = (int)countUpDown.Value;
            consignment.Price = int.Parse(priceTextBox.Text);
            consignment.CostOfTransportation = int.Parse(costOfTranspontationTextBox.Text);

            if (editable)
            {
                InfoAboutWarehouse.warehouse.Consignments[EditItemIndex] = consignment;
                editable = false;
            }
            else
            {
                InfoAboutWarehouse.warehouse.AddConsignment(consignment);
            }
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveInfo();
        }

        private void NewConsignment_Load(object sender, EventArgs e)
        {
            List<string> strDeliveries = new List<string>();
            deliveries = (Delivery[])Enum.GetValues(typeof(Delivery));
            foreach (Delivery delivery in deliveries)
            {
                strDeliveries.Add(delivery.ToString());
            }
            deliveryComboBox.Items.AddRange(strDeliveries.ToArray());

            if (File.Exists(path))
            {
                Vegetable vegetable = new Vegetable();
                InfoAboutWarehouse.vegetables = vegetable.GetAll(path);
                vegetableComboBox.Items.AddRange(InfoAboutWarehouse.vegetables.ToArray());
            }
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
