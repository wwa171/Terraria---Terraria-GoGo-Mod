using Terraria;
using Terraria.ModLoader;

namespace TrGoGo.Projectiles
{
	public class Prous_Blade_Pro : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(595);

			aiType = 595;
			Main.projFrames[projectile.type] = 28;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Prous_Blade_Pro");

		}


	}
}
