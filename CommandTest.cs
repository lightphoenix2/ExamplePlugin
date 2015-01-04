using SDG;

namespace ExamplePlugin
{
    class CommandTest : Command
    {
        public CommandTest()
        {
            base.commandName = "test";
            base.commandInfo = base.commandHelp = "This is a testcommand";
        }

        public override void execute(SteamPlayerID caller, string command)
        {
            ChatManager.say("Test");
        }
    }
}
