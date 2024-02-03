﻿namespace ET.Handler
{
    [FriendClass(typeof(DouShouQiBoardComponent))]
    public class M2C_PrepareNoticeHandler:AMHandler<M2C_PrepareNotice>
    {
        protected override void Run(Session session, M2C_PrepareNotice message)
        {
            DouShouQiBoardComponent board = session.ZoneScene().GetComponent<DouShouQiBoardComponent>();
            Log.Info($"M2C_PrepareNotice A board = {board.ToString1()}");
            if (message.ReadyPlayerId == board.playerAID)
            {
                board.playerAReady = message.isPrepare;
            }
            else if (message.ReadyPlayerId == board.playerBID)
            {
                board.playerBReady = message.isPrepare;
            }
            Log.Info($"M2C_PrepareNotice B board = {board.ToString1()}");
            Game.EventSystem.Publish(new EventType.DouShouQiPlayerPrepare(){ZoneScene = session.ZoneScene(), PlayerId = message.ReadyPlayerId, IsPrepare = message.isPrepare});
        }
    }
}