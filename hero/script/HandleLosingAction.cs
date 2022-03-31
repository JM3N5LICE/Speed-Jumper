using genie;
using genie.cast;
using genie.script;
using genie.services;
using genie.services.raylib;

using hero.cast;

namespace hero.script {
    class HandleLosingAction : genie.script.Action {
        // private Boolean gameOver;
        private float levelHeight = 2000;
        // private float levelWidth = 0;
        
        
        private RaylibScreenService screenService;
        GameOver gameOver = new GameOver("./hero/assets/GameOver.png", 1000, 500, 500, 400, 0, 0);

        public HandleLosingAction(int priority, RaylibScreenService screenService) : base(priority) {
            this.screenService = screenService;
            // this.gameOver = false;
        }
// The execute that is triggered when the hero is dead.
        public override void execute(Cast cast, Script script, Clock clock, Callback callback) {
            
            Actor hero = cast.GetFirstActor("hero");
            //player fell off map
            if(hero.GetY() >= levelHeight || ((HasLifeActor)hero).GetHP() <= 0)
            {
                // endGame(cast, hero);

                // Say Game Over
                cast.AddActor("gameOver", gameOver);
                // stop the hero from moving & close the game
                cast.RemoveActor("hero", hero);
                // Play Game over Sound
            }
        }
    }
}