using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class Nereus_Magnum : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("네레우스 매그넘");
			Tooltip.SetDefault("35%의 확률로 총알을 소모하지 않습니다.");
		}
		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.useAnimation = 10;
			item.damage = 30;
			item.knockBack = 7;
			item.width = 20;
			item.height = 20;
			item.useTime = 10;
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

	    public override bool ConsumeAmmo(Player player)
	    {
	        return Main.rand.NextFloat() >= .35f;
	    }
    }
}
