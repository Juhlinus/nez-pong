﻿using Microsoft.Xna.Framework;
using Nez;

namespace Pong.Entities
{
    class Text : Entity
    {
        private string _text;
        private Color _color;
        private Vector2 _position;
        private Vector2 _scale;

        public Text(string text, Color color, Vector2 position, Vector2 scale)
        {
            _text = text;
            _color = color;
            _position = position;
            _scale = scale;
        }

        public override void onAddedToScene()
        {
            var text = new Nez.Text(Graphics.instance.bitmapFont, _text, Vector2.Zero, _color);

            addComponent(text);

            scale = _scale;
            transform.position = _position;
        }
    }
}