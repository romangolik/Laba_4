namespace WindowsFormsApp1
{
    partial class InfoAboutWarehouse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listOfConsigments = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOpenListOfVegetables = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listOfConsigments
            // 
            this.listOfConsigments.Dock = System.Windows.Forms.DockStyle.Top;
            this.listOfConsigments.FormattingEnabled = true;
            this.listOfConsigments.ItemHeight = 16;
            this.listOfConsigments.Location = new System.Drawing.Point(0, 0);
            this.listOfConsigments.Name = "listOfConsigments";
            this.listOfConsigments.Size = new System.Drawing.Size(800, 340);
            this.listOfConsigments.TabIndex = 1;
            this.listOfConsigments.SelectedIndexChanged += new System.EventHandler(this.listOfConsigments_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(144, 371);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(578, 371);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(482, 371);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(240, 371);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOpenListOfVegetables
            // 
            this.btnOpenListOfVegetables.Location = new System.Drawing.Point(336, 371);
            this.btnOpenListOfVegetables.Name = "btnOpenListOfVegetables";
            this.btnOpenListOfVegetables.Size = new System.Drawing.Size(140, 30);
            this.btnOpenListOfVegetables.TabIndex = 6;
            this.btnOpenListOfVegetables.Text = "ListOfVegetables";
            this.btnOpenListOfVegetables.UseVisualStyleBackColor = true;
            this.btnOpenListOfVegetables.Click += new System.EventHandler(this.btnOpenListOfVegetables_Click);
            // 
            // InfoAboutWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.btnOpenListOfVegetables);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listOfConsigments);
            this.Name = "InfoAboutWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoAboutWarehouse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InfoAboutWarehouse_FormClosing);
            this.Load += new System.EventHandler(this.InfoAboutWarehouse_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listOfConsigments;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOpenListOfVegetables;
    }
}