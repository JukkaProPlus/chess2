
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class DlgDouShouQiBoardViewComponentAwakeSystem : AwakeSystem<DlgDouShouQiBoardViewComponent> 
	{
		public override void Awake(DlgDouShouQiBoardViewComponent self)
		{
			self.uiTransform = self.GetParent<UIBaseWindow>().uiTransform;
		}
	}


	[ObjectSystem]
	public class DlgDouShouQiBoardViewComponentDestroySystem : DestroySystem<DlgDouShouQiBoardViewComponent> 
	{
		public override void Destroy(DlgDouShouQiBoardViewComponent self)
		{
			self.DestroyWidget();
		}
	}
}
