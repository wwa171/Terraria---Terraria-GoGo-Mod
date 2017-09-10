using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class Wood_Bullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("���� �Ѿ�");
			Tooltip.SetDefault("��¼��� �ν����°� �ƴϰ���...?");
		}
		public override void SetDefaults()
		{
			item.damage = 2;
		    item.ranged = true;
		    item.width = 8;
		    item.height = 8;
		    item.maxStack = 999;
		    item.consumable = true;
		    item.knockBack = 1.5f;
		    item.value = 0;
		    item.rare = 1;
		    item.shoot = 14;
		    item.shootSpeed = 15f;
		    item.ammo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
		    recipe.AddIngredient(ItemID.Wood, 1);
		    recipe.AddTile(null, "WoodBench");
            recipe.SetResult(this,5);
			recipe.AddRecipe();
		}
    }
}
