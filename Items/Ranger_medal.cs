using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class Ranger_medal : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("레인저 메달");
			Tooltip.SetDefault("이 메달을 목에 걸자 눈이 맑아지는것같다."
                + "\n원거리 데미지 +8%" + "\n방어력 +0" + "\n원거리 크리티걸확률 +5%");
        }
		public override void SetDefaults()
		{
			item.width = 10;
			item.height = 14;
			item.value = 10;
            item.rare = 2;
		    item.accessory = true;
		    item.defense = 0;
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
            player.rangedDamage += 0.08f;
            player.rangedCrit += 5;
        }
    }
}
