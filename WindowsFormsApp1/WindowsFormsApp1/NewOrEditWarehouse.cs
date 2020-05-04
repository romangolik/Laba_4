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
    public partial class NewOrEditWarehouse : Form
    {
        Warehouse theWarehouse;
        public NewOrEditWarehouse(Warehouse warehouse)
        {
            InitializeComponent();
            theWarehouse = warehouse;
            if (theWarehouse != null)
            {
                warehouseNumberTextBox.Text = theWarehouse.Number.ToString();
                costOfServiceTextBox.Text = theWarehouse.CostOfService.ToString();
            }
        }

        private void SaveInfo()
        {
            try
            {
                theWarehouse.Number = Int32.Parse(warehouseNumberTextBox.Text);
                theWarehouse.CostOfService = Int32.Parse(costOfServiceTextBox.Text);
                theWarehouse.Consignments = theWarehouse.Consignments;
                this.DialogResult = DialogResult.OK;
            }
            catch (FormatException)
            {
                MessageBox.Show("Введені дані мають не правильний формат!!!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveInfo();
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

        private void NewOrEditWarehouse_FormClosing(object sender, FormClosingEventArgs e)
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
