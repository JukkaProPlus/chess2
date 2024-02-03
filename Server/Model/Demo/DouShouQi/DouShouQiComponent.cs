using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Scene))]
    [ChildType(typeof(DouShouQiBoardComponent))]
    public class DouShouQiComponent:Entity, IAwake,IDestroy
    {
        public List<DouShouQiBoardComponent> Boards = new List<DouShouQiBoardComponent>();
    }
}