using genie.cast;

namespace hero.cast {
    class Ship : Actor {

        public Ship(string path, int width, int height,
                        float x = 0, float y = 0,
                        float vx = 0, float vy = 0,
                        float rotation = 0, float rotationVel = 0) : 
        base(path, width, height, x, y, vx, vy, rotation, rotationVel)
        {

        }
    }
}