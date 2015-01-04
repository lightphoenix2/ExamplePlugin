using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steamworks;
using SDG;
using System.Reflection;
using Rocket;

namespace ExamplePlugin
{
    public class ExampleComponent : RocketComponent
    {
        private ExampleConfiguration configuration;
     
        protected override void Load()
        {
            configuration = Configuration.LoadConfiguration<ExampleConfiguration>();
            Logger.Log("This is the Testmod load()!" + configuration.Age);
        }

        protected override void onPlayerDisconnected(CSteamID D)
        {
            Logger.Log("onPlayerDisconnected");
        }

        protected override void onPlayerConnected(CSteamID r)
        {
            Logger.Log("onPlayerConnected");
        }

        protected override void onServerShutdown()
        {
            Logger.Log("onServerShutdown");
        }
    }
}
