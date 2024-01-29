
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	[EnableMethod]
	public  class DlgChessLobbyViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.LoopVerticalScrollRect ELoopScrollList_ChessTypeLoopVerticalScrollRect
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELoopScrollList_ChessTypeLoopVerticalScrollRect == null )
     			{
		    		this.m_ELoopScrollList_ChessTypeLoopVerticalScrollRect = UIFindHelper.FindDeepChild<UnityEngine.UI.LoopVerticalScrollRect>(this.uiTransform.gameObject,"ELoopScrollList_ChessType");
     			}
     			return this.m_ELoopScrollList_ChessTypeLoopVerticalScrollRect;
     		}
     	}

		public UnityEngine.UI.Button EButton_CloseButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_CloseButton == null )
     			{
		    		this.m_EButton_CloseButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EButton_Close");
     			}
     			return this.m_EButton_CloseButton;
     		}
     	}

		public UnityEngine.UI.Image EButton_CloseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_CloseImage == null )
     			{
		    		this.m_EButton_CloseImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EButton_Close");
     			}
     			return this.m_EButton_CloseImage;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_ELoopScrollList_ChessTypeLoopVerticalScrollRect = null;
			this.m_EButton_CloseButton = null;
			this.m_EButton_CloseImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.LoopVerticalScrollRect m_ELoopScrollList_ChessTypeLoopVerticalScrollRect = null;
		private UnityEngine.UI.Button m_EButton_CloseButton = null;
		private UnityEngine.UI.Image m_EButton_CloseImage = null;
		public Transform uiTransform = null;
	}
}
