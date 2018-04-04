using System;
using System.Data;

namespace AlterarData
{
    class Data
    {
        #region Propriedades

        // propriedades públicas
        public string dia { get; set; }
        public string mes { get; set; }
        public string ano { get; set; }
        public string hora { get; set; }
        public string minutos { get; set; }
        public string minutosAlteracao { get; set; }
        public string dataAlterada { get; set; }
        public string operacao { get; set; }

        // propriedades estáticas da classe para converter a data e hora em minutos
        static int minutosAno { get; set; }
        static int minutosDia { get; set; }
        static int minutosHora { get; set; }
        static int totalMinutosDataHora { get; set; }

        // propriedades estáticas da classe para converter os minutos de volta no formato data e hora
        static int acharAnoQuotient { get; set; }
        static int acharAnoRemainder { get; set; }
        static int acharDiaQuotient { get; set; }
        static int acharDiaRemainder { get; set; }
        static int acharHoraQuotient { get; set; }
        static int acharHoraRemainder { get; set; }
        static int acharDiadoMes { get; set; }
        static int acharMes { get; set; }

        // Constantes da classe que representa 1 ano, 1 dia e 1 hora em minutos
        const int anoMinutos = 525600;
        const int diaMinutos = 1440;
        const int horaMinutos = 60;

        #endregion

        #region Métodos Públicos que retornar um valor

        // Metodo público principal requerido no teste
        public string ChangeDate(string date, char op, long value)
        {

            // Dividir a data com hora cada um na sua propriedade
            dia = date.Split(new char[] { '/', ' ', ':' }, 5)[0];
            mes = date.Split(new char[] { '/', ' ', ':' }, 5)[1];
            ano = date.Split(new char[] { '/', ' ', ':' }, 5)[2];
            hora = date.Split(new char[] { '/', ' ', ':' }, 5)[3];
            minutos = date.Split(new char[] { '/', ' ', ':' }, 5)[4];

            operacao = op.ToString();
            minutosAlteracao = value.ToString();

            TotalMinutosConvertidopelaDataHora();

            // Voltar com o formato data e hora
            dataAlterada = String.Format
                ("{0}/{1}/{2} {3}:{4}", 
                acharDiadoMes.ToString().PadLeft(2,'0'), 
                acharMes.ToString().PadLeft(2, '0'), 
                acharAnoQuotient.ToString().PadLeft(4, '0'), 
                acharHoraQuotient.ToString().PadLeft(2, '0'), 
                acharHoraRemainder.ToString().PadLeft(2, '0'));
            return dataAlterada;
        }

        // Método público para validar o dia no txtDia sendo até 31 dias ( obs: o lengh já explicito na própria propriedade do txt sendo 2 )
        public bool ValidarDiaTextBox(int diaParaChecar)
        {
            return (diaParaChecar >= 1 && diaParaChecar <= 31);
        }

        // Método público para validar o mês no txtMes sendo até  12 meses ( obs: o lengh já explicito na própria propriedade do txt sendo 2 )
        public bool ValidarMesTextBox(int mesParaChecar)
        {
            return (mesParaChecar >= 1 && mesParaChecar <= 12);
        }

        // Método público para validar a quantidade de dias no txtDia permitido baseado no txtMes se dever ser no máximo 28, 30 ou 31 dias
        public bool ValidarDiaMes(int dia, int mes)
        {
            int diaMes;
            switch (mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    diaMes = 31;
                    break;
                case 2:
                    diaMes = 28;
                    break;
                default:
                    diaMes = 30;
                    break;
            }
            return (dia <= diaMes);
        }

        // Método público para validar se a hora de ter até o número 23 (obs: o lengh já explicito na própria propriedade do txt sendo 2 )
        public bool ValidarHoraTextBox(int horaParaChecar)
        {
            return (horaParaChecar >= 0 && horaParaChecar <= 23);
        }

        //Método público para validar se os minutos deve ter até o número 59 ( obs: o lengh já explicito na própria propriedade do txt sendo 2 )
        public bool ValidarMinutosTextBox(int minutosParaChecar)
        {
            return (minutosParaChecar >= 0 && minutosParaChecar <= 59);
        }
        
        #endregion

        #region Métodos Privados de Conversão DataHora para Minutos 
        
        // Método privado para achar o total de minutos da data fornecida dos 3 métodos privados de conversão da classe Data. 
        private void TotalMinutosConvertidopelaDataHora()
        {
            ConverterAnoemMinutos();
            ConverterDiaemMinutos();
            ConverterDataHoraemMinutos();
            totalMinutosDataHora = minutosAno + minutosDia + minutosHora;

            ConverterMinutosemAno();
        }
        // Método privado para achar Ano em minutos da data e hora fornecida
        private void ConverterAnoemMinutos()
        {
            minutosAno = Convert.ToInt32(ano) * anoMinutos;
        }

