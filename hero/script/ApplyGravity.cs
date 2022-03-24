using genie;
using genie.cast;
using genie.script;
using genie.services;
using genie.services.raylib;
using hero.cast;

namespace hero.script {
    class ApplyGravity : genie.script.Action {

        private Actor hero; 
        static public bool gravity = true;
        public ApplyGravity(int priority) : base(priority) {
            
        }

        public override void execute(Cast cast, Script script, Clock clock, Callback callback) {

            if(gravity == true)
            {
                this.hero = cast.GetFirstActor("hero");
                float vy = this.hero.GetVy();
                this.hero.SetVy(vy+5);
            }
            // make the hero stop on the platforms and ground 
            
        }
    }
}