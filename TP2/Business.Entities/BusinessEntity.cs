using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class BusinessEntity
    {
        private int _Id;
        private States _State;

        public int ID { get => _Id; set => _Id = value; }
        public States State { get => _State; set => _State = value; }

        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }
    }
}
