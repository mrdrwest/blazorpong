//From https://github.com/exceptionnotfound/BattleshipModellingPractice

using System.ComponentModel;
using blazorpong.Shared.Helpers;

namespace blazorpong.Shared.GameObjects
{

    public class Tile
    {
        public OccupationType OccupationType { get; set; }
        public Coordinates Coordinates { get; set; }

        public Tile(int column, int row)
        {
            Coordinates = new Coordinates(column, row);
            OccupationType = OccupationType.Empty;
        }

        public Tile() { }

        public string Status
        {
            get
            {
                return OccupationType.GetAttributeOfType<DescriptionAttribute>().Description;
            }
        }

        public bool IsOccupied
        {
            get
            {
                return OccupationType == OccupationType.Ball
                    || OccupationType == OccupationType.Paddle;
            }
        }

    }
}