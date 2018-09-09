using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Invoco al constructor para crear un objeto 
            LibroValoraciones libro = new LibroValoraciones();
            libro.AgregarValoracion(3.5f);
            libro.AgregarValoracion(5);

            //Construyo un objeto sobre la variable de tipo libro, creada inicialmente como un objeto de clase 
            libro = new LibroValoraciones();
            libro.AgregarValoracion(2);

            //Hay que tener cuidado cuando creamos una variable como un objeto de clase a cuando utilizo la variable para 
            //almacenar datos. 

            //Asigno valores de una variable a otra varible siempre y cuando sean del mismo tipo, ya q sino me da error
            LibroValoraciones libro2 = libro;

            //Lo q no podria hacer seria la siguiente conversion, ya q estoy asignando un entero a mi varible del tipo
            //LibroValoraciones
            LibroValoraciones libro3 = 10;

            //Lo que si puedo hacer es llamar a mi metodo de AgregarValoracion 
            libro.AgregarValoracion(2);
        }
    }
}
