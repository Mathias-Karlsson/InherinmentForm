using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherinmentForm
{
    enum SPECIES { CAT, DOG, BIRD}
    class Animal
    {
        public string Name;
        public SPECIES Species; /* 0=Cat, 1=Dog, 2=Bird */
        public bool CanFly;
    }
}
