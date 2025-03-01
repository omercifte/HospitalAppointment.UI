using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointment.UI.Tools
{
    public class FormUtils
    {
        public static bool IsFormsOpen(Form form)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == form.GetType())
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
