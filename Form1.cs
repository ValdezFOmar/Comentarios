using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Comentarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
            Comentario comentario = new Comentario(1, 34, "Primer Comentario", false,
                                                  new Usuario("Yo", "elespaiderman420@gmail.com", "192.128.001.6"), 
                                                  DateTime.Now);
            ComentarioDB.SaveToFile(comentario, @"C:\Users\Usuario\OOP-21\Comentarios\ComentariosDB.txt");
            */
        }

        private void SubirComentarioBtn_Click(object sender, EventArgs e)
        {
            List<Comentario> comentarios = ComentarioDB.ReadFromFile(@"C:\Users\Usuario\OOP-21\Comentarios\ComentariosDB.txt");
            foreach (Comentario c in comentarios)
            {
                label1.Text += c.ToString();
            }
        }
    }
}
