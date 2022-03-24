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
        RaylibPhysicsService? physicsService;
        
        public HandleGroundCollisions(int priority, RaylibPhysicsService physicsService) : base(priority)
        {
            this.hero = null;
            this.physicsService = physicsService;
            this.ground = null;
        }

        // internal RaylibPhysicsService? physicsService { get => physicsService; set => physicsService = value; }

        public override void execute(Cast cast, Script script, Clock clock, Callback callback)
        {
          
            this.hero = cast.GetFirstActor("hero");
            
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
                        if(this.physicsService.IsAbove(this.hero, platform))
                        {
                            this.hero.SetVy(0);
                            (float, float) upLeftPlatform = platform.GetTopLeft();
                            int halfHero = (this.hero.GetHeight())/2;
                            this.hero.SetY((upLeftPlatform.Item2)-halfHero);
                            this.hero.SetGround(true);
                        }
                        if(this.physicsService.IsBelow(this.hero, platform))
                        {
                            this.hero.SetVy(0);
                            (float, float) belowLeftPlatform = platform.GetBottomLeft();
                            int halfHero = (this.hero.GetHeight())/2;
                            this.hero.SetY((belowLeftPlatform.Item2)+halfHero);
                        }
                        // if(this.physicsService.IsLeftOfhero, platform))
                        // {
                        //     this.hero.SetVy(0);
                        //     (float, float) upLeftPlatform = platform.GetTopLeft();
                        //     int halfHero = (this.hero.GetHeight())/2;
                        //     this.hero.SetY((upLeftPlatform.Item2)-halfHero);
                        //     this.hero.SetGround(true);
                        // }
                        // if(this.physicsService.IsRightOf(this.hero, platform))
                        // {
                        //     this.hero.SetVy(0);
                        //     (float, float) upLeftPlatform = platform.GetTopLeft();
                        //     int halfHero = (this.hero.GetHeight())/2;
                        //     this.hero.SetY((upLeftPlatform.Item2)-halfHero);
                        //     this.hero.SetGround(true);
                        // }
                    }
                }
            }
        }
    }
}