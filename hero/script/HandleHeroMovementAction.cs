using genie;
using genie.cast;
using genie.script;
using genie.services;
using genie.services.raylib;

namespace hero.script {
    class HandleHeroMovementAction : genie.script.Action {
        
        private RaylibKeyboardService keyboardService;
        private genie.cast.Actor? hero;
        private List<int> keysOfInterest;
        private int heroMovementVel;

        public HandleHeroMovementAction(int priority, RaylibKeyboardService keyboardService) : base(priority) {
            this.keyboardService = keyboardService;
            this.hero = null;
            this.heroMovementVel = 4;
            this.keysOfInterest = new List<int>();
            this.keysOfInterest.Add(Keys.LEFT);
            this.keysOfInterest.Add(Keys.RIGHT);
            this.keysOfInterest.Add(Keys.SPACE);
        }

        public override void execute(Cast cast, Script script, Clock clock, Callback callback) {
            
            // Grab the hero from the cast
            this.hero = cast.GetFirstActor("hero");

            // Only move if hero is not null
            if (this.hero != null) {
                
                // Get the keysState from the keyboardService
                Dictionary<int, bool> keysState = keyboardService.GetKeysState(this.keysOfInterest);
                
                // Change the velocity to the appropriate value and let MoveActorsAction handle the
                // actual movement
                if (keysState[Keys.LEFT]) {
                    // this.hero.SetVx(-this.heroMovementVel);
                    foreach (Actor actor in cast.GetAllActors())
                    {
                        if (actor != this.hero)
                        {
                            actor.SetVx(this.heroMovementVel);
                        }

                    }
                }
                if (keysState[Keys.RIGHT]) {
                    // this.hero.SetVx(-this.heroMovementVel);
                    foreach (Actor actor in cast.GetAllActors())
                    {
                        if (actor != this.hero)
                        {
                            actor.SetVx(-this.heroMovementVel);
                        }
                    }
                }
                // Hero jumping
                if (keysState[Keys.SPACE]) {
                    this.hero.SetVy((-this.heroMovementVel)-5);
                    
                }

                // If none of the LEFT or RIGHT keys are down, x-velocity is 0
                if (!(keysState[Keys.LEFT] || keysState[Keys.RIGHT])) {
                    foreach (Actor actor in cast.GetAllActors())
                    {
                        if (actor != this.hero)
                        {
                            actor.SetVx(0);
                        }
                    }
                }

                // If none of the UP or DOWN keys are down, y-velocity is 0
                if (!(keysState[Keys.SPACE])) {
                    this.hero.SetVy(0);
                }
            }
        }
    }
}