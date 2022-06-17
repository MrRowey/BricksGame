using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Bricks
{
    class GameContent
    {
        public Texture2D imgBrick { get; set; }    
        public Texture2D imgPaddle { get; set; }
        public Texture2D imgBall { get; set; }
        public Texture2D imgPixel { get; set; }
        public SoundEffect startSound { get; set; }
        public SoundEffect brickSound { get; set; }
        public SoundEffect paddleBounceSound { get; set; }
        public SoundEffect wallBounceSound { get; set; }
        public SoundEffect missSound { get; set; }
        public SpriteFont lableFont { get; set; }


        public GameContent(ContentManager Content)
        {
        // load images
        imgBall = Content.Load<Texture2D>("Ball");
        imgPixel = Content.Load<Texture2D>("Pixel");
        imgPaddle = Content.Load<Texture2D>("Paddle");
        imgBrick = Content.Load<Texture2D>("Brick");

        // Load Sounds
        startSound = Content.Load<SoundEffect>("StartSound");
        brickSound = Content.Load<SoundEffect>("BrickSound");
        paddleBounceSound = Content.Load<SoundEffect>("PaddleBounceSound");
        wallBounceSound = Content.Load<SoundEffect>("WallBounceSound");
        missSound = Content.Load<SoundEffect>("MissSound");

        // Load fonts
        lableFont = Content.Load<SpriteFont>("Arial20");

        }
    }
}