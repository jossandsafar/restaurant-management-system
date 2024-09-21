using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.Model;

namespace WinFormsApp2
{
    public partial class MealType : Form
    {
        RestaurantDbContext db;
        public MealType(RestaurantDbContext dbContext)
        {
            db = dbContext;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the Id of the selected row
                if (selectedRow.Cells["Id"].Value is int id)
                {
                    // Find the Table entity with the corresponding Id
                    var tableToUpdate = db.MealTypes.Find(id);

                    if (tableToUpdate != null)
                    {
                        // Get the updated values from the text box and combo box
                        if (int.TryParse(OrderNumber.Text, out int orderNumber))
                        {
                            tableToUpdate.OrderNumber = orderNumber;
                        }
                        else
                        {
                            MessageBox.Show("Invalid table number.");
                            return;
                        }

                        string ordertype = OrderType.SelectedItem.ToString();
                        tableToUpdate.OrderType = ordertype;

                        // Update the Table entity in the DbContext and save changes
                        db.MealTypes.Update(tableToUpdate);
                        db.SaveChanges();

                        // Refresh the DataGridView to reflect the changes
                        dataGridView1.DataSource = db.MealTypes.ToList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table tb = new Table(db);
            tb.Show();
            this.Hide();
        }

        private void MealType_Load(object sender, EventArgs e)
        {
            using (var dbContext = new RestaurantDbContext())
            {
                var meal = db.MealTypes.ToList();
                dataGridView1.DataSource = meal;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(OrderNumber.Text) && OrderType.SelectedItem != null)
            {
                using (var dbContext = new RestaurantDbContext())
                {
                    // Get the table number from the textbox
                    if (!int.TryParse(OrderNumber.Text, out int ordernumber))
                    {
                        MessageBox.Show("Invalid table number.");
                        return;
                    }

                    // Get the table state from the combobox
                    string ordertype = OrderType.SelectedItem.ToString();



                    var newMealType = new Model.MealType
                    {
                        OrderNumber = ordernumber,
                        OrderType = ordertype
                    };



                    dbContext.MealTypes.Add(newMealType);
                    dbContext.SaveChanges();

                    // Refresh the DataGridView to show the newly added record
                    dataGridView1.DataSource = dbContext.MealTypes.ToList();
                }
            }
            else
            {
                MessageBox.Show("One or more controls are not initialized.");
            }
        }

        private void DeleteOrder_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the Id of the selected row
                if (selectedRow.Cells["Id"].Value is int id)
                {
                    // Find the Table entity with the corresponding Id
                    var tableToDelete = db.MealTypes.Find(id);

                    if (tableToDelete != null)
                    {
                        // Remove the Table entity from the DbContext and save changes
                        db.MealTypes.Remove(tableToDelete);
                        db.SaveChanges();

                        // Refresh the DataGridView to reflect the changes
                        dataGridView1.DataSource = db.MealTypes.ToList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}
