using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace Global.NPCs.Bosses
{
	public class LunaticCultist : GlobalNPC
    {
        public override bool InstancePerEntity => true;
        public override void SetDefaults(NPC npc)
		{
            if (npc.type == NPCID.CultistBoss)
            {
				npc.lifeMax = (int)(npc.lifeMax  * ((float)50000 / 25000));
 
