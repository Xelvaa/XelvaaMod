using Terraria;
using Terraria.ID;
using Terraria.Modloader;
using XelvaaMod.Content.Buffs;

public override void UpdateBadLifeRegen()
    {
        void DamageOverTime(int badLifeRegen, bool affectLifeRegenCount = false)
        {
            if (Player.lifeRegen > 0)
                Player.lifeRegen = 0;

            if (affectLifeRegenCount && Player.lifeRegenCount > 0)
                Player.lifeRegen = 0;

            Player.lifeRegenTime = 0;
            Player.lifeRegen -= badLifeRegen;
        }
        if (Toxic)
            DamageOverTime(40);
    }