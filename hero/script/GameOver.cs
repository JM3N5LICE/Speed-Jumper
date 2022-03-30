// using genie;
// using genie.cast;
// using genie.script;
// using genie.services;
// using genie.services.raylib;

// using hero.cast;

// namespace hero.script {
//     class GameOver : genie.script.Action {
//         // private Boolean gameOver;
//         private float levelHeight = 2000;
//         // private float levelWidth = 0;

//         private genie.cast.Actor? hero;
        
//         private RaylibScreenService screenService;

//         public GameOver(int priority, RaylibScreenService screenService) : base(priority) {
//             this.screenService = screenService;
//             // this.gameOver = false;
//         }
// // The execute that is triggered when the hero is dead.
//         public override void execute(Cast cast, Script script, Clock clock, Callback callback) {
            
//             //player fell off map
//             if(this.hero.GetY() >= levelHeight)
//             {
//                 endGame();
//             }
//             //touched enemy

//             //
//         }
//         public void endGame()
//         {
//             // Screen black
//             // Say Game Over
//             // Play Game over Sound 
//             // Close the game
//         }
//     }
// }