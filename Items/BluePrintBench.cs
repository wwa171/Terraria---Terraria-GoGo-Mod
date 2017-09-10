using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class BluePrintBench : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("블루프린트 작업대");
			Tooltip.SetDefault("전문적인 기술이 필요한 아이템을 만들수 있습니다." + "\n스프라이트 제작자 : Uriah");
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
            item.rare = 4;
		    item.createTile = mod.TileType("BluePrintBench");
            item.consumable = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
		    recipe.AddIngredient(ItemID.Hellforge, 1);
		    recipe.AddIngredient(ItemID.IronBar, 10);
		    recipe.AddIngredient(ItemID.Silk, 5);
		    recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.anyIronBar = true;
		    recipe.anyWood = true;
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
