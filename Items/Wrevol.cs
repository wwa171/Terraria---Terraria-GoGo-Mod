using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class Wrevol : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("목재 리볼버");
			Tooltip.SetDefault("나무로 만든 조잡한 리볼버다");
		}
		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.useAnimation = 30;
			item.damage = 7;
			item.knockBack = 7;
			item.width = 20;
			item.height = 20;
			item.useTime = 30;
		    item.ranged = true;
			item.noMelee = true;
			item.autoReuse = false;
			item.UseSound = SoundID.Item11;
			item.useAmmo = AmmoID.Bullet;
		    item.shoot = 10;
            item.shootSpeed = 18f;
			item.rare = 2;
			item.value = 100;
		    item.holdStyle = 0;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
		    recipe.AddIngredient(ItemID.Wood, 25);
		    recipe.AddTile(null, "WoodBench");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
