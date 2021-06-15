using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using System.Data;
using System.Linq;

namespace Comentarios
{
    class Usuario
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string DireccionIP { get; set; }

        public Usuario(string nombre, string correo, string direccionIP)
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
        public string Estado { get; set; }
        public Usuario Autor { get; set; }
        public DateTime Fecha { get; set; }

        public Comentario() { }
        public Comentario(int id, int likes, string texto, string estado, Usuario autor, DateTime fecha)
        {
            ID = id;
            Likes = likes;
            Texto = texto;
            Autor = autor;
            Fecha = fecha;
            Estado = estado;
        }
        public override string ToString()
        {
            string comentario;
            try
            {
                if (Estado == "Borrar")
                {
                    comentario = $"By: {Autor} - Este comentario ha sido borrado - On: {Fecha}";
                }
                else if (Estado == "Inapropiado")
                {
                    comentario = $"By: {Autor} - Este comentario fue marcado como inapropiado - On: {Fecha}";
                }
                else
                {
                    comentario = $"By: {Autor} - Likes: {Likes} - \" {Texto} \" - On: {Fecha}";
                }
                return String.Format(comentario);
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.ToString());
                return String.Format("");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return String.Format("");
            }
        }
    }
    class ComentarioDB
    {
        //Ruta = C:\Users\Usuario\OOP-21\Comentarios\ComentariosDB.txt
        public static void SaveToFile(List<Comentario> comentarios, string path)
        {
            StreamWriter textOut = null;
            try
            {
                textOut = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
                foreach (Comentario comentario in comentarios)
                {
                    textOut.Write(comentario.ID + "|");
                    textOut.Write(comentario.Likes + "|");
                    textOut.Write(comentario.Texto + "|");
                    textOut.Write(comentario.Estado + "|");
                    textOut.Write(comentario.Autor.Nombre + "|");
                    textOut.Write(comentario.Autor.Correo + "|");
                    textOut.Write(comentario.Autor.DireccionIP + "|");
                    textOut.WriteLine(comentario.Fecha.ToString("g", CultureInfo.CreateSpecificCulture("es-ES")));
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if  (textOut != null)
                {
                    textOut.Close();
                }
            }
        }
        public static List<Comentario> ReadFromFile(string path)
        {
            List<Comentario> comentarios = new List<Comentario>();
            StreamReader textIn = null;
            try
            {
                textIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));
                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    string[] columns = row.Split('|');
                    Comentario c = new Comentario();
                    c.ID = int.Parse(columns[0]);
                    c.Likes = int.Parse(columns[1]);
                    c.Texto = columns[2];
                    c.Estado = columns[3];
                    c.Autor = new Usuario(columns[4], columns[5], columns[6]);
                    c.Fecha = DateTime.Parse(columns[7], CultureInfo.CreateSpecificCulture("es-ES"));
                    comentarios.Add(c);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (textIn != null)
                {
                    textIn.Close();
                }
            }
            return comentarios;
        }
        public static List<Comentario> OrdenarLikes(List<Comentario> comentarios)
        {
            List<Comentario> comentariosOrdenados = new List<Comentario>();
            var comentariosPorLikes = from c in comentarios
                                       orderby c.Likes descending
                                       select c;
            foreach (var c in comentariosPorLikes)
            {
                comentariosOrdenados.Add(c);
            }
            return comentariosOrdenados;
        }
        public static List<Comentario> OrdenarRecientes(List<Comentario> comentarios)
        {
            List<Comentario> comentariosOrdenados = new List<Comentario>();
            var comentariosRecientes = from c in comentarios
                                       orderby c.Fecha descending
                                       select c;
            foreach (var c in comentariosRecientes)
            {
                comentariosOrdenados.Add(c);
            }
            return comentariosOrdenados;
        }
    }
}
