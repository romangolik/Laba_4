namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listOfWarehouses = new System.Windows.Forms.ListBox();
            this.btnAddWarehouse = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowShortInfo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listOfWarehouses
            // 
            this.listOfWarehouses.Dock = System.Windows.Forms.DockStyle.Top;
            this.listOfWarehouses.FormattingEnabled = true;
            this.listOfWarehouses.ItemHeight = 16;
            this.listOfWarehouses.Location = new System.Drawing.Point(0, 0);
            this.listOfWarehouses.Name = "listOfWarehouses";
            this.listOfWarehouses.Size = new System.Drawing.Size(772, 340);
            this.listOfWarehouses.TabIndex = 0;
            this.listOfWarehouses.SelectedIndexChanged += new System.EventHandler(this.listOfWarehouse_SelectedIndexChanged);
            // 
            // btnAddWarehouse
            // 
            this.btnAddWarehouse.Location = new System.Drawing.Point(163, 364);
            this.btnAddWarehouse.Name = "btnAddWarehouse";
            this.btnAddWarehouse.Size = new System.Drawing.Size(90, 30);
            this.btnAddWarehouse.TabIndex = 1;
            this.btnAddWarehouse.Text = "Add";
            this.btnAddWarehouse.UseVisualStyleBackColor = true;
            this.btnAddWarehouse.Click += new System.EventHandler(this.btnAddWarehouse_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(547, 364);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 30);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(451, 364);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Enabled = false;
            this.btnShowInfo.Location = new System.Drawing.Point(355, 364);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(90, 30);
            this.btnShowInfo.TabIndex = 4;
            this.btnShowInfo.Text = "ShowInfo";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(259, 364);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShowShortInfo
            // 
            this.btnShowShortInfo.Enabled = false;
            this.btnShowShortInfo.Location = new System.Drawing.Point(37, 364);
            this.btnShowShortInfo.Name = "btnShowShortInfo";
            this.btnShowShortInfo.Size = new System.Drawing.Size(120, 30);
            this.btnShowShortInfo.TabIndex = 6;
            this.btnShowShortInfo.Text = "ShowShortInfo";
            this.btnShowShortInfo.UseVisualStyleBackColor = true;
            this.btnShowShortInfo.Click += new System.EventHandler(this.btnShowShortInfo_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(643, 364);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 417);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShowShortInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddWarehouse);
            this.Controls.Add(this.listOfWarehouses);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddWarehouse;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.ListBox listOfWarehouses;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowShortInfo;
        private System.Windows.Forms.Button btnSave;
    }
}

