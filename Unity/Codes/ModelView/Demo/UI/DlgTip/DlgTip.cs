namespace ET
{
	 [ComponentOf(typeof(UIBaseWindow))]
	public  class DlgTip :Entity,IAwake,IUILogic
	{

		public DlgTipViewComponent View { get => this.Parent.GetComponent<DlgTipViewComponent>();} 

		 

	}
}
