
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	[EnableMethod]
	public  class DlgTipViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.Text ELabel_TipText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELabel_TipText == null )
     			{
		    		this.m_ELabel_TipText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"ELabel_Tip");
     			}
     			return this.m_ELabel_TipText;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_ELabel_TipText = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Text m_ELabel_TipText = null;
		public Transform uiTransform = null;
	}
}
