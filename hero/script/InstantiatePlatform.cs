using genie;
using genie.cast;
using genie.script;
using genie.services;
using genie.services.raylib;
using hero.cast;

namespace hero.script {

    public class InstantiatePlatform : genie.script.Action
    {

            private string path;
            Platform platform1 = new Platform("./hero/assets/brick.png", 100, 50, 300, 500, 0, 0);
            Platform platform2 = new Platform("./hero/assets/brick.png", 100, 50, 500, 600, 0, 0);
            Platform platform3 = new Platform("./hero/assets/brick.png", 100, 50, 1200, 600, 0, 0);
            Platform platform4 = new Platform("./hero/assets/brick.png", 100, 50, 1800, 600, 0, 0);
            Platform platform5 = new Platform("./hero/assets/brick.png", 100, 50, 2400, 600, 0, 0);
        // cast.AddActor("platform", platform1);
        public InstantiatePlatform(int priority, string path) : base(priority)
        {   
            this.path = path;
        }
        public override void execute(Cast cast, Script script, Clock clock, Callback callback)
        {
            cast.AddActor("platform", platform1);
            cast.AddActor("platform", platform2);
            cast.AddActor("platform", platform3);
            cast.AddActor("platform", platform4);
            cast.AddActor("platform", platform5);
            script.RemoveAction("update", this);
        }
    }
}