using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;

namespace FargowiltasSouls.Buffs
{
    public class AbomFang : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Abominable Fang");
            Description.SetDefault("The power of Masochist Mode compels you");
            Main.debuff[Type] = true;
            Main.buffNoSave[Type] = true;
            longerExpertDebuff = false;
            canBeCleared = false;
        }

        public override bool Autoload(ref string name, ref string texture)
        {
            texture = "FargowiltasSouls/Buffs/PlaceholderDebuff";
            return true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            FargoPlayer fargoPlayer = player.GetModPlayer<FargoPlayer>();
            player.ichor = true;
            player.onFire2 = true;
            player.electrified = true;
            player.moonLeech = true;
        }
    }
}