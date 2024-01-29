namespace ET.DouShouQi
{
    public class DouShouQIPiece:Entity, IAwake<long, int,int,int>, ISelectablePiece
    {
        public long OwnerInstanceId { get; set; }
        public int PieceId { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public PieceStateEnum State { get; set; }
    }
}