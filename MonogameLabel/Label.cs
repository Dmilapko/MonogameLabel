using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using FormElementsLib;
using MonoHelper;

namespace MonogameLabel
{
    public class Label : TextFE
    {
        public SpriteFont font;
        public int fontsize, fontinitsize;
        int sth, stw;
        public float realx=0, realy=0;
        public float realwidth = 0, realheight = 0;

        public Label(int x, int y, int width, int heigth, string _text, SpriteFont _font, int _fontinitsize, int _fontsize, uint packedcolor = 0)
        {
            Location = new Vector2(x, y);
            font = _font;
            fontsize = _fontsize;
            fontinitsize = _fontinitsize;
            text = _text;
            Location = new Vector2(x, y);
            Size = new System.Drawing.Size(width, heigth);
            textcolor = new Color(packedcolor);
            stw = width;
            sth = heigth;
            if (width > 0 && heigth > 0) Size = new System.Drawing.Size(width, heigth);
            else
            {
                if (width < 0) width = MHeleper.GetTextWidth(text, font, fontinitsize, fontsize);
                if (heigth < 0) heigth = MHeleper.GetFontHeight(font, fontinitsize, fontsize);
                Size = new System.Drawing.Size(width, heigth);
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (visible)
            {
                if (stw < 0) 
                    Size.Width = MHeleper.GetTextWidth(text, font, fontinitsize, fontsize);
                if (sth < 0) 
                    Size.Height = MHeleper.GetFontHeight(font, fontinitsize, fontsize);
                realx = Location.X + (Size.Width - (float)fontsize / fontinitsize * font.MeasureString(text).X) / 2;
                realy = Location.Y + (Size.Height - (float)fontsize / fontinitsize * font.MeasureString(text).Y) / 2;
                realwidth = (float)fontsize / fontinitsize * font.MeasureString(text).X;
                realheight = (float)fontsize / fontinitsize * font.MeasureString(text).Y;
                if (!outline)
                {
                    spriteBatch.DrawString(font, text, new Vector2(Location.X + (Size.Width - (float)fontsize / fontinitsize * font.MeasureString(text).X) / 2, Location.Y + (Size.Height - (float)fontsize / fontinitsize * font.MeasureString(text).Y) / 2), textcolor, 0f, new Vector2(0, 0), ((float)fontsize / fontinitsize), SpriteEffects.None, 1f);
                }
                else
                {

                    spriteBatch.DrawString(font, text, new Vector2(Location.X + (Size.Width - (float)fontsize / fontinitsize * font.MeasureString(text).X) / 2 - outlinelength, Location.Y + (Size.Height - (float)fontsize / fontinitsize * font.MeasureString(text).Y) / 2), OutlineColor, 0f, new Vector2(0, 0), ((float)fontsize / fontinitsize), SpriteEffects.None, 1f);
                    spriteBatch.DrawString(font, text, new Vector2(Location.X + (Size.Width - (float)fontsize / fontinitsize * font.MeasureString(text).X) / 2 - outlinelength, Location.Y + (Size.Height - (float)fontsize / fontinitsize * font.MeasureString(text).Y) / 2 + outlinelength), OutlineColor, 0f, new Vector2(0, 0), ((float)fontsize / fontinitsize), SpriteEffects.None, 1f);
                    spriteBatch.DrawString(font, text, new Vector2(Location.X + (Size.Width - (float)fontsize / fontinitsize * font.MeasureString(text).X) / 2, Location.Y + (Size.Height - (float)fontsize / fontinitsize * font.MeasureString(text).Y) / 2 + outlinelength), OutlineColor, 0f, new Vector2(0, 0), ((float)fontsize / fontinitsize), SpriteEffects.None, 1f);
                    spriteBatch.DrawString(font, text, new Vector2(Location.X + (Size.Width - (float)fontsize / fontinitsize * font.MeasureString(text).X) / 2 + outlinelength, Location.Y + (Size.Height - (float)fontsize / fontinitsize * font.MeasureString(text).Y) / 2 + outlinelength), OutlineColor, 0f, new Vector2(0, 0), ((float)fontsize / fontinitsize), SpriteEffects.None, 1f);
                    spriteBatch.DrawString(font, text, new Vector2(Location.X + (Size.Width - (float)fontsize / fontinitsize * font.MeasureString(text).X) / 2 + outlinelength, Location.Y + (Size.Height - (float)fontsize / fontinitsize * font.MeasureString(text).Y) / 2), OutlineColor, 0f, new Vector2(0, 0), ((float)fontsize / fontinitsize), SpriteEffects.None, 1f);
                    spriteBatch.DrawString(font, text, new Vector2(Location.X + (Size.Width - (float)fontsize / fontinitsize * font.MeasureString(text).X) / 2 + outlinelength, Location.Y + (Size.Height - (float)fontsize / fontinitsize * font.MeasureString(text).Y) / 2 - outlinelength), OutlineColor, 0f, new Vector2(0, 0), ((float)fontsize / fontinitsize), SpriteEffects.None, 1f);
                    spriteBatch.DrawString(font, text, new Vector2(Location.X + (Size.Width - (float)fontsize / fontinitsize * font.MeasureString(text).X) / 2, Location.Y + (Size.Height - (float)fontsize / fontinitsize * font.MeasureString(text).Y) / 2 - outlinelength), OutlineColor, 0f, new Vector2(0, 0), ((float)fontsize / fontinitsize), SpriteEffects.None, 1f);
                    spriteBatch.DrawString(font, text, new Vector2(Location.X + (Size.Width - (float)fontsize / fontinitsize * font.MeasureString(text).X) / 2 - outlinelength, Location.Y + (Size.Height - (float)fontsize / fontinitsize * font.MeasureString(text).Y) / 2 - outlinelength), OutlineColor, 0f, new Vector2(0, 0), ((float)fontsize / fontinitsize), SpriteEffects.None, 1f);
                    spriteBatch.DrawString(font, text, new Vector2(Location.X + (Size.Width - (float)fontsize / fontinitsize * font.MeasureString(text).X) / 2, Location.Y + (Size.Height - (float)fontsize / fontinitsize * font.MeasureString(text).Y) / 2), textcolor, 0f, new Vector2(0, 0), ((float)fontsize / fontinitsize), SpriteEffects.None, 1f);
                }
            }
        }
    }
}
