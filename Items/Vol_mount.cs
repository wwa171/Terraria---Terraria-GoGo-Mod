using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class Vol_mount : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("볼텍스 바이크 키");
			Tooltip.SetDefault("스프라이트 제작자 : Neutrin.");
        }
		public override void SetDefaults()
		{
            item.width = 20;
            item.height = 30;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.value = 300;
            item.rare = 5;
            item.noMelee = true;
            item.mountType = mod.MountType("Vol");
        }


    }
}