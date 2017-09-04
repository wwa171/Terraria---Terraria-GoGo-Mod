using Terraria.ModLoader;

namespace TrGoGo
{
	class TrGoGo : Mod
	{
		public TrGoGo()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
