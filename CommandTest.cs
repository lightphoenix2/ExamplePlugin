using Rocket;
using Rocket.RocketAPI;
using Rocket.RocketAPI.Components;
using SDG;
using Steamworks;

namespace ExamplePlugin
{
    class CommandTest : Command
    {
        public CommandTest()
        {
            base.commandName = "test";
            base.commandInfo = base.commandHelp = "This is a testcommand";
        }

        protected override void execute(SteamPlayerID caller, string command)
        {
        }

        void RocketPlayerComponent_OnDamaged(CSteamID caller, byte d)
        {
            Logger.Log("Invoker: "+caller.ToString()+" Value:"+d);
        }
    }
}
