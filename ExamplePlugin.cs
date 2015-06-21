using Rocket.API;
using Rocket.Core.Logging;

namespace ExamplePlugin
{
    public class ExamplePlugin : IRocketPlugin<ExampleConfiguration>
    {
        protected override void Load()
        {
            //Events.OnPlayerInventoryUpdated += PlayerEvents_OnPlayerInventoryUpdated;
            //Events.OnPlayerDamaged += Events_OnPlayerDamaged;
            //Events.OnPlayerUpdateStamina += Events_OnPlayerUpdateStamina;

            Logger.Log(ExamplePlugin.Configuration.Name == null ? "yes" : "no");

            Logger.Log("conf is " + ExamplePlugin.Configuration.Age + " and" + ExamplePlugin.Configuration.Name);
        }
    }
}
