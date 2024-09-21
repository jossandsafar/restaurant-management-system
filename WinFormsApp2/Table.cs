using Microsoft.EntityFrameworkCore;
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
    public partial class Table : Form
    {
        RestaurantDbContext db;

        public Table(RestaurantDbContext dbContext)
        {
            db = dbContext;
            InitializeComponent();
        }



        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Table_Load(object sender, EventArgs e)
        {
            using (var dbContext = new RestaurantDbContext())
            {
                var tables = db.Table.ToList();
                dataGridView1.DataSource = tables;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(tableNumberTextBox.Text) && tableStateComboBox.SelectedItem != null)
            {
                using (var dbContext = new RestaurantDbContext())
                {
                    // Get the table number from the textbox
                    if (!int.TryParse(tableNumberTextBox.Text, out int tableNumber))
                    {
                        MessageBox.Show("Invalid table number.");
                        return;
                    }

                    // Get the table state from the combobox
                    string tableState = tableStateComboBox.SelectedItem.ToString();



                    var newTable = new Model.Table
                    {
                        TableNumber = tableNumber,
                        TableState = tableState
                    };



                    dbContext.Table.Add(newTable);
                    dbContext.SaveChanges();

                    // Refresh the DataGridView to show the newly added record
                    dataGridView1.DataSource = dbContext.Table.ToList();
                }
            }
            else
            {
                MessageBox.Show("One or more controls are not initialized.");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the Id of the selected row
                if (selectedRow.Cells["Id"].Value is int id)
                {
                    // Find the Table entity with the corresponding Id
                    var tableToDelete = db.Table.Find(id);

                    if (tableToDelete != null)
                    {
                        // Remove the Table entity from the DbContext and save changes
                        db.Table.Remove(tableToDelete);
                        db.SaveChanges();

                        // Refresh the DataGridView to reflect the changes
                        dataGridView1.DataSource = db.Table.ToList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void updateButton_Click_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the Id of the selected row
                if (selectedRow.Cells["Id"].Value is int id)
                {
                    // Find the Table entity with the corresponding Id
                    var tableToUpdate = db.Table.Find(id);

                    if (tableToUpdate != null)
                    {
                        // Get the updated values from the text box and combo box
                        if (int.TryParse(tableNumberTextBox.Text, out int tableNumber))
                        {
                            tableToUpdate.TableNumber = tableNumber;
                        }
                        else
                        {
                            MessageBox.Show("Invalid table number.");
                            return;
                        }

                        string tableState = tableStateComboBox.SelectedItem.ToString();
                        tableToUpdate.TableState = tableState;

                        // Update the Table entity in the DbContext and save changes
                        db.Table.Update(tableToUpdate);
                        db.SaveChanges();

                        // Refresh the DataGridView to reflect the changes
                        dataGridView1.DataSource = db.Table.ToList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          MealType MT = new MealType(db);
            MT.Show();
          
            this.Hide();
        }
    }

}
