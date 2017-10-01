using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class Xenic_Sword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("제닉 소드");
			Tooltip.SetDefault("휘두를때마다 3개의 녹조류 총알을 발사합니다.");
		}
		public override void SetDefaults()
		{
			item.damage = 40;
			item.melee = true;
			item.width = 30;
			item.height = 30;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 120000;
			item.rare = 7;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 207;
            item.shootSpeed = 10f;
		}

	    public override void AddRecipes()
	    {
	        ModRecipe recipe = new ModRecipe(mod);
	        recipe.AddIngredient(ItemID.HallowedBar, 15);
	        recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
	        recipe.AddIngredient(null, "Soul_of_Mind");
	        recipe.anyIronBar = true;
	        recipe.AddTile(null, "BluePrintBench");
	        recipe.SetResult(this);
	        recipe.AddRecipe();
	    }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
	    {
	        int numberProjectiles = 3; // 4 or 5 shots
	        for (int i = 0; i < numberProjectiles; i++)
	        {
	            Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // 30 degree spread.
	            // If you want to randomize the speed to stagger the projectiles
	            // float scale = 1f - (Main.rand.NextFloat() * .3f);
	            // perturbedSpeed = perturbedSpeed * scale; 
	            Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
	        }
	        return false; // return false because we don't want tmodloader to shoot projectile
	    }
    }
}
