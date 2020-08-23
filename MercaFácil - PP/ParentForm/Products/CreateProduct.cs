using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParentForm
{
    public partial class CreateProduct : Form
    {
        MercaFacil_2DataSetTableAdapters.ProductoTableAdapter tap;

        public CreateProduct()
        {
            InitializeComponent();
        }

        private void btn_CreateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_vIva.Text != "" && txt_Amount.Text != "" && txt_Price.Text != "")
                {

                    string code = txt_Code.Text;
                    string name = txt_Name.Text;
                    string description = txt_Description.Text;

                    int n;
                    bool number = int.TryParse(txt_Amount.Text, out n);
                    bool number2 = int.TryParse(txt_Price.Text, out n);
                    bool number3 = int.TryParse(txt_vIva.Text, out n);
                    bool number4 = int.TryParse(cmb_TypeProduct.SelectedValue.ToString(), out n);

                    if (number && number2 && number3 && number4)
                    {
                        int type = Convert.ToInt32(cmb_TypeProduct.SelectedValue);                      
                        int vIva = Convert.ToInt32(txt_vIva.Text);
                        int Amount = Convert.ToInt32(txt_Amount.Text);
                        int price = Convert.ToInt32(txt_Price.Text);

                        if (code != "" && name != "" && description != "" && vIva > 0 && Amount > 0 && price > 0)
                        {
                            DialogResult result = MessageBox.Show("¿Desea Agregar el producto?", "Agregar Producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            if (result == DialogResult.OK)
                            {
                                tap = new MercaFacil_2DataSetTableAdapters.ProductoTableAdapter();

                                tap.Insert(code, name, description, type, price, vIva, Amount, 0);

                                MdiParent parent = (MdiParent)this.MdiParent;

                                parent.logTA.Insert("Producto Registrado", "Registro Producto", System.DateTime.Now, parent.CurrentUser.Id);

                                txt_Code.ResetText();
                                txt_Name.ResetText();
                                txt_Description.ResetText();
                                txt_vIva.ResetText();
                                txt_Amount.ResetText();
                                txt_Price.ResetText();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un entero válido");
                    }

                }
                else
                {
                    MessageBox.Show("Todos los Campos son Obligatorios... Llenelos de Forma Adecuada", "Agregar Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha Ocurrido el Siguiente Error: " + error, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateProduct_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mercaFacil_2DataSet.Tipo_Producto' Puede moverla o quitarla según sea necesario.
            this.tipo_ProductoTableAdapter.Fill(this.mercaFacil_2DataSet.Tipo_Producto);

        }
    }
}
