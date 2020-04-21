using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.WindowState
{
    public class LockWindow : IWindowState
    {
        public bool GetWindowWorkSpaceIsEnable() => false;

        public float GetWindowWorkSpaceOpacity() => 0.5f;

        public bool GetLockImgVisibility() => true;

        public void LockWindowClick(WindowContext windowContext)
        {
            windowContext.WindowState = new UnLockWindow();
        }
    }
}
