using AmongUs.Api;
using AmongUs.ModLoader;

namespace AmongUsExampleMod
{
	public class ExampleMod : Mod
	{
		public ExampleMod() : base("Example", "Example Mod", "0.0") {}

		public override void Load()
		{
			Game.StartEvent += manager => Log.LogInfo("success");
		}
	}
}
