using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class IronBench2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("ö�� ������");
			Tooltip.SetDefault("ö �� �� ���� ��� ����� �ֽ��ϴ�.");
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
		    item.createTile = mod.TileType("IronBench");
            item.consumable = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
		    recipe.AddIngredient(ItemID.LeadBar, 30);
            recipe.AddTile(null , "StoneBench");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
