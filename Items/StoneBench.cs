using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class StoneBench : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("석재 조립대");
			Tooltip.SetDefault("돌 로 더 많은 장비를 만들수 있습니다.");
		}
		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 22;
			item.useTime = 10;
		    item.maxStack = 99;
			item.useStyle = 1;
		    item.useTurn = true;
			item.value = 150;
            item.rare = 1;
		    item.createTile = mod.TileType("StoneBench");
            item.consumable = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
		    recipe.AddIngredient(ItemID.StoneBlock, 50);
            recipe.AddTile(null , "WoodBench");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
