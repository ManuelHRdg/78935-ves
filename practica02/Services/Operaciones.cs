using System;
using WSDL.mensajes;
using System.Collections;

namespace WSDL.operaciones
{
    public class Operaciones : Mensajes
    {

        ArrayList al = new ArrayList();
        public string Saludar(string nombre)
        {
            string msj = "Hola " + nombre;
            al.Add(nombre);
            return msj;
        }
        public string Mostrar(int id)
        {
            string x = (string) al[id];
            return x;
        }
    }
}