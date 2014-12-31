using System;
using System.Text;

using SDG;
using UnityEngine;
using Rocket.RocketAPI;

namespace ExamplePlugin
{
    class CommandTest : RocketCommand
    {
        public void Execute(SDG.SteamPlayerID caller, string command)
        {
            ChatManager.say(String.Format("Your testmessage is: {0}", ExamplePlugin.Configuration.aText));
        }

        public string Name
        {
            get { return "Test"; }
        }

        public string Help
        {
            get { return "This is a helpmessage"; }
        }
    }
}
