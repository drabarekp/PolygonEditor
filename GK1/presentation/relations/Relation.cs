﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{ 
    public abstract class Relation
    {
        public abstract void EnforceRelation(Vertex moved, (int X, int Y) newPosition);
    }
}
