using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Bouncing_Ball.Classes
{
    /// <summary>
    /// Class Ball
    /// </summary>
    class Ball
    {
        private Point center;     // Location coordinate X,Y of center 
        private Point velocity;   // The speed at which the ball is moving in any 2D Vector direction X,Y
        private int   radius;     // Ball Radius in pixel
        private int   bounciness; // The amount of force the ball add to velocity -Y has when it hit the floor with gravity on

        /// <summary>
        /// Ball Constructor
        /// </summary>
        /// <param name="center"    > Location of the ball for initial spawning coordinate X,Y </param>
        /// <param name="radius"    > Ball Radius in pixel </param>
        /// <param name="bounciness"> How much the ball bounce on the floor with gravity </param>
        public Ball(Point center, int radius, int bounciness)
        {
            this.center     = center;      //-
            this.radius     = radius;      // Set values based on constructor input
            this.bounciness = bounciness;  //-
        }

        /// <summary>
        /// Move the ball includind gravity
        /// </summary>
        /// <param name="maxX"> ClientSize Width  </param>
        /// <param name="maxY"> ClientSize Height </param>
        public void Move(int maxX, int maxY)
        {
            // Reverse X velocity direction when the ball hit boundary
            if (center.X <= radius || center.X + radius >= maxX)
            {
                velocity.X = -velocity.X;

            }
            center.X += velocity.X; // Move the ball X location based to its current X velocity

            // Stop the ball, reverse the Y velocity when it hit top boundary and give it a little push downward.
            if (center.Y <= radius)
            {
                velocity.Y = 1;
            }

            // Apply gravity to the ball if it is in the air.
            if (center.Y + radius < maxY)
            {
                velocity.Y += 1; // Apply downward gravity on the ball every pass
            }
            else // If the ball hit the floor make it bounce
            {
                velocity.Y = -bounciness; // Remove current Y velocity and apply bounciness value to the ball -Y velocity
            }

            center.Y += velocity.Y; // Move the ball Y location based to its current Y velocity
        }

        /// <summary>
        /// Glide the ball around the area excluding gravity
        /// </summary>
        /// <param name="maxX"> ClientSize Width  </param>
        /// <param name="maxY"> ClientSize Height </param>
        public void Glide(int maxX, int maxY)
        {
            // Reverse X velocity direction when the ball hit boundary
            if (center.X <= radius || center.X + radius >= maxX)
            {
                velocity.X = -velocity.X;
            }

            // Reverse Y velocity direction when the ball hit boundary
            if (center.Y <= radius || center.Y + radius >= maxY)
            {
                velocity.Y = -velocity.Y;
            }
            center.X += velocity.X; // Move the ball X location based to its current X velocity
            center.Y += velocity.Y; // Move the ball Y location based to its current Y velocity
        }

        /// <summary>
        /// Add Force to the ball velocity
        /// </summary>
        /// <param name="forceX"> X velocity to add </param>
        /// <param name="forceY"> Y velocity to add </param>
        public void AddForce(int forceX, int forceY)
        {
            velocity.X += forceX;
            velocity.Y += forceY;
        }

        /// <summary>
        /// Draw ball on provided Graphic(Object)
        /// </summary>
        /// <param name="g"> Graphic(Object) where the ball will be drawn on</param>
        public void Draw(Graphics g)
        {
            Brush myPen = new SolidBrush(Color.Red);
            g.FillEllipse(myPen, new Rectangle(this.center.X - radius, this.center.Y - radius, radius * 2, radius * 2));
            myPen.Dispose();
        }

        // Properties
        public Point Center     { get => center;   } // Read Only
        public Point Velocity   { get => velocity; } // Read Only
        public int   Radius     { get => radius;     set => radius     = value; }
        public int   Bounciness { get => bounciness; set => bounciness = value; }
    }
}
