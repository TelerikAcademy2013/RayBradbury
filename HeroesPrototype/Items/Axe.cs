﻿using System;
using System.Linq;
using HeroesPrototype.Geometry;

namespace HeroesPrototype.Items
{
	public class Axe : Weapon
	{
		public Axe(Point2D origin) : base("Axe", origin, 4, 10, 2)
		{
		}
	}
}
