using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
	[FriendClass(typeof(DlgTip))]
	public static class DlgTipSystem
	{

		public static void RegisterUIEvent(this DlgTip self)
		{
		 
		}

		public static void ShowWindow(this DlgTip self, Entity contextData = null)
		{
			self.View.ELabel_TipText.text = self.DomainScene().GetComponent<TipComponent>().GetTip();
			self.AutoClose().Coroutine();
		}

		public static async ETTask AutoClose(this DlgTip self)
		{
			await TimerComponent.Instance.WaitAsync(1000);
			self.DomainScene().GetComponent<UIComponent>().CloseWindow(WindowID.WindowID_Tip);
		}

	}
}
