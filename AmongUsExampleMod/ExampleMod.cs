using AmongUs.Api;
using AmongUs.Loader;

namespace AmongUsExampleMod
{
	public class ExampleMod : Mod
	{
		public ExampleMod() : base("Example", "Example Mod", "0.0") {}

		public override void Load() {
			
			GameLobby.LobbyLoadEvent += manager => Log.Write("Game lobby loaded");

		}
	}
}
