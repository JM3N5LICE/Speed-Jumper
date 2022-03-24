// This is where 
using genie;
using genie.cast;
using genie.script;
using genie.services;
using genie.services.raylib;
using hero.cast;

namespace hero.script {

    public class InstantiateEnemy : genie.script.Action
    {

        
            Platform Enemy1 = new Platform("", 100, 50, 300, 500, 0, 0);
            Platform Enemy2 = new Platform("", 100, 50, 500, 600, 0, 0);
            Platform Enemy3 = new Platform("", 100, 50, 1200, 600, 0, 0);
            Platform Enemy4 = new Platform("", 100, 50, 1800, 600, 0, 0);
            Platform Enemy5 = new Platform("", 100, 50, 2400, 600, 0, 0);
        // cast.AddActor("platform", platform1);
        public InstantiateEnemy(int priority) : base(priority)
        {   

        }
        public override void execute(Cast cast, Script script, Clock clock, Callback callback)
        {
            cast.AddActor("Enemy", Enemy1);
            cast.AddActor("Enemy", Enemy2);
            cast.AddActor("Enemy", Enemy3);
            cast.AddActor("Enemy", Enemy4);
            cast.AddActor("Enemy", Enemy5);
            script.RemoveAction("update", this);
        }
    }
}