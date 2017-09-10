using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class Thrower_medal : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("쓰로워의 메달");
			Tooltip.SetDefault("이 메달을 목에 걸자 몸이 날렵해진것같다."
                + "\n쓰로잉 데미지 +5%" + "\n방어력 +1" + "\n쓰로잉 크리티걸확률 +5%");
        }
		public override void SetDefaults()
		{
			item.width = 10;
			item.height = 14;
			item.value = 10;
            item.rare = 2;
		    item.accessory = true;
		    item.defense = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 15);
		    recipe.anyIronBar = true;
            recipe.AddIngredient(mod,"WoodMedal");
            recipe.AddTile(null , "WoodBench");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.thrownDamage -= 0.05f;
            player.thrownCrit -= 5;

        }
    }
}
