using genie;
using genie.cast;
using genie.script;
using genie.services;
using genie.services.raylib;

using hero.cast;

namespace hero.script {
    class GameOver : genie.script.Action {
        
        private RaylibScreenService screenService;

        public GameOver(int priority, RaylibScreenService screenService) : base(priority) {
            this.screenService = screenService;
        }
// The execute that is triggered when the hero is dead.
        public override void execute(Cast cast, Script script, Clock clock, Callback callback) {

            if(||)
            {
                
            }
        }
    }
}