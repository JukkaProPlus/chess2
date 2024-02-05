namespace ET
{
	 [ComponentOf(typeof(UIBaseWindow))]
	public  class DlgDouShouQiFinish :Entity,IAwake,IUILogic
	{

		public DlgDouShouQiFinishViewComponent View { get => this.Parent.GetComponent<DlgDouShouQiFinishViewComponent>();} 

		 

	}
}
