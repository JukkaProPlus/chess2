namespace ET
{
    public class DouShouQiFinishEventHandler:AEvent<EventType.DouShouQiFinish>
    {
        protected override void Run(EventType.DouShouQiFinish args)
        {
            Log.Info("斗兽棋结束");
            args.ZoneScene.GetComponent<UIComponent>().ShowWindow(WindowID.WindowID_DouShouQiFinish);
        }
    }
}