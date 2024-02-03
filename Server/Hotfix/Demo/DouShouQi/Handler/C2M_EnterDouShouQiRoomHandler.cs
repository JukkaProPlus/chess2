using System;

namespace ET
{
    public class C2M_EnterDouShouQiRoomHandler:AMActorLocationRpcHandler<Unit, C2M_EnterDouShouQiRoom, M2C_EnterDouShouQiRoom>
    {
        protected override async ETTask Run(Unit unit, C2M_EnterDouShouQiRoom request, M2C_EnterDouShouQiRoom response, Action reply)
        {
            unit.DomainScene().GetComponent<DouShouQiComponent>().EnterABoard(unit.Id, out DouShouQiBoardComponent board, out int errorCode, request.RoomId);
            if (board == null)
            {
                response.Error = errorCode;
                response.Message = $"进入棋盘失败 errorCode = {errorCode},roomID = {request.RoomId}";
                reply();
                await ETTask.CompletedTask;
            }
            response.Board = board.ToMessage();
            reply();
            await ETTask.CompletedTask;
        }
    }
}