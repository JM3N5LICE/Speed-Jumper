// using genie;
// using genie.cast;
// using genie.script;
// using genie.services;
// using genie.services.raylib;

// using hero.cast;

// namespace hero.script {
    // class HandleBulletsAsteroidsCollisionAction : genie.script.Action {
        
    //     // Member Variables
    //     RaylibPhysicsService physicsService;
    //     RaylibAudioService audioService;
    //     private PlayerScore? score;
    //     private List<Actor> bullets;


        // Constructor
        // public HandleBulletsAsteroidsCollisionAction(int priority, RaylibPhysicsService physicsService, RaylibAudioService audioService) : base(priority) {
        //     this.score = null;
        //     this.physicsService = physicsService;
        //     this.audioService = audioService;
        //     this.bullets = new List<Actor>();
        // }

//         public override void execute(Cast cast, Script script, Clock clock, Callback callback) {
//             // Grab the score from the cast
//             this.score = (PlayerScore?) cast.GetFirstActor("score");

//             // First, get a list of bullets out of the cast
//             bullets = cast.GetActors("bullets");

//             // Check if any bullet collides with any hero
//             foreach (Asteroid hero in cast.GetActors("heros")) {
//                 Actor? collidedBullet = this.physicsService.CheckCollisionList(hero, bullets);
//                 if (collidedBullet != null) {
//                     cast.RemoveActor("bullets", collidedBullet);
//                     hero.TakeDamage(1);
//                     this.audioService.PlaySound("hero/assets/sound/rock_cracking.wav", (float) 0.1);

//                     // Destroy hero if its health is 0 and give player a score
//                     if (hero.GetHP() <= 0) {
//                         cast.RemoveActor("heros", hero);
//                         if (this.score != null) {
//                             this.score.AddScore(hero.GetPoints());
//                         }
//                         this.audioService.PlaySound("hero/assets/sound/explosion-01.wav", (float) 0.1);
//                     }
//                 }
//             }
//         }
//     }
// }