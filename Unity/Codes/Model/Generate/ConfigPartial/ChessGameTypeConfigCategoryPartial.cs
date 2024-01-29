using System.Collections.Generic;

namespace ET
{
    public partial class ChessGameTypeConfigCategory
    {
        public List<ChessGameTypeConfig> List = null;
        public override void AfterEndInit()
        {
            base.AfterEndInit();
            List = this.list;
            this.List.Sort((a, b) => a.Order - b.Order);
        }

        public ChessGameTypeConfig GetByIndex(int index)
        {
            return this.List[index];
        }
        public int GetNameIdByIndex(int index)
        {
            return this.List[index].Name;
        }
    }
}