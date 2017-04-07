using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Irish_Poker
{
    class StartScreen : GameScreen
    {
        SpriteFont spriteFont;

        public StartScreen(Game game, SpriteBatch spriteBatch, SpriteFont spriteFont) : base(game, spriteBatch)
        {
            this.spriteFont = spriteFont;
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);

            spriteBatch.DrawString(spriteFont, "Math Battle!", new Vector2(175, 75), Color.Black);
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        public override void Initialize()
        {
            base.Initialize();
        }
    }
}
