using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace XelvaaMod.Global.Weapons.Ranger
{

	public class FlareGun : GlobalItem
	{

		public override bool AppliesToEntity(Item item, bool lateInstatiation) {
			return item.type == ItemID.FlareGun;
		}

		public override void SetDefaults(Item item) {
			item.StatsModifiedBy.Add(Mod); 
			item.damage = 3;
			item.DamageType = DamageClass.Ranged;
			item.knockBack = 0f;
		}
	}
}

//j'avais déjà testé ce truc auparavant ça marchait bien mais les reforges étaient quand même bloqués (vu que le flare gun de base ne peut pas avoir de reforge).
//Une idée comment forcer l'arme à avoir des reforges ?
