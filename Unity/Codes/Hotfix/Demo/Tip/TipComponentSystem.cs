namespace ET
{
    public class TipComponentAwakeSystem: AwakeSystem<TipComponent>
    {
        public override void Awake(TipComponent self)
        {
            self.tips.Clear();
        }
    }
    [FriendClass(typeof(TipComponent))]
    public static class TipComponentSystem
    {
        public static void AddTip(this TipComponent self, string tip)
        {
            self.tips.Enqueue(tip);
        }
        public static string GetTip(this TipComponent self)
        {
            return self.tips.Dequeue();
        }
    }
}