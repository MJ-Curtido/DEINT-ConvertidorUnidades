using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_ConvertidorUnidades.MVVM.ViewModels
{
    public class ConverterViewModel
    {
        public ConverterViewModel(String opcion)
        {
            if (opcion.Equals("INFORMACION")) { }
            else if (opcion.Equals("VOLUMEN")) { }
            else if (opcion.Equals("ALTURA")) { }
            else if (opcion.Equals("MASA")) { }
            else if (opcion.Equals("TEMPERATURA")) { }
            else if (opcion.Equals("ENERGIA")) { }
            else if (opcion.Equals("AREA")) { }
            else if (opcion.Equals("VELOCIDAD")) { }
            else { }
        }
    }
}
