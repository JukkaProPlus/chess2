using System.Linq;
namespace ET
{
    public partial class DouShouQiPieceConfigCategory
    {
        public bool CanEat(DouShouQiPieceConfig self, DouShouQiPieceConfig other)
        {
            return self.FoodIds.Contains(other.Id);
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