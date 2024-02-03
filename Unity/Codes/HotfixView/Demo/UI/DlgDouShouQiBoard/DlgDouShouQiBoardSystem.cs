using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
	[FriendClass(typeof(DlgDouShouQiBoard))]
	public static  class DlgDouShouQiBoardSystem
	{

		public static void RegisterUIEvent(this DlgDouShouQiBoard self)
		{
			self.View.EButton_CloseButton.AddListener(async () =>
			{
				int err = await DouShouQiHelper.ReqLeaveBoard(self.ZoneScene());
				if (err == ErrorCode.ERR_Success)
				{
					self.ZoneScene().GetComponent<UIComponent>().CloseWindow(WindowID.WindowID_DouShouQiBoard);
				}
			});
			self.View.EButton_PrepareMeButton.AddListener(() =>
			{
				bool isPrepare = !self.ZoneScene().GetComponent<DouShouQiBoardComponent>().isMeReady();
				DouShouQiHelper.ReqPrepare(self.ZoneScene(), isPrepare).Coroutine();
			});
		}

		public static void ShowWindow(this DlgDouShouQiBoard self, Entity contextData = null)
		{
			self.Refresh();
		}
		public static void Refresh(this DlgDouShouQiBoard self)
		{
			self.View.ELabel_PrepareText.text = self.ZoneScene().GetComponent<DouShouQiBoardComponent>().isMeReady()
					? LanguageHelper.GetLanguageString(20) : LanguageHelper.GetLanguageString(19);		//"取消准备" : "准备";
			self.View.ELabel_PrepareOpponentText.text = self.ZoneScene().GetComponent<DouShouQiBoardComponent>().isOpponentReady()
					? LanguageHelper.GetLanguageString(21):LanguageHelper.GetLanguageString(22);
		}

		 

	}
}
