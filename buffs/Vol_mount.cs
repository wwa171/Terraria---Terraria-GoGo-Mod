using Terraria;
using Terraria.ModLoader;

namespace TrGoGo.buffs
{
    public class Vol_mount : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Vol");
            Description.SetDefault("빠르게 달릴수 있습니다.");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(mod.MountType<Mounts.Vol>(), player);
            player.buffTime[buffIndex] = 10;
        }
    }
}