using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Bricks
{
    class GameBorder
    {
        public float Width { get; set; }
        public float Height { get; set; }
        private Texture2D imgPixel { get; set; }
        private SpriteBatch spriteBatch;

        public GameBorder(float screenWidth, float screenHeight, SpriteBatch spriteBatch, GameContent gameContent)
        {
            Width = screenWidth;
            Height = screenHeight;
            imgPixel = gameContent.imgPixel;
            this.spriteBatch = spriteBatch;
        }

        public void Draw()
        {
            spriteBatch.Draw(imgPixel, new Rectangle(0, 0, (int)Width - 1, 1), Color.White);  //draw top border
            spriteBatch.Draw(imgPixel, new Rectangle(0, 0, 1, (int)Height - 1), Color.White);  //draw left border
            spriteBatch.Draw(imgPixel, new Rectangle((int)Width - 1, 0, 1, (int)Height - 1), Color.White);  //draw right border
        }



    }
}
