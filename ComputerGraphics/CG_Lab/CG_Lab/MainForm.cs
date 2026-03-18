using CG_Lab.Lab1;
using CG_Lab.Lab2;


namespace CG_Lab
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LabButton1_Click(object sender, EventArgs e)
        {
            LaboratoryCG1 lab1 = new LaboratoryCG1();
            lab1.FormClosed += (s, args) =>
            {
                this.Show(); 
            };

            this.Hide(); 
            lab1.Show();
        }

        private void LabButton2_Click(object sender, EventArgs e)
        {
            LaboratoryCG2 lab2 = new LaboratoryCG2();
            lab2.FormClosed += (s, args) =>
            {
                this.Show(); 
            };

            this.Hide(); 
            lab2.Show();
        }


    }
}
