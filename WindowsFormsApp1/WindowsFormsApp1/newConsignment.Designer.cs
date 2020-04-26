namespace WindowsFormsApp1
{
    partial class NewConsignment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deliveryComboBox = new System.Windows.Forms.ComboBox();
            this.dateOfDeliveryPicker = new System.Windows.Forms.DateTimePicker();
            this.costOfTranspontationTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.countUpDown = new System.Windows.Forms.NumericUpDown();
            this.vegetableComboBox = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.countUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delivery:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vegetable:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of delivery:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cost of transportation:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Count:";
            // 
            // deliveryComboBox
            // 
            this.deliveryComboBox.FormattingEnabled = true;
            this.deliveryComboBox.Location = new System.Drawing.Point(210, 33);
            this.deliveryComboBox.Name = "deliveryComboBox";
            this.deliveryComboBox.Size = new System.Drawing.Size(200, 24);
            this.deliveryComboBox.TabIndex = 6;
            // 
            // dateOfDeliveryPicker
            // 
            this.dateOfDeliveryPicker.Location = new System.Drawing.Point(210, 120);
            this.dateOfDeliveryPicker.Name = "dateOfDeliveryPicker";
            this.dateOfDeliveryPicker.Size = new System.Drawing.Size(200, 22);
            this.dateOfDeliveryPicker.TabIndex = 7;
            // 
            // costOfTranspontationTextBox
            // 
            this.costOfTranspontationTextBox.Location = new System.Drawing.Point(210, 237);
            this.costOfTranspontationTextBox.Name = "costOfTranspontationTextBox";
            this.costOfTranspontationTextBox.Size = new System.Drawing.Size(200, 22);
            this.costOfTranspontationTextBox.TabIndex = 8;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(210, 197);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 22);
            this.priceTextBox.TabIndex = 9;
            // 
            // countUpDown
            // 
            this.countUpDown.Location = new System.Drawing.Point(210, 158);
            this.countUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.countUpDown.Name = "countUpDown";
            this.countUpDown.Size = new System.Drawing.Size(200, 22);
            this.countUpDown.TabIndex = 10;
            // 
            // vegetableComboBox
            // 
            this.vegetableComboBox.FormattingEnabled = true;
            this.vegetableComboBox.Location = new System.Drawing.Point(210, 77);
            this.vegetableComboBox.Name = "vegetableComboBox";
            this.vegetableComboBox.Size = new System.Drawing.Size(200, 24);
            this.vegetableComboBox.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(71, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(297, 318);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // NewConsignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 388);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.vegetableComboBox);
            this.Controls.Add(this.countUpDown);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.costOfTranspontationTextBox);
            this.Controls.Add(this.dateOfDeliveryPicker);
            this.Controls.Add(this.deliveryComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewConsignment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewConsigment";
            this.Load += new System.EventHandler(this.NewConsignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.ComboBox deliveryComboBox;
        internal System.Windows.Forms.DateTimePicker dateOfDeliveryPicker;
        internal System.Windows.Forms.TextBox costOfTranspontationTextBox;
        internal System.Windows.Forms.TextBox priceTextBox;
        internal System.Windows.Forms.NumericUpDown countUpDown;
        internal System.Windows.Forms.ComboBox vegetableComboBox;
    }
}