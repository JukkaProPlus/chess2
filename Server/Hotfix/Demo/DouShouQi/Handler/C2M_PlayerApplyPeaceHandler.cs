using System;

namespace ET
{
    public class C2M_PlayerApplyPeaceHandler:AMActorLocationRpcHandler<Unit, C2M_PlayerApplyPeace, M2C_PlayerApplyPeace>
    {
        protected override async ETTask Run(Unit unit, C2M_PlayerApplyPeace request, M2C_PlayerApplyPeace response, Action reply)
        {
            if (unit.DomainScene().GetComponent<DouShouQiComponent>().IsInDouShouQiBoard(unit.InstanceId, out DouShouQiBoardComponent board))
            {
                long oppoentPlayerInstanceId = board.GetOpponentPlayerID(unit.InstanceId);
                if (oppoentPlayerInstanceId != 0)
                {
                    Unit anotherPlayer = unit.DomainScene().GetComponent<UnitComponent>().Get(oppoentPlayerInstanceId);
                    MessageHelper.SendToClient(anotherPlayer, new M2C_AskAgreePeace());
                }
                else
                {
                    response.Error = ErrorCode.ERR_DouShouQiNoOpponent;
                    response.Message = "没有对手";
                }
                reply();
                await ETTask.CompletedTask;
            } else
            {
                response.Error = ErrorCode.ERR_DouShouQiCurOutside;
                response.Message = "当前不在棋盘中";
                reply();
                await ETTask.CompletedTask;
            }
        }
    }
}