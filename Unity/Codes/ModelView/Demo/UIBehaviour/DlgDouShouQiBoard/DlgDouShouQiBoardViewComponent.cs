
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	[EnableMethod]
	public  class DlgDouShouQiBoardViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.Image EPos0Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPos0Image == null )
     			{
		    		this.m_EPos0Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos0");
     			}
     			return this.m_EPos0Image;
     		}
     	}

		public UnityEngine.UI.Button EPosButton0Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton0Button == null )
     			{
		    		this.m_EPosButton0Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EBoard/EPos0/EPosButton0");
     			}
     			return this.m_EPosButton0Button;
     		}
     	}

		public UnityEngine.UI.Image EPosButton0Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton0Image == null )
     			{
		    		this.m_EPosButton0Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos0/EPosButton0");
     			}
     			return this.m_EPosButton0Image;
     		}
     	}

		public ES_Piece ES_Piece0
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_es_piece0 == null )
     			{
		    	   Transform subTrans = UIFindHelper.FindDeepChild<Transform>(this.uiTransform.gameObject,"EBoard/EPos0/ES_Piece0");
		    	   this.m_es_piece0 = this.AddChild<ES_Piece,Transform>(subTrans);
     			}
     			return this.m_es_piece0;
     		}
     	}

		public UnityEngine.UI.Image EPos1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPos1Image == null )
     			{
		    		this.m_EPos1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos1");
     			}
     			return this.m_EPos1Image;
     		}
     	}

		public UnityEngine.UI.Button EPosButton1Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton1Button == null )
     			{
		    		this.m_EPosButton1Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EBoard/EPos1/EPosButton1");
     			}
     			return this.m_EPosButton1Button;
     		}
     	}

		public UnityEngine.UI.Image EPosButton1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton1Image == null )
     			{
		    		this.m_EPosButton1Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos1/EPosButton1");
     			}
     			return this.m_EPosButton1Image;
     		}
     	}

		public ES_Piece ES_Piece1
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_es_piece1 == null )
     			{
		    	   Transform subTrans = UIFindHelper.FindDeepChild<Transform>(this.uiTransform.gameObject,"EBoard/EPos1/ES_Piece1");
		    	   this.m_es_piece1 = this.AddChild<ES_Piece,Transform>(subTrans);
     			}
     			return this.m_es_piece1;
     		}
     	}

		public UnityEngine.UI.Image EPos2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPos2Image == null )
     			{
		    		this.m_EPos2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos2");
     			}
     			return this.m_EPos2Image;
     		}
     	}

		public UnityEngine.UI.Button EPosButton2Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton2Button == null )
     			{
		    		this.m_EPosButton2Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EBoard/EPos2/EPosButton2");
     			}
     			return this.m_EPosButton2Button;
     		}
     	}

		public UnityEngine.UI.Image EPosButton2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton2Image == null )
     			{
		    		this.m_EPosButton2Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos2/EPosButton2");
     			}
     			return this.m_EPosButton2Image;
     		}
     	}

		public ES_Piece ES_Piece2
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_es_piece2 == null )
     			{
		    	   Transform subTrans = UIFindHelper.FindDeepChild<Transform>(this.uiTransform.gameObject,"EBoard/EPos2/ES_Piece2");
		    	   this.m_es_piece2 = this.AddChild<ES_Piece,Transform>(subTrans);
     			}
     			return this.m_es_piece2;
     		}
     	}

		public UnityEngine.UI.Image EPos3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPos3Image == null )
     			{
		    		this.m_EPos3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos3");
     			}
     			return this.m_EPos3Image;
     		}
     	}

		public UnityEngine.UI.Button EPosButton3Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton3Button == null )
     			{
		    		this.m_EPosButton3Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EBoard/EPos3/EPosButton3");
     			}
     			return this.m_EPosButton3Button;
     		}
     	}

		public UnityEngine.UI.Image EPosButton3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton3Image == null )
     			{
		    		this.m_EPosButton3Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos3/EPosButton3");
     			}
     			return this.m_EPosButton3Image;
     		}
     	}

		public ES_Piece ES_Piece3
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_es_piece3 == null )
     			{
		    	   Transform subTrans = UIFindHelper.FindDeepChild<Transform>(this.uiTransform.gameObject,"EBoard/EPos3/ES_Piece3");
		    	   this.m_es_piece3 = this.AddChild<ES_Piece,Transform>(subTrans);
     			}
     			return this.m_es_piece3;
     		}
     	}

		public UnityEngine.UI.Image EPos4Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPos4Image == null )
     			{
		    		this.m_EPos4Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos4");
     			}
     			return this.m_EPos4Image;
     		}
     	}

		public UnityEngine.UI.Button EPosButton4Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton4Button == null )
     			{
		    		this.m_EPosButton4Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EBoard/EPos4/EPosButton4");
     			}
     			return this.m_EPosButton4Button;
     		}
     	}

		public UnityEngine.UI.Image EPosButton4Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton4Image == null )
     			{
		    		this.m_EPosButton4Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos4/EPosButton4");
     			}
     			return this.m_EPosButton4Image;
     		}
     	}

		public ES_Piece ES_Piece4
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_es_piece4 == null )
     			{
		    	   Transform subTrans = UIFindHelper.FindDeepChild<Transform>(this.uiTransform.gameObject,"EBoard/EPos4/ES_Piece4");
		    	   this.m_es_piece4 = this.AddChild<ES_Piece,Transform>(subTrans);
     			}
     			return this.m_es_piece4;
     		}
     	}

		public UnityEngine.UI.Image EPos5Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPos5Image == null )
     			{
		    		this.m_EPos5Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos5");
     			}
     			return this.m_EPos5Image;
     		}
     	}

		public UnityEngine.UI.Button EPosButton5Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton5Button == null )
     			{
		    		this.m_EPosButton5Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EBoard/EPos5/EPosButton5");
     			}
     			return this.m_EPosButton5Button;
     		}
     	}

		public UnityEngine.UI.Image EPosButton5Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton5Image == null )
     			{
		    		this.m_EPosButton5Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos5/EPosButton5");
     			}
     			return this.m_EPosButton5Image;
     		}
     	}

		public ES_Piece ES_Piece5
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_es_piece5 == null )
     			{
		    	   Transform subTrans = UIFindHelper.FindDeepChild<Transform>(this.uiTransform.gameObject,"EBoard/EPos5/ES_Piece5");
		    	   this.m_es_piece5 = this.AddChild<ES_Piece,Transform>(subTrans);
     			}
     			return this.m_es_piece5;
     		}
     	}

		public UnityEngine.UI.Image EPos6Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPos6Image == null )
     			{
		    		this.m_EPos6Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos6");
     			}
     			return this.m_EPos6Image;
     		}
     	}

		public UnityEngine.UI.Button EPosButton6Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton6Button == null )
     			{
		    		this.m_EPosButton6Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EBoard/EPos6/EPosButton6");
     			}
     			return this.m_EPosButton6Button;
     		}
     	}

		public UnityEngine.UI.Image EPosButton6Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton6Image == null )
     			{
		    		this.m_EPosButton6Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos6/EPosButton6");
     			}
     			return this.m_EPosButton6Image;
     		}
     	}

		public ES_Piece ES_Piece6
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_es_piece6 == null )
     			{
		    	   Transform subTrans = UIFindHelper.FindDeepChild<Transform>(this.uiTransform.gameObject,"EBoard/EPos6/ES_Piece6");
		    	   this.m_es_piece6 = this.AddChild<ES_Piece,Transform>(subTrans);
     			}
     			return this.m_es_piece6;
     		}
     	}

		public UnityEngine.UI.Image EPos7Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPos7Image == null )
     			{
		    		this.m_EPos7Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos7");
     			}
     			return this.m_EPos7Image;
     		}
     	}

		public UnityEngine.UI.Button EPosButton7Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton7Button == null )
     			{
		    		this.m_EPosButton7Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EBoard/EPos7/EPosButton7");
     			}
     			return this.m_EPosButton7Button;
     		}
     	}

		public UnityEngine.UI.Image EPosButton7Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton7Image == null )
     			{
		    		this.m_EPosButton7Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos7/EPosButton7");
     			}
     			return this.m_EPosButton7Image;
     		}
     	}

		public ES_Piece ES_Piece7
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_es_piece7 == null )
     			{
		    	   Transform subTrans = UIFindHelper.FindDeepChild<Transform>(this.uiTransform.gameObject,"EBoard/EPos7/ES_Piece7");
		    	   this.m_es_piece7 = this.AddChild<ES_Piece,Transform>(subTrans);
     			}
     			return this.m_es_piece7;
     		}
     	}

		public UnityEngine.UI.Image EPos8Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPos8Image == null )
     			{
		    		this.m_EPos8Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos8");
     			}
     			return this.m_EPos8Image;
     		}
     	}

		public UnityEngine.UI.Button EPosButton8Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton8Button == null )
     			{
		    		this.m_EPosButton8Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EBoard/EPos8/EPosButton8");
     			}
     			return this.m_EPosButton8Button;
     		}
     	}

		public UnityEngine.UI.Image EPosButton8Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton8Image == null )
     			{
		    		this.m_EPosButton8Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos8/EPosButton8");
     			}
     			return this.m_EPosButton8Image;
     		}
     	}

		public ES_Piece ES_Piece8
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_es_piece8 == null )
     			{
		    	   Transform subTrans = UIFindHelper.FindDeepChild<Transform>(this.uiTransform.gameObject,"EBoard/EPos8/ES_Piece8");
		    	   this.m_es_piece8 = this.AddChild<ES_Piece,Transform>(subTrans);
     			}
     			return this.m_es_piece8;
     		}
     	}

		public UnityEngine.UI.Image EPos9Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPos9Image == null )
     			{
		    		this.m_EPos9Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos9");
     			}
     			return this.m_EPos9Image;
     		}
     	}

		public UnityEngine.UI.Button EPosButton9Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton9Button == null )
     			{
		    		this.m_EPosButton9Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EBoard/EPos9/EPosButton9");
     			}
     			return this.m_EPosButton9Button;
     		}
     	}

		public UnityEngine.UI.Image EPosButton9Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton9Image == null )
     			{
		    		this.m_EPosButton9Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos9/EPosButton9");
     			}
     			return this.m_EPosButton9Image;
     		}
     	}

		public ES_Piece ES_Piece9
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_es_piece9 == null )
     			{
		    	   Transform subTrans = UIFindHelper.FindDeepChild<Transform>(this.uiTransform.gameObject,"EBoard/EPos9/ES_Piece9");
		    	   this.m_es_piece9 = this.AddChild<ES_Piece,Transform>(subTrans);
     			}
     			return this.m_es_piece9;
     		}
     	}

		public UnityEngine.UI.Image EPos10Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPos10Image == null )
     			{
		    		this.m_EPos10Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos10");
     			}
     			return this.m_EPos10Image;
     		}
     	}

		public UnityEngine.UI.Button EPosButton10Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton10Button == null )
     			{
		    		this.m_EPosButton10Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EBoard/EPos10/EPosButton10");
     			}
     			return this.m_EPosButton10Button;
     		}
     	}

		public UnityEngine.UI.Image EPosButton10Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton10Image == null )
     			{
		    		this.m_EPosButton10Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos10/EPosButton10");
     			}
     			return this.m_EPosButton10Image;
     		}
     	}

		public ES_Piece ES_Piece10
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_es_piece10 == null )
     			{
		    	   Transform subTrans = UIFindHelper.FindDeepChild<Transform>(this.uiTransform.gameObject,"EBoard/EPos10/ES_Piece10");
		    	   this.m_es_piece10 = this.AddChild<ES_Piece,Transform>(subTrans);
     			}
     			return this.m_es_piece10;
     		}
     	}

		public UnityEngine.UI.Image EPos11Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPos11Image == null )
     			{
		    		this.m_EPos11Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos11");
     			}
     			return this.m_EPos11Image;
     		}
     	}

		public UnityEngine.UI.Button EPosButton11Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton11Button == null )
     			{
		    		this.m_EPosButton11Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EBoard/EPos11/EPosButton11");
     			}
     			return this.m_EPosButton11Button;
     		}
     	}

		public UnityEngine.UI.Image EPosButton11Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton11Image == null )
     			{
		    		this.m_EPosButton11Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos11/EPosButton11");
     			}
     			return this.m_EPosButton11Image;
     		}
     	}

		public ES_Piece ES_Piece11
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_es_piece11 == null )
     			{
		    	   Transform subTrans = UIFindHelper.FindDeepChild<Transform>(this.uiTransform.gameObject,"EBoard/EPos11/ES_Piece11");
		    	   this.m_es_piece11 = this.AddChild<ES_Piece,Transform>(subTrans);
     			}
     			return this.m_es_piece11;
     		}
     	}

		public UnityEngine.UI.Image EPos12Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPos12Image == null )
     			{
		    		this.m_EPos12Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos12");
     			}
     			return this.m_EPos12Image;
     		}
     	}

		public UnityEngine.UI.Button EPosButton12Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton12Button == null )
     			{
		    		this.m_EPosButton12Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EBoard/EPos12/EPosButton12");
     			}
     			return this.m_EPosButton12Button;
     		}
     	}

		public UnityEngine.UI.Image EPosButton12Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton12Image == null )
     			{
		    		this.m_EPosButton12Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos12/EPosButton12");
     			}
     			return this.m_EPosButton12Image;
     		}
     	}

		public ES_Piece ES_Piece12
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_es_piece12 == null )
     			{
		    	   Transform subTrans = UIFindHelper.FindDeepChild<Transform>(this.uiTransform.gameObject,"EBoard/EPos12/ES_Piece12");
		    	   this.m_es_piece12 = this.AddChild<ES_Piece,Transform>(subTrans);
     			}
     			return this.m_es_piece12;
     		}
     	}

		public UnityEngine.UI.Image EPos13Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPos13Image == null )
     			{
		    		this.m_EPos13Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos13");
     			}
     			return this.m_EPos13Image;
     		}
     	}

		public UnityEngine.UI.Button EPosButton13Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton13Button == null )
     			{
		    		this.m_EPosButton13Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EBoard/EPos13/EPosButton13");
     			}
     			return this.m_EPosButton13Button;
     		}
     	}

		public UnityEngine.UI.Image EPosButton13Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton13Image == null )
     			{
		    		this.m_EPosButton13Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos13/EPosButton13");
     			}
     			return this.m_EPosButton13Image;
     		}
     	}

		public ES_Piece ES_Piece13
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_es_piece13 == null )
     			{
		    	   Transform subTrans = UIFindHelper.FindDeepChild<Transform>(this.uiTransform.gameObject,"EBoard/EPos13/ES_Piece13");
		    	   this.m_es_piece13 = this.AddChild<ES_Piece,Transform>(subTrans);
     			}
     			return this.m_es_piece13;
     		}
     	}

		public UnityEngine.UI.Image EPos14Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPos14Image == null )
     			{
		    		this.m_EPos14Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos14");
     			}
     			return this.m_EPos14Image;
     		}
     	}

		public UnityEngine.UI.Button EPosButton14Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton14Button == null )
     			{
		    		this.m_EPosButton14Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EBoard/EPos14/EPosButton14");
     			}
     			return this.m_EPosButton14Button;
     		}
     	}

		public UnityEngine.UI.Image EPosButton14Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton14Image == null )
     			{
		    		this.m_EPosButton14Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos14/EPosButton14");
     			}
     			return this.m_EPosButton14Image;
     		}
     	}

		public ES_Piece ES_Piece14
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_es_piece14 == null )
     			{
		    	   Transform subTrans = UIFindHelper.FindDeepChild<Transform>(this.uiTransform.gameObject,"EBoard/EPos14/ES_Piece14");
		    	   this.m_es_piece14 = this.AddChild<ES_Piece,Transform>(subTrans);
     			}
     			return this.m_es_piece14;
     		}
     	}

		public UnityEngine.UI.Image EPos15Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPos15Image == null )
     			{
		    		this.m_EPos15Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos15");
     			}
     			return this.m_EPos15Image;
     		}
     	}

		public UnityEngine.UI.Button EPosButton15Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton15Button == null )
     			{
		    		this.m_EPosButton15Button = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EBoard/EPos15/EPosButton15");
     			}
     			return this.m_EPosButton15Button;
     		}
     	}

		public UnityEngine.UI.Image EPosButton15Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EPosButton15Image == null )
     			{
		    		this.m_EPosButton15Image = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EBoard/EPos15/EPosButton15");
     			}
     			return this.m_EPosButton15Image;
     		}
     	}

		public ES_Piece ES_Piece15
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_es_piece15 == null )
     			{
		    	   Transform subTrans = UIFindHelper.FindDeepChild<Transform>(this.uiTransform.gameObject,"EBoard/EPos15/ES_Piece15");
		    	   this.m_es_piece15 = this.AddChild<ES_Piece,Transform>(subTrans);
     			}
     			return this.m_es_piece15;
     		}
     	}

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
			this.m_EPos0Image = null;
			this.m_EPosButton0Button = null;
			this.m_EPosButton0Image = null;
			this.m_es_piece0?.Dispose();
			this.m_es_piece0 = null;
			this.m_EPos1Image = null;
			this.m_EPosButton1Button = null;
			this.m_EPosButton1Image = null;
			this.m_es_piece1?.Dispose();
			this.m_es_piece1 = null;
			this.m_EPos2Image = null;
			this.m_EPosButton2Button = null;
			this.m_EPosButton2Image = null;
			this.m_es_piece2?.Dispose();
			this.m_es_piece2 = null;
			this.m_EPos3Image = null;
			this.m_EPosButton3Button = null;
			this.m_EPosButton3Image = null;
			this.m_es_piece3?.Dispose();
			this.m_es_piece3 = null;
			this.m_EPos4Image = null;
			this.m_EPosButton4Button = null;
			this.m_EPosButton4Image = null;
			this.m_es_piece4?.Dispose();
			this.m_es_piece4 = null;
			this.m_EPos5Image = null;
			this.m_EPosButton5Button = null;
			this.m_EPosButton5Image = null;
			this.m_es_piece5?.Dispose();
			this.m_es_piece5 = null;
			this.m_EPos6Image = null;
			this.m_EPosButton6Button = null;
			this.m_EPosButton6Image = null;
			this.m_es_piece6?.Dispose();
			this.m_es_piece6 = null;
			this.m_EPos7Image = null;
			this.m_EPosButton7Button = null;
			this.m_EPosButton7Image = null;
			this.m_es_piece7?.Dispose();
			this.m_es_piece7 = null;
			this.m_EPos8Image = null;
			this.m_EPosButton8Button = null;
			this.m_EPosButton8Image = null;
			this.m_es_piece8?.Dispose();
			this.m_es_piece8 = null;
			this.m_EPos9Image = null;
			this.m_EPosButton9Button = null;
			this.m_EPosButton9Image = null;
			this.m_es_piece9?.Dispose();
			this.m_es_piece9 = null;
			this.m_EPos10Image = null;
			this.m_EPosButton10Button = null;
			this.m_EPosButton10Image = null;
			this.m_es_piece10?.Dispose();
			this.m_es_piece10 = null;
			this.m_EPos11Image = null;
			this.m_EPosButton11Button = null;
			this.m_EPosButton11Image = null;
			this.m_es_piece11?.Dispose();
			this.m_es_piece11 = null;
			this.m_EPos12Image = null;
			this.m_EPosButton12Button = null;
			this.m_EPosButton12Image = null;
			this.m_es_piece12?.Dispose();
			this.m_es_piece12 = null;
			this.m_EPos13Image = null;
			this.m_EPosButton13Button = null;
			this.m_EPosButton13Image = null;
			this.m_es_piece13?.Dispose();
			this.m_es_piece13 = null;
			this.m_EPos14Image = null;
			this.m_EPosButton14Button = null;
			this.m_EPosButton14Image = null;
			this.m_es_piece14?.Dispose();
			this.m_es_piece14 = null;
			this.m_EPos15Image = null;
			this.m_EPosButton15Button = null;
			this.m_EPosButton15Image = null;
			this.m_es_piece15?.Dispose();
			this.m_es_piece15 = null;
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

		private UnityEngine.UI.Image m_EPos0Image = null;
		private UnityEngine.UI.Button m_EPosButton0Button = null;
		private UnityEngine.UI.Image m_EPosButton0Image = null;
		private ES_Piece m_es_piece0 = null;
		private UnityEngine.UI.Image m_EPos1Image = null;
		private UnityEngine.UI.Button m_EPosButton1Button = null;
		private UnityEngine.UI.Image m_EPosButton1Image = null;
		private ES_Piece m_es_piece1 = null;
		private UnityEngine.UI.Image m_EPos2Image = null;
		private UnityEngine.UI.Button m_EPosButton2Button = null;
		private UnityEngine.UI.Image m_EPosButton2Image = null;
		private ES_Piece m_es_piece2 = null;
		private UnityEngine.UI.Image m_EPos3Image = null;
		private UnityEngine.UI.Button m_EPosButton3Button = null;
		private UnityEngine.UI.Image m_EPosButton3Image = null;
		private ES_Piece m_es_piece3 = null;
		private UnityEngine.UI.Image m_EPos4Image = null;
		private UnityEngine.UI.Button m_EPosButton4Button = null;
		private UnityEngine.UI.Image m_EPosButton4Image = null;
		private ES_Piece m_es_piece4 = null;
		private UnityEngine.UI.Image m_EPos5Image = null;
		private UnityEngine.UI.Button m_EPosButton5Button = null;
		private UnityEngine.UI.Image m_EPosButton5Image = null;
		private ES_Piece m_es_piece5 = null;
		private UnityEngine.UI.Image m_EPos6Image = null;
		private UnityEngine.UI.Button m_EPosButton6Button = null;
		private UnityEngine.UI.Image m_EPosButton6Image = null;
		private ES_Piece m_es_piece6 = null;
		private UnityEngine.UI.Image m_EPos7Image = null;
		private UnityEngine.UI.Button m_EPosButton7Button = null;
		private UnityEngine.UI.Image m_EPosButton7Image = null;
		private ES_Piece m_es_piece7 = null;
		private UnityEngine.UI.Image m_EPos8Image = null;
		private UnityEngine.UI.Button m_EPosButton8Button = null;
		private UnityEngine.UI.Image m_EPosButton8Image = null;
		private ES_Piece m_es_piece8 = null;
		private UnityEngine.UI.Image m_EPos9Image = null;
		private UnityEngine.UI.Button m_EPosButton9Button = null;
		private UnityEngine.UI.Image m_EPosButton9Image = null;
		private ES_Piece m_es_piece9 = null;
		private UnityEngine.UI.Image m_EPos10Image = null;
		private UnityEngine.UI.Button m_EPosButton10Button = null;
		private UnityEngine.UI.Image m_EPosButton10Image = null;
		private ES_Piece m_es_piece10 = null;
		private UnityEngine.UI.Image m_EPos11Image = null;
		private UnityEngine.UI.Button m_EPosButton11Button = null;
		private UnityEngine.UI.Image m_EPosButton11Image = null;
		private ES_Piece m_es_piece11 = null;
		private UnityEngine.UI.Image m_EPos12Image = null;
		private UnityEngine.UI.Button m_EPosButton12Button = null;
		private UnityEngine.UI.Image m_EPosButton12Image = null;
		private ES_Piece m_es_piece12 = null;
		private UnityEngine.UI.Image m_EPos13Image = null;
		private UnityEngine.UI.Button m_EPosButton13Button = null;
		private UnityEngine.UI.Image m_EPosButton13Image = null;
		private ES_Piece m_es_piece13 = null;
		private UnityEngine.UI.Image m_EPos14Image = null;
		private UnityEngine.UI.Button m_EPosButton14Button = null;
		private UnityEngine.UI.Image m_EPosButton14Image = null;
		private ES_Piece m_es_piece14 = null;
		private UnityEngine.UI.Image m_EPos15Image = null;
		private UnityEngine.UI.Button m_EPosButton15Button = null;
		private UnityEngine.UI.Image m_EPosButton15Image = null;
		private ES_Piece m_es_piece15 = null;
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
