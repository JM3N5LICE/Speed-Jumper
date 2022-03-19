// Handle the collision between the ground and the hero actor
// Jeff 

using genie;
using genie.cast;
using genie.script;
using genie.services;
using genie.services.raylib;

namespace hero.script
{
    class HandleGroundCollisions : genie.script.Action
    {
        public HandleGroundCollisions(int priority) : base(priority)
        {
            
        }

        public override void execute(Cast cast, Script script, Clock clock, Callback callback)
        {
            // throw new NotImplementedException();
        }
    }
}