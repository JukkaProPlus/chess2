
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	[EnableMethod]
	public  class DlgDouShouQiFinishViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.Text E_ResultText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ResultText == null )
     			{
		    		this.m_E_ResultText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_Result");
     			}
     			return this.m_E_ResultText;
     		}
     	}

		public UnityEngine.UI.Button E_AgainButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_AgainButton == null )
     			{
		    		this.m_E_AgainButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Again");
     			}
     			return this.m_E_AgainButton;
     		}
     	}

		public UnityEngine.UI.Image E_AgainImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_AgainImage == null )
     			{
		    		this.m_E_AgainImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Again");
     			}
     			return this.m_E_AgainImage;
     		}
     	}

		public UnityEngine.UI.Text E_AgainText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_AgainText == null )
     			{
		    		this.m_E_AgainText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_Again/E_Again");
     			}
     			return this.m_E_AgainText;
     		}
     	}

		public UnityEngine.UI.Button E_LeaveButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_LeaveButton == null )
     			{
		    		this.m_E_LeaveButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Leave");
     			}
     			return this.m_E_LeaveButton;
     		}
     	}

		public UnityEngine.UI.Image E_LeaveImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_LeaveImage == null )
     			{
		    		this.m_E_LeaveImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Leave");
     			}
     			return this.m_E_LeaveImage;
     		}
     	}

		public UnityEngine.UI.Text E_LeaveText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_LeaveText == null )
     			{
		    		this.m_E_LeaveText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_Leave/E_Leave");
     			}
     			return this.m_E_LeaveText;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_ResultText = null;
			this.m_E_AgainButton = null;
			this.m_E_AgainImage = null;
			this.m_E_AgainText = null;
			this.m_E_LeaveButton = null;
			this.m_E_LeaveImage = null;
			this.m_E_LeaveText = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Text m_E_ResultText = null;
		private UnityEngine.UI.Button m_E_AgainButton = null;
		private UnityEngine.UI.Image m_E_AgainImage = null;
		private UnityEngine.UI.Text m_E_AgainText = null;
		private UnityEngine.UI.Button m_E_LeaveButton = null;
		private UnityEngine.UI.Image m_E_LeaveImage = null;
		private UnityEngine.UI.Text m_E_LeaveText = null;
		public Transform uiTransform = null;
	}
}
