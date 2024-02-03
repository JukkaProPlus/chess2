
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class ES_PieceAwakeSystem : AwakeSystem<ES_Piece,Transform> 
	{
		public override void Awake(ES_Piece self,Transform transform)
		{
			self.uiTransform = transform;
		}
	}


	[ObjectSystem]
	public class ES_PieceDestroySystem : DestroySystem<ES_Piece> 
	{
		public override void Destroy(ES_Piece self)
		{
			self.DestroyWidget();
		}
	}
}
