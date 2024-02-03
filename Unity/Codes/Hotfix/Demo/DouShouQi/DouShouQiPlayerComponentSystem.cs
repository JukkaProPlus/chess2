namespace ET
{
    public class DouShouQiPlayerComponentAwakeSystem:AwakeSystem<DouShouQiPlayerComponent>
    {
        public override void Awake(DouShouQiPlayerComponent self)
        {
            
        }
    }

    public static class DouShouQiPlayerComponentSystem
    {
        public static void SetBoard(this DouShouQiPlayerComponent self,DouShouQiBoardComponent board)
        {
            self.Board = board;
        }
        public static void SetIsMyTurn(this DouShouQiPlayerComponent self,bool isMyTurn)
        {
            self.IsMyTurn = isMyTurn;
        }

        // public static void Select(this DouShouQiPlayerComponent self, long pieceInstanceId)
        // {
        //     self.Board.Select(pieceInstanceId);
        // }
    }
}