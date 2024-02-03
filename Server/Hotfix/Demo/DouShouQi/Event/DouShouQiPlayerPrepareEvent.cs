using ET.EventType;
namespace ET.Event
{
    public class DouShouQiPlayerPrepareEvent:AEvent<DouShouQiPlayerPrepare>
    {
        protected override void Run(DouShouQiPlayerPrepare args)
        {
            DouShouQiBoardComponent board = args.Unit.DomainScene().GetComponent<DouShouQiComponent>().GetBoard(args.roomID);
            if (board.isAllPlayerReady())
            {
                // board();
            }
        }
    }
}