namespace ET
{
	 [ComponentOf(typeof(UIBaseWindow))]
	public  class DlgDouShouQiBoard :Entity,IAwake,IUILogic
	{

		public DlgDouShouQiBoardViewComponent View { get => this.Parent.GetComponent<DlgDouShouQiBoardViewComponent>();} 
		public UnityEngine.Transform[] positions = new UnityEngine.Transform[16];
		public ES_Piece[] ESPieces = new ES_Piece[16];
		 

	}
}
