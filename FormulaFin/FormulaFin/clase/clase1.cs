using System.Security.Cryptography.X509Certificates;

namespace FormulaProy
{
    public class FormulaF()
    {
        public void FormulaFin()
        {

            Console.WriteLine("Bienvenido a la calculadora financiera.");
            Console.WriteLine("Desea invetir utilizando interes simple o compuesto? \n1. Interes Simple.  \n2. Interes Compuesto");

            int respuesta = int.Parse(Console.ReadLine());

            switch (respuesta)
            {
                case 1:
                    InteresSimple();
                break;

                case 2:
                    InteresCompuestoSelec();
                break;

            }

        }

        public void InteresCompuestoSelec()
        {
            Console.WriteLine("Desea invertir una vez al año o desea invertir varias veces al año? \n1. Una vez al año. (Formula Normal) \n2. Varias veces al año. (Formula Compleja)");
            int respuesta2 = int.Parse(Console.ReadLine());

            switch (respuesta2)
            {
                case 1:
                    InteresCompuestoAnual();
                break;

                case 2:

                    InteresCompuestoVar();

                break;


            }
        }
        #region Metodo Interes Simple
        public void InteresSimple()
        {
            double CapitalFinal = 0;
            double CapitalInicial = 0;
            double TasaInteres = 0;
            double NPeriodoAhorro = 0;

            Console.WriteLine("Ingrese su capital inicial.");
            CapitalInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su % de tasa de interes.");
            TasaInteres = double.Parse(Console.ReadLine());

            if (TasaInteres >= 36)
            {
                Console.WriteLine("Tasa de interes demasiado elevada.");
                return;
            }

            TasaInteres = TasaInteres / 100;

            Console.WriteLine("Ingrese su tiempo de ahorro.");
            NPeriodoAhorro = double.Parse(Console.ReadLine());

            CapitalFinal = CapitalInicial * TasaInteres * NPeriodoAhorro;

            CapitalFinal = (Math.Round(CapitalFinal, 2));

            Console.WriteLine($"Su capital final es igual a {CapitalFinal}");
            return;
        }
        #endregion

        #region Metodo Interes Compuesto (Normal)
        public void InteresCompuestoAnual()
        {
            double CapitalFinal = 0;
            double CapitalInicial = 0;
            double TasaInteres = 0;
            double NPeriodoAhorro = 0;

            Console.WriteLine("Ingrese su capital inicial.");
            CapitalInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su % de tasa de interes.");
            TasaInteres = double.Parse(Console.ReadLine());

            if (TasaInteres >= 36)
            {
                Console.WriteLine("Tasa de interes demasiado elevada.");
                return;
            }

            TasaInteres = TasaInteres / 100;

            Console.WriteLine("Ingrese su tiempo de ahorro.");
            NPeriodoAhorro = double.Parse(Console.ReadLine());



            TasaInteres = (1 + TasaInteres);
            TasaInteres = Math.Pow(TasaInteres, NPeriodoAhorro);

            CapitalFinal = (CapitalInicial * TasaInteres);

            Console.WriteLine($"Su capital final es igual a {CapitalFinal}");
            return;
        }
        #endregion

        #region Metodo Interes Compuesto (Complejo)
        public void InteresCompuestoVar()
        {
            double CapitalFinal = 0;
            double CapitalInicial = 0;
            double TasaInteres = 0;
            double NPeriodoAhorro = 0;
            int Capitalizacion = 0;


            Console.WriteLine("Que cada tanto desea capitalizar?");
            Console.WriteLine("1. Mensualmente \n2. Bimestralmente \n3. Trimestralmente \n4. Cuatrimestralmente \n5. Semestralmente \n6. Anualmente \n7. Semanalmente \n8. Quincenalmente ");

            int eleccion = int.Parse(Console.ReadLine());

            switch (eleccion)
            {
                case 1:
                    Capitalizacion = 12;
                break;

                case 2:
                    Capitalizacion = 6;
                break;

                case 3:
                    Capitalizacion = 4;
                break;

                case 4:
                    Capitalizacion = 3;
                break;

                case 5:
                    Capitalizacion = 2;
                break;

                case 6:
                    InteresCompuestoAnual();
                break;

                case 7:
                    Capitalizacion = 52;
                break;

                case 8:
                    Capitalizacion = 24;
                break;
            }


            Console.WriteLine("Ingrese su capital inicial.");
            CapitalInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su % de tasa de interes.");
            TasaInteres = double.Parse(Console.ReadLine());

            if (TasaInteres >= 36)
            {
                Console.WriteLine("Tasa de interes demasiado elevada.");
                return;
            }

            TasaInteres = TasaInteres / 100;

            Console.WriteLine("Ingrese su tiempo de ahorro.");
            NPeriodoAhorro = double.Parse(Console.ReadLine());



            TasaInteres = (1 + TasaInteres/Capitalizacion);
            TasaInteres = Math.Pow(TasaInteres, (NPeriodoAhorro * Capitalizacion));

            CapitalFinal = (CapitalInicial * TasaInteres);

            CapitalFinal = (Math.Round(CapitalFinal, 2)); 

            Console.WriteLine($"Su capital final es igual a {CapitalFinal}");
            return;
        }
        #endregion
    }
}
