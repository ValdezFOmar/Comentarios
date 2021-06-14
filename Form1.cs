using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Comentarios
{
    public partial class Form1 : Form
    {
        List<Comentario> comentariosFromFile = ComentarioDB.ReadFromFile(@"C:\Users\Usuario\OOP-21\Comentarios\ComentariosDB.txt");
        List<Comentario> comentarios = new List<Comentario>();

        public void EscribirComentarios()
        {
            ListBoxComentarios.Items.Clear();
            foreach (Comentario c in comentarios)
            {
                ListBoxComentarios.Items.Add(c);
            }
        }

        public Form1()
        {
            InitializeComponent();
      
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Comentario c in comentariosFromFile)
            {
                comentarios.Add(c);
            }
            EscribirComentarios();
            SubirComentarioBtn.Enabled = false;
        }

        private void SubirComentarioBtn_Click(object sender, EventArgs e)
        {
            int id = ListBoxComentarios.Items.Count; 
            Comentario comentario = new Comentario(id, 0, ComentarioTxt.Text.Trim(), "Normal",
                                                   new Usuario("Coco", "coco@gmail.com", "323.3.24.24"), DateTime.Now);
            comentarios.Add(comentario);
            ListBoxComentarios.Items.Add(comentario);
            ComentarioTxt.Text = "";
            ComentarioTxt.Focus();
        }

        private void ComentarioTxt_TextChanged(object sender, EventArgs e)
        {
            if (ComentarioTxt.Text.Trim() == "")
            {
                SubirComentarioBtn.Enabled = false;
            }
            else
            {
                SubirComentarioBtn.Enabled = true;
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            int index = ListBoxComentarios.SelectedIndex;
            if (index != -1)
            {
                comentarios[index].Estado = "Borrar";
            }
            EscribirComentarios();
        }

        private void BtnReportar_Click(object sender, EventArgs e)
        {
            int index = ListBoxComentarios.SelectedIndex;
            if (index != -1)
            {
                comentarios[index].Estado = "Inapropiado";
            }
            EscribirComentarios();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var idMenorAMayor = from c in comentarios
                                          orderby c.ID ascending
                                          select c;
            comentariosFromFile.Clear();
            foreach (var c in idMenorAMayor)
            {
                comentariosFromFile.Add(c);
            }
            ComentarioDB.SaveToFile(comentariosFromFile, @"C:\Users\Usuario\OOP-21\Comentarios\ComentariosDB.txt");
        }

        private void BtnLike_Click(object sender, EventArgs e)
        {
            int index = ListBoxComentarios.SelectedIndex;
            if (index != -1)
            {
                comentarios[index].Likes += 1;
            }
            EscribirComentarios();
        }

        private void BtnOrdenarReciente_Click(object sender, EventArgs e)
        {
            comentarios = ComentarioDB.OrdenarRecientes(comentarios);
            EscribirComentarios();
        }

        private void BtnOrdenarLikes_Click(object sender, EventArgs e)
        {
            comentarios = ComentarioDB.OrdenarLikes(comentarios);
            EscribirComentarios();
        }
    }
}
