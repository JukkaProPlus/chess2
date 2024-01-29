using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Scene))]
    public class TipComponent:Entity,IAwake
    {
        public Queue<string> tips = new Queue<string>();
    }
}