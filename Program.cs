namespace EstructurasDeControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int a = 10;
             int b = 20;
             if (a > b)
             {
                 Console.WriteLine("a es mayor que b");

             }
             else if (b > a)
             {

                 Console.WriteLine("b es mayor que a");
             }
             else {
                 Console.WriteLine("Son iguales");
             }



             int edad = 25;
             bool tienesLicencia = false;

             if (edad >= 18 && tienesLicencia)
             {
                 Console.WriteLine("Puedes conducir!");
             }
             else {
                 Console.WriteLine("No puedes conducir!");
             }



             bool esEstudiante = true;
             bool esEmpleado = true;

             if (esEstudiante || esEmpleado)
             {
                 Console.WriteLine("Puedes acceder al descuento!");
             }
             else {
                 Console.WriteLine("No puedes acceder al descuento!");
             }


             int temperatura = 30;
             bool esSoleado = true;

             if ((esSoleado && temperatura > 25) || temperatura > 35){
                 Console.WriteLine("Es un día para ir a la playa!");
             }
             else{
                 Console.WriteLine("No es un día para ir a la playa!");

             }


            int edad = 17;
            bool estaInscrito = true;

            if (edad >= 18)
            {
                if (estaInscrito)
                {
                    Console.WriteLine("Si puedes acceder!");

                }
                else {
                    Console.WriteLine("No puedes acceder porque no estás inscrito!");
                }

            }
            else {

                Console.WriteLine("No puedes acceder al beneficio porque no tienes la edad requerida!");
            }

            Console.WriteLine("Escribe un número de día:");
            int dia = int.Parse(Console.ReadLine());

            switch (dia) {
                case 1: 
                    Console.WriteLine("Es lunes!");
                    break;
                case 2: 
                    Console.WriteLine("Es martes!");
                    break;
                case 3: 
                    Console.WriteLine("Es miércoles!");
                    break;
                case 4: 
                    Console.WriteLine("Es jueves!");
                    break;
                case 5: 
                    Console.WriteLine("Es viernes!");
                    break;
                case 6: 
                case 7: 
                    Console.WriteLine("Es fin de semana!");
                    break;
                default:
                    Console.WriteLine("Día no válido!");
                    break;
            }


            for (int i = 0; i < 5; i++) {
                Console.WriteLine($"Iteración número: {i}");
            }

            int[] numeros = { 10, 20, 30, 40, 50};

            for (int i = 0; i < numeros.Length; i++) {
                Console.WriteLine($"Elemento en posición: {i}: {numeros[i]}");
            }*/
            // int contador = 1;
            /*
            while (contador <=5) {
           
                contador++;
            
                if (contador == 3) {
                    continue;
                }
            
            Console.WriteLine($"Iteración número: {contador}");    
            }

            do {

                Console.WriteLine($"Iteración número: {contador}");
                contador++;

            } while (contador<=5);

            int[] numeros = { 1, 2, 3, 4, 5 };

            foreach (int numero in numeros) {
                Console.WriteLine($"Número: {numero}");

            }


            List<string> list = new List<string> {"Ana", "Juan", "Pedro" };

            foreach (string nombre in list)
            {
                Console.WriteLine($"Persona: {nombre}");

            }

            Dictionary<string, int> edades = new Dictionary<string, int> {
                {"Ana",30 },
                {"Juan",25 },
                {"Pedro",40 }
            };

            foreach (KeyValuePair<string, int> persona in edades) {
                Console.WriteLine($"{persona.Key} tiene {persona.Value}");
            }*/
            try
            {
                int divisor = 0;
                int resultado = 10 / divisor;

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally {
                Console.WriteLine("Este código se ejecuta siempre!");
            }


        }
    }
}
