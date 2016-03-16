using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AssignmentComplete
{
    class Mine : IFactory
    {
        public Vector2 Position
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public List<IContainer> ProductsToShip
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }

        public ITruck GetReadyTruck()
        {
            throw new NotImplementedException();
        }

        public void Update(float dt)
        {
            throw new NotImplementedException();
        }
    }
}
