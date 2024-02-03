namespace ET
{
    public class DouShouQiPlayerPrepare_SetState:AEvent<EventType.DouShouQiPlayerPrepare>
    {
        protected override void Run(EventType.DouShouQiPlayerPrepare args)
        {
            args.ZoneScene.GetComponent<UIComponent>().GetDlgLogic<DlgDouShouQiBoard>()?.Refresh();
        }
    }
}