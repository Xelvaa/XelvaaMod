using Terraria;
using Terraria.ID;
using Terraria.Modloader;

namespace XelvaaMod.Content.Buffs {
    public class SeverePoison : ModBuff {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Severe Poison");
            Description.SetDefault("Slowly losing life");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;}
        public override Update(Player player, ref int buffIndex){
            // le nouveau debuff doit faire 20 de dps (le poison pour info c'est 6) 
            // même effet visuel que le poison donc faut copier l'effet quoi
            player.GetModPlayer<XelvaaModPlayer>().SeverePoison = true;}
}
}
