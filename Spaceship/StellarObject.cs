﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSpaceship
{
    internal class StellarObject
    {
        protected Coordinate coordinate;
        protected string owner;
        protected string type;
        public StellarObject(Coordinate coordinate)
        {
            this.coordinate = coordinate;
        }

        public virtual Coordinate GetCoordinate()
        {
            return coordinate;
        } 
        public virtual string GetOwner()
        {
            return owner;
        }
    }
}
