using AmongUs.Api;
using AmongUs.Api.Registry;
using AmongUs.Loader;

namespace AmongUsExampleMod
{
	public class ExampleMod : Mod
	{
		public ExampleMod() : base("Example", "Example Mod", "0.0") {}
		
		public override void Load(RegistrarProvider registrar)
		{
			GameLobby.LobbyLoadEvent += lobby => Log.Write("Game lobby loaded");
			registrar.GetRegistrar(KillDistance.Registry).Register("Infinite", new KillDistance(500));
		}
	}
}
