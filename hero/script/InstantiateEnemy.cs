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

        
            Enemy Enemy1 = new Enemy("./hero/assets/goomba.png", 50, 50, 900, 725, 15, 0);
            // Platform Enemy2 = new Platform("", 100, 50, 500, 600, 0, 0);
            // Platform Enemy3 = new Platform("", 100, 50, 1200, 600, 0, 0);
            // Platform Enemy4 = new Platform("", 100, 50, 1800, 600, 0, 0);
            // Platform Enemy5 = new Platform("", 100, 50, 2400, 600, 0, 0);
        // cast.AddActor("platform", platform1);
        public InstantiateEnemy(int priority) : base(priority)
        {   

        }
        public override void execute(Cast cast, Script script, Clock clock, Callback callback)
        {
            cast.AddActor("enemy", Enemy1);
            // cast.AddActor("enemy", Enemy2);
            // cast.AddActor("enemy", Enemy3);
            // cast.AddActor("enemy", Enemy4);
            // cast.AddActor("enemy", Enemy5);
            script.RemoveAction("update", this);
        }
    }
}