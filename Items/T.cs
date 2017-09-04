using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class T : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("GS");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.useAnimation = 20;
			item.damage = 10;
			item.knockBack = 7;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
		    item.ranged = true;
			item.noMelee = true;
			item.autoReuse = false;
			item.UseSound = SoundID.Item14;
			item.useAmmo = AmmoID.Bullet;
		    item.shoot = mod.ProjectileType("Q");
            item.shootSpeed = 16f;
			item.rare = 2;
			item.value = 100;

        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
		    recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}



        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-22, 0);
        }

        //¼¦°Ç
        public static Vector2[] randomSpread(float speedX, float speedY, int angle, int num)
	    {
	        var posArray = new Vector2[num];
	        float spread = (float)(angle * 0.0134532925);
	        float baseSpeed = (float)System.Math.Sqrt(speedX * speedX + speedY * speedY);
	        double baseAngle = System.Math.Atan2(speedX, speedY);
	        double randomAngle;
	        for (int i = 0; i < num; ++i)
	        {
	            randomAngle = baseAngle + (Main.rand.NextFloat() - 0.5f) * spread;
	            posArray[i] = new Vector2(baseSpeed * (float)System.Math.Sin(randomAngle), baseSpeed * (float)System.Math.Cos(randomAngle));
	        }
	        return (Vector2[])posArray;
	    }

	    public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
	    {
	        type = mod.ProjectileType("Q");
            Vector2[] speeds = randomSpread(speedX, speedY, 8, 6);
	        for (int i = 0; i < 5; i++)
	        {
	            Projectile.NewProjectile(position.X, position.Y, speeds[i].X, speeds[i].Y, type, damage, knockBack, player.whoAmI);
	        }
	        return false;
	    }
        //¼¦°Ç ³¡

	    
    }
}
