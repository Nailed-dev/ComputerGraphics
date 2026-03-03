using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Lab.Lab1
{
    public partial class LaboratoryCG1 : Form
    {
        public LaboratoryCG1()
        {
            InitializeComponent();
        }

        public LaboratoryCG1(MainForm form1)
        {
            InitializeComponent();
        }

        private void MatrixCalculate_Click(object sender, EventArgs e)
        {
            MatrixCalculate matrixCalculate = new MatrixCalculate();
            matrixCalculate.Show();
        }

        private void LaboratoryCG1_Load(object sender, EventArgs e)
        {

        }

        private void Andrey_Click(object sender, EventArgs e)
        {
            AndreySuchilin andreySuchilin = new AndreySuchilin();
            andreySuchilin.Show();
        }
        private void Artem_Click(object sender, EventArgs e)
        {
            ArtemZemlyanskiy artemZemlyanskiy = new ArtemZemlyanskiy();
            artemZemlyanskiy.Show();
        }


    }
}
