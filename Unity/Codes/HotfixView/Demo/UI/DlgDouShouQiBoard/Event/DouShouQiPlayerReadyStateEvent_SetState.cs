using ET.EventType;

namespace ET
{
    public class DouShouQiPlayerReadyStateEvent_SetState:AEvent<EventType.DouShouQiPlayerReadyState>
    {
        protected override void Run(DouShouQiPlayerReadyState args)
        {
            args.ZoneScene.GetComponent<UIComponent>().GetDlgLogic<DlgDouShouQiBoard>()?.Refresh();
        }
    }
}