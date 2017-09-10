using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class Lancer_medal : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("창잡이 메달");
			Tooltip.SetDefault("이 메달을 목에 걸자 무기 날에 신비한 기운이 감돈다."
                + "\n밀리데미지 +5%" + "\n방어력 -3" + "\n밀리 크리티걸확률 +5%" + "\n??? : 자해해라 랜서");
        }
		public override void SetDefaults()
		{
			item.width = 10;
			item.height = 14;
			item.value = 10;
            item.rare = 2;
		    item.accessory = true;
		    item.defense = -3;
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
            player.meleeDamage += 0.05f;
            player.meleeCrit += 5;
        }
    }
}
