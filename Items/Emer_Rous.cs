using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class Emer_Rous : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Emer Rous");
			Tooltip.SetDefault("ÅºÆÛÁü ½ÉÇÔ");
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.useAnimation = 7;
			item.damage = 50;
			item.knockBack = 1;
			item.width = 20;
			item.height = 20;
			item.useTime = 7;
		    item.ranged = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Bullet;
            item.UseSound = SoundID.Item11;
            item.shoot = 10;
            item.shootSpeed = 80f;
			item.rare = 4;
			item.value = 20000;
		    item.holdStyle = 0;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
		    recipe.AddIngredient(ItemID.SoulofNight, 20);
            recipe.AddIngredient(ItemID.IronBar, 15);
		    recipe.AddIngredient(ItemID.IllegalGunParts, 2);
            recipe.anyIronBar = true;
            recipe.AddTile(null, "BluePrintBench");
            recipe.SetResult(this);
			recipe.AddRecipe();
	    }

	    public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
	        Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(13));
	        speedX = perturbedSpeed.X;
	        speedY = perturbedSpeed.Y;
	        return true;
	    }
}
}
