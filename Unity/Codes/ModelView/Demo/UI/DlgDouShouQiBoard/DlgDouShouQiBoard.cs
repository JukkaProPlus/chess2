namespace ET
{
	 [ComponentOf(typeof(UIBaseWindow))]
	public  class DlgDouShouQiBoard :Entity,IAwake,IUILogic
	{

		public DlgDouShouQiBoardViewComponent View { get => this.Parent.GetComponent<DlgDouShouQiBoardViewComponent>();} 

		 

	}
}
