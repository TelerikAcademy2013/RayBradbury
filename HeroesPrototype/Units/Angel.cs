﻿using System;
using System.Linq;
using HeroesPrototype.Geometry;
using System.Drawing;

namespace HeroesPrototype
{
	public class Angel : UnitLevel3
	{
        private readonly Bitmap sprite;

        public Angel(Point2D origin)
            : base("Angel", origin, 12, 12, 40, 300)
		{
		}        

        public Angel(Point2D origin, Bitmap sprite)
            : base("Angel", origin, 12, 12, 40, 300)
        {
            this.Origin = origin;
            this.sprite = sprite;
        }
	}
}