using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.WindowState
{
    public class WindowContext
    {
        public IWindowState WindowState { get; set; }
        public WindowContext(IWindowState windowState)
        {
            WindowState = windowState;
        }

        public float GetWindowWorkSpaceOpacity() => WindowState.GetWindowWorkSpaceOpacity();

        public bool GetWindowWorkSpaceIsEnable() => WindowState.GetWindowWorkSpaceIsEnable();

        public bool GetLockImgVisibility() => WindowState.GetLockImgVisibility();

        public void LockWindowClick() => WindowState.LockWindowClick(this);
    }
}
