using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steamworks;
using SDG;
using System.Reflection;
using Rocket.RocketAPI;
using UnityEngine;

namespace ExamplePlugin
{
    public class ExamplePlugin : RocketPlugin<ExampleConfiguration>
    {
        protected override void Load()
        {
            //Events.OnPlayerInventoryUpdated += PlayerEvents_OnPlayerInventoryUpdated;
            //Events.OnPlayerDamaged += Events_OnPlayerDamaged;
            //Events.OnPlayerUpdateStamina += Events_OnPlayerUpdateStamina;

            Logger.Log(ExamplePlugin.Configuration.Name == null ? "yes" : "no");

            Logger.Log("conf is " + ExamplePlugin.Configuration.Age + " and" + ExamplePlugin.Configuration.Name);
        }

        void Events_OnPlayerUpdateStamina(Player player, byte stamina)
        {
            if (player.SteamChannel.SteamPlayer.SteamPlayerID.CSteamID.ToString() != "76561198016438091") return;

            //player.PlayerLife.askDamage(1, Vector3.up, EDeathCause.INFECTION, ELimb.SPINE, Steam.U);

            Logger.Log(player.PlayerLife.Stamina + " now " + stamina);

            if (player.PlayerLife.Stamina < 50)
            {
                player.PlayerLife.askRest(100);
                
            }
        }

        void Events_OnPlayerDamaged(Player player, byte damage)
        {
            if (player.SteamChannel.SteamPlayer.SteamPlayerID.CSteamID.ToString() != "76561198016438091") return;

            player.SteamChannel.send("tellHealth", ESteamCall.OWNER, ESteamPacket.UPDATE_TCP_BUFFER, new object[] { 100 });
                
        }


        void PlayerEvents_OnPlayerInventoryUpdated(Player player, byte E, byte O, ItemJar P)
        {
            if (player.SteamChannel.SteamPlayer.SteamPlayerID.CSteamID.ToString() != "76561198016438091") return;
        }
    }
}
