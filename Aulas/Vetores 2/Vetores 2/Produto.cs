using System.Globalization;

namespace Course
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public override string ToString()
        {
            return Nome
            + "\n"
            + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
