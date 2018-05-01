using Terraria.ModLoader;

namespace FisherManNPC
{
	class FisherManNPC : Mod
	{
		public FisherManNPC()
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
