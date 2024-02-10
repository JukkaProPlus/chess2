// using System.Linq;
namespace ET
{
    public partial class DouShouQiPieceConfigCategory
    {
        public bool CanEat(DouShouQiPieceConfig self, DouShouQiPieceConfig other)
        {
            for (int i = 0; i < self.FoodIds.Length; i++)
            {
                if (self.FoodIds[i] == other.Id)
                {
                    return true;
                }
            }

            return false;
        }
        public bool CanEat(DouShouQIPiece self, DouShouQIPiece other)
        {
            return CanEat(Get(self.PieceId), Get(other.PieceId));
        }

        public bool CanEat(int selfPieceId, int otherPieceId)
        {
            return CanEat(Get(selfPieceId), Get(otherPieceId));
        }
    }
}