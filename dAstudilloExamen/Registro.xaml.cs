
using Microsoft.Maui.Graphics.Text;

namespace dAstudilloExamen;

public partial class Registro : ContentPage
{

    public Registro(String usuario )
	{
		InitializeComponent();


		titulo.Text = usuario;
	}

    private void BotonCalcular(object sender, EventArgs e)
    {
        string monto = Monto.Text;
        float calculo = (float)(((1500 - float.Parse(monto)) / 4) + (1500 * 0.4));
        mensual.Text=calculo.ToString();
        
    }

    private void resumen_Clicked(object sender, EventArgs e)
    {
        DateTime fechaSeleccionada = fecha.Date;
        string dia = fechaSeleccionada.ToString();

        DisplayAlert("Resumen",
            "Nombre: "+nombre.Text+ "\n" +
            "Apellido: "+apellido.Text +"\n" +
            "Edad: "+edad.Text+ "\n" +
            "Fecha: "+ dia+ "\n"+
            "Pais: "+pais.SelectedItem+ "\n"+
            "Ciudad: " + ciudad.SelectedItem+ "\n"+
            "Monto: " +Monto.Text+ "\n"+
            "Mensual: "+mensual.Text+ "\n"+
            "Pago total: "+"1500"
             ,
            "OK");
    }
}