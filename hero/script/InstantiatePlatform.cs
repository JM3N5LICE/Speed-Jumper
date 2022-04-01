using genie;
using genie.cast;
using genie.script;
using genie.services;
using genie.services.raylib;
using hero.cast;

namespace hero.script {

    public class InstantiatePlatform : genie.script.Action
    {

        
            Platform platform1 = new Platform("./hero/assets/brick.png", 100, 50, 300, 600, 0, 0);
            Platform platform2 = new Platform("./hero/assets/brick.png", 100, 50, 500, 600, 0, 0);
            Platform platform3 = new Platform("./hero/assets/brick.png", 100, 50, 6000, 600, 0, 0);
            Platform platform4 = new Platform("./hero/assets/brick.png", 100, 50, 1500, 600, 0, 0);
            Platform platform5 = new Platform("./hero/assets/brick.png", 100, 50, 5000, 600, 0, 0);

            
            Platform platform6 = new Platform("./hero/assets/brick.png", 100, 50, 4000, 600, 0, 0);
            Platform platform7 = new Platform("./hero/assets/brick.png", 100, 50, 3000, 600, 0, 0);
            Platform platform8 = new Platform("./hero/assets/brick.png", 100, 50, 2000, 600, 0, 0);
            Platform platform9 = new Platform("./hero/assets/brick.png", 100, 50, 8150, 500, 0, 0);
            Platform platform10 = new Platform("./hero/assets/brick.png", 100, 50, 7900, 600, 0, 0);


        public InstantiatePlatform(int priority) : base(priority)
        {   

        }
        public override void execute(Cast cast, Script script, Clock clock, Callback callback)
        {
            cast.AddActor("platform", platform1);
            cast.AddActor("platform", platform2);
            cast.AddActor("platform", platform3);
            cast.AddActor("platform", platform4);
            cast.AddActor("platform", platform5);
            cast.AddActor("platform", platform6);
            cast.AddActor("platform", platform7);
            cast.AddActor("platform", platform8);
            cast.AddActor("platform", platform9);
            cast.AddActor("platform", platform10);
            script.RemoveAction("update", this);
        }
    }
}