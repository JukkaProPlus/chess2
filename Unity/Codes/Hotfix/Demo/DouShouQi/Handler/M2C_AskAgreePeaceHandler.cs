namespace ET.Handler
{
    public class M2C_AskAgreePeaceHandler:AMHandler<M2C_AskAgreePeace>
    {
        protected override void Run(Session session, M2C_AskAgreePeace message)
        {
            Game.EventSystem.Publish(new EventType.DouShouQiPlayerAskPeace(){ZoneScene = session.ZoneScene()});
        }
    }
}