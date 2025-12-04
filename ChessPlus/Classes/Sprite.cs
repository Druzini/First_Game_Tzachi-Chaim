using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace FirstGameTry.Clasess;

public class Sprite
{
    public Texture2D Texture { get; }
    public Vector2 Position { get; set; }
    public Sprite(Texture2D texture, Vector2 position)
    {
        this.Texture = texture;
        this.Position = position;
    }
    public virtual void Update()
    {
    }
}
