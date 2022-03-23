// This action handles the collison of the hero with the platform so that he doesn't go through the platform
// Justyn
using genie;
using genie.cast;
using genie.script;
using genie.services;
using genie.services.raylib;

namespace hero.script
{
    class HandleHeroPlatformCollision : genie.script.Action
    {
        // creates member variables
        private genie.cast.Actor? hero;
        private genie.cast.Actor? platform;
        RaylibPhysicsService? physicsService;
        
        public HandleHeroPlatformCollision(int priority, RaylibPhysicsService physicsService) : base(priority)
        {
            this.hero = null;
            this.physicsService = physicsService;
            this.platform = null;
        }

        // internal RaylibPhysicsService? physicsService { get => physicsService; set => physicsService = value; }

        public override void execute(Cast cast, Script script, Clock clock, Callback callback)
        {
            if(cast.GetFirstActor("platform")!=null)
            {
            // Console.WriteLine("Was this called?");
            platform = cast.GetFirstActor("platform");
            }
            if(cast.GetFirstActor("hero")!=null)
            {
            // Console.WriteLine("Was this called?");
            hero = cast.GetFirstActor("hero");
            }
            if(hero != null && platform != null)
            {
                float vy = hero.GetVy();
                // Console.WriteLine("Was this called?");
                // How do you create a boolean that would set the apply gravity to be false here? --Jeremy Doung
                // Actor? collideGround = this.physicsService.CheckCollision(this.hero, this.ground);
                if (this.physicsService.CheckCollision(this.hero, this.platform))
                {
                    ApplyGravity.gravity = false;
                    Console.WriteLine("gravity worked");
                    this.hero = cast.GetFirstActor("hero");
                    this.hero.SetVy(0);
                }
                else
                {
                    ApplyGravity.gravity = true;
                    Console.WriteLine("gravity fails");
                }
            }
        }
    }
}