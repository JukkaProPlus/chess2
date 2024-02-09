namespace ET.Demo.Tip
{
    public class Tip_ShowTip:AEvent<EventType.Tip>
    {
        protected override void Run(EventType.Tip args)
        {
            RunAsync(args).Coroutine();
        }
        private async ETTask RunAsync(EventType.Tip args)
        {
            // TipComponent tipComponent = args.ZoneScene.GetComponent<TipComponent>();
            // if (tipComponent == null)
            // {
            //     return;
            // }
            args.ZoneScene.GetComponent<UIComponent>().ShowWindow<DlgTip>();
            await ETTask.CompletedTask;
        }
    }
    
}