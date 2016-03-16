using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AssignmentComplete
{
    class Ikea : IFactory
    {
        private Vector2 position;
        private Texture2D volvo;
        private Texture2D ikea;
        private Texture2D product_box;
        private Texture2D product_container;
        private List<IContainer> products_to_ship;
        private Texture2D truck;

        public Ikea(Vector2 _position, Texture2D _volvo, Texture2D _ikea, Texture2D _product_box, Texture2D _product_container)
        {
            this.position = _position;
            this.ikea = _ikea;
            this.product_box = _product_box;
            this.product_container = _product_container;
            this.truck = truck;
        }

        public Vector2 Position
        {
            get
            {
                return position;
            }
        }

        public List<IContainer> ProductsToShip
        {
            get
            {
                return products_to_ship;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(ikea, Vector2.Zero, Color.White);
        }

        public ITruck GetReadyTruck()
        {
            Truck sample_truck = new Truck(truck, position);
            return sample_truck;
        }

        public void Update(float dt)
        {
        }
    }
}
