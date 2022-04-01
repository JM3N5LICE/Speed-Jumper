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

        
        Enemy enemy1 = new Enemy("./hero/assets/goomba.png", 50, 50, 900, 725, 15, 0);
        Enemy enemy2 = new Enemy("./hero/assets/goomba.png", 50, 50, 1500, 725, 15, 0);
        Enemy enemy3 = new Enemy("./hero/assets/goomba.png", 50, 50, 2100, 725, 15, 0);
        Enemy enemy4 = new Enemy("./hero/assets/goomba.png", 50, 50, 2800, 725, 15, 0);
        Enemy enemy5 = new Enemy("./hero/assets/goomba.png", 50, 50, 3500, 725, 15, 0);
        Enemy enemy6 = new Enemy("./hero/assets/goomba.png", 50, 50, 4200, 725, 15, 0);
        Enemy enemy7 = new Enemy("./hero/assets/goomba.png", 50, 50, 4900, 725, 15, 0);
        Enemy enemy8 = new Enemy("./hero/assets/goomba.png", 50, 50, 5600, 725, 15, 0);
        Enemy enemy9 = new Enemy("./hero/assets/goomba.png", 50, 50, 6300, 725, 15, 0);
        Enemy enemy10 = new Enemy("./hero/assets/goomba.png", 50, 50, 7000, 725, 15, 0);
        Enemy enemy11 = new Enemy("./hero/assets/goomba.png", 50, 50, 7300, 725, 15, 0);

        
        // cast.AddActor("platform", platform1);
        public InstantiateEnemy(int priority) : base(priority)
        {   

        }
        public override void execute(Cast cast, Script script, Clock clock, Callback callback)
        {
            cast.AddActor("enemy", enemy1);
            cast.AddActor("enemy", enemy2);
            cast.AddActor("enemy", enemy3);
            cast.AddActor("enemy", enemy4);
            cast.AddActor("enemy", enemy5);
            cast.AddActor("enemy", enemy6);
            cast.AddActor("enemy", enemy7);
            cast.AddActor("enemy", enemy8);
            cast.AddActor("enemy", enemy9);
            cast.AddActor("enemy", enemy10);
            cast.AddActor("enemy", enemy11);
            script.RemoveAction("update", this);
        }
    }
}