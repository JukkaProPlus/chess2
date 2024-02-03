using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Scene))]
    public class DouShouQiPlayerComponent:Entity,IAwake
    {
        // public int PlayerId { get; set; }
        public bool IsAI { get; set; }
        public bool IsMyTurn { get; set; }
        public DouShouQiBoardComponent Board { get; set; }
    }
}