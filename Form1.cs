using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App_Estudiantes_CRUD
{
    public partial class Form1 : Form
    {
        //Instancia de la clase ControllerCRUD para el uso de los métodos.
        ControllerCRUD controllerCRUD = new ControllerCRUD();
        //Creación e inicialización de la variable que almacena el índice para el Estudiante seleccionado.
        int indexFilaSelect = -1;
        int indexFilaEliminate = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Estudiante de prueba.
            controllerCRUD.AddEstudiante(new Estudiante("Erick", 23, "erozgp@gmail.com"));
            updateFormComponents();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se verifica que se haya seleccionado cualquier celda de la fila con un click para guardar el índice de toda la fila.
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                indexFilaEliminate = e.RowIndex;                    
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (indexFilaSelect > -1 && isFieldNotNullValidator())
            {
                //Actualizar elemento seleccionado.
                Estudiante updatedDataEstudiante = getTxtBxData();
                controllerCRUD.UpdateEstudiante(indexFilaSelect, updatedDataEstudiante);
                updateFormComponents();
            }
            else if(isFieldNotNullValidator())
            {
                //Crea un nuevo estudiante.
                controllerCRUD.AddEstudiante(getTxtBxData());
                updateFormComponents();
            } else
            {
                MessageBox.Show("Completa todos los campos. :)");
            }

        }

        private Estudiante getRowData(int index)
        {
            //Obtengo los datos del elemento seleccionado y se devuelve el Estudiante.
            DataGridViewRow fila = dataGridView1.Rows[index];
            return new Estudiante(
                fila.Cells["Nombre"].Value.ToString(),
                Int32.Parse(fila.Cells["Edad"].Value.ToString()),
                fila.Cells["Email"].Value.ToString());

        }

        private Estudiante getTxtBxData()
        {
            //Obtengo los datos actualizados o nuevos de los cuadros de texto.
            return new Estudiante(
                TxtBxNombre.Text,
                Int32.Parse(TxtBxEdad.Text),
                TxtBxEmail.Text);
        }

        private Boolean isFieldNotNullValidator()
        {
            //Se valida el contenido en las cajas de texto.
            if (!string.IsNullOrEmpty(TxtBxNombre.Text) && !string.IsNullOrEmpty(TxtBxEdad.Text) && !string.IsNullOrEmpty(TxtBxEmail.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void updateFormComponents()
        {
            //Actualizo el DataGridView y valores.
            TxtBxNombre.Text = null;
            TxtBxEdad.Text = null;
            TxtBxEmail.Text = null;
            indexFilaSelect = -1;
            indexFilaEliminate = -1;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = controllerCRUD.GetEstudiantes();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (indexFilaEliminate > -1)
            {
                controllerCRUD.RemoveEstudiante(indexFilaEliminate);

                updateFormComponents();
            }
            else
            {
                MessageBox.Show("Seleccione un elemento para eliminar. :)");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se verifica que se haya seleccionado cualquier celda de la fila con doble click para guardar el índice de toda la fila y obtener los datos para cargarlos en los cuadros de texto.
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Estudiante dataEstudiante = getRowData(e.RowIndex);
                indexFilaSelect = e.RowIndex;
                label4.Text = Convert.ToString(indexFilaSelect);
                TxtBxNombre.Text = dataEstudiante.Nombre;
                TxtBxEdad.Text = Convert.ToString(dataEstudiante.Edad);
                TxtBxEmail.Text = dataEstudiante.Email;
            }
        }
    }
}