        // Método privado para achar a quantidade de dia em minutos da data e hora fornecida
        private void ConverterDiaemMinutos()
        {

            int diaMes;

            // 1. achar a quantidade de dias anterior ao mês vigente da data fornecida
            switch (mes)
            {
                case "01":
                    diaMes = 0;
                    break;
                case "02":
                    diaMes = 31;
                    break;
                case "03":
                    diaMes = 59;
                    break;
                case "04":
                    diaMes = 90;
                    break;
                case "05":
                    diaMes = 120;
                    break;
                case "06":
                    diaMes = 151;
                    break;
                case "07":
                    diaMes = 181;
                    break;
                case "08":
                    diaMes = 212;
                    break;
                case "09":
                    diaMes = 243;
                    break;
                case "10":
                    diaMes = 273;
                    break;
                case "11":
                    diaMes = 304;
                    break;
                case "12":
                    diaMes = 334;
                    break;
                default:
                    diaMes = 0;
                    break;
            }

            // 2. Calcular os dias do mês anterior + o dia da data fornecida e multiplicar pelos minutos por dia; 
            minutosDia = diaMes * diaMinutos;

        }

        // Método privado para achar a quantidade de hora em minutos da data e hora fornecida
        private void ConverterDataHoraemMinutos()
        {
            if (operacao == "+")
            {
                minutosHora = (Convert.ToInt32(hora) * horaMinutos) + Convert.ToInt32(minutos) + Convert.ToInt32(minutosAlteracao);
            }
            else
            {
                minutosHora = (Convert.ToInt32(hora) * horaMinutos) + Convert.ToInt32(minutos) - +Convert.ToInt32(minutosAlteracao);
            }
        }

        #endregion

        #region Métodos Privados de Conversão de Minutos em DataHora

        private void ConverterMinutosemAno()
        {
            acharAnoQuotient = totalMinutosDataHora / anoMinutos;
            acharAnoRemainder = totalMinutosDataHora % anoMinutos;
            ConverterMinutosemDia();
        }
        private void ConverterMinutosemDia()
        {
            acharDiaQuotient = acharAnoRemainder / diaMinutos;
            acharDiaRemainder = acharAnoRemainder % diaMinutos;

            if (acharDiaQuotient < 31) { acharMes = 1; }
            if (acharDiaQuotient >= 31 && acharDiaQuotient < 59) { acharMes = 2; acharDiadoMes = acharDiaQuotient - 31 + 1; }
            if (acharDiaQuotient >= 59 && acharDiaQuotient < 90) { acharMes = 3; acharDiadoMes = acharDiaQuotient - 59 + 1; }
            if (acharDiaQuotient >= 90 && acharDiaQuotient < 120) { acharMes = 4; acharDiadoMes = acharDiaQuotient - 90 + 1; }
            if (acharDiaQuotient >= 120 && acharDiaQuotient < 151) { acharMes = 5; acharDiadoMes = acharDiaQuotient - 120 + 1; }
            if (acharDiaQuotient >= 151 && acharDiaQuotient < 181) { acharMes = 6; acharDiadoMes = acharDiaQuotient - 151 + 1; }
            if (acharDiaQuotient >= 181 && acharDiaQuotient < 212) { acharMes = 7; acharDiadoMes = acharDiaQuotient - 181 + 1; }
            if (acharDiaQuotient >= 212 && acharDiaQuotient < 243) { acharMes = 8; acharDiadoMes = acharDiaQuotient - 212 + 1; }
            if (acharDiaQuotient >= 243 && acharDiaQuotient < 273) { acharMes = 9; acharDiadoMes = acharDiaQuotient - 243 + 1; }
            if (acharDiaQuotient >= 273 && acharDiaQuotient < 304) { acharMes = 10; acharDiadoMes = acharDiaQuotient - 273 + 1; }
            if (acharDiaQuotient >= 304 && acharDiaQuotient < 334) { acharMes = 11; acharDiadoMes = acharDiaQuotient - 304 + 1; }
            if (acharDiaQuotient >= 334 && acharDiaQuotient <= 365) { acharMes = 12; acharDiadoMes = acharDiaQuotient - 334 + 1; }
            ConverterMinutosemHora();
        }
        private void ConverterMinutosemHora()
        {
            acharHoraQuotient = acharDiaRemainder / horaMinutos;
            acharHoraRemainder = acharDiaRemainder % horaMinutos;
        }
        #endregion
    }
}

