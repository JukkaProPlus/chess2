using System;

namespace ET
{
    [FriendClassAttribute(typeof(ET.DouShouQiBoardComponent))]
    public class C2M_OpenPieceHandler : AMActorLocationRpcHandler<Unit, C2M_OpenPiece, M2C_OpenPiece>
    {
        protected override async ETTask Run(Unit unit, C2M_OpenPiece request, M2C_OpenPiece response, Action reply)
        {
            if (unit.DomainScene().GetComponent<DouShouQiComponent>().GetBoardByPlayerId(unit.Id, out DouShouQiBoardComponent board))
            {
                response.Error = board.OpenPiece(unit.Id, request.x, request.y);
                M2C_DouShouQiPlayerChange m2C_DouShouQiPlayerChange = new M2C_DouShouQiPlayerChange() { Board = board.ToMessage() };
                Unit playerA = unit.DomainScene().GetComponent<UnitComponent>().Get(board.playerAID);
                Unit playerB = unit.DomainScene().GetComponent<UnitComponent>().Get(board.playerBID);
                MessageHelper.SendToClient(playerA, m2C_DouShouQiPlayerChange);
                MessageHelper.SendToClient(playerB, m2C_DouShouQiPlayerChange);
                reply();
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