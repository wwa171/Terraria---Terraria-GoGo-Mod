using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class Q : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("¡÷¥‘¿« ∞Á¿∏∑Œ");
			Tooltip.SetDefault("«—πÊø° ¡÷¥‘∞Á¿∏∑Œ ∫∏≥Ω¥Ÿ");
		}
		public override void SetDefaults()
		{
			item.damage = 2000;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.sellPrice(0, 0, 0, 20);
            item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		    item.shoot = mod.ProjectileType("Q");
		    item.shootSpeed = 16f;

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
	}
}
