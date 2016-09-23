﻿using System.Numerics;
using MiNET.Blocks;
using MiNET.Utils;
using MiNET.Worlds;

namespace MiNET.Items
{
	public class ItemHoe : Item
	{
		internal ItemHoe(short id) : base(id)
		{
			MaxStackSize = 1;
		}

		public override void UseItem(Level world, Player player, BlockCoordinates blockCoordinates, BlockFace face, Vector3 faceCoords)
		{
			Block block = world.GetBlock(blockCoordinates);
			if (block is Grass || block is Dirt || block is GrassPath)
			{
				Farmland farmland = new Farmland
				{
					Coordinates = blockCoordinates,
					Metadata = 0
				};
				world.SetBlock(farmland);
			}
		}
	}
}