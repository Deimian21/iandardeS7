using System.Net;

namespace iandardeS7.Vistas;

public partial class AgergarEstudiante : ContentPage
{
    public AgergarEstudiante()
    {
        InitializeComponent();
    }

    private void btnAgregar_Clicked(object sender, EventArgs e)
    {
        try
        {
            WebClient client = new WebClient();
            var parametros = new System.Collections.Specialized.NameValueCollection();
            parametros.Add("nombre", txtNombre.Text);
            parametros.Add("apellido", txtApellido.Text);
            parametros.Add("edad", txtEdad.Text);
            client.UploadValues("http://192.168.1.2/moviles/post.php", "POST", parametros);
            Navigation.PushAsync(new Inicio());
        }
        catch (Exception ex)
        {

            DisplayAlert("ERROR", ex.Message, "CERRAR");
        }

    }
}