using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        public Color categoryColor { get; set; }
        public string categoryName { get; set; }
        public string action { get; set; }
        public bool DeleteFlag { get; set; }


        private void BtBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void changeColor()
        {
            categoryColor = Color.FromArgb(trbRed.Value, trbGreen.Value, trbBlue.Value);
            pbColorView.BackColor = categoryColor;
        }

        // Methoden, falls jemand die Trackbar benutzt
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

        // Speichermethode
        private void btSafe_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                if(Calendar.getCategoryofName(tbName.Text) != null)
                {
                    MessageBox.Show("The name of your category is already given.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Categories cat = new Categories();
                    cat.categoryName = tbName.Text;
                    cat.categoryColor = categoryColor;
                    DataLoader.savedCategories.AddLast(cat);
                    cat.action = "create category";
                    DataLoader.everythingYouEverDidOnThisProject.Push(cat);
                    MessageBox.Show("Your category has been created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("The category has no name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Benutzerrückmeldung
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

        // Feature: Trackbar updatet sich automatisch bei Zahleingabe
        private void tbGreen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trbGreen.Value = limitInt(Int32.Parse(tbGreen.Text), 0, 255);
            }
            catch (FormatException)
            {
            }
        }

        private void tbBlue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trbBlue.Value = limitInt(Int32.Parse(tbBlue.Text), 0, 255);
            }
            catch (FormatException)
            { 
            }
        }

        private void tbRed_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trbRed.Value = limitInt(Int32.Parse(tbRed.Text), 0, 255);
            }
            catch (FormatException)
            {
            }
        }

        /// <summary>
        /// Methode um einen Wert ein Minimum und Maximum zu geben
        /// </summary>
        /// <returns></returns>
        public int limitInt(int value, int min, int max)
        {
            if (value < min)
	        {
                return min;
	        }
            else if (value <= max)
            {
                return value;
            }
            else
            {
                return max;
            }
        }

        // STRG+Z für Undo-Feature
        private void Categories_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                Popup.navigateUndo();
            }
        }
        
        // Undo-Befehle für alle Kategorien
        public static void undoCategory(object lastModification)
        {
            if (lastModification != null)
            {
                if (lastModification.GetType() == typeof(Categories))
                {
                    Categories cat = (Categories)lastModification;
                    if (cat.action == "create category")
                    {
                        MessageBox.Show("Undo: Your Category: '" + cat.categoryName + "' was successfully deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataLoader.savedCategories.Remove(cat);                    }
                    else if (cat.action == "delete category")
                    {
                        MessageBox.Show("Undo: Your Category: '" + cat.categoryName + "' was successfully recreated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataLoader.savedCategories.AddLast(cat); 
                    }
                } 
            }
        }

        // Kategorie löschen
        private void btDeleteC_Click(object sender, EventArgs e)
        {
            if (Calendar.getCategoryofName(tbName.Text) != null)
            {
                Categories cat = Calendar.getCategoryofName(tbName.Text);
                cat.action = "delete category";
                DataLoader.everythingYouEverDidOnThisProject.Push(cat);
                DataLoader.savedCategories.Remove(Calendar.getCategoryofName(tbName.Text));
                MessageBox.Show("Your Category: '" + tbName.Text + "' was successfully deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                MessageBox.Show("No Category with the name: '" + tbName.Text + "' found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
