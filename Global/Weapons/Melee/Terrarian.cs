using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace XelvaaMod.Global.Weapons.Melee
{

	public class Terrarian : GlobalItem
	{

		public override bool AppliesToEntity(Item item, bool lateInstatiation) {
			return item.type == ItemID.Terrarian;
		}

		public override void SetDefaults(Item item) {
			item.StatsModifiedBy.Add(Mod); 
			item.damage = 105;
			item.knockBack = 4f;
		}
	}
}
