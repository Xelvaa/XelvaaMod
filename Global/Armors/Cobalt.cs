using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Global.Armors
{
    public class Cobalt : GlobalItem
    {
        public override bool InstancePerEntity => true;
        public override GlobalItem Clone(Item item, Item itemClone)
        {
            return base.Clone(item, itemClone);
        }
        public override void SetDefaults(Item item)
        {
            switch (item.type)
            {
             case ItemID.CobaltHat:
             item.defense = 9;
             return;
             case ItemID.CobaltBreastplate:
             item.defense = 12;
             return;
             case ItemID.CobaltLeggings:
             item.defense = 10;
             return;
             }
             }

