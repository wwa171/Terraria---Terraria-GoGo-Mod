using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class Wood_Crossbow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("목재 석궁");
			Tooltip.SetDefault("나무로 만든 조잡한 리볼버다");
		}
		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.useAnimation = 33;
			item.damage = 8;
			item.knockBack = 7;
			item.width = 20;
			item.height = 20;
			item.useTime = 33;
		    item.ranged = true;
			item.noMelee = true;
			item.autoReuse = false;
			item.UseSound = SoundID.Item5;
			item.useAmmo = AmmoID.Arrow;
		    item.shoot = 10;
            item.shootSpeed = 16f;
			item.rare = 2;
			item.value = 100;
		    item.holdStyle = 3;

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
