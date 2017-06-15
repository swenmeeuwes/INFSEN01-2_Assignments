﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUILibrary.Util.Visitor;
using GUILibrary.AssetLoading;
using GUILibrary.Util.Structures;
using Microsoft.Xna.Framework.Graphics;

namespace GUILibrary.UI.Label
{
    class Label : View.View
    {
        public string Text { get; set; }
        public TextAlign Align { get; set; } = TextAlign.LEFT;
        public SpriteFont Font { get; set; }

        public Label(string text, Point2D<int> position)
        {
            this.Text = text;
            this.Position = position;

            // Use a font as "default" label font
            this.Font = AssetLibrary.Instance.RetrieveAsset<SpriteFont>("Arial");
            this.Color = Color.Black;

            var measuredSize = Font.MeasureString(text);
            this.Size = new Vector2<int>((int)measuredSize.X, (int)measuredSize.Y);
        }
        public Label(string text, SpriteFont font)
        {
            this.Text = text;
            this.Font = font;

            this.Color = Color.Black;
        }

        public override void Update(IUpdateVisitor updateVisitor, float deltaTime)
        {
            updateVisitor.Update(this, deltaTime);
            base.Update(updateVisitor, deltaTime);
        }
        public override void Draw(IDrawVisitor drawVisitor)
        {
            drawVisitor.Draw(this);
        }        
    }
}
