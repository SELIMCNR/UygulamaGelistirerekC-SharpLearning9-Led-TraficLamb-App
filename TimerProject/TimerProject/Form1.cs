namespace TimerProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac == 1)
            {
                label2.Text = "Led";
                this.BackColor = Color.PeachPuff;
            }
            if (sayac == 9)
            {
                this.BackColor = Color.Red;
                sayac = 10;
                label2.Text = "Trafik lambasý";
            }
         
            if (sayac == 10 || sayac == 49)
            {
                this.BackColor = Color.Red;
            }
            if (sayac == 50 || sayac == 59)
            {
                this.BackColor = Color.Yellow;
            }
           if (sayac == 60 || sayac == 90)
            {
                this.BackColor = Color.Green;
               
            }
           if(sayac == 91)
            {
                sayac = 0;
            }
        }
    }
}