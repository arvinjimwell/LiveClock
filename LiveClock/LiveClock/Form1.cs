
namespace LiveClock
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer t = null!;
        public Form1()
        {
            InitializeComponent();
            StartTimer();
        }

        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 500;
            t.Tick += new EventHandler(FillLabelBox!);
            t.Enabled = true;
        }

        private void FillLabelBox(object sender, EventArgs e)
        {
            string Time = DateTime.Now.ToString("hh:mmtt");
            HourBox.Text = Time.Substring(0, 2);
            MinuteBox.Text = Time.Substring(3, 2);
            MeridiemBox.Text = Time.Substring(5, 2);
        }

    }
}