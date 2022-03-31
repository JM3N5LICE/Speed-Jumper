using genie;
using genie.cast;
using genie.script;
using genie.services;
using genie.services.raylib;
using hero.cast;

namespace hero.script
{
    class HandleHeroEndpointCollision : genie.script.Action
    {
        // creates member variables
        private genie.cast.Actor? hero;
        RaylibPhysicsService? physicsService;

        HandleHeroMovementAction? movement;
        Winner winner = new Winner("./hero/assets/winner.png", 1000, 500, 500, 400, 0, 0);
        public HandleHeroEndpointCollision(int priority, RaylibPhysicsService physicsService) : base(priority)
        {
            this.hero = null;
            this.physicsService = physicsService;
        }

        // internal RaylibPhysicsService? physicsService { get => physicsService; set => physicsService = value; }

        public override void execute(Cast cast, Script script, Clock clock, Callback callback)
        {
            hero = cast.GetFirstActor("hero");
            

            // Console.WriteLine("Was this called?");
            foreach (Actor endpoint in cast.GetActors("endpoint"))
            {
                if(hero != null)
                {
                    float vy = hero.GetVy();
                    // Console.WriteLine("Was this called?");
                    // How do you create a boolean that would set the apply gravity to be false here? --Jeremy Doung
                    // Actor? collideGround = this.physicsService.CheckCollision(this.hero, this.ground);
                    if (this.physicsService.CheckCollision(this.hero, endpoint))
                    {
                        // ApplyGravity.gravity = false;
                        // Console.WriteLine("gravity worked");
                        // this.hero = cast.GetFirstActor("hero");

                        
                        cast.AddActor("winner", winner);
                        movement = null;
                        
                        
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