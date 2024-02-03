
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
			this.m_es_piece0?.Dispose();
			this.m_es_piece0 = null;
			this.m_EPos1Image = null;
			this.m_es_piece1?.Dispose();
			this.m_es_piece1 = null;
			this.m_EPos2Image = null;
			this.m_es_piece2?.Dispose();
			this.m_es_piece2 = null;
			this.m_EPos3Image = null;
			this.m_es_piece3?.Dispose();
			this.m_es_piece3 = null;
			this.m_EPos4Image = null;
			this.m_es_piece4?.Dispose();
			this.m_es_piece4 = null;
			this.m_EPos5Image = null;
			this.m_es_piece5?.Dispose();
			this.m_es_piece5 = null;
			this.m_EPos6Image = null;
			this.m_es_piece6?.Dispose();
			this.m_es_piece6 = null;
			this.m_EPos7Image = null;
			this.m_es_piece7?.Dispose();
			this.m_es_piece7 = null;
			this.m_EPos8Image = null;
			this.m_es_piece8?.Dispose();
			this.m_es_piece8 = null;
			this.m_EPos9Image = null;
			this.m_es_piece9?.Dispose();
			this.m_es_piece9 = null;
			this.m_EPos10Image = null;
			this.m_es_piece10?.Dispose();
			this.m_es_piece10 = null;
			this.m_EPos11Image = null;
			this.m_es_piece11?.Dispose();
			this.m_es_piece11 = null;
			this.m_EPos12Image = null;
			this.m_es_piece12?.Dispose();
			this.m_es_piece12 = null;
			this.m_EPos13Image = null;
			this.m_es_piece13?.Dispose();
			this.m_es_piece13 = null;
			this.m_EPos14Image = null;
			this.m_es_piece14?.Dispose();
			this.m_es_piece14 = null;
			this.m_EPos15Image = null;
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
		private ES_Piece m_es_piece0 = null;
		private UnityEngine.UI.Image m_EPos1Image = null;
		private ES_Piece m_es_piece1 = null;
		private UnityEngine.UI.Image m_EPos2Image = null;
		private ES_Piece m_es_piece2 = null;
		private UnityEngine.UI.Image m_EPos3Image = null;
		private ES_Piece m_es_piece3 = null;
		private UnityEngine.UI.Image m_EPos4Image = null;
		private ES_Piece m_es_piece4 = null;
		private UnityEngine.UI.Image m_EPos5Image = null;
		private ES_Piece m_es_piece5 = null;
		private UnityEngine.UI.Image m_EPos6Image = null;
		private ES_Piece m_es_piece6 = null;
		private UnityEngine.UI.Image m_EPos7Image = null;
		private ES_Piece m_es_piece7 = null;
		private UnityEngine.UI.Image m_EPos8Image = null;
		private ES_Piece m_es_piece8 = null;
		private UnityEngine.UI.Image m_EPos9Image = null;
		private ES_Piece m_es_piece9 = null;
		private UnityEngine.UI.Image m_EPos10Image = null;
		private ES_Piece m_es_piece10 = null;
		private UnityEngine.UI.Image m_EPos11Image = null;
		private ES_Piece m_es_piece11 = null;
		private UnityEngine.UI.Image m_EPos12Image = null;
		private ES_Piece m_es_piece12 = null;
		private UnityEngine.UI.Image m_EPos13Image = null;
		private ES_Piece m_es_piece13 = null;
		private UnityEngine.UI.Image m_EPos14Image = null;
		private ES_Piece m_es_piece14 = null;
		private UnityEngine.UI.Image m_EPos15Image = null;
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
