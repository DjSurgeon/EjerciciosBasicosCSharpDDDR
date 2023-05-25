using System;

namespace DiscoDuroDeRoerBasicosCSharp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tEjercicios correspondientes al canal de Youtube DiscoDuro de Roer\n");
            Console.WriteLine("\t\tEjercicios básicos de C#\n");
            Console.WriteLine("\t\tEjercicio número 1:\n");
            Ejercicio1();
            Console.WriteLine("\n\t _____ Ejercicio 1 Completado_____\n");
            Ejercicio2();
            Console.WriteLine("\n\t _____ Ejercicio 2 Completado_____\n");
            Ejercicio3();
            Console.WriteLine("\n\t _____ Ejercicio 3 Completado_____\n");
            Ejercicio4();
            Console.WriteLine("\n\t _____ Ejercicio 4 Completado_____\n");
            Ejercicio5();
            Console.WriteLine("\n\t _____ Ejercicio 5 Completado_____\n");
            Ejercicio6();
            Console.WriteLine("\n\t _____ Ejercicio 6 Completado_____\n");
        }
        // 1. Crear 3 variables numericas con el valor que tu quieras y en otra variable númerica guardar el valor de
        // la suma de las 3 anteriores.Mostrar por consola.
        public static void Ejercicio1()
        {
            int variable1 = 45;
            int variable2 = 75;
            int variable3 = 19;
            int sumaVariables = variable1 + variable2 + variable3;

            Console.WriteLine($"La suma de {variable1}, más {variable2}, más {variable3} es igual a: {sumaVariables}.");
        }

        // 2. Pedir por consola un nombre de persona y el nombre de una ciudad (no hace falta que sean reales o comprobarlos)
        // y mostrar por pantalla, el siguiente mensaje "Hola " nombre " bienvenido a " ciudad
        public static void Ejercicio2()
        {
            String nombre;
            String ciudad;

            Console.WriteLine("¿Cómo te llamas?");
            nombre = Console.ReadLine();
            Console.WriteLine("¿Cómo se llama la ciudad?");
            ciudad = Console.ReadLine();
            Console.WriteLine($"Hola {nombre}, bienvenido a {ciudad}.");
        }
        // 3. Pedir por consola tu nombre y tu edad y mostrar el siguiente mensaje:
        // "Te llamas " nombre " y tienes " años " años"
        public static void Ejercicio3()
        {
            String nombre;
            String edad;
            Console.WriteLine("¿Cómo te llamas?");
            nombre = Console.ReadLine();
            Console.WriteLine("¿Cuantos años tienes?");
            edad = Console.ReadLine();
            Console.WriteLine($"Te llamas {nombre} y tienes {edad} años.");
        }
        //   4. Pedir dos números al usuario por teclado y decir que número es el mayor.
        public static void Ejercicio4()
        {
            int primerNumero;
            int segundoNumero;

            Console.WriteLine("Introduzca el primer número, por favor.");
            primerNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo número, por favor.");
            segundoNumero = Convert.ToInt32(Console.ReadLine());

            if (primerNumero == segundoNumero)
            {
                Console.WriteLine("Lo números introducidos son iguales.");
            }
            else if (primerNumero > segundoNumero)
            {
                Console.WriteLine($"El número {primerNumero}, es mayor que {segundoNumero}.");
            }
            else if (segundoNumero > primerNumero)
            {
                Console.WriteLine($"El número {segundoNumero}, es mayor que {primerNumero}.");
            }
        }
        //  5. Pedir el nombre de la semana al usuario y decirle si es fin de semana o no. 
        // En caso de error, indicarlo.
        public static void Ejercicio5()
        {
            String diaDeLaSemana;

            Console.WriteLine("¿Qué día de la semana es hoy?");
            diaDeLaSemana = Console.ReadLine();

            switch (diaDeLaSemana)
            {
                case "Lunes":
                    Console.WriteLine($"Hoy es {diaDeLaSemana}, no es fin de semana.");
                    break;
                case "Martes":
                    Console.WriteLine($"Hoy es {diaDeLaSemana}, no es fin de semana.");
                    break;
                case "Miercoles":
                    Console.WriteLine($"Hoy es {diaDeLaSemana}, no es fin de semana.");
                    break;
                case "Jueves":
                    Console.WriteLine($"Hoy es {diaDeLaSemana}, no es fin de semana.");
                    break;
                case "Viernes":
                    Console.WriteLine($"Hoy es {diaDeLaSemana}, casi es fin de semana.");
                    break;
                case "Sábado":
                    Console.WriteLine($"Hoy es {diaDeLaSemana}, por fin es fin de semana.");
                    break;
                case "Domingo":
                    Console.WriteLine($"Hoy es {diaDeLaSemana}, todavía es fin de semana.");
                    break;
            }
        }
        // 6. Pedir al usuario el precio de un producto(valor positivo) y la forma de pagar(efectivo o tarjeta)
        // si la forma de pago es mediante tarjeta, pedir el numero de cuenta(inventado)
        public static void Ejercicio6()
        {
            double precio;
            string formaPago;
            int numeroCuenta;

            Console.WriteLine("Introduce el precio de los zapatos.");
            precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Los zapatos cuestan {precio} Euros");
            Console.WriteLine("¿Como desea pagar? (E)fectivo o (T)arjeta.");
            formaPago = Console.ReadLine();
            if (formaPago == "E")
            {
                Console.WriteLine($"Son {precio} Euros en efectivo.");
            }
            else if (formaPago == "T")
            {
                Console.WriteLine($"Son {precio} Euros en tarjeta.");
                Console.WriteLine("Introduzca su número de cuenta(8 digitos).");
                numeroCuenta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Los {precio} Euros seran cargados en su cuenta ES 34 {numeroCuenta}.");
            }
            else
            {
                Console.WriteLine("Por favor, introduzca una forma de pago disponible.");
            }
        }
    }
}
