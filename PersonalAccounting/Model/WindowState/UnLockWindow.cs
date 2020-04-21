using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.WindowState
{
    public class UnLockWindow : IWindowState
    {
        public bool GetWindowWorkSpaceIsEnable() => true;

        public float GetWindowWorkSpaceOpacity() => 1f;

        public bool GetLockImgVisibility() => false;

        public void LockWindowClick(WindowContext windowContext)
        {
            windowContext.WindowState = new LockWindow();
        }
    }
}
