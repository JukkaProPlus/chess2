namespace ET.Handler
{
    public class M2C_DouShouQiPlayerChangeHandler:AMHandler<M2C_DouShouQiPlayerChange>
    {
        protected override void Run(Session session, M2C_DouShouQiPlayerChange message)
        {
            DouShouQiBoardComponent board = session.ZoneScene().GetComponent<DouShouQiBoardComponent>();
            board.FromMessage(message.Board);
            Game.EventSystem.Publish(new EventType.DouShouQiBoardChange(){ZoneScene = session.ZoneScene()});
        }
    }
}