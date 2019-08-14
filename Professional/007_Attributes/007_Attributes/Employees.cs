using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Attributes
{
    [AccessLevel(AccessLevelAttribute.AccessLevel.low)]
    class Manager { }
    [AccessLevel(AccessLevelAttribute.AccessLevel.normal)]
    class Programmer { }
    [AccessLevel(AccessLevelAttribute.AccessLevel.hard)]
    class Director { }
}
