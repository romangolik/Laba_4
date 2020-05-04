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
    public partial class NewOrEditVegetable : Form
    {
        Vegetable theVegetable;
        public NewOrEditVegetable(Vegetable vegetable)
        {
            InitializeComponent();
            theVegetable = vegetable;
            if (theVegetable != null)
            {
                nameTextBox.Text = theVegetable.Name;
                countryTextBox.Text = theVegetable.Country;
                seasonTextBox.Text = theVegetable.NumberSeasonOfMaturation.ToString();
            }
        }

        private void SaveInfo()
        {
            try
            {
                theVegetable.Name = nameTextBox.Text;
                theVegetable.Country = countryTextBox.Text;
                theVegetable.NumberSeasonOfMaturation = int.Parse(seasonTextBox.Text);
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

        private void NewOrEditVegetable_FormClosing(object sender, FormClosingEventArgs e)
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
