using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Prototype
    {
        public int Id { get; private set; }
        public Prototype(int id)
        {
            this.Id = id;
        }
        public abstract Prototype Clone();
    }

    class LecturerPrototype : Prototype
    {
        public LecturerPrototype(int id)
            : base(id)
        { }
        public override Prototype Clone()
        {
            return new LecturerPrototype(Id);
        }
    }

   
}
