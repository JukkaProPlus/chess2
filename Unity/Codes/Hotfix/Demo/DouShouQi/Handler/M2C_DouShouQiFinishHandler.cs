namespace ET.Handler
{
    public class M2C_DouShouQiFinishHandler:AMHandler<M2C_DouShouQiFinish>
    {
        protected override void Run(Session session, M2C_DouShouQiFinish message)
        {
            Log.Info("斗兽棋结束");
            Game.EventSystem.Publish(new EventType.DouShouQiFinish(){ZoneScene = session.ZoneScene()});
        }
    }
}