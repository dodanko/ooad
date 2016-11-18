using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Assignment03
{
    public partial class Entity
    {
        public int Id { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Entity);
        }

        public virtual bool Equals(Entity other)
        {
            if (other == null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            if (Equals(Id, default(int)))
                return base.GetHashCode();
            return Id.GetHashCode();
        }

        public static bool operator ==(Entity x, Entity y)
        {
            return Equals(x, y);
        }

        public static bool operator !=(Entity x, Entity y)
        {
            return !(x == y);
        }
    }
}
