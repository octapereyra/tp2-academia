using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class BusinessEntity
    {
        private int _id;
        private States _state;

        public int ID { get => _id; set => _id = value; }
        public States State { get => _state; set => _state = value; }

        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }
    }
}
