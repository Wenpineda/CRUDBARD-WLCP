using CapaNegocio;

namespace CapaPresentación
{
    public partial class Form1 : Form
    {
        CN_Productos objetoCN = new CN_Productos();
        private string idProducto = null;
        private bool Editar = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeerProds();
        }
        private void LeerProds()
        {
            CN_Productos objeto = new CN_Productos();
            dataGridView1.DataSource = objeto.LeerProductos();
        }
        private void LimpiarForm()
        {
            txtNom.Clear();
            txtDesc.Clear();
            txtPrec.Clear();
            txtCant.Clear();
            txtEsta.Clear();

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            {
                if (Editar == false) 
                {
                    try 
                    {
                        objetoCN.InsProd(txtNom.Text, txtDesc.Text, txtPrec.Text, txtCant.Text, txtEsta.Text);
                        MessageBox.Show("Registro Exitoso");
                        LeerProds();
                        LimpiarForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al regustrar datos debido a : " + ex);
                    }
                }
                if (Editar == true)
                {
                    try
                    {
                        objetoCN.ActProd(txtNom.Text, txtDesc.Text, txtPrec.Text, txtCant.Text, txtEsta.Text,idProducto);
                        MessageBox.Show("Actualizacion Exitoso");
                        LeerProds();
                        LimpiarForm();
                        Editar = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar los datos debido a : " + ex);
                    }
                }
            }
        }

        private void BtnAct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNom.Text = dataGridView1.CurrentRow.Cells["nomprod"].Value.ToString();
                txtDesc.Text = dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();
                txtPrec.Text = dataGridView1.CurrentRow.Cells["precio"].Value.ToString();
                txtCant.Text = dataGridView1.CurrentRow.Cells["cantidad"].Value.ToString();
                txtEsta.Text = dataGridView1.CurrentRow.Cells["estado"].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells["idProducto"].Value.ToString();

            }
            else
                MessageBox.Show("Porfavor seleccione una fila");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                idProducto = dataGridView1.CurrentRow.Cells["idProducto"].Value.ToString();
                objetoCN.EliProd(idProducto);     
                MessageBox.Show("Se elimino correctamente");
                LeerProds();
                }
                else
                MessageBox.Show("Porfacor seleccione una fila");

            }
            
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}