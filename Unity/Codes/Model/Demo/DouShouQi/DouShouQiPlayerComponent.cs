using System.Collections.Generic;

namespace ET.DouShouQi
{
    public class DouShouQiPlayerComponent:Entity,IAwake
    {
        public List<DouShouQIPiece> Pieces = new List<DouShouQIPiece>();
        // public int PlayerId { get; set; }
        public bool IsAI { get; set; }
        public bool IsMyTurn { get; set; }
    }
}