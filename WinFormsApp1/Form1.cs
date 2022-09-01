namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateSalary_Click(object sender, EventArgs e)
        {
            double hourlywage = Convert.ToDouble(tbxHourlyWage.Text);
            double weeklywage = hourlywage * 40;
            double grosssalary = weeklywage * 52;
            lblGross.Text = grosssalary.ToString("C");
            double taxrate = Convert.ToDouble(tbxTaxRate.Text) / 100 + 1;
            double aftertax = grosssalary / taxrate;
            lblAfterTax.Text = aftertax.ToString("C");
            
        }

        private void btnCalcJointSalary_Click(object sender, EventArgs e)
        {
            double hourlywage = Convert.ToDouble(tbxHourlyWage.Text);
            double weeklywage = hourlywage * Convert.ToDouble(tbxHrs1.Text);
            double grosssalary = weeklywage * 52;
            lblGross.Text = grosssalary.ToString("C");
            double taxrate = (Convert.ToDouble(tbxTaxRate.Text) / 100) + 1;
            double aftertax = grosssalary / taxrate;
            lblAfterTax.Text = aftertax.ToString("C");

            double hourlywage2 = Convert.ToDouble(tbxHrlyWg2.Text);
            double weeklywage2 = hourlywage2 * Convert.ToDouble(tbxHrs2.Text);
            double grosssalary2 = weeklywage2 * 52;
            lblGross2.Text = grosssalary2.ToString("C");
            double aftertax2 = grosssalary2 / taxrate;
            lblAftrTax2.Text = aftertax2.ToString("C");

            double hourlywageCombined = Convert.ToDouble(tbxHourlyWage.Text) + Convert.ToDouble(tbxHrlyWg2.Text);
            double weeklywageCombined = hourlywageCombined * Convert.ToDouble(tbxHrs1.Text) + Convert.ToDouble(tbxHrs2.Text);
            double grosssalaryCombined = weeklywageCombined * 52;
            lblGrossCombined.Text = grosssalaryCombined.ToString("C");
            double aftertaxCombined = grosssalaryCombined / taxrate;
            lblAfterTaxCombined.Text = aftertaxCombined.ToString("C");
        }
    }
}