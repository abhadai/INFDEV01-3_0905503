﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AssignmentComplete
{
    class Truck : ITruck
    {
        public Texture2D truck;
        public Vector2 position;

        public Truck(Texture2D _truck, Vector2 _position)
        {
            this.truck = _truck;
            this.position = _position;
        }

        public IContainer Container
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Vector2 Position
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Vector2 Velocity
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void AddContainer(IContainer container)
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
        }

        public void StartEngine()
        {
        }

        public void Update(float dt)
        {
        }
    }
}
