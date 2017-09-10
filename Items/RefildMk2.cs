using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class RefildMk2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("리엔필드-MK2");
			Tooltip.SetDefault("스프라이트 제작자 : Nagu");
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.useAnimation = 50;
			item.damage = 100;
			item.knockBack = 7;
			item.width = 20;
			item.height = 20;
			item.useTime = 50;
		    item.ranged = true;
			item.noMelee = true;
			item.autoReuse = false;
			item.useAmmo = AmmoID.Bullet;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Lee_enfield_Mk2");
            item.shoot = 10;
            item.shootSpeed = 80f;
			item.rare = 2;
			item.value = 100;
		    item.holdStyle = 0;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
		    recipe.AddIngredient(ItemID.Musket, 1);
            recipe.AddIngredient(ItemID.Musket, 1);
            recipe.AddTile(null, "WoodBench");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
