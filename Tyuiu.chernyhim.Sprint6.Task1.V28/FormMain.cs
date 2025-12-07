using Tyuiu.chernyhim.Sprint6.Task1.V28.Lib;
namespace Tyuiu.chernyhim.Sprint6.Task1.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();


        private void buttonDone_Click_1(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(StartTextBox.Text);
                int stop = Convert.ToInt32(StopTextBox.Text);

                string str;

                int len = ds.GetMassFunction(start, stop).Length;

                double[] valuearray = new double[len];

                valuearray = ds.GetMassFunction(start, stop);

                textBoxresult.Text = "";
                textBoxresult.AppendText("    X      f(x)   " + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

      
    }
}
