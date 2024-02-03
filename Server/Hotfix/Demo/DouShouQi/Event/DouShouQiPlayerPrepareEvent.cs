using ET.EventType;
namespace ET.Event
{
    [FriendClass(typeof(DouShouQiBoardComponent))]
    public class DouShouQiPlayerPrepareEvent:AEventAsync<DouShouQiPlayerPrepare>
    {
        protected override async ETTask Run(DouShouQiPlayerPrepare args)
        {
            DouShouQiBoardComponent board = args.Unit.DomainScene().GetComponent<DouShouQiComponent>().GetBoard(args.roomID);
            if (board.isAllPlayerReady())
            {
                await TimerComponent.Instance.WaitAsync(2000);
                board.beginRandomPieces();
                M2C_DouShouQiPlayerChange m2C_DouShouQiPlayerChange = new M2C_DouShouQiPlayerChange(){Board = board.ToMessage()};
                Unit playerA = args.Unit.DomainScene().GetComponent<UnitComponent>().Get(board.playerAID);
                Unit playerB = args.Unit.DomainScene().GetComponent<UnitComponent>().Get(board.playerAID);
                MessageHelper.SendToClient(playerA, m2C_DouShouQiPlayerChange);
                MessageHelper.SendToClient(playerB, m2C_DouShouQiPlayerChange);
            }
        }
    }
}