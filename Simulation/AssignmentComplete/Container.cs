using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AssignmentComplete
{
    class ProductContainer : IContainer
    {
        public int current_amount;
        public int max_capacity;
        public Vector2 position;
         
        public ProductContainer(int _current_amount, int _max_capacity, Vector2 _position)
        {
            this.current_amount = _current_amount;
            this.max_capacity = _max_capacity;
            this.position = _position;
        }

        public int CurrentAmount
        {
            get
            {
                return current_amount;
            }
        }

        public int MaxCapacity
        {
            get
            {
                return max_capacity;
            }
        }

        public Vector2 Position
        {
            get
            {
                return position;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool AddContent(int amount)
        {
            return true;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
        }
    }

    class OreContainer : IContainer
    {
        public int current_amount;
        public int max_capacity;
        public Vector2 position;

        public OreContainer(int _current_amount, int _max_capacity, Vector2 _position)
        {
            this.current_amount = _current_amount;
            this.max_capacity = _max_capacity;
            this.position = _position;
        }

        public int CurrentAmount
        {
            get
            {
                return current_amount;
            }
        }

        public int MaxCapacity
        {
            get
            {
                return max_capacity;
            }
        }

        public Vector2 Position
        {
            get
            {
                return position;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool AddContent(int amount)
        {
            return true;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
        }
    }
}
