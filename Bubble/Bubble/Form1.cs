namespace Bubble
{
    public partial class Form1 : Form
    {
        List<Bubbles> bubblelist = new List<Bubbles>();
        string[] backgrounds = { "01.jpg", "02.jpg", "03.jpg", "04.jpg", "05.jpg" };
        int backgroundNumber = 0;
        Random random = new Random();
        Image background; 
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint
                |ControlStyles.OptimizedDoubleBuffer
                |ControlStyles.UserPaint, true);
            background = Image.FromFile("image/"
                + backgrounds[backgroundNumber]);
            MakeBubbles();
        }

        private void ParticleTimerEvent(object sender, EventArgs e)
        {

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

        }

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {

        }
        public void MakeBubbles() 
        {
            
        }
    }
}