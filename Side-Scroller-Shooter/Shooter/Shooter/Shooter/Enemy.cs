using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Shooter
{

    class Enemy
    {
        // Animation representing the enemy
        public Animation EnemyAnimation;

        // The position of the enemy ship relative to the top left corner of thescreen
        public Vector2 Position;

        // The state of the Enemy Ship
        public bool Active;

        // The hit points of the enemy, if this goes to zero the enemy dies
        public int Health;

        // The amount of damage the enemy inflicts on the player ship
        public int Damage;

        // The amount of score the enemy will give to the player
        public int Value;

        // Get the width of the enemy ship
        public int Width
        {
            get { return EnemyAnimation.FrameWidth; }
        }

        // Get the height of the enemy ship
        public int Height
        {
            get { return EnemyAnimation.FrameHeight; }
        }

        // The speed at which the enemy moves
        float enemyMoveSpeed;


        public void Initialize(Animation animation, Vector2 position)
        {
            // Load the enemy ship texture
            EnemyAnimation = animation;

            // Set the position of the enemy
            Position = position;

            // We initialize the enemy to be active so it will be updated
            Active = true;


            // Set the health of the enemy
            Health = 10;

            // Set the amount of damage the enemy can do
            Damage = 10;

            // Set how fast the enemy moves
            enemyMoveSpeed = 6f;

            // Set the score value of the enemy
            Value = 100;
        }


        public void Update(GameTime gameTime)
        {
            // The enemy always moves to the left so decrement x
            Position.X -= enemyMoveSpeed;

            // Update the position of the Animation
            EnemyAnimation.Position = Position;

            // Update Animation
            EnemyAnimation.Update(gameTime);

            // If the enemy is past the screen or its health reaches 0, deactivate
            if (Position.X < -Width || Health <= 0)
            {
                // By setting the Active flag to false, the game will remove
                Active = false;
            }
        }



        public void Draw(SpriteBatch spriteBatch)
        {
            // Draw the animation
            EnemyAnimation.Draw(spriteBatch);
        }
    }

        class Enemy2
    {
        // Animation representing the enemy
        public Animation EnemyAnimation2;

        // The position of the enemy ship relative to the top left corner of thescreen
        public Vector2 Position2;

        // The state of the Enemy Ship
        public bool Active2;

        // The hit points of the enemy, if this goes to zero the enemy dies
        public int Health2;

        // The amount of damage the enemy inflicts on the player ship
        public int Damage2;

        // The amount of score the enemy will give to the player
        public int Value2;

        // Get the width of the enemy ship
        public int Width2
        {
            get { return EnemyAnimation2.FrameWidth; }
        }

        // Get the height of the enemy ship
        public int Height2
        {
            get { return EnemyAnimation2.FrameHeight; }
        }

        // The speed at which the enemy moves
        float enemyMoveSpeed2;


        public void Initialize(Animation animation2, Vector2 position2)
        {
            // Load the enemy ship texture
            EnemyAnimation2 = animation2;

            // Set the position of the enemy
            Position2 = position2;

            // We initialize the enemy to be active so it will be updated
            Active2 = true;


            // Set the health of the enemy
            Health2 = 8;

            // Set the amount of damage the enemy can do
            Damage2 = 15;

            // Set how fast the enemy moves
            enemyMoveSpeed2 = 8f;

            // Set the score value of the enemy
            Value2 = 150;
        }


        public void Update(GameTime gameTime)
        {
            // The enemy always moves to the left so decrement x
            Position2.X -= enemyMoveSpeed2;

            // Update the position of the Animation
            EnemyAnimation2.Position = Position2;

            // Update Animation
            EnemyAnimation2.Update(gameTime);

            // If the enemy is past the screen or its health reaches 0, deactivate
            if (Position2.X < -Width2 || Health2 <= 0)
            {
                // By setting the Active flag to false, the game will remove
                Active2 = false;
            }
        }



        public void Draw(SpriteBatch spriteBatch)
        {
            // Draw the animation
            EnemyAnimation2.Draw(spriteBatch);
        }

    }
}