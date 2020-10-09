using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BLL
{
    public static class GLOBAL_BLL
    {
        public static string stringConexaoBanco;
        public static LOGIN_DESK_DTO login_desk;

        public static bool IsDate(string date)
        {
            DateTime dt;

            return DateTime.TryParse(date, out dt);

        }

        public static List<ItemComboBox> Anos(int PrimeiroAno, int UltimoAno, bool Inverso)
        {
            try
            {

                List<ItemComboBox> anos = new List<ItemComboBox>();
                if (Inverso)
                {
                    for (int i = UltimoAno; i >= PrimeiroAno; i--)
                    {
                        anos.Add(new ItemComboBox() { value = i.ToString(), text = i.ToString() });
                    }
                }
                else
                {
                    for (int i = PrimeiroAno; i <= UltimoAno; i++)
                    {
                        anos.Add(new ItemComboBox() { value = i.ToString(), text = i.ToString() });
                    }
                }
                return anos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static DataTable Select(string Query)
        {
            try
            {
                DataTable dtt = new GLOBAL_DAO(stringConexaoBanco).Select(Query);
                return dtt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

    public class ValidaException : Exception
    {
        public string Value { get; set; }
        public string Title { get; set; }
        public ValidaException(string Message, string Value = "Dados incorretos", string Title = "")
            : base(Message)
        {
            this.Value = Value;
            this.Title = Title;
        }
    }
}
