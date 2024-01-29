
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[EnableMethod]
	public  class Scroll_Item_chessType : Entity,IAwake,IDestroy,IUIScrollItem 
	{
		public long DataId {get;set;}
		private bool isCacheNode = false;
		public void SetCacheMode(bool isCache)
		{
			this.isCacheNode = isCache;
		}

		public Scroll_Item_chessType BindTrans(Transform trans)
		{
			this.uiTransform = trans;
			return this;
		}

		public UnityEngine.UI.Button E_ButtonChessTypeButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if (this.isCacheNode)
     			{
     				if( this.m_E_ButtonChessTypeButton == null )
     				{
		    			this.m_E_ButtonChessTypeButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_ButtonChessType");
     				}
     				return this.m_E_ButtonChessTypeButton;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_ButtonChessType");
     			}
     		}
     	}

		public UnityEngine.UI.Image E_ButtonChessTypeImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if (this.isCacheNode)
     			{
     				if( this.m_E_ButtonChessTypeImage == null )
     				{
		    			this.m_E_ButtonChessTypeImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_ButtonChessType");
     				}
     				return this.m_E_ButtonChessTypeImage;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_ButtonChessType");
     			}
     		}
     	}

		public UnityEngine.UI.Text E_LabelChessNameText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if (this.isCacheNode)
     			{
     				if( this.m_E_LabelChessNameText == null )
     				{
		    			this.m_E_LabelChessNameText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_LabelChessName");
     				}
     				return this.m_E_LabelChessNameText;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_LabelChessName");
     			}
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_ButtonChessTypeButton = null;
			this.m_E_ButtonChessTypeImage = null;
			this.m_E_LabelChessNameText = null;
			this.uiTransform = null;
			this.DataId = 0;
		}

		private UnityEngine.UI.Button m_E_ButtonChessTypeButton = null;
		private UnityEngine.UI.Image m_E_ButtonChessTypeImage = null;
		private UnityEngine.UI.Text m_E_LabelChessNameText = null;
		public Transform uiTransform = null;
	}
}
