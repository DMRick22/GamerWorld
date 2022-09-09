using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerWorld
{
    internal abstract class Entity
    {
        private int id;

        public Entity()
        {

        }
        protected Entity(int id)
        {
            Id = id;
        }

        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return $"ID: {id}\n";
        }
    }
}
