using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class Soul_of_Mind : ModItem
	{
		public override void SetStaticDefaults()
		{
		    DisplayName.SetDefault("소울 오브 마인드");
		    Tooltip.SetDefault("불안정해서 금방이라도 사라질것같다.");
		}

        public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 10;
			item.value = 100000;
			item.rare = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofLight, 10);
		    recipe.AddIngredient(ItemID.SoulofNight, 10);
		    recipe.AddIngredient(ItemID.SoulofMight, 10);
		    recipe.AddIngredient(ItemID.SoulofSight, 10);
		    recipe.AddIngredient(ItemID.SoulofFright, 10);
		    recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.SetResult(this, 1);
		    recipe.AddTile(null, "BluePrintBench");
		    recipe.AddRecipe();
        }
	}
}
