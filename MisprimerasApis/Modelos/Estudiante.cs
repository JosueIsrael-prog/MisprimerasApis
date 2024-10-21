namespace MisprimerasApis.Modelos
{
    public class Estudiante
    {
        public int id { get; set; }
        public string Nombre { get, set; }

        public DateTime FechaNacimiento { get; set; }
        public Boolean EstaInscrito { get; set; }
        public int Edad { get; set; }
    }
}
