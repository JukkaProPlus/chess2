using System;

namespace ET
{
    public class C2M_LeaveDouShouQiRoomHandler:AMActorLocationRpcHandler<Unit, C2M_LeaveDouShouQiRoom, M2C_LeaveDouShouQiRoom>
    {
        protected override async ETTask Run(Unit unit, C2M_LeaveDouShouQiRoom request, M2C_LeaveDouShouQiRoom response, Action reply)
        {
            if (unit.DomainScene().GetComponent<DouShouQiComponent>()
                .IsInDouShouQiBoard(unit.Id, out DouShouQiBoardComponent board))
            {
                long opponentPlayerID = board.GetOpponentPlayerID(unit.Id);
                if(board.LeaveBoard(unit.Id))
                {
                    response.Error = ErrorCode.ERR_Success;
                    response.Message = "离开棋盘成功";
                    if (opponentPlayerID != 0)
                    {
                        Unit opponentPlayer = unit.DomainScene().GetComponent<UnitComponent>().Get(opponentPlayerID);
                        if (opponentPlayer != null)
                        {
                            M2C_DouShouQiPlayerChange m2C_DouShouQiPlayerChange = new M2C_DouShouQiPlayerChange(){Board = board.ToMessage()};
                            MessageHelper.SendToClient(opponentPlayer, m2C_DouShouQiPlayerChange);
                        }
                    }
                }
            }
            else
            {
                response.Error = ErrorCode.ERR_DouShouQiCurOutside;
                response.Message = "当前不在棋盘中";
            }
            reply();
            await ETTask.CompletedTask;
        }
        // protected override ETTask Run(Unit unit, C2M_LeaveDouShouQiRoom request, M2C_LeaveDouShouQiRoom response, Action reply)
        // {
        //     throw new NotImplementedException();
        // }
    }
    
}