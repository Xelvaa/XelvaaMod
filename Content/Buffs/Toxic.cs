using Terraria;
using Terraria.ID;
using Terraria.Modloader;

namespace XelvaaMod.Content.debuff {
    public class Toxic : ModBuff {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Toxic");
            Description.SetDefault("You're infected");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;}
        public override Update(Player player, ref int buffIndex){
            // le nouveau debuff doit faire 20 de dps (le poison pour info c'est 6) 
            // même effet visuel que le poison donc faut copier l'effet quoi
            player.GetModPlayer<XelvaaModPlayer>().Toxic = true;}
}
}
