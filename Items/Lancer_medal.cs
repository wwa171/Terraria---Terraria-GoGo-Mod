using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class Lancer_medal : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("â���� �޴�");
			Tooltip.SetDefault("�� �޴��� �� ���� ���� ���� �ź��� ����� ������."
                + "\n�и������� +5%" + "\n���� -3" + "\n�и� ũ��Ƽ��Ȯ�� +5%" + "\n??? : �����ض� ����");
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
