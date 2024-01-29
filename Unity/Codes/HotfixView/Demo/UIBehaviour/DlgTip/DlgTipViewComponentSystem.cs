
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class DlgTipViewComponentAwakeSystem : AwakeSystem<DlgTipViewComponent> 
	{
		public override void Awake(DlgTipViewComponent self)
		{
			self.uiTransform = self.GetParent<UIBaseWindow>().uiTransform;
		}
	}


	[ObjectSystem]
	public class DlgTipViewComponentDestroySystem : DestroySystem<DlgTipViewComponent> 
	{
		public override void Destroy(DlgTipViewComponent self)
		{
			self.DestroyWidget();
		}
	}
}
