
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class Scroll_Item_chessTypeDestroySystem : DestroySystem<Scroll_Item_chessType> 
	{
		public override void Destroy( Scroll_Item_chessType self )
		{
			self.DestroyWidget();
		}
	}
}
