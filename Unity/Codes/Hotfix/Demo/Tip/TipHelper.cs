namespace ET
{
    [FriendClass(typeof(TipComponent))]
    public static class TipHelper
    {
        public static void ShowTip(Scene zoneScene, string tip)
        {
            TipComponent tipComponent = zoneScene.GetComponent<TipComponent>();
            if (tipComponent == null)
            {
                return;
            }

            tipComponent.tips.Enqueue(tip);
            Game.EventSystem.Publish(new EventType.Tip(){ZoneScene = zoneScene,TipStr = tip});
        }
    }
}