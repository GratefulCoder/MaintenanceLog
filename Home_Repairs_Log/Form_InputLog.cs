using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;


namespace RepairLog
{
    public partial class Form_InputLog : Form
    {
        public Form_InputLog()
        {
            InitializeComponent();
        }

        private void textBox_Cost_Leave(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(textBox_Cost.Text, out value))
                textBox_Cost.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            else
                textBox_Cost.Text = String.Empty;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (validate_Form(sender))
            {
      
                DatabaseManager.InsertDataIntoTable(textBox_ItemRepaired, dateTimePicker1, textBox_Cost, textBox_Store, textBox_Description);
            }


        }

        private bool validate_Form(object sender)
        {
            if (this.textBox_ItemRepaired.TextLength == 0)
            {
                MessageBox.Show("Please enter a value for the " + label_ItemRepaired.Text + " field.");
                this.textBox_ItemRepaired.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(dateTimePicker1.Value.ToString()))
            {
                MessageBox.Show("Please enter a value for the " + label_Date.Text + " field.");
                this.dateTimePicker1.Focus();
                return false;
            }
            if (this.textBox_Cost.TextLength == 0)
            {
                MessageBox.Show("Please enter a value for the " + label_Cost.Text + " field.");
                this.textBox_Cost.Focus();
                return false;
            }
            if (this.textBox_Store.TextLength == 0)
            {
                MessageBox.Show("Please enter a value for the " + label_Store.Text + " field.");
                this.textBox_Store.Focus();
                return false;
            }
            if (this.textBox_Description.TextLength == 0)
            {
                MessageBox.Show("Please enter a value for the " + label_Description.Text + " field.");
                this.textBox_Description.Focus();
                return false;
            }
            return true;
        }

        private void resetFormFields()
        {
            textBox_ItemRepaired.ResetText();
            dateTimePicker1.ResetText();
            textBox_Cost.ResetText();
            textBox_Store.ResetText();
            textBox_Description.ResetText();

        }
    }

}
