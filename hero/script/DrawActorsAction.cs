using genie;
using genie.cast;
using genie.script;
using genie.services;
using genie.services.raylib;

using hero.cast;

namespace hero.script {
    class DrawActorsAction : genie.script.Action {
        
        private RaylibScreenService screenService;

        public DrawActorsAction(int priority, RaylibScreenService screenService) : base(priority) {
            this.screenService = screenService;
        }

        public override void execute(Cast cast, Script script, Clock clock, Callback callback) {

            // First, fill the screen with white every frame, get ready to draw more stuff
            this.screenService.FillScreen(Color.WHITE);
            // foreach (Actor actor in cast.GetAllActors()) {
            //     Color actorColor = actor is Ground ? Color.GREEN : Color.BLACK;
            //     this.screenService.DrawRectangle(actor.GetPosition(), actor.GetWidth(), actor.GetHeight(), actorColor, 5);
            // }
            this.screenService.DrawActors(cast.GetAllActors());
            Actor ground = cast.GetFirstActor("platform");
            this.screenService.DrawRectangle(ground.GetPosition(), ground.GetWidth(), ground.GetHeight(), Color.GREEN, 0);
        }
    }
}