// Create the platform actor
using genie.cast;
namespace hero.cast 
{
    public class Platform : Actor
    {

        private int points;
        public Platform(string path, int width, int height, float x = 0, float y = 0,
        float vx = 0, float vy = 0) : base(path, width, height, x, y, vx, vy)
        {

        }
    }
}