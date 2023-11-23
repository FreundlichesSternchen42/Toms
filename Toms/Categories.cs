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

        private void BtBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void changeColor()
        {
            categoryColor = Color.FromArgb(tbRed.Value, tbGreen.Value, tbBlue.Value);
            pbColorView.BackColor = categoryColor;
        }

        private void tbRed_Scroll(object sender, EventArgs e)
        {
            changeColor();
        }

        private void tbGreen_Scroll(object sender, EventArgs e)
        {
            changeColor();
        }

        private void tbBlue_Scroll(object sender, EventArgs e)
        {
            changeColor();
        }

        private void btSafe_Click(object sender, EventArgs e)
        {
            Categories cat = new Categories();
            cat.categoryName = tbName.Text;
            cat.categoryColor = categoryColor;
            Safe.savedCategories.AddLast(cat);
        }
    }
}
