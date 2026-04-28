using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CG_Lab.Lab1;
using CG_Lab.Lab3;

namespace CG_Lab.Lab3
{
    public partial class Lab3Choice : Form
    {
        public Lab3Choice()
        {
            InitializeComponent();
        }

        private void MainLabButton_Click(object sender, EventArgs e)
        {
            LaboratoryCG3 laboratoryCG3 = new LaboratoryCG3();
            laboratoryCG3.Show();
        }

        private void CosmosButton_Click(object sender, EventArgs e)
        {
            cosmos.Cosmos cosmos = new cosmos.Cosmos();
            cosmos.Show();
        }
        
        private void BicycleButton_Click(Object sender, EventArgs e)
        {
           
        }
    }
}
