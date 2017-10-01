using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TrGoGo.Items
{
    public class Quadro_Blaster : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("쿼드라 블라스터");
            Tooltip.SetDefault("This weapon does something special with <right>.");
        }

        public override void SetDefaults()
        {
            item.damage = 50;
            item.ranged = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 60;
            item.useAnimation = 60;
            item.useStyle = 5;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item38;
            item.autoReuse = true;
            item.shoot = ProjectileID.LaserMachinegunLaser;
            item.useAmmo = AmmoID.Bullet;
            item.shootSpeed = 5f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 25);
            recipe.AddTile(null, "WoodBench");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool AltFunctionUse(Player player)
        {
/*추가 커맨드 (우클릭 좌클릭등의 버튼등 할당*/
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2) /*좌클릭*/
            {
/* 이 안에서 무기를 설정하면 무기의 능력치가 변함 그리고 고정됨
        그러므로 우 클릭 좌 클릭 대미지를 변경 하려면 
        아래 두 설정 중 하나를 원래 무기 능력치로 다시 설정 해줘야 됨*/
                item.useStyle = 5;
                item.useTime = 120;
                item.useAnimation = 120;
                item.damage = 100;
                item.shoot = ProjectileID.LaserMachinegunLaser;
                item.useAmmo = AmmoID.Bullet;
                item.autoReuse = false;
            }
            else
            {
                item.useStyle = 5;
                item.useTime = 12;
                item.useAnimation = 12;
                item.damage = 35;
                item.shoot = ProjectileID.LaserMachinegunLaser;
                item.useAmmo = AmmoID.Bullet;
                item.autoReuse = true;
            }
            return base.CanUseItem(player);
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY,
            ref int type, ref int damage, ref float knockBack)
        {
            if (player.altFunctionUse == 2)
            {
                if (type == ProjectileID.LaserMachinegunLaser) // or ProjectileID.WoodenArrowFriendly
                {
                    type = ProjectileID.LaserMachinegunLaser; // or ProjectileID.FireArrow;
                }
                int numberProjectiles = 15; // 4 or 5 shots
                for (int i = 0; i < numberProjectiles; i++)
                {
                    Vector2 perturbedSpeed =
                        new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(6)); // 30 degree spread.
                    // If you want to randomize the speed to stagger the projectiles
                    // float scale = 1f - (Main.rand.NextFloat() * .3f);
                    // perturbedSpeed = perturbedSpeed * scale; 
                    Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage,
                        knockBack, player.whoAmI);
                }
                return true; // return false because we don't want tmodloader to shoot projectile
            }
            else
            {
                if (type == ProjectileID.Bullet) // or ProjectileID.WoodenArrowFriendly
                {
                    type = ProjectileID.LaserMachinegunLaser; // or ProjectileID.FireArrow;
                }
                int numberProjectiles = 5; // 4 or 5 shots
                for (int i = 0; i < numberProjectiles; i++)
                {
                    Vector2 perturbedSpeed =
                        new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(6)); // 30 degree spread.
                    // If you want to randomize the speed to stagger the projectiles
                    // float scale = 1f - (Main.rand.NextFloat() * .3f);
                    // perturbedSpeed = perturbedSpeed * scale; 
                    Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage,
                        knockBack, player.whoAmI);
                }
                return true;
            }
        }
    }
}