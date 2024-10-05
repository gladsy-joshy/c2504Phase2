namespace Example2Project
{
    public partial class MainPageForm : Form
    {
        public MainPageForm()
        {
            InitializeComponent();
        }
        private SumCalcForm frmSumCalc = new SumCalcForm();
        private SquareCalcForm frmSquareCalc = new SquareCalcForm();
        private SalaryPage frmSalary = new SalaryPage();
        private ContactList frmContactList = new ContactList();
        private NewContact frmNewContact = new NewContact();


        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainPageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void mnuCalc_Click(object sender, EventArgs e)
        {

        }

        private void mnuSumCalc_Click(object sender, EventArgs e)
        {
            frmSumCalc.MdiParent = this;
            frmSumCalc.Show();
            frmSumCalc.Activate();

        }

        private void mnuSal_Click(object sender, EventArgs e)
        {
            frmSalary.MdiParent = this;
            frmSalary.Show();
            frmSalary.Activate();

        }

        private void mnuContact_Click(object sender, EventArgs e)
        {

        }

        private void mnuNewContact_Click(object sender, EventArgs e)
        {
            frmNewContact.MdiParent = this;
            frmNewContact.Show();
            frmNewContact.Activate();

        }

        private void mnuContactList_Click(object sender, EventArgs e)
        {
            frmContactList.MdiParent = this;
            frmContactList.Show();
            frmContactList.Activate();
        }

        private void mnuSquareCalc_Click(object sender, EventArgs e)
        {
            frmSquareCalc.MdiParent = this;
            frmSquareCalc.Show();
            frmSquareCalc.Activate();
        }
    }
}
