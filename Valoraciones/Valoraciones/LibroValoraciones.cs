using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class LibroValoraciones
    {
        //Creo mi listado de valoraciones, donde se van a almacenar las valoraciones
        List<float> valoraciones = new List<float>();

        //Declaro mi constructor. Todas las clases tienen un constructor.
        public LibroValoraciones()
        {
            valoraciones = new List<float>();
        }
        
        //Declaramos metodos de mi clase
        public void AgregarValoracion(float valoracion)
        {
            valoraciones.Add(valoracion);
        }

        
    }
}
