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
    public class Ball
    {
        #region vars
        Random myRnd = new Random();
        private Label scoreL;
        private Label scoreR;
        private GroupBox gb;
        private PictureBox ball;
        public int xSpeed, ySpeed; // speed of ball by X and Y 
        #endregion

        public Ball(PictureBox pic, GroupBox gb, Label sl, Label sr)
        {
            this.scoreL = sl;
            this.scoreR = sr;
            this.gb = gb; 
            this.ball = pic;
            xSpeed = 4;
            ySpeed = 5;
        }

        internal void BallMove()
        {
            var bottom = Walls.bottomWorld - ball.Height;

            //make ball moving
            ball.Location = new Point(ball.Location.X + xSpeed, Math.Max(Walls.topWorld, Math.Min(bottom, ball.Location.Y + ySpeed)));
            
            //make ball bouncing from the walls
            if (ball.Location.Y == bottom || ball.Location.Y == Walls.topWorld)
            {
                ySpeed *= -1; //chage Y direction if ball hits top or bottom

            }
            if (ball.Location.X <= Walls.leftWall)
            {
                BallScore(scoreR); 

            }
            else if (ball.Location.X >= Walls.rightWall)
            {
                BallScore(scoreL);
            }
        }

        // chage a score and set a new speed if ball was scored into the goal
        public void BallScore(Label Label)
        {
            ball.Location = new Point(gb.Width / 2, gb.Height / 2);
            Label.Text = (int.Parse(Label.Text) + 1).ToString();
            do
            {
                xSpeed = myRnd.Next(-6, 6);
                ySpeed = myRnd.Next(-6, 6);
            } while (xSpeed == 0 ||ySpeed == 0);
        }
    }
}
