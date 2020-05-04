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
    public partial class NewOrEditConsignment : Form
    {
        Consignment theConsignment;
        public NewOrEditConsignment(Consignment consignment)
        {
            InitializeComponent();
            theConsignment = consignment;
            if (theConsignment.DateOfDelivery != DateTime.MinValue)
            {
                dateOfDeliveryPicker.Value = theConsignment.DateOfDelivery;
                countUpDown.Value = theConsignment.Count;
                priceTextBox.Text = theConsignment.Price.ToString();
                costOfTranspontationTextBox.Text = theConsignment.CostOfTransportation.ToString();
            }
        }

        private Delivery[] deliveries;
        private string path = "store/all_vegetables.xml";

        private void SaveInfo()
        {
            try
            {
                theConsignment.Delivery = (Delivery)Enum.Parse(typeof(Delivery), deliveryComboBox.SelectedItem.ToString());
                theConsignment.Vegetable = (Vegetable)vegetableComboBox.SelectedItem;
                theConsignment.DateOfDelivery = dateOfDeliveryPicker.Value;
                theConsignment.Count = (int)countUpDown.Value;
                theConsignment.Price = int.Parse(priceTextBox.Text);
                theConsignment.CostOfTransportation = int.Parse(costOfTranspontationTextBox.Text);
                if (theConsignment.Vegetable != null)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Поле Vegetable має не правильний формат!!!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введені дані мають не правильний формат!!!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Введені дані мають не правильний формат!!!");
            }
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
                InfoAboutWarehouse.Vegetables = vegetable.GetAll(path);
                vegetableComboBox.Items.AddRange(InfoAboutWarehouse.Vegetables.ToArray());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SaveChanges saveChanges = new SaveChanges();
            if (saveChanges.ShowDialog() == DialogResult.OK)
            {
                SaveInfo();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void NewOrEditConsignment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                SaveChanges saveChanges = new SaveChanges();
                if (saveChanges.ShowDialog() == DialogResult.OK)
                {
                    SaveInfo();
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }
    }
}
