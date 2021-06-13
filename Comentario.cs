using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Comentarios
{
    class Usuario
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string DireccionIP { get; set; }

        Usuario(string nombre, string correo, string direccionIP)
        {
            Nombre = nombre;
            Correo = correo;
            DireccionIP = direccionIP;
        }

        public override string ToString()
        {
            return String.Format($"{Nombre}");
        }
    }

    class Comentario
    {
        public int ID { get; set; }
        public int Likes { get; set; }
        public string Texto { get; set; }
        public bool Es_Inapropiado { get; set; }
        public Usuario Autor { get; set; }
        public DateTime Fecha { get; set; }

        Comentario(int id, int likes, string texto, bool inapropiado, Usuario autor, DateTime fecha)
        {
            ID = id;
            Likes = likes;
            Texto = texto;
            Autor = autor;
            Fecha = fecha;
            Es_Inapropiado = inapropiado;
        }
    }

    class ComentarioDB
    {
        //Ruta = C:\Users\Usuario\OOP-21\Comentarios\ComentariosDB.txt
    }
}
