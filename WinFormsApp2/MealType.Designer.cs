namespace WinFormsApp2
{
    partial class MealType
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            OrderNumber = new TextBox();
            OrderType = new ComboBox();
            DeleteOrder = new Button();
            button4 = new Button();
            UpdateOrder = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-7, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 568);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new Font("Raleway SemiBold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(13, 280);
            button2.Name = "button2";
            button2.Size = new Size(143, 45);
            button2.TabIndex = 2;
            button2.Text = "MealType";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Raleway SemiBold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(13, 161);
            button1.Name = "button1";
            button1.Size = new Size(143, 45);
            button1.TabIndex = 0;
            button1.Text = "Tables";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(OrderNumber);
            panel2.Controls.Add(OrderType);
            panel2.Controls.Add(DeleteOrder);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(UpdateOrder);
            panel2.Controls.Add(dataGridView1);
            panel2.ForeColor = SystemColors.Highlight;
            panel2.Location = new Point(182, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(633, 565);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(325, 438);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 9;
            label2.Text = "Order Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 439);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 8;
            label1.Text = "Order Number";
            // 
            // OrderNumber
            // 
            OrderNumber.Location = new Point(171, 439);
            OrderNumber.Name = "OrderNumber";
            OrderNumber.Size = new Size(125, 27);
            OrderNumber.TabIndex = 7;
            // 
            // OrderType
            // 
            OrderType.FormattingEnabled = true;
            OrderType.Items.AddRange(new object[] { "By Phone", "In Person", "App order" });
            OrderType.Location = new Point(448, 438);
            OrderType.Name = "OrderType";
            OrderType.Size = new Size(151, 28);
            OrderType.TabIndex = 6;
            // 
            // DeleteOrder
            // 
            DeleteOrder.Font = new Font("Raleway SemiBold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteOrder.Location = new Point(456, 501);
            DeleteOrder.Name = "DeleteOrder";
            DeleteOrder.Size = new Size(143, 45);
            DeleteOrder.TabIndex = 5;
            DeleteOrder.Text = "Delete";
            DeleteOrder.UseVisualStyleBackColor = true;
            DeleteOrder.Click += DeleteOrder_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Raleway SemiBold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(235, 501);
            button4.Name = "button4";
            button4.Size = new Size(143, 45);
            button4.TabIndex = 4;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // UpdateOrder
            // 
            UpdateOrder.Font = new Font("Raleway SemiBold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateOrder.Location = new Point(23, 501);
            UpdateOrder.Name = "UpdateOrder";
            UpdateOrder.Size = new Size(143, 45);
            UpdateOrder.TabIndex = 3;
            UpdateOrder.Text = "Update";
            UpdateOrder.UseVisualStyleBackColor = true;
            UpdateOrder.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(617, 415);
            dataGridView1.TabIndex = 0;
            // 
            // MealType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 581);
            Controls.Add(panel1);
            Name = "MealType";
            Text = "MealType";
            Load += MealType_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Button DeleteOrder;
        private Button button4;
        private Button UpdateOrder;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private TextBox OrderNumber;
        private ComboBox OrderType;
    }
}