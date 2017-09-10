using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class Xenic_Rifle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("제닉 라이플");
			Tooltip.SetDefault("녹조류 총알을 발사합니다.");
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.useAnimation = 9;
			item.damage = 25;
			item.knockBack = 1;
			item.width = 20;
			item.height = 20;
			item.useTime = 9;
		    item.ranged = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Bullet;
            item.UseSound = SoundID.Item11;
            item.shoot = 207;
            item.shootSpeed = 80f;
			item.rare = 7;
			item.value = 120000;
		    item.holdStyle = 0;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
		    recipe.AddIngredient(ItemID.HallowedBar, 15);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
		    recipe.AddIngredient(ItemID.IllegalGunParts, 10);
            recipe.AddIngredient(null, "Soul_of_Mind");
            recipe.anyIronBar = true;
            recipe.AddTile(null, "BluePrintBench");
            recipe.SetResult(this);
			recipe.AddRecipe();
	    }

	    public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type,
	        ref int damage, ref float knockBack)
	    {
            if (type == ProjectileID.Bullet) // or ProjectileID.WoodenArrowFriendly
            {
                type = ProjectileID.ChlorophyteBullet; // or ProjectileID.FireArrow;
            }
            
            Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(13));
	        speedX = perturbedSpeed.X;
	        speedY = perturbedSpeed.Y;
	        return true;
        }
    }
}
