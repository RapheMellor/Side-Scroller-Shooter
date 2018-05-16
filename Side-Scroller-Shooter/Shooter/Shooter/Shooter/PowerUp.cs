using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shooter
{
    class PowerUp
    {
        public Animation PowerUpAnimation;

        // The position of the enemy ship relative to the top left corner of thescreen
        public Vector2 Position;

        public bool Active;

        // Get the width of the enemy ship
        public int Width
        {
            get { return PowerUpAnimation.FrameWidth; }
        }

        // Get the height of the enemy ship
        public int Height
        {
            get { return PowerUpAnimation.FrameHeight; }
        }

        // The speed at which the enemy moves
        float powerUpMoveSpeed;

        public void Initialize(Animation animation, Vector2 position)
        {
            // Load the enemy ship texture
            PowerUpAnimation = animation;

            // Set the position of the enemy
            Position = position;

            // Set how fast the enemy moves
            powerUpMoveSpeed = 6f;

            // We initialize the enemy to be active so it will be updated
            Active = true;
        }

        public void Update(GameTime gameTime)
        {
            // The enemy always moves to the left so decrement x
            Position.X -= powerUpMoveSpeed;

            // Update the position of the Animation
            PowerUpAnimation.Position = Position;

            // Update Animation
            PowerUpAnimation.Update(gameTime);

            // If the enemy is past the screen or its health reaches 0, deactivate
            //if (Position.X < -Width || Health <= 0)
           // {
                // By setting the Active flag to false, the game will remove
               // Active = false;
           // }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            // Draw the animation
            PowerUpAnimation.Draw(spriteBatch);
        }
    }
}
