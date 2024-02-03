using System;

namespace ET
{
    [FriendClass(typeof(DouShouQiBoardComponent))]
    public class C2M_PrepareHandler:AMActorLocationRpcHandler<Unit, C2M_Prepare, M2C_Prepare>
    {
        protected override async ETTask Run(Unit unit, C2M_Prepare request, M2C_Prepare response, Action reply)
        {
            if (unit.DomainScene().GetComponent<DouShouQiComponent>().IsInDouShouQiBoard(unit.Id, out DouShouQiBoardComponent board))
            {
                long anotherPlayerID = 0;
                if (board.playerAID == unit.Id)
                {
                    anotherPlayerID = board.playerBID;
                    board.playerAReady = request.IsPrepare;
                } else if (board.playerBID == unit.Id)
                {
                    anotherPlayerID = board.playerAID;
                    board.playerBReady = request.IsPrepare;
                }
                
                if (anotherPlayerID != 0)
                {
                    Unit anotherPlayer = unit.DomainScene().GetComponent<UnitComponent>().Get(anotherPlayerID);
                    if (anotherPlayer != null)
                    {
                        M2C_PrepareNotice m2C_PrepareNotice = new M2C_PrepareNotice(){ReadyPlayerId = unit.Id, isPrepare = request.IsPrepare};
                        MessageHelper.SendToClient(anotherPlayer, m2C_PrepareNotice);
                    }   
                }
            }
            else
            {
                response.Error = ErrorCode.ERR_DouShouQiCurOutside;
                response.Message = "当前不在棋盘中";
            }
            reply();
            await Game.EventSystem.PublishAsync(new EventType.DouShouQiPlayerPrepare(){roomID = board.roomID, Unit = unit});
        }
    }
}