using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using XelvaaMod;
using System.Collections.Generic;
using Terraria.Utilities;
using static Terraria.ModLoader.ModContent;

namespace XelvaaMod.Global.Accessories
{
    public class Accessories : GlobalItem
    {
        
        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            switch (item.type)
            {
                            case ItemID.EyeoftheGolem:
                    player.GetCritChance<GenericDamageClass>() += 14;
                    break;
                    }
                    
