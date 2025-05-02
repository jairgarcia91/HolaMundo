using System.Text.RegularExpressions;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            bool isValid = Regex.IsMatch(txtContraseña1.Text, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&#])[A-Za-z\d@$!%*?&#]+$");

            if (!isValid)
            {
                MessageBox.Show("La contraseña no cumple con los requisitos especificados");
                return;
            }


            if (!txtContraseña1.Text.Equals(txtContraseña2.Text))
            {
                MessageBox.Show("Las contraseñas ingresadas son distintas");
                return;
            }

            MessageBox.Show("Las contraseñas ingresadas son iguales");
        }
    }
}
