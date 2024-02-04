
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[EnableMethod]
	public  class ES_Piece : Entity,ET.IAwake<UnityEngine.Transform>,IDestroy 
	{
		public UnityEngine.UI.Image E_SpriteImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_SpriteImage == null )
     			{
		    		this.m_E_SpriteImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Sprite");
     			}
     			return this.m_E_SpriteImage;
     		}
     	}

		public UnityEngine.UI.Text E_LabelText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_LabelText == null )
     			{
		    		this.m_E_LabelText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_Label");
     			}
     			return this.m_E_LabelText;
     		}
     	}

		public UnityEngine.UI.Button E_ButtonButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ButtonButton == null )
     			{
		    		this.m_E_ButtonButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Button");
     			}
     			return this.m_E_ButtonButton;
     		}
     	}

		public UnityEngine.UI.Image E_ButtonImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ButtonImage == null )
     			{
		    		this.m_E_ButtonImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Button");
     			}
     			return this.m_E_ButtonImage;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_SpriteImage = null;
			this.m_E_LabelText = null;
			this.m_E_ButtonButton = null;
			this.m_E_ButtonImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Image m_E_SpriteImage = null;
		private UnityEngine.UI.Text m_E_LabelText = null;
		private UnityEngine.UI.Button m_E_ButtonButton = null;
		private UnityEngine.UI.Image m_E_ButtonImage = null;
		public Transform uiTransform = null;
	}
}
