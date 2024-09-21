namespace WinFormsApp2
{
    partial class Table
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
            tableNumberTextBox = new TextBox();
            tableStateComboBox = new ComboBox();
            deleteButton_Click = new Button();
            addButton = new Button();
            updateButton_Click = new Button();
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
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 568);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
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
            button2.Click += button2_Click;
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
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(tableNumberTextBox);
            panel2.Controls.Add(tableStateComboBox);
            panel2.Controls.Add(deleteButton_Click);
            panel2.Controls.Add(addButton);
            panel2.Controls.Add(updateButton_Click);
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
            label2.Size = new Size(106, 28);
            label2.TabIndex = 9;
            label2.Text = "Table State";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 439);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 8;
            label1.Text = "Table Number";
            // 
            // tableNumberTextBox
            // 
            tableNumberTextBox.Location = new Point(171, 439);
            tableNumberTextBox.Name = "tableNumberTextBox";
            tableNumberTextBox.Size = new Size(125, 27);
            tableNumberTextBox.TabIndex = 7;
            // 
            // tableStateComboBox
            // 
            tableStateComboBox.FormattingEnabled = true;
            tableStateComboBox.Items.AddRange(new object[] { "Full", "Empty" });
            tableStateComboBox.Location = new Point(448, 438);
            tableStateComboBox.Name = "tableStateComboBox";
            tableStateComboBox.Size = new Size(151, 28);
            tableStateComboBox.TabIndex = 6;
            // 
            // deleteButton_Click
            // 
            deleteButton_Click.Font = new Font("Raleway SemiBold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton_Click.Location = new Point(448, 501);
            deleteButton_Click.Name = "deleteButton_Click";
            deleteButton_Click.Size = new Size(143, 45);
            deleteButton_Click.TabIndex = 5;
            deleteButton_Click.Text = "Delete";
            deleteButton_Click.UseVisualStyleBackColor = true;
            deleteButton_Click.Click += button5_Click;
            // 
            // addButton
            // 
            addButton.Font = new Font("Raleway SemiBold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.Location = new Point(235, 501);
            addButton.Name = "addButton";
            addButton.Size = new Size(143, 45);
            addButton.TabIndex = 4;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // updateButton_Click
            // 
            updateButton_Click.Font = new Font("Raleway SemiBold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            updateButton_Click.Location = new Point(23, 501);
            updateButton_Click.Name = "updateButton_Click";
            updateButton_Click.Size = new Size(143, 45);
            updateButton_Click.TabIndex = 3;
            updateButton_Click.Text = "Update";
            updateButton_Click.UseVisualStyleBackColor = true;
            updateButton_Click.Click += updateButton_Click_Click;
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
            // Table
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 570);
            Controls.Add(panel1);
            Name = "Table";
            Text = "Tables";
            Load += Table_Load;
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
        private Label label2;
        private Label label1;
        private TextBox tableNumberTextBox;
        private ComboBox tableStateComboBox;
        private Button deleteButton_Click;
        private Button addButton;
        private Button updateButton_Click;
        private DataGridView dataGridView1;
    }
}