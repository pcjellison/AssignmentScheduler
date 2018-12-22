using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentScheduler
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void CreateAssignmentBtn_Click(object sender, EventArgs e)
        {
            CreateAssignmentForm createAssign = new CreateAssignmentForm();
            createAssign.Show();
        }
    }
}
