using genie;
using genie.cast;
using genie.script;
using genie.services;
using genie.services.raylib;

namespace hero.script
{
    class HandleHeroEnemyCollisions : genie.script.Action
    {
        // creates member variables
        private genie.cast.Actor? hero;
        private genie.cast.Actor? enemy;
        RaylibPhysicsService? physicsService;
        
        public HandleHeroEnemyCollisions(int priority, RaylibPhysicsService physicsService) : base(priority)
        {
            this.hero = null;
            this.physicsService = physicsService;
            this.enemy = null;
        }

        // internal RaylibPhysicsService? physicsService { get => physicsService; set => physicsService = value; }

        public override void execute(Cast cast, Script script, Clock clock, Callback callback)
        {
          
        //     this.hero = cast.GetFirstActor("hero");
            
            
        //     foreach (Actor enemy in cast.GetActors("enemy"))
        //     {
        //         if(hero != null)
        //         {
        //             float vy = hero.GetVy();
        //             // Console.WriteLine("Was this called?");
        //             // How do you create a boolean that would set the apply gravity to be false here? --Jeremy Doung
        //             // Actor? collideGround = this.physicsService.CheckCollision(this.hero, this.ground);
        //             if (this.physicsService.CheckCollision(this.hero, enemy))
        //             {
        //                 // ApplyGravity.gravity = false;
        //                 // Console.WriteLine("gravity worked");
        //                 // this.hero = cast.GetFirstActor("hero");
        //                 if(this.physicsService.IsAbove(this.hero, enemy))
        //                 {
        //                     this.hero.SetVy(0);
        //                     (float, float) topLeft = enemy.GetTopLeft();
        //                     int halfHero = (this.hero.GetHeight())/2;
        //                     this.hero.SetY((topLeft.Item2)-halfHero);
        //                     this.hero.SetGround(true);
        //                     foreach (Actor actor in cast.GetAllActors())
        //                     {
        //                         if(this.enemy == enemy)
        //                         {
        //                             cast.RemoveActor("enemy", enemy);
        //                         }
        //                     }
        //                 }
        //                 if(this.physicsService.IsBelow(this.hero, enemy))
        //                 {
        //                     this.hero.SetVy(0);
        //                     (float, float) bottomLeft = enemy.GetBottomLeft();
        //                     int halfHero = (this.hero.GetHeight())/2;
        //                     this.hero.SetY((bottomLeft.Item2)+halfHero);
        //                 }
        //                 if(this.physicsService.IsLeftOf(hero, enemy))
        //                 {
        //                     this.hero.SetVx(0);
        //                     (float, float) topLeft = enemy.GetTopLeft();
        //                     int halfHero = (this.hero.GetWidth())/2;
        //                     this.hero.SetX((topLeft.Item1)-halfHero);
                            
        //                 }
        //                 if(this.physicsService.IsRightOf(this.hero, enemy))
        //                 {
        //                     this.hero.SetVx(0);
        //                     (float, float) topRight = enemy.GetTopRight();
        //                     int halfHero = (this.hero.GetWidth())/2;
        //                     this.hero.SetX((topRight.Item1)+halfHero);
                            
            //             }
            //         }
            //     }
            // }
        }
    }
}