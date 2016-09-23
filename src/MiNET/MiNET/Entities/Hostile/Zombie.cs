﻿using MiNET.Worlds;
using MiNET.Items;

namespace MiNET.Entities.Hostile
{
	public class Zombie : HostileMob, IAgeable
	{
		public Zombie(Level level) : base((int) EntityType.Zombie, level)
		{
			Width = Length = 0.6;
			Height = 1.8;
		}

		public bool IsBaby { get; set; }
	}
}