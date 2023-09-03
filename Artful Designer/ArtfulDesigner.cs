namespace Artful_Designer
{
    public partial class ArtfulDesigner : Form
    {
        public ArtfulDesigner()
        {
            InitializeComponent();
        }

        private void ArtfulDesigner_Load(object sender, EventArgs e)
        {
            labelBox1.BackColor = Color.LightCyan;
            labelBox2.BackColor = SystemColors.ButtonHighlight;
            labelBox3.BackColor = SystemColors.ButtonHighlight;
            labelBox2.BackColor = SystemColors.ButtonHighlight;

            labelBox1.Visible = false;
            labelBox2.Visible = false;
            labelBox3.Visible = false;
            labelBox4.Visible = false;

            buttonNextBox1.Visible = false;
            buttonNextBox2.Visible = false;
            buttonNextBox3.Visible = false;
            buttonNextBox4.Visible = false;

            buttonBackBox1.Visible = false;
            buttonBackBox2.Visible = false;
            buttonBackBox3.Visible = false;
            buttonBackBox4.Visible = false;

            buttonStartOver.Visible = false;
        }

        private void buttonLetsGo_Click(object sender, EventArgs e)
        {
            labelBox1.Visible = true;
            labelBox2.Visible = true;
            labelBox3.Visible = true;
            labelBox4.Visible = true;

            buttonLetsGo.Visible = false;

            buttonNextBox1.Visible = true;
            buttonBackBox1.Visible = true;

            labelWelcome.Text = "\r\n\r\n   \r\n\r\n\r\n   This is BOX 1 \r\n\r\n   ";
        }

        private void ButtonBackBox1_Click(object sender, EventArgs e)
        {
            labelBox1.Visible = false;
            labelBox2.Visible = false;
            labelBox3.Visible = false;
            labelBox4.Visible = false;

            buttonLetsGo.Visible = true;
            buttonNextBox1.Visible = false;
            buttonBackBox1.Visible = false;

            labelWelcome.Text = "\r\n\r\n   \r\n\r\n\r\n   Hello, I'm Arti! \r\n\r\n   I'm here to welcome you to our humble application, which allows you to create an unlimited number\r\n   of images for your projects or social media by following a predefined text file. \r\n\r\n   From it, we will create what's expected - beautiful images that will align with your design vision. We'll walk \r\n   through the program in four steps, and during each one, you'll need to select specific settings.\r\n\r\n   On the final step, after clicking the 'Generate' button, you'll be able to save the files you've created. \r\n\r\n\r\n   We look forward to having fun together. \r\n\r\n   Good luck!\r\n";
        }

        private void ButtonBackBox2_Click(object sender, EventArgs e)
        {
            buttonNextBox1.Visible = true;
            buttonNextBox2.Visible = false;

            buttonBackBox1.Visible = true;
            buttonBackBox2.Visible = false;

            labelBox1.BackColor = Color.LightCyan;
            labelBox2.BackColor = SystemColors.ButtonHighlight;


            labelWelcome.Text = "\r\n\r\n   \r\n\r\n\r\n   This is BOX 1 \r\n\r\n   ";
        }

        private void ButtonBackBox3_Click(object sender, EventArgs e)
        {
            buttonNextBox2.Visible = true;
            buttonNextBox3.Visible = false;

            buttonBackBox2.Visible = true;
            buttonBackBox3.Visible = false;

            labelBox2.BackColor = Color.LightCyan;
            labelBox3.BackColor = SystemColors.ButtonHighlight;

            labelWelcome.Text = "\r\n\r\n   \r\n\r\n\r\n   This is BOX 2 \r\n\r\n   ";
        }

        private void ButtonBackBox4_Click(object sender, EventArgs e)
        {
            buttonNextBox3.Visible = true;
            buttonNextBox4.Visible = false;

            buttonBackBox3.Visible = true;
            buttonBackBox4.Visible = false;

            labelBox3.BackColor = Color.LightCyan;
            labelBox4.BackColor = SystemColors.ButtonHighlight;

            labelWelcome.Text = "\r\n\r\n   \r\n\r\n\r\n   This is BOX 3 \r\n\r\n   ";
        }

        private void ButtonNextBox1_Click(object sender, EventArgs e)
        {
            buttonNextBox1.Visible = false;
            buttonNextBox2.Visible = true;

            buttonBackBox1.Visible = false;
            buttonBackBox2.Visible = true;

            labelBox1.BackColor = Color.Gainsboro;
            labelBox2.BackColor = Color.LightCyan;

            labelWelcome.Text = "\r\n\r\n   \r\n\r\n\r\n   This is BOX 2 \r\n\r\n   ";
        }

        private void ButtonNextBox2_Click(object sender, EventArgs e)
        {
            buttonNextBox2.Visible = false;
            buttonNextBox3.Visible = true;

            buttonBackBox2.Visible = false;
            buttonBackBox3.Visible = true;

            labelBox2.BackColor = Color.Gainsboro;
            labelBox3.BackColor = Color.LightCyan;

            labelWelcome.Text = "\r\n\r\n   \r\n\r\n\r\n   This is BOX 3 \r\n\r\n   ";
        }

        private void ButtonNextBox3_Click(object sender, EventArgs e)
        {
            buttonNextBox3.Visible = false;
            buttonNextBox4.Visible = true;

            buttonBackBox3.Visible = false;
            buttonBackBox4.Visible = true;

            labelBox3.BackColor = Color.Gainsboro;
            labelBox4.BackColor = Color.LightCyan;

            labelWelcome.Text = "\r\n\r\n   \r\n\r\n\r\n   This is BOX 4 \r\n\r\n   ";
        }

        private void ButtonNextBox4_Click(object sender, EventArgs e)
        {
            labelBox1.Visible = false;
            labelBox2.Visible = false;
            labelBox3.Visible = false;
            labelBox4.Visible = false;

            buttonNextBox1.Visible = false;
            buttonNextBox2.Visible = false;
            buttonNextBox3.Visible = false;
            buttonNextBox4.Visible = false;

            buttonBackBox1.Visible = false;
            buttonBackBox2.Visible = false;
            buttonBackBox3.Visible = false;
            buttonBackBox4.Visible = false;

            buttonStartOver.Visible = true;

            labelWelcome.Height = 185;

            labelWelcome.Text = "\r\n\r\n   \r\n\r\n\r\n   Your files have been generated successfully. You can locate them in the specified folder. \r\n\r\n   ";

            //generate logic here
        }

        private void buttonStartOver_Click(object sender, EventArgs e)
        {
            // Create a new instance of the current form
            ArtfulDesigner newLoad = new ArtfulDesigner();

            // Hide the current form
            this.Hide();

            // Show the new form
            newLoad.ShowDialog();

            // Close the current form
            this.Close();
        }
    }
}