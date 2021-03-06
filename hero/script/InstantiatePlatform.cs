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
            Platform platform9 = new Platform("./hero/assets/brick.png", 100, 50, 8150, 500, 0, 0);
            Platform platform10 = new Platform("./hero/assets/brick.png", 100, 50, 7900, 600, 0, 0);
            Platform platform8 = new Platform("./hero/assets/brick.png", 100, 50, 2000, 600, 0, 0);
            Platform platform11 = new Platform("./hero/assets/brick.png", 100, 50, 2150, 650, 0, 0);

            Platform platform12 = new Platform("./hero/assets/brick.png", 100, 50, 2500, 600, 0, 0);
            Platform platform13 = new Platform("./hero/assets/brick.png", 100, 50, 2650, 650, 0, 0);

            Platform platform14 = new Platform("./hero/assets/brick.png", 100, 50, 3500, 600, 0, 0);
            Platform platform15 = new Platform("./hero/assets/brick.png", 100, 50, 3650, 650, 0, 0);

            Platform platform16 = new Platform("./hero/assets/brick.png", 100, 50, 4500, 600, 0, 0);
            Platform platform17 = new Platform("./hero/assets/brick.png", 100, 50, 4650, 650, 0, 0);



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
            cast.AddActor("platform", platform11);

            cast.AddActor("platform", platform12);
            cast.AddActor("platform", platform13);
            cast.AddActor("platform", platform14);
            cast.AddActor("platform", platform15);
            cast.AddActor("platform", platform16);
            cast.AddActor("platform", platform17);
            script.RemoveAction("update", this);
        }
    }
}