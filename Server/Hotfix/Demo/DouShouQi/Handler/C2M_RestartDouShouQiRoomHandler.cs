using System;

namespace ET
{
    [FriendClassAttribute(typeof(ET.DouShouQiBoardComponent))]
    public class C2M_RestartDouShouQiRoomHandler : AMActorLocationRpcHandler<Unit, C2M_RestartDouShouQiRoom, M2C_RestartDouShouQiRoom>
    {
        protected override async ETTask Run(Unit unit, C2M_RestartDouShouQiRoom request, M2C_RestartDouShouQiRoom response, Action reply)
        {
            if (unit.DomainScene().GetComponent<DouShouQiComponent>().GetBoardByPlayerId(unit.Id, out DouShouQiBoardComponent board))
            {
                int err = board.Restart();
                response.Error = err;
                if (err == ErrorCode.ERR_Success)
                {
                    M2C_DouShouQiPlayerChange m2C_DouShouQiPlayerChange = new M2C_DouShouQiPlayerChange() { Board = board.ToMessage() };
                    if (board.playerAID != 0)
                    {
                        Unit playerA = unit.DomainScene().GetComponent<UnitComponent>().Get(board.playerAID);
                        MessageHelper.SendToClient(playerA, m2C_DouShouQiPlayerChange);
                    }
                    if (board.playerBID != 0)
                    {
                        Unit playerB = unit.DomainScene().GetComponent<UnitComponent>().Get(board.playerBID);
                        MessageHelper.SendToClient(playerB, m2C_DouShouQiPlayerChange);
                    }
                    reply();
                }
                else
                {
                    reply();
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