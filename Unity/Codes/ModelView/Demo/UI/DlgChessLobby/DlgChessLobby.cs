using System.Collections.Generic;

namespace ET
{
	 [ComponentOf(typeof(UIBaseWindow))]
	public  class DlgChessLobby :Entity,IAwake,IUILogic
	{

		public DlgChessLobbyViewComponent View { get => this.Parent.GetComponent<DlgChessLobbyViewComponent>();}

		public Dictionary<int, Scroll_Item_chessType> ScrollItemChessTypesdict = new Dictionary<int, Scroll_Item_chessType>();

	}
}
