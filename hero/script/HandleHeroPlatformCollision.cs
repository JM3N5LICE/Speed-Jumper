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
        RaylibPhysicsService? physicsService;
        
        public HandleHeroPlatformCollision(int priority, RaylibPhysicsService physicsService) : base(priority)
        {
            this.hero = null;
            this.physicsService = physicsService;
        }

        // internal RaylibPhysicsService? physicsService { get => physicsService; set => physicsService = value; }

        public override void execute(Cast cast, Script script, Clock clock, Callback callback)
        {
            hero = cast.GetFirstActor("hero");

            // Console.WriteLine("Was this called?");
            foreach (Actor platform in cast.GetActors("platform"))
            {
                if(hero != null)
                {
                    float vy = hero.GetVy();
                    // Console.WriteLine("Was this called?");
                    // How do you create a boolean that would set the apply gravity to be false here? --Jeremy Doung
                    // Actor? collideGround = this.physicsService.CheckCollision(this.hero, this.ground);
                    if (this.physicsService.CheckCollision(this.hero, platform))
                    {
                        // ApplyGravity.gravity = false;
                        // Console.WriteLine("gravity worked");
                        // this.hero = cast.GetFirstActor("hero");
                        this.hero.SetVy(0);
                        (float, float) upLeftPlatform = platform.GetTopLeft();
                        int halfHero = (this.hero.GetHeight())/2;
                        this.hero.SetY((upLeftPlatform.Item2)-halfHero);
                    }
                    else
                    {
                        // ApplyGravity.gravity = true;
                        // Console.WriteLine("gravity falls");
                    }
                }    
            }
        
        }
    }
}