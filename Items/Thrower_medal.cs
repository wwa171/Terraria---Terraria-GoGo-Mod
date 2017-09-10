using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
	public class Thrower_medal : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("���ο��� �޴�");
			Tooltip.SetDefault("�� �޴��� �� ���� ���� ���������Ͱ���."
                + "\n������ ������ +5%" + "\n���� +1" + "\n������ ũ��Ƽ��Ȯ�� +5%");
        }
		public override void SetDefaults()
		{
			item.width = 10;
			item.height = 14;
			item.value = 10;
            item.rare = 2;
		    item.accessory = true;
		    item.defense = 1;
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
            player.thrownDamage -= 0.05f;
            player.thrownCrit -= 5;

        }
    }
}
