namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesString
    {
        public int RetornarQuantidadeCaracteres(string texto)
        {
            var numeroCaracteres = texto.Length;
            return numeroCaracteres;
        }

        public bool ContemCaractere(string texto, string textoProcurado)
        {
            return texto.Contains(textoProcurado);
        }

        public bool TextoTerminaCom(string texto, string textoProcurado)
        {
            var termina = texto.EndsWith(textoProcurado);
            return termina;
        }
    }
}