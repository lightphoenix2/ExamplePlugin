using System;

using Steamworks;
using Rocket.RocketAPI;


namespace ExamplePlugin
{
    public class ExamplePlugin : RocketPlugin
    {

        public static ExampleConfiguration Configuration = RocketConfiguration.LoadConfiguration<ExampleConfiguration>();
     
        string RocketPlugin.Author
        {
            get { return "fr34kyn01535"; }
        }
        
        void RocketPlugin.Load()
        {
            Logger.Log("This is the ExamplePlugin load() " + Configuration.aNumber);
            RocketAPI.Commands.RegisterCommand(new CommandTest());

            RocketAPI.Events.PlayerConnected += onPlayerConnected;
            RocketAPI.Events.PlayerDisconnected += onPlayerDisconnected;
        }

        static void onPlayerConnected(CSteamID id)
        {
            Logger.Log("onPlayerConnected");
        }

        static void onPlayerDisconnected(CSteamID id)
        {
            Logger.Log("onPlayerDisconnected");
        }
    }
}
