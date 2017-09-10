using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class Ranger_medal : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("������ �޴�");
			Tooltip.SetDefault("�� �޴��� �� ���� ���� �������°Ͱ���."
                + "\n���Ÿ� ������ +8%" + "\n���� +0" + "\n���Ÿ� ũ��Ƽ��Ȯ�� +5%");
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
