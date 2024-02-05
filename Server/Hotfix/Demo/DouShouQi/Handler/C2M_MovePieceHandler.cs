using System;

namespace ET
{
    [FriendClassAttribute(typeof(ET.DouShouQiBoardComponent))]
    public class C2M_MovePieceHandler : AMActorLocationRpcHandler<Unit, C2M_MovePiece, M2C_MovePiece>
    {
        protected override async ETTask Run(Unit unit, C2M_MovePiece request, M2C_MovePiece response, Action reply)
        {
            if (unit.DomainScene().GetComponent<DouShouQiComponent>().IsInDouShouQiBoard(unit.Id, out DouShouQiBoardComponent board))
            {
                response.Error = board.MovePiece(unit.Id, request.sourceX, request.sourceY, request.destX, request.destY);
                bool isFinish = board.IsDouShouQiFinish();
                M2C_DouShouQiPlayerChange m2C_DouShouQiPlayerChange = new M2C_DouShouQiPlayerChange() { Board = board.ToMessage() };
                Unit playerA = unit.DomainScene().GetComponent<UnitComponent>().Get(board.playerAID);
                Unit playerB = unit.DomainScene().GetComponent<UnitComponent>().Get(board.playerBID);
                MessageHelper.SendToClient(playerA, m2C_DouShouQiPlayerChange);
                MessageHelper.SendToClient(playerB, m2C_DouShouQiPlayerChange);
                reply();
                if (isFinish)
                {
                    M2C_DouShouQiFinish m2C_DouShouQiFinish = new M2C_DouShouQiFinish() { winPlayerId = board.winnerID };
                    MessageHelper.SendToClient(playerA, m2C_DouShouQiFinish);
                    MessageHelper.SendToClient(playerB, m2C_DouShouQiFinish);
                }
            }
            else
            {
                response.Error = ErrorCode.ERR_DouShouQiCurOutside;
                reply();
            }
            await ETTask.CompletedTask;
        }
    }
}