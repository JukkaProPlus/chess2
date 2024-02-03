namespace ET
{
    public class DouShouQiBoardChangeEvent_Change:AEvent<EventType.DouShouQiBoardChange>
    {
        protected override void Run(EventType.DouShouQiBoardChange args)
        {
            args.ZoneScene.GetComponent<UIComponent>().GetDlgLogic<DlgDouShouQiBoard>()?.Refresh();
        }
    }
}