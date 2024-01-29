
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class DlgChessLobbyViewComponentAwakeSystem : AwakeSystem<DlgChessLobbyViewComponent> 
	{
		public override void Awake(DlgChessLobbyViewComponent self)
		{
			self.uiTransform = self.GetParent<UIBaseWindow>().uiTransform;
		}
	}


	[ObjectSystem]
	public class DlgChessLobbyViewComponentDestroySystem : DestroySystem<DlgChessLobbyViewComponent> 
	{
		public override void Destroy(DlgChessLobbyViewComponent self)
		{
			self.DestroyWidget();
		}
	}
}
