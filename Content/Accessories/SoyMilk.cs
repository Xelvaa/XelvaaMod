using XelvaaMod.Content.Accessories;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.Chat;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace XelvaaMod.Content.Accessories
{
	public class SoyMilk : ModItem
	{
		public override void SetStaticDefaults()
		{

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 30;
			Item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{

			player.GetDamage(DamageClass.Generic) *= 0.4f;
			player.GetAttackSpeed(DamageClass.Generic) *= 2.75f;
			player.GetArmorPenetration(DamageClass.Generic) += 5f;//je ne trouve pas comment réduire la taille des armes/projectiles aussi
			player.GetKnockback(DamageClass.Generic) += -2.25f; 
		}
		public override void AddRecipes()
		{
            Recipe recipe = Recipe.Create(ModContent.ItemType<SoyMilk>(), 1);
            recipe.AddIngredient(ItemID.StoneBlock); // pas encore trouvé de recipe ou de drop adéquat 
            global::System.Object value = recipe.Register();
		}
	}
}
