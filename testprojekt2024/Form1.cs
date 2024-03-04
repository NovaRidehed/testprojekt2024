using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace testprojekt2024
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Hej ";
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void throwdicebutton_Click(object sender, EventArgs e)
        {
            rand.Next(1,6);
            int dice1 = rand.Next(1, 7);
            int dice2 = rand.Next(1, 7);
            int dice3 = rand.Next(1, 7);
            int dice4 = rand.Next(1, 7);
            int dice5 = rand.Next(1, 7);
            
            textBox2.Text = dice1 + " " + dice2 + " " + dice3 + " " + dice4 + " " + dice5; 
        }
    }
}