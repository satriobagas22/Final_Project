namespace FlapyBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pipe_down = new PictureBox();
            flappy = new PictureBox();
            ground = new PictureBox();
            pipe_up = new PictureBox();
            lb_score = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipe_down).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipe_up).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Cloud1;
            pictureBox1.Location = new Point(-3, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(642, 577);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pipe_down
            // 
            pipe_down.Image = Properties.Resources.PipeUp;
            pipe_down.Location = new Point(452, 409);
            pipe_down.Name = "pipe_down";
            pipe_down.Size = new Size(133, 260);
            pipe_down.SizeMode = PictureBoxSizeMode.StretchImage;
            pipe_down.TabIndex = 1;
            pipe_down.TabStop = false;
            pipe_down.Click += pictureBox2_Click;
            // 
            // flappy
            // 
            flappy.Image = Properties.Resources.Flappy;
            flappy.Location = new Point(35, 204);
            flappy.Name = "flappy";
            flappy.Size = new Size(80, 65);
            flappy.SizeMode = PictureBoxSizeMode.StretchImage;
            flappy.TabIndex = 2;
            flappy.TabStop = false;
            // 
            // ground
            // 
            ground.Image = Properties.Resources.Ground;
            ground.Location = new Point(-3, 565);
            ground.Name = "ground";
            ground.Size = new Size(683, 151);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // pipe_up
            // 
            pipe_up.Image = Properties.Resources.PipeDown;
            pipe_up.Location = new Point(318, -96);
            pipe_up.Name = "pipe_up";
            pipe_up.Size = new Size(133, 333);
            pipe_up.SizeMode = PictureBoxSizeMode.StretchImage;
            pipe_up.TabIndex = 4;
            pipe_up.TabStop = false;
            // 
            // lb_score
            // 
            lb_score.AutoSize = true;
            lb_score.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lb_score.Location = new Point(77, 9);
            lb_score.Name = "lb_score";
            lb_score.Size = new Size(124, 32);
            lb_score.TabIndex = 5;
            lb_score.Text = "SCORE : 0";
            lb_score.Click += lb_score_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(634, 711);
            Controls.Add(lb_score);
            Controls.Add(pipe_up);
            Controls.Add(ground);
            Controls.Add(flappy);
            Controls.Add(pipe_down);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipe_down).EndInit();
            ((System.ComponentModel.ISupportInitialize)flappy).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipe_up).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pipe_down;
        private PictureBox flappy;
        private PictureBox ground;
        private PictureBox pipe_up;
        private Label lb_score;
        private System.Windows.Forms.Timer timer1;
    }
}