using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlterarData
{
    interface InterfaceData
    {
        string ChangeDate(string date, char op, long value);
        bool ValidarDiaTextBox(int diaParaChecar);
        bool ValidarMesTextBox(int mesParaChecar);
        bool ValidarDiaMes(int dia, int mes);
        bool ValidarHoraTextBox(int horaParaChecar);
        bool ValidarMinutosTextBox(int minutosParaChecar);
     }
}
