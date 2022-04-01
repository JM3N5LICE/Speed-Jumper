using genie;
using genie.cast;
using genie.script;
using genie.services;
using genie.services.raylib;
using hero.cast;

namespace hero.script {
    class HandleHeroMovementAction : genie.script.Action {
        
        private RaylibKeyboardService keyboardService;
        private RaylibAudioService audioService;
        private genie.cast.Actor? hero;
        private genie.cast.Actor? background;
        private genie.cast.Actor? endpoint;
        private List<int> keysOfInterest;
        private int heroMovementVel;

        public HandleHeroMovementAction(int priority, RaylibKeyboardService keyboardService, RaylibAudioService audioService) : base(priority) {
            this.keyboardService = keyboardService;
            this.audioService = audioService;
            this.hero = null;

            this.background = null;
            this.endpoint = null;

            this.heroMovementVel = 4;
            this.keysOfInterest = new List<int>();
            this.keysOfInterest.Add(Keys.LEFT);
            this.keysOfInterest.Add(Keys.RIGHT);
            this.keysOfInterest.Add(Keys.SPACE);
            
        }

        public override void execute(Cast cast, Script script, Clock clock, Callback callback) {
            
            // Grab the hero from the cast
            this.hero = cast.GetFirstActor("hero");

            this.background = cast.GetFirstActor("background_image");
            this.endpoint = cast.GetFirstActor("endpoint");
            
            

            // Only move if hero is not null
            if (this.hero != null) {
                
                // Get the keysState from the keyboardService
                Dictionary<int, bool> keysState = keyboardService.GetKeysState(this.keysOfInterest);
                
                // Change the velocity to the appropriate value and let MoveActorsAction handle the
                // actual movement
                if (keysState[Keys.LEFT]) {
                    // this.hero.SetVx(-this.heroMovementVel);
                    if (this.background != null)
                    {
                        this.background.SetVx(0);
                    }
                    foreach (Actor actor in cast.GetActors("platform"))
                    {


                        actor.SetVx(this.heroMovementVel);
                    }
                    foreach (Enemy actor in cast.GetActors("enemy"))
                    {
                        actor.SetVx(actor.GetDirection() * actor.GetVXConstant() + this.heroMovementVel);
                    }
                    if(endpoint != null)
                    {
                        this.endpoint.SetVx(this.heroMovementVel);

                    }
                }
                if (keysState[Keys.RIGHT]) {

                    
                    if (this.background != null)
                    {
                        this.background.SetVx(0);
                    }
                    // this.hero.SetVx(-this.heroMovementVel);
                    foreach (Actor actor in cast.GetActors("platform"))
                    {

                        actor.SetVx(-this.heroMovementVel);

                    }
                    foreach (Enemy actor in cast.GetActors("enemy"))
                    {
                        actor.SetVx(actor.GetDirection() * actor.GetVXConstant() - this.heroMovementVel);
                    }

                    if(endpoint != null)
                    {
                        this.endpoint.SetVx(-this.heroMovementVel); 
                    }

                }
                // Hero jumping
                if (keysState[Keys.SPACE] && hero.getGround()) {
                    this.hero.SetVy(-50);
                    this.hero.SetGround(false);
                    this.audioService.PlaySound("./hero/assets/sound/mario_jump.mp3", (float) 0.1);
                    
                }

                // If none of the LEFT or RIGHT keys are down, x-velocity is 0
                if (!(keysState[Keys.LEFT] || keysState[Keys.RIGHT])) {
                    foreach (Actor actor in cast.GetActors("platform"))
                    {    
                        actor.SetVx(0);  
                    }
                    foreach (Enemy actor in cast.GetActors("enemy"))
                    {

                        actor.SetVx(actor.GetDirection() * actor.GetVXConstant());
                    }
                    if(endpoint != null)
                    {
                        this.endpoint.SetVx(0); 
                    }
                }

                // If none of the UP or DOWN keys are down, y-velocity is 0
                if (!(keysState[Keys.SPACE])) {
                    this.hero.SetVy(0);
                    
                }
                Console.WriteLine(this.hero.GetPosition());
            }
        }
    }
}