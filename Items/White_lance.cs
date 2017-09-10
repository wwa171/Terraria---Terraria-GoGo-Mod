using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class White_lance : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("화이트 랜스");
			Tooltip.SetDefault("신성한 기운이 느껴진다." + "\n스프라이트 제작자: MelonFanta");
		}
		public override void SetDefaults()
		{
		    item.damage = 50;
		    item.melee = true;
		    item.width = 38;
		    item.height = 38;
		    item.scale = 1.1f;
		    item.maxStack = 1;
		    item.useTime = 20;
		    item.useAnimation = 20;
		    item.knockBack = 4f;
		    item.UseSound = SoundID.Item1;
            item.noMelee = true;
		    item.noUseGraphic = true;
		    item.useTurn = true;
		    item.useStyle = 5;
		    item.value = 20000;
		    item.rare = 3;
		    item.shoot = mod.ProjectileType("White_lance");
		    item.shootSpeed = 5f;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
		    recipe.AddIngredient(ItemID.CrystalShard, 20);
            recipe.AddIngredient(ItemID.PixieDust, 30);
            recipe.AddIngredient(ItemID.Wood, 25);
            recipe.AddIngredient(ItemID.IronBar, 20);
		    recipe.anyIronBar = true;
		    recipe.anyWood = true;
            recipe.AddTile(null, "BluePrintBench");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
