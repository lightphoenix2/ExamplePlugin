using Rocket.RocketAPI;
using Rocket.Logging;
using SDG;
using Rocket.RocketAPI.Events;

namespace ExamplePlugin
{
    internal class CommandTest : Command
    {
        public CommandTest()
        {
            base.commandName = "test";
            base.commandInfo = base.commandHelp = "This is a testcommand";
        }

        protected override void execute(SteamPlayerID caller, string command)
        {
            Player p = PlayerTool.getPlayer(caller.CSteamID);
            RocketPlayer pl = p.transform.gameObject.transform.GetComponent<RocketPlayer>();

            //pl.Bleeding = !pl.Bleeding;
            //pl.Broken = !pl.Broken;
            //pl.Damage(1, Vector3.down, EDeathCause.INFECTION, ELimb.LEFT_FOOT, new CSteamID(0));

            RocketPlayerEvents.OnPlayerUpdateBleeding += ple_OnPlayerUpdateBleeding;
			RocketPlayerEvents.OnPlayerUpdateBroken += ple_OnPlayerUpdateBroken;
			RocketPlayerEvents.OnPlayerUpdateFood += ple_OnPlayerUpdateFood;
			RocketPlayerEvents.OnPlayerUpdateHealth += ple_OnPlayerUpdateHealth;
			RocketPlayerEvents.OnPlayerUpdateLife += ple_OnPlayerUpdateLife;
			RocketPlayerEvents.OnPlayerUpdateStamina += ple_OnPlayerUpdateStamina;
			RocketPlayerEvents.OnPlayerUpdateVirus += ple_OnPlayerUpdateVirus;
			RocketPlayerEvents.OnPlayerUpdateWater += ple_OnPlayerUpdateWater;
        }

        private void ple_OnPlayerUpdateWater(Player player, byte water)
        {
            Logger.Log("ple_OnPlayerUpdateWater");
        }

        private void ple_OnPlayerUpdateVision(Player player, bool vision)
        {
            Logger.Log("ple_OnPlayerUpdateVision");
        }

        private void ple_OnPlayerUpdateVirus(Player player, byte virus)
        {
            Logger.Log("ple_OnPlayerUpdateVirus");
        }

        private void ple_OnPlayerUpdateStamina(Player player, byte stamina)
        {
            Logger.Log("ple_OnPlayerUpdateStamina");
        }

        private void ple_OnPlayerUpdateOxygen(Player player, byte oxygen)
        {
            Logger.Log("ple_OnPlayerUpdateOxygen");
        }

        private void ple_OnPlayerUpdateLife(Player player, byte life)
        {
            Logger.Log("ple_OnPlayerUpdateLife");
        }

        private void ple_OnPlayerUpdateHealth(Player player, byte health)
        {
            Logger.Log("ple_OnPlayerUpdateHealth");
        }

        private void ple_OnPlayerUpdateFreezing(Player player, bool freezing)
        {
            Logger.Log("ple_OnPlayerUpdateFreezing");
        }

        private void ple_OnPlayerUpdateFood(Player player, byte food)
        {
            Logger.Log("ple_OnPlayerUpdateFood");
        }

        private void ple_OnPlayerUpdateBroken(Player player, bool broken)
        {
            Logger.Log("ple_OnPlayerUpdateBroken");
        }

        private void ple_OnPlayerUpdateBleeding(Player player, bool bleeding)
        {
            Logger.Log("ple_OnPlayerUpdateBleeding");
        }
    }
}