﻿using System;
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
    public partial class InfoAboutWarehouse : Form
    {
        public static Warehouse warehouse;
        private static List<Vegetable> vegetables = new List<Vegetable>();
        public InfoAboutWarehouse()
        {
            InitializeComponent();
        }

        public static List<Vegetable> Vegetables
        {
            get 
            {
                return vegetables;
            }
            set
            {
                vegetables = value;
            }
        }

        private int indexOfWarehouse;
        public int IndexOfWarehouse
        {
            get
            {
                return indexOfWarehouse;
            }
            set
            {
                indexOfWarehouse = value;
            }
        }

        public void RefreshInfo()
        {
            listOfConsigments.Items.Clear();
            listOfConsigments.Items.AddRange(warehouse.Consignments.ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            warehouse = Form1.warehouses[IndexOfWarehouse];
            Consignment newConsignment = new Consignment();
            NewOrEditConsignment newOrEditConsignment = new NewOrEditConsignment(newConsignment);
            if (newOrEditConsignment.ShowDialog() == DialogResult.OK)
            {
                listOfConsigments.Items.Add(newConsignment.ToString());
                warehouse.Consignments.Add(newConsignment);
            }
        }

        private void listOfConsigments_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            warehouse = Form1.warehouses[IndexOfWarehouse];
            int index = listOfConsigments.SelectedIndex;
            if (index == -1)
            {
                index = warehouse.Consignments.Count - 1;
            }
            NewOrEditConsignment newOrEditConsignment = new NewOrEditConsignment(warehouse.Consignments[index]);
            if (newOrEditConsignment.ShowDialog() == DialogResult.OK)
            {
                listOfConsigments.Items[index] = warehouse.Consignments[listOfConsigments.SelectedIndex].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            warehouse = Form1.warehouses[IndexOfWarehouse];
            int index = listOfConsigments.SelectedIndex;
            if (index == -1)
            {
                index = warehouse.Consignments.Count - 1;
            }
            warehouse.RemoveConsigment(warehouse.Consignments[index]);
            RefreshInfo();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnOpenListOfVegetables_Click(object sender, EventArgs e)
        {
            ListOfVegetables listOfVegetables = new ListOfVegetables();
            listOfVegetables.Show();
        }

        private void InfoAboutWarehouse_Load(object sender, EventArgs e)
        {
            warehouse = Form1.warehouses[IndexOfWarehouse];
            if (File.Exists("store/warehouses/warehouse_" + warehouse.Number + ".xml"))
            {
                Consignment consignment = new Consignment();
                warehouse.Consignments = Form1.warehouses[IndexOfWarehouse].Consignments;
                RefreshInfo();
            }
        }

        private void InfoAboutWarehouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.warehouses[IndexOfWarehouse].WriteToFile("store/warehouses/warehouse_" + Form1.warehouses[IndexOfWarehouse].Number + ".xml");
        }
    }
}
