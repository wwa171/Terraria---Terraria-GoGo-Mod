using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class Warrior_medal : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("검사의 메달");
			Tooltip.SetDefault("이 메달을 목에 걸자 몸에 힘이 생긴다."
                + "\n밀리데미지 -5%" + "\n방어력 +3" + "\n밀리 크리티걸확률 -1%" + "\n최대체력 +5");
        }
		public override void SetDefaults()
		{
			item.width = 10;
			item.height = 14;
			item.value = 10;
            item.rare = 2;
		    item.accessory = true;
		    item.defense = 3;
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
            player.meleeDamage -= 0.05f;
            player.meleeCrit -= 1;
            player.statLifeMax2 += 5;
        }
    }
}
