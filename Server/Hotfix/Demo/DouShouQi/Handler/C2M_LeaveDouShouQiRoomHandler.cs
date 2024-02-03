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
                board.LeaveBoard(unit.Id);
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