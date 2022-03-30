using genie;
using genie.cast;
using genie.script;
using genie.services;
using genie.services.raylib;
using hero.cast;

namespace hero.script {
    class HandleEnemyMovementAction : genie.script.Action {
        
        public HandleEnemyMovementAction(int priority) : base(priority) {

            


        }

        public override void execute(Cast cast, Script script, Clock clock, Callback callback) {
            List<Actor> enemyList = cast.GetActors("enemy");
            foreach(Enemy enemy in enemyList){
                if((DateTime.Now - enemy.GetLastDirectionSwitch()).Seconds >= 3){
                    enemy.SetDirection(-enemy.GetDirection());
                    enemy.SetLastDirectionSwitch(DateTime.Now);
                }
            }
            
            
        }
    }
}