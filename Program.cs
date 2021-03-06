using Raylib_cs;

using genie;
using genie.cast;
using genie.script;
using genie.test;
using genie.services;
using genie.services.raylib;

using hero.script;
using hero.cast;

namespace hero
{
    public static class Program
    {
        public static void Test() {
            // MouseMap mouseMap = new MouseMap();
            // mouseMap.getRaylibMouse(-1);

            // CastScriptTest castScriptTest = new CastScriptTest();
            // castScriptTest.testCast();
            // castScriptTest.testScript();

            ServicesTest servicesTest = new ServicesTest();
            servicesTest.TestScreenService();

            // Director director = new Director();
            // director.DirectScene();
        }

        public static void Main(string[] args)
        {
            // A few game constants
            // Level size here 
            (int, int) L_SIZE = (8000, 2000);
            // Window Size here 
            (int, int) W_SIZE = (1000, 800);
            // (int, int) START_POSITION = (4000, 800);
            string SCREEN_TITLE = "Speed Jumper";
            int FPS = 120;
            
            // Initiate all services
            RaylibKeyboardService keyboardService = new RaylibKeyboardService();
            RaylibPhysicsService physicsService = new RaylibPhysicsService();
            RaylibScreenService screenService = new RaylibScreenService(W_SIZE, SCREEN_TITLE, FPS);
            RaylibAudioService audioService = new RaylibAudioService();
            RaylibMouseService mouseService = new RaylibMouseService();

            // Create the director
            Director director = new Director();

            // Create the cast
            Cast cast = new Cast();

            // Create the ground
            Ground ground = new Ground("", L_SIZE.Item1,(100), //path, width, height
                                                    L_SIZE.Item1/2, W_SIZE.Item2,   // x and y
                                                    0, 0);  // vx and vy
            
            // Create the player
            Hero hero = new Hero("./hero/assets/spaceship/mario.png", 50, 70, W_SIZE.Item1/2, W_SIZE.Item2/2, 0, 0, 100);
            Endpoint endpoint = new Endpoint("./hero/assets/endpoint.png", 75, 500, 8150, 225, 0, 0); 

            

            // Create the platform
            // Platform platform = new InstantiatePlatform();


            // Scale the background to have the same dimensions as the Window,
            // then position it at the center of the screen

            Background GameOverScreen = new Background("./hero/assets/GameOver.png", W_SIZE.Item1, W_SIZE.Item2, W_SIZE.Item1/2, W_SIZE.Item2/2);
            Background backgroundImage = new Background("./hero/assets/background.png", W_SIZE.Item1, W_SIZE.Item2, W_SIZE.Item1/2, W_SIZE.Item2/2);
            
            // Create the Player Score
            // PlayerScore score = new PlayerScore(path:"", score:0);

            // Create the Start Button
            // StartGameButton startGameButton = new StartGameButton("./hero/assets/others/start_button.png", 305, 113, W_SIZE.Item1/2, W_SIZE.Item2/2);

            // Give actors to cast
            cast.AddActor("background_image", backgroundImage);
            cast.AddActor("hero", hero);
            // cast.AddActor("start_button", startGameButton);

            cast.AddActor("platform", ground);

            cast.AddActor("endpoint", endpoint);
            
            // cast.AddActor("score", score);

            // Create the script
            Script script = new Script();

            // Add all input actions
            script.AddAction("input", new HandleQuitAction(2,screenService));
            script.AddAction("input", new HandleHeroMovementAction(3, keyboardService, audioService));

            // // Add all update actions
            script.AddAction("update", new InstantiatePlatform(1));
            script.AddAction("update", new InstantiateEnemy(1));
            script.AddAction("update", new ApplyGravity(1));

            script.AddAction("update", new HandleEnemyMovementAction(2));
            script.AddAction("update", new MoveActorsAction(2, physicsService));
            script.AddAction("update", new HandleGroundCollisions(1, physicsService));
            script.AddAction("update", new HandleLosingAction(1, screenService));
            script.AddAction("update", new HandleHeroEnemyCollisions(2, physicsService));
            script.AddAction("update", new HandleWinningAction(2, physicsService));


            

            // // Add all output actions
            script.AddAction("output", new DrawActorsAction(2, screenService));
            script.AddAction("output", new UpdateScreenAction(3, screenService));
            script.AddAction("output", new PlayBackgroundMusicAction(1, "./hero/assets/sound/mario_heavy.mp3", audioService));

            // Yo, director, do your thing!
            director.DirectScene(cast, script);

            
        }
    }
}