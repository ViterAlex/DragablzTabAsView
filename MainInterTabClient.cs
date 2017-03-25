using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Dragablz;
using DragablzTabAsView.Views;

namespace DragablzTabAsView
{
    class MainInterTabClient:IInterTabClient
    {
        #region Implementation of IInterTabClient

        public INewTabHost<Window> GetNewHost(IInterTabClient interTabClient, object partition, TabablzControl source)
        {
            var view = new TabHostWindow();
            return  new NewTabHost<Window>(view,view.TabsContainer);
        }

        public TabEmptiedResponse TabEmptiedHandler(TabablzControl tabControl, Window window)
        {
            return TabEmptiedResponse.CloseWindowOrLayoutBranch;
        }

        #endregion
    }
}
