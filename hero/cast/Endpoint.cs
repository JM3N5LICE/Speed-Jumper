using genie.cast;
namespace hero.cast 
{
    public class Endpoint : Actor
    {

        private int points;
        public Endpoint(string path, int width, int height, float x = 0, float y = 0,
        float vx = 0, float vy = 0) : base(path, width, height, x, y, vx, vy)
        {

        }
    }
}