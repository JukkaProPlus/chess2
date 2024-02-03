using System.Collections.Generic;
namespace ET
{
    [ChildType(typeof(DouShouQIPiece))]
    [ComponentOf(typeof(Scene))]
    public class DouShouQiBoardComponent:Entity,IAwake<int>, IDestroy,ITransfer
    {
        public List<DouShouQIPiece> Pieces = new List<DouShouQIPiece>();
        public int roomID = 0;
        public long playerAID = 0;
        public long playerBID = 0;
        public bool playerAReady = false;
        public bool playerBReady = false;
        /// <summary>
        /// 轮到这个玩家操作了
        /// </summary>
        public long curTurnPlayerID = 0;
        // #if SERVER
        // public 
        // #endif
    }
}