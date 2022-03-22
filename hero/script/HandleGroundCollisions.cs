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
        // creates member variables
        private genie.cast.Actor? hero;
        private genie.cast.Actor? ground;
        private RaylibPhysicsService physicsService;
        
        public HandleGroundCollisions(int priority) : base(priority)
        {
            
        }

        public override void execute(Cast cast, Script script, Clock clock, Callback callback)
        {
            float vy = this.hero.GetVy();
            // How do you create a boolean that would set the apply gravity to be false here? --Jeremy Doung
            if (this.physicsService.CheckCollision(this.hero, ground))
            {
                // ApplyGravity.gravity = true;
                // this.hero = cast.GetFirstActor("hero");
                // this.hero.SetVy(0);
            }
            else
            {
                // ApplyGravity.gravity = false;
            }
        }
    }
}