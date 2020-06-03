using System;

namespace maistarde
{
    class Program
    {
        static void Main(string[] args)
        //Exiba a hora atual acrescida de 6 horas e 30 minutos.Agora 15:51, mais tarde 22:21.


       {
            DateTime horasistema = DateTime.Now;
            DateTime horasfutura = horasistema.AddHours(6);
            DateTime minutosfuturo= horasfutura.AddMinutes(30);
            Console.WriteLine ($"hora sistema: {horasistema} e daqui 6 horas e 30 minutos será: {minutosfuturo}");
            


    }
    }
}
