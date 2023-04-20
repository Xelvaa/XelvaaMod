using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Global.Weapons.Melee
{
	public class PsychoKnife : GlobalItem
	{
		public override bool AppliesToEntity(Item item, bool lateInstatiation) {
			return item.type == ItemID.PsychoKnife;
		}

		public override void SetDefaults(Item item) {
			item.StatsModifiedBy.Add(Mod);

			item.damage = 50;
      item.useStyle = ItemUseStyleID.Rapier;
		}
