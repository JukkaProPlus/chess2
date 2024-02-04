namespace ET
{
	 [ComponentOf(typeof(UIBaseWindow))]
	public  class DlgDouShouQiBoard :Entity,IAwake,IUILogic
	{

		public DlgDouShouQiBoardViewComponent View { get => this.Parent.GetComponent<DlgDouShouQiBoardViewComponent>();} 
		public UnityEngine.UI.Button[] positionButtons = new UnityEngine.UI.Button[16];
		public ES_Piece[] ESPieces = new ES_Piece[16];
		public bool registeredESPicesEvent = false;
		 

	}
}
