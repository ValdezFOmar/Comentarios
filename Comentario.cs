using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Globalization;

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
        public bool Es_Inapropiado { get; set; }
        public Usuario Autor { get; set; }
        public DateTime Fecha { get; set; }

        public Comentario() { }
        public Comentario(int id, int likes, string texto, bool inapropiado, Usuario autor, DateTime fecha)
        {
            ID = id;
            Likes = likes;
            Texto = texto;
            Autor = autor;
            Fecha = fecha;
            Es_Inapropiado = inapropiado;
        }

        public override string ToString()
        {
            return String.Format($"{ID}; Likes: {Likes}; <{Texto}>; By: {Autor}; On: {Fecha}\n");
        }
    }

    class ComentarioDB
    {
        //Ruta = C:\Users\Usuario\OOP-21\Comentarios\ComentariosDB.txt
        public static void SaveToFile(Comentario comentario, string path)
        {
            StreamWriter textOut = null;
            try
            {
                textOut = new StreamWriter(new FileStream(path, FileMode.Append, FileAccess.Write));
                textOut.Write(comentario.ID + "|");
                textOut.Write(comentario.Likes + "|");
                textOut.Write(comentario.Texto + "|");
                textOut.Write(comentario.Es_Inapropiado + "|");
                textOut.Write(comentario.Autor.Nombre + "|");
                textOut.Write(comentario.Autor.Correo + "|");
                textOut.Write(comentario.Autor.DireccionIP + "|");
                textOut.WriteLine(comentario.Fecha.ToString("g", CultureInfo.CreateSpecificCulture("es-ES")));
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
                    c.Es_Inapropiado = bool.Parse(columns[3]);
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

    }
}
