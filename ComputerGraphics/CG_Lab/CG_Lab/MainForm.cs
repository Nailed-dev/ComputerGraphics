using CG_Lab.Lab1;


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
            LaboratoryCG1 laboratoryCG1 = new LaboratoryCG1();
            laboratoryCG1.Show();
        }
    }
}
