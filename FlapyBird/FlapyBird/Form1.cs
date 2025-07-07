namespace FlapyBird
{
    public partial class Form1 : Form
    {
        int pipespeed = 13;
        int gravity = 10;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            flappy.Top += gravity;
            pipe_up.Left -= pipespeed;
            pipe_down.Left -= pipespeed;
            lb_score.Text = "Score:" + score;

            if (pipe_up.Left < -150)
            {
                pipe_up.Left = 800;
                score++;
            }

            if (flappy.Bounds.IntersectsWith(pipe_down.Bounds) ||
                flappy.Bounds.IntersectsWith(pipe_up.Bounds) ||
                flappy.Bounds.IntersectsWith(ground.Bounds))
            {
                Endgame();
            }
            if(score > 5) 
            {
                pipespeed = 21;
            }
            if(flappy.Top < -25) 
            {
                Endgame() ;
            }
        }

        private void lb_score_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = +15;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }
        private void Endgame()
        {
            timer1.Stop();
            lb_score.Text = "Game Over";
        }
    }
}