using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ping
{
    public partial class Form1 : Form
    {

        Ball Ball;
        Walls wall;

        public Form1()
        {
            InitializeComponent();
            wall = new Walls();
            Ball = new Ball(ball, groupBox1, scoreL, scoreR);
        }

        #region vars 
        // set the speed movement
        public int movementSpeed = 5;
        // var to set up the buttons for moving board
        public bool upPressed, downPressed, wPressed, sPressed;
        #endregion
 
        private void timer1_Tick(object sender, EventArgs e)
        {
            //left paddle 
            PaddleMove(paddleL, wPressed, sPressed);

            //rigth paddle
            PaddleMove(paddleR, upPressed, downPressed);

            //ball move
            Ball.BallMove();

            //in case if the ball was repelled
            if (ball.Bounds.IntersectsWith(paddleL.Bounds) || ball.Bounds.IntersectsWith(paddleR.Bounds))
            {
                Ball.xSpeed *= -1;
            }
        }


        #region paddle 

        // set Down Key
        private void Down(object sender, KeyEventArgs e)
        {
            SetKeys(e, true);
        }

        //set Up key
        private void Up(object sender, KeyEventArgs e)
        {
            SetKeys(e, false);
        }

        //make paddle move
        public void PaddleMove(PictureBox paddle, bool up, bool down)
        {
            if (up)
            {
                paddle.Location = new Point(paddle.Location.X, Math.Max(Walls.topWorld, Math.Min(Walls.bottomWorld-paddle.Height, paddle.Location.Y - movementSpeed)));
            }else if (down)
            {
                paddle.Location = new Point(paddle.Location.X, Math.Max(Walls.topWorld, Math.Min(Walls.bottomWorld - paddle.Height, paddle.Location.Y + movementSpeed)));
            }
        }
        
        // keys setting
        public void SetKeys(KeyEventArgs k, bool t)
        {
            switch (k.KeyCode)
            {
                case Keys.Up:
                    upPressed = t;
                    break;
                case Keys.W:
                    wPressed = t;
                    break;
                case Keys.Down:
                    downPressed = t;
                    break;
                case Keys.S:
                    sPressed = t;
                    break;

            }
        }


        #endregion


    }
}
