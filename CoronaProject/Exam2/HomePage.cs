using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam2
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            Learn lf = new Learn();
            lf.Show();
            this.Hide();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            Game gform = new Game(txtBoxName.Text);
            gform.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddInstructions addForm = new AddInstructions();
            addForm.Show();
            this.Hide();
        }
    }
}
