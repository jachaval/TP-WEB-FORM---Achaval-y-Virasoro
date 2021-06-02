using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class frmArticulo : Form
    {
        private Articulo articulo = null;
        public frmArticulo()
        {
            InitializeComponent(); 
            Text = "Agregar Artículo";
        }
        public frmArticulo(Articulo Articulo)
        {
            InitializeComponent();
            this.articulo = Articulo;
            Text = "Modificar Artículo";
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            //System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    txtCodigoArticulo.Text = articulo.CodigoArticulo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtUrlImagen.Text = articulo.UrlImagen;
                    RecargarImg(txtUrlImagen.Text);
                    cboMarca.SelectedValue = articulo.marca.Id;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }





        }//cierra load

        private void btnAceptar_Click(object sender, EventArgs e)
        {


            //Articulo nuevo = new Articulo();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.CodigoArticulo = txtCodigoArticulo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.UrlImagen = txtUrlImagen.Text;
                articulo.marca = (Marca)cboMarca.SelectedItem;

                if(articulo.Id == 0)
                {
                    articuloNegocio.agregar(articulo);
                    MessageBox.Show("Agregado sin problemas");
                }
                else
                {
                    articuloNegocio.modificar(articulo);
                    MessageBox.Show("Modificado sin problemas");
                }
                
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



        }//cierra aceptar

        private void RecargarImg(string img)
        {
            try
            {
                pbxArticulo.Load(img);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Url Imagen Inválida");
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            
            //    RecargarImg(txtUrlImagen.Text);
            
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            RecargarImg(txtUrlImagen.Text);
        }
    }//cierra class


}
