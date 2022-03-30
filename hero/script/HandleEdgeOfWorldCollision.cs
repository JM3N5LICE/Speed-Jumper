// using genie;
// using genie.cast;
// using genie.script;
// using genie.services;
// using genie.services.raylib;


// using hero.cast;

// namespace hero.script {
//     class HandleEdgeOfWorldCollision : genie.script.Action {
//         private float levelHeight = 2000;
//         // private float levelWidth = 0;

//         private genie.cast.Actor? hero;
        
//         private RaylibScreenService screenService;

//         public HandleEdgeOfWorldCollision(int priority, RaylibScreenService screenService) : base(priority) {
//             this.screenService = screenService;
//         }
// // The execute that is triggered when the hero is dead.
//         public override void execute(Cast cast, Script script, Clock clock, Callback callback) {
            
//             // GameOver GameOver = script.AddAction(new GameOver(1));
//             //player fell off map
//             if(this.hero.GetY() >= levelHeight)
//             {
//                 this.hero = GameOver.endGame();
//             }
//             //touched enemy

//             //
//         }
//     }
// }