// // Kaden work on this
namespace hero.cast {
    class Enemy : HasLifeActor {

        private int points;

        public Enemy(string path, int width, int height,
                        float x = 0, float y = 0,
                        float vx = 0, float vy = 0,
                        int maxHP = 0) :
        base(path, width, height, x, y, vx, vy, 0, 0,
                    0, 0, maxHP, false) {    
        }
    }
}


// // Code left and right movement in the MoveActorsAction class or create a new one (HandleEnemyMovement?)