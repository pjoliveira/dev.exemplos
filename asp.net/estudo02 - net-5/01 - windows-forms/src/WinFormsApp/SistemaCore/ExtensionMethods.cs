using System;
using System.Linq;
using System.Text;

namespace SistemaCore
{

    /// <summary>
    /// Classe que extende os métodos Asp .Net
    /// </summary>
    public static class ExtensionMethods
    {

        /// <summary>
        /// Coloca os traços no documento informado
        /// </summary>
        /// <param name="cep">Cep desejado - Pode ser com pontos já ou não</param>
        /// <returns></returns>
        public static string FormatarCEP(this string cep)
        {
            try
            {
                var tmp = cep = string.Empty;

                if (tmp.Length == 8)
                    return Convert.ToUInt64(tmp).ToString(@"00000\-000");
                else
                    return cep;
            }
            catch { return cep; }
        }

        /// <summary>
        /// Método que converte um texto para inteiro
        /// </summary>
        /// <param name="valor">Valor em string</param>
        /// <returns>Valor int32</returns>
        public static int ToInt32(this string valor)
        {
            try
            {
                return Convert.ToInt32(valor);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Método que converte um objeto para um valor double
        /// </summary>
        /// <param name="obj">Número em texto a ser convertido</param>
        /// <returns>Retorna o número double convertido</returns>
        public static double ToDouble(this object obj)
        {
            try { return Convert.ToDouble(obj); }
            catch { throw new Exception(string.Format("O valor informado não é um valor double válido! Valor informado: '{0}'", obj)); }
        }

        /// <summary>
        /// Método que verifica se um texto é nulo. Já usa o Trim
        /// </summary>
        /// <param name="text">Texto a ser verificado</param>
        /// <returns>Retorna se é nulo ou não</returns>
        public static bool IsNullOrEmpty(this string text)
        {
            try
            {
                if (text == null)
                    return true;

                return string.IsNullOrEmpty(text.Trim());
            }
            catch { throw new Exception(string.Format("O valor informado não é um valor texto válido! Valor informado: '{0}'", text)); }
        }


    }
}
