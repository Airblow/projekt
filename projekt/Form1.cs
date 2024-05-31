namespace projekt
{
    public partial class startPage : Form
    {
        public startPage()
        {
            InitializeComponent();
        }

        void start_Click(object sender, EventArgs e)
        {
            subjectPage subjectPage = new subjectPage();
            utility.SpawnForm(this, subjectPage);

        }
    }
}