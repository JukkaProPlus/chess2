
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class DlgDouShouQiFinishViewComponentAwakeSystem : AwakeSystem<DlgDouShouQiFinishViewComponent> 
	{
		public override void Awake(DlgDouShouQiFinishViewComponent self)
		{
			self.uiTransform = self.GetParent<UIBaseWindow>().uiTransform;
		}
	}


	[ObjectSystem]
	public class DlgDouShouQiFinishViewComponentDestroySystem : DestroySystem<DlgDouShouQiFinishViewComponent> 
	{
		public override void Destroy(DlgDouShouQiFinishViewComponent self)
		{
			self.DestroyWidget();
		}
	}
}
