using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Common.RarityChange
{
    public class ChangesRarity : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            switch (item.type)
            {
            case ItemID.AnkletoftheWind
            case ItemID.FeralClaws
            case ItemID.JungleHat
            case ItemID.JungleShirt
            case ItemID.JunglePants
            case ItemID.IvyWhip
            case ItemID.BladeofGrass
            case ItemID.ThornChakram
            case ItemID.JungleYoyo
            case ItemID.ThornWhip
            item.rare = ItemRarityID.Green;
                    break;
            case ItemID.SolarEruption
            case ItemID.StardustCellStaff
            case ItemID.VortexBeater
            case ItemID.NebulaArcanum
            case ItemID.StardustDragonStaff
            case ItemID.DayBreak
            case ItemID.NebulaBlaze
            case ItemID.Phantasm
            case ItemID.SuperHealingPotion
            case ItemID.LunarCraftingStation
            case ItemID.LunarHook
            case ItemID.Terrarian
            case ItemID.FairyQueenMagicItem
            case ItemID.FairyQueenRangedItem
            case ItemID.EmpressButterfly
            case ItemID.PiercingStarlight
            case ItemID.RainbowWhip
            case ItemID.SparkleGuitar
            case ItemID.
            case ItemID.
            case ItemID.
            case ItemID.
            item.rage = ItemRarityID.Cyan
  
