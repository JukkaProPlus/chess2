using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
	[FriendClass(typeof(DlgChessLobby))]
	public static  class DlgChessLobbySystem
	{

		public static void RegisterUIEvent(this DlgChessLobby self)
		{
			self.View.ELoopScrollList_ChessTypeLoopVerticalScrollRect.AddItemRefreshListener(((transform, index) =>
			{
				self.OnScrollItemRefreshHandler(transform, index);
			}));
			self.RegisterCloseEvent<DlgAdventure>(self.View.EButton_CloseButton);
		}
		public static void OnScrollItemRefreshHandler(this DlgChessLobby self, Transform transform, int index)
		{
			Scroll_Item_chessType chessType = self.ScrollItemChessTypesdict[index].BindTrans(transform);
			ChessGameTypeConfig config = ChessGameTypeConfigCategory.Instance.GetByIndex(index);
			if (!ReferenceEquals(config, null))
			{
				chessType.E_LabelChessNameText.text = LanguageHelper.GetLanguageString(config.Name);
				chessType.E_ButtonChessTypeButton.AddListener(() =>
				{
					self.OnSelectChessTypeHandler(index);
				});	
			}
			
		}

		public static void ShowWindow(this DlgChessLobby self, Entity contextData = null)
		{
			int count = ChessGameTypeConfigCategory.Instance.List.Count;
			self.AddUIScrollItems(ref self.ScrollItemChessTypesdict, count);
			self.View.ELoopScrollList_ChessTypeLoopVerticalScrollRect.SetVisible(true, count);
		}
		public static void HideWindow(this DlgChessLobby self)
		{
			self.View.ELoopScrollList_ChessTypeLoopVerticalScrollRect.SetVisible(false);
			self.RemoveUIScrollItems(ref self.ScrollItemChessTypesdict);
		}

		public static void OnSelectChessTypeHandler(this DlgChessLobby self, int index)
		{
			string name = LanguageHelper.GetLanguageAddCNString(ChessGameTypeConfigCategory.Instance.GetNameIdByIndex(index));
			Log.Info($"选择了{name}");
		}

		 

	}
}
