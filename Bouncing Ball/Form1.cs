using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bouncing_Ball.Classes;

namespace Bouncing_Ball
{
    public partial class Form1 : Form
    {
        List<Ball> myBalls; // Ball list            
        int        maxX;    // Graphic drawing Boundary Width
        int        maxY;    // Graphic drawing Boundary Height
        Random     rando;   // Random device
        int        ballQty; // Quantity of ball on screen

        public Form1()
        {
            InitializeComponent();
            maxX = ClientSize.Width;  // Get initial Width
            maxY = ClientSize.Height; // Get initial Height
            rando = new Random();     // Construct a random device object
            InitializeBalls();
        }

        /// <summary>
        /// Initialize the ball list
        /// </summary>
        private void InitializeBalls()
        {
            int.TryParse(TBoxBallQty.Text, out ballQty); // Get value from Textbox
            // If value is invalid or outside of range set 1 by default
            if (ballQty > 100 || ballQty == 0)
            {
                TBoxBallQty.Text = "1";
                ballQty = 1;
            }

            myBalls = new List<Ball>(); // Initialize a List of Ball

            // Add ball to the list based on ballQty with random properties
            for (int i = 0; i < ballQty; i++)
            {
                myBalls.Add(new Ball(
                    new Point(
                    rando.Next(100, maxX - 100),  // Random spawn location X
                    rando.Next(100, maxY - 100)), // Random spawn location Y
                    rando.Next(5, 50),            // Random size  
                    rando.Next(20, 50))           // Random bounciness
                    );
            }

            // Add random velocity to all the balls.
            foreach (var item in myBalls)
            {
                item.AddForce(rando.Next(-15,15), rando.Next(-15, 15));
            }
        }

        /// <summary>
        /// Refresh the current form on every timer tick.
        /// </summary>
        private void TimerRefresh_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

        /// <summary>
        /// Reaply boundary after the form resizing.
        /// </summary>
        private void Form1_Resize(object sender, EventArgs e)
        {
            maxX = ClientSize.Width;
            maxY = ClientSize.Height;
        }

        /// <summary>
        /// Reset the ball list
        /// </summary>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            InitializeBalls();
        }

        /// <summary>
        /// Every time the form is refresh it calls this to redraw the balls.
        /// </summary>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Draw all the balls from the list.
            foreach (var item in myBalls)
            {
                item.Draw(e.Graphics); // Draw the ball.
                // Based on checkbox either move the ball with or without gravity.
                if (ChkBoxGravity.Checked)
                {
                    item.Move(maxX, maxY);  // Call move the ball with gravity, sent the boundary.
                }
                else
                {
                    item.Glide(maxX, maxY); // Call move the ball without gravity, sent the boundary.
                }
                
            }
        }
    }
}
