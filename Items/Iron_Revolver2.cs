using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
    public class Iron_Revolver2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("철재 리볼버");
            Tooltip.SetDefault("철 로 만든 리볼버다");
        }

        public override void SetDefaults()
        {
            item.useStyle = 5;
            item.useAnimation = 27;
            item.damage = 12;
            item.knockBack = 7;
            item.width = 20;
            item.height = 20;
            item.useTime = 27;
            item.ranged = true;
            item.noMelee = true;
            item.autoReuse = false;
            item.UseSound = SoundID.Item11;
            item.useAmmo = AmmoID.Bullet;
            item.shoot = 10;
            item.shootSpeed = 20f;
            item.rare = 2;
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
