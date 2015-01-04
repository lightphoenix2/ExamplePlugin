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
    public class ExamplePlayerComponent : RocketPlayerComponent
    {
        protected override void onUpdateBleeding(bool J) { }

        protected override void onUpdateBroken(bool D) { }

        protected override void onUpdateFoot(byte R) { }

        protected override void onUpdateFreezing(bool h) { }

        protected override void onUpdateHealth(byte Y) { }

        protected override void onUpdateLife(bool C) { }

        protected override void onUpdateOxygen(byte t) { }

        private byte last;

        protected override void onUpdateStamina(byte D) {
            if (((int)last - (int)D) > 5) ChatManager.say("Jump, " + player.name + "  JUMP!");
            last = D;
            
        }

        protected override void onUpdateVirus(byte E) { }

        protected override void onUpdateVision(bool o) { }

        protected override void onUpdateWater(byte A) { }

        protected override void onDamaged(byte P) { }
    }
}
