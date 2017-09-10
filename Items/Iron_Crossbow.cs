using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class Iron_Crossbow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("√∂¿Á ºÆ±√");
			Tooltip.SetDefault("√∂∑Œ ∏∏µÁ ºÆ±√¿Ã¥Ÿ.");
		}
		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.useAnimation = 35;
			item.damage = 13;
			item.knockBack = 7;
			item.width = 20;
			item.height = 20;
			item.useTime = 35;
		    item.ranged = true;
			item.noMelee = true;
			item.autoReuse = false;
			item.UseSound = SoundID.Item5;
			item.useAmmo = AmmoID.Arrow;
		    item.shoot = 10;
            item.shootSpeed = 18f;
			item.rare = 3;
			item.value = 100;
		    item.holdStyle = 0;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
		    recipe.AddIngredient(ItemID.LeadBar, 15);
		    recipe.AddIngredient(ItemID.Wood, 5);
            recipe.AddTile(null, "IronBench");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
