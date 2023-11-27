using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toms
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        public Color categoryColor;
        public string categoryName;
        public string action;

        private void BtBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void changeColor()
        {
            categoryColor = Color.FromArgb(trbRed.Value, trbGreen.Value, trbBlue.Value);
            pbColorView.BackColor = categoryColor;
        }

        private void trbRed_Scroll(object sender, EventArgs e)
        {
            changeColor();
            tbRed.Text = trbRed.Value.ToString();
        }

        private void trbGreen_Scroll(object sender, EventArgs e)
        {
            changeColor();
            tbGreen.Text = trbGreen.Value.ToString();
        }

        private void trbBlue_Scroll(object sender, EventArgs e)
        {
            changeColor();
            tbBlue.Text = trbBlue.Value.ToString();
        }

        private void btSafe_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                Categories cat = new Categories();
                cat.categoryName = tbName.Text;
                cat.categoryColor = categoryColor;
                Popup.savedCategories.AddLast(cat);
                cat.action = "create category";
                Popup.everythingYouEverDidOnThisProject.Push(cat);
                MessageBox.Show("Your category has been created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tmUpdate_Tick(object sender, EventArgs e)
        {

            if (tbName.Text == "")
            { 
                btSafeC.Text = "Error: Name is needed!";
            }
            else if (Calendar.getCategoryofName(tbName.Text) != null || tbName.Text == "Default")
            {
                btSafeC.Text = "Error: Known name!";;
            }
            else
            {
                btSafeC.Text = "Save Category";
            }
        }

        private void tbGreen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trbGreen.Value = limitInt(Int32.Parse(tbGreen.Text), 255);
            }
            catch (FormatException)
            {
            }
        }

        private void tbBlue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trbBlue.Value = limitInt(Int32.Parse(tbBlue.Text), 255);
            }
            catch (FormatException)
            { 
            }
        }

        private void tbRed_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trbRed.Value = limitInt(Int32.Parse(tbRed.Text), 255);
            }
            catch (FormatException)
            {
            }
        }

        public int limitInt(int value, int max)
        {
            if (value <= max)
            {
                return value;
            }
            else
            {
                return max;
            }
        }

        private void Categories_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                object lastModification = Popup.everythingYouEverDidOnThisProject.Pop();
                if (lastModification != null)
                {
                    if (lastModification.GetType() == typeof(Categories))
                    {
                        Categories cat = (Categories)lastModification;
                        if (cat.action == "create category")
                        {
                            Popup.savedCategories.Remove(cat);
                            btSafeC.Text = "last Category deleted";
                        }
                    } 
                }
            }
        }

        private void btDeleteC_Click(object sender, EventArgs e)
        {
         
            Popup.savedCategories.Remove(Calendar.getCategoryofName(tbName.Text));
            MessageBox.Show("Your Category: " + tbName.Text + " has been deleted!", "Message" , MessageBoxButtons.OK, MessageBoxIcon.Information);  
        }
    }
}
