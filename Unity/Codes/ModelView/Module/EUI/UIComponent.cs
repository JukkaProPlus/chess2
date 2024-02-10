﻿using System.Collections.Generic;

namespace ET
{
    public interface IUILogic
    {
        
    }

    public interface IUIScrollItem
    {
        
    }
    
    [ComponentOf(typeof(Scene))]
    [ChildType(typeof(UIBaseWindow))]
    public class UIComponent : Entity,IAwake,IDestroy
    {
        public Dictionary<int, UIBaseWindow> AllWindowsDic     = new Dictionary<int, UIBaseWindow>();
        public List<WindowID> UIBaseWindowlistCached           = new List<WindowID>();
        public Dictionary<int, UIBaseWindow> VisibleWindowsDic = new Dictionary<int, UIBaseWindow>();
        public Queue<int> StackWindowsQueue               = new Queue<int>();
        public bool IsPopStackWndStatus                        = false;

    }
}