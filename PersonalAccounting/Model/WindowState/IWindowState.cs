using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.WindowState
{
    public interface IWindowState
    {
        float GetWindowWorkSpaceOpacity();
       
        bool GetWindowWorkSpaceIsEnable();
        
        bool GetLockImgVisibility();

        void LockWindowClick(WindowContext windowContext);
    }
}
