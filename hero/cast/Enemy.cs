// // Kaden work on this
namespace hero.cast {
    class Enemy : HasLifeActor {

        private int vxConstant = 5;
        private int points;
        private DateTime lastDirectionSwitch;

        private int direction = 1;
        public Enemy(string path, int width, int height,
                        float x = 0, float y = 0,
                        float vx = 0, float vy = 0,
                        int maxHP = 0) :
        base(path, width, height, x, y, vx, vy, 0, 0,
                    0, 0, maxHP, false) {    
            this.lastDirectionSwitch = DateTime.Now;
        }
        public void SetLastDirectionSwitch(DateTime lastDirectionSwitch){
            this.lastDirectionSwitch = lastDirectionSwitch;
        }
        public DateTime GetLastDirectionSwitch(){
            return this.lastDirectionSwitch;
        }

        public void SetVXConstant(int vxConstants){
            this.vxConstant = vxConstant;
        }
        public int GetVXConstant(){
            return this.vxConstant;
        }

        public void SetDirection(int direction)
        {
            this.direction = direction;
        }

        public int GetDirection()
        {
            return this.direction;
        }
    }
}


// // Code left and right movement in the MoveActorsAction class or create a new one (HandleEnemyMovement?)