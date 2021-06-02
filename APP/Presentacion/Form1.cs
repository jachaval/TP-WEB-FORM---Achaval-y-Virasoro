using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form

    {

        private List<Articulo> listaArticulo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {      
            cargarGrilla();
        }


        private void cargarGrilla()
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                listaArticulo = articuloNegocio.listar();
                dgvArticulo.DataSource = listaArticulo;

                ocultarColumnas();

                RecargarImg(listaArticulo[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            //Oculto Columnas de la grilla.
            //Puedo poner el indice de la columna o el nombre de la propiedad.

            //dgvArticulo.Columns["Marca"].Visible = false;
            dgvArticulo.Columns["Descripcion"].Visible = false;
            dgvArticulo.Columns["UrlImagen"].Visible = false;
        }

        private void RecargarImg(string img)
        {
            
            pbxArticulo.Load(img);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmArticulo agregar = new frmArticulo();
            agregar.ShowDialog();
            cargarGrilla();
        }

        //evento
        private void dgvArticulo_MouseClick(object sender, MouseEventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            RecargarImg(seleccionado.UrlImagen);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            frmArticulo modificar = new frmArticulo(seleccionado);
            modificar.ShowDialog();
            cargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (MessageBox.Show("Estás seguro de eliminarlo?", "Eliminandooo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    negocio.eliminar(seleccionado.Id);
                    cargarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // busqueda();
        }
        private void busqueda()
        {
            //txtFiltro
            List<Articulo> listaFiltrada;
            if (txtFiltro.Text != "")
            {
                listaFiltrada = listaArticulo.FindAll(Filtrar => Filtrar.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()) || Filtrar.marca.Descripcion.ToUpper().Contains(txtFiltro.Text.ToUpper()) || Filtrar.CodigoArticulo.ToUpper().Contains(txtFiltro.Text.ToUpper()));
                dgvArticulo.DataSource = null;
                dgvArticulo.DataSource = listaFiltrada;
            }
            else
            {
                dgvArticulo.DataSource = null;
                dgvArticulo.DataSource = listaArticulo;
            }

            ocultarColumnas();
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            busqueda();
        }
    }
}
