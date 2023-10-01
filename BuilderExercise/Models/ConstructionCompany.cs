namespace BuilderExercise.Models
{
    /// <summary>
    /// Director
    /// </summary>
    public class ConstructionCompany
    {
        public House ConstructHouse(HouseBuilder builder)
        {
            builder.BuildFoundation();
            builder.BuildWalls();
            builder.BuildRoof();

            // There is probably a better way to do this, but for now, requires
            // the least changing of code.
            if (builder.GetType().Name == "CustomHouseBuilder")
            {
                builder.BuildGarage();
                builder.BuildGarden();
                builder.BuildSwimmingPool();
            }

            return builder.GetHouse();
        }
    }
}
