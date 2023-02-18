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
    public partial class AddInstructions : Form
    {
        public AddInstructions()
        {
            InitializeComponent();
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            AddInfo addiForm = new AddInfo();
            addiForm.Show();
            this.Hide();
            this.Dispose();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            AddQuestion addqForm = new AddQuestion();
            addqForm.Show();
            this.Hide();
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnHp_Click(object sender, EventArgs e)
        {
            HomePage hm = new HomePage();
            hm.Show();
            this.Hide();
        }
    }
}
