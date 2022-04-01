using genie;
using genie.cast;
using genie.script;
using genie.services;
using genie.services.raylib;
using hero.cast;

namespace hero.script
{
    class HandleWinningAction : genie.script.Action
    {
        // creates member variables
        private genie.cast.Actor? hero;
        RaylibPhysicsService? physicsService;
        
        public HandleWinningAction(int priority, RaylibPhysicsService physicsService) : base(priority)
        {
            this.hero = null;
            this.physicsService = physicsService;
        }

        // internal RaylibPhysicsService? physicsService { get => physicsService; set => physicsService = value; }

        public override void execute(Cast cast, Script script, Clock clock, Callback callback)
        {
            hero = cast.GetFirstActor("hero");

            // Console.WriteLine("Was this called?");
            Actor endpoint = cast.GetFirstActor("endpoint");
            if(hero != null)
            {
                float vy = hero.GetVy();
                // Console.WriteLine("Was this called?");
                // How do you create a boolean that would set the apply gravity to be false here? --Jeremy Doung
                // Actor? collideGround = this.physicsService.CheckCollision(this.hero, this.ground);
                if (this.physicsService.CheckCollision(this.hero, endpoint))
                {
                    // Black Screen
                    // Display Winning Message
                    // Play winning sound
                    // Close the game
                    Console.WriteLine("You win!");
                }
            } 
        }
    }
}