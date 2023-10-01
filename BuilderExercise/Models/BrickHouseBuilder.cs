namespace BuilderExercise.Models
{
    public class BrickHouseBuilder : HouseBuilder
    {
        public override void BuildFoundation()
        {
            house.Foundation = "Piles of bricks";
        }

        public override void BuildWalls()
        {
            house.Walls = "Bricks and glass";
        }

        public override void BuildRoof()
        {
            house.Roof = "Brick Roof";
        }

        public override void BuildGarage()
        {
            house.HasGarage = true;
        }

        public override void BuildSwimmingPool()
        {
            house.HasSwimmingPool = false;
        }

        public override void BuildGarden()
        {
            house.HasGarden = true;
        }
    }
}
