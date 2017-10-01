using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class Nerous_Blade : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Arkhalis);

			item.damage = 90;
		    item.value = 120000;
		    item.useTime = 30;
		    item.useAnimation = 30;
        }

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("네로우스 블레이드");
			Tooltip.SetDefault("파랑색이 좋겠군!");
		}


		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = mod.ProjectileType("Nerous_Blade_Pro");
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 1);
			recipe.SetResult(this);
            recipe.AddTile(null, "BluePrintBench");
            recipe.AddRecipe();
		}
	}
}
