
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	[EnableMethod]
	public  class DlgDouShouQiBoardViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.Button EButton_PrepareMeButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_PrepareMeButton == null )
     			{
		    		this.m_EButton_PrepareMeButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EButton_PrepareMe");
     			}
     			return this.m_EButton_PrepareMeButton;
     		}
     	}

		public UnityEngine.UI.Image EButton_PrepareMeImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_PrepareMeImage == null )
     			{
		    		this.m_EButton_PrepareMeImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EButton_PrepareMe");
     			}
     			return this.m_EButton_PrepareMeImage;
     		}
     	}

		public UnityEngine.UI.Text ELabel_PrepareText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELabel_PrepareText == null )
     			{
		    		this.m_ELabel_PrepareText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"EButton_PrepareMe/ELabel_Prepare");
     			}
     			return this.m_ELabel_PrepareText;
     		}
     	}

		public UnityEngine.UI.Text ELabel_MyNameText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELabel_MyNameText == null )
     			{
		    		this.m_ELabel_MyNameText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"ELabel_MyName");
     			}
     			return this.m_ELabel_MyNameText;
     		}
     	}

		public UnityEngine.UI.Text ELabel_OpponentNameText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELabel_OpponentNameText == null )
     			{
		    		this.m_ELabel_OpponentNameText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"ELabel_OpponentName");
     			}
     			return this.m_ELabel_OpponentNameText;
     		}
     	}

		public UnityEngine.UI.Button EButton_PrepareOpponentButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_PrepareOpponentButton == null )
     			{
		    		this.m_EButton_PrepareOpponentButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EButton_PrepareOpponent");
     			}
     			return this.m_EButton_PrepareOpponentButton;
     		}
     	}

		public UnityEngine.UI.Image EButton_PrepareOpponentImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_PrepareOpponentImage == null )
     			{
		    		this.m_EButton_PrepareOpponentImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EButton_PrepareOpponent");
     			}
     			return this.m_EButton_PrepareOpponentImage;
     		}
     	}

		public UnityEngine.UI.Text ELabel_PrepareOpponentText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELabel_PrepareOpponentText == null )
     			{
		    		this.m_ELabel_PrepareOpponentText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"EButton_PrepareOpponent/ELabel_PrepareOpponent");
     			}
     			return this.m_ELabel_PrepareOpponentText;
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
			this.m_EButton_PrepareMeButton = null;
			this.m_EButton_PrepareMeImage = null;
			this.m_ELabel_PrepareText = null;
			this.m_ELabel_MyNameText = null;
			this.m_ELabel_OpponentNameText = null;
			this.m_EButton_PrepareOpponentButton = null;
			this.m_EButton_PrepareOpponentImage = null;
			this.m_ELabel_PrepareOpponentText = null;
			this.m_EButton_CloseButton = null;
			this.m_EButton_CloseImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Button m_EButton_PrepareMeButton = null;
		private UnityEngine.UI.Image m_EButton_PrepareMeImage = null;
		private UnityEngine.UI.Text m_ELabel_PrepareText = null;
		private UnityEngine.UI.Text m_ELabel_MyNameText = null;
		private UnityEngine.UI.Text m_ELabel_OpponentNameText = null;
		private UnityEngine.UI.Button m_EButton_PrepareOpponentButton = null;
		private UnityEngine.UI.Image m_EButton_PrepareOpponentImage = null;
		private UnityEngine.UI.Text m_ELabel_PrepareOpponentText = null;
		private UnityEngine.UI.Button m_EButton_CloseButton = null;
		private UnityEngine.UI.Image m_EButton_CloseImage = null;
		public Transform uiTransform = null;
	}
}
