using System;
namespace ET
{
    public interface ISelectablePiece
    {
        
    }
    public interface ISelectablePieceSystem:ISystemType
    {
        // public bool MoveTo(Object self,int x, int y);
    }
    [ObjectSystem]
    public abstract class SelectablePieceSystem<T>:ISelectablePieceSystem where T:ISelectablePiece
    {
        public Type SystemType()
        {
            return typeof(ISelectablePieceSystem);
        }

        public Type Type()
        {
            return typeof(T);
        }

        public abstract bool MoveTo(T self, int x, int y);
        public abstract bool Select(T self, long operatorInstanceId);
        public abstract bool Deselect(T self, long operatorInstanceId);
    }
}