namespace ET
{
    public class DouShouQiPieceAwakeSystem : AwakeSystem<DouShouQIPiece, long, int, int, int>
    {
        public override void Awake(DouShouQIPiece self, long ownerId, int pieceId, int x, int y)
        {
            self.OwnerId = ownerId;
            self.PieceId = pieceId;
            self.X = x;
            self.Y = y;
            self.State = PieceStateEnum.Unselected;
            self.Awake();
        }
    }
    public class DouShouQiPieceSelectableSystem:SelectablePieceSystem<DouShouQIPiece>
    {
        public override bool Select(DouShouQIPiece self, long operatorInstanceId)
        {
            if (operatorInstanceId != self.OwnerId)
            {
                // Log.Info($"不是自己的棋子，不能选择");
                Log.Info(LanguageHelper.GetLanguageString(17));
                return false;
            }
            return self.Select();
        }
        public override bool Deselect(DouShouQIPiece self, long operatorInstanceId)
        {
            if (operatorInstanceId != self.OwnerId)
            {
                // Log.Info($"不是自己的棋子，不能取消选择");
                Log.Info(LanguageHelper.GetLanguageString(18));
                return false;
            }
            return self.Deselect();
        }
    
        public override bool MoveTo(DouShouQIPiece self, int x, int y)
        {
            return true;
        }
    }
    public static class DouShouQiPieceSystem
    {
        public static void Awake(this DouShouQIPiece self)
        {
            
        }
        public static bool Select(this DouShouQIPiece self)
        {
            self.State = PieceStateEnum.Selected;
            return true;
        }
        public static bool Deselect(this DouShouQIPiece self)
        {
            self.State = PieceStateEnum.Unselected;
            return true;
        }
        public static void FromMessage(this DouShouQIPiece self, DouShouQiPieceProto douShouQiPieceProto)
        {
            // self.Id = douShouQiPieceProto.Id;
            self.OwnerId = douShouQiPieceProto.OwnerInstanceId;
            self.PieceId = douShouQiPieceProto.PieceId;
            self.X = douShouQiPieceProto.x;
            self.Y = douShouQiPieceProto.y;
            self.State = PieceStateEnum.Unselected;
        }

        public static DouShouQiPieceProto ToMessage(this DouShouQIPiece self)
        {
            DouShouQiPieceProto douShouQiPieceProto = new DouShouQiPieceProto();
            douShouQiPieceProto.PieceId = self.PieceId;
            douShouQiPieceProto.OwnerInstanceId = self.OwnerId;
            douShouQiPieceProto.x = self.X;
            douShouQiPieceProto.y = self.Y;
            return douShouQiPieceProto;
        }
    }
}