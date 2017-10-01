using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class Vol_mount : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("���ؽ� ����ũ Ű");
			Tooltip.SetDefault("��������Ʈ ������ : Neutrin.");
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