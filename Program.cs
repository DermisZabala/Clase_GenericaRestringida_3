using System;

namespace Genericos_Restringidos_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AlmacenEmpleado<Jefe> AlmacenJefes = new AlmacenEmpleado<Jefe>(4);
            AlmacenEmpleado<Programador> AlmacenProgramador = new AlmacenEmpleado<Programador>(3);
            AlmacenEmpleado<Analista> AlmacenAnalistas = new AlmacenEmpleado<Analista>(6);

            /*
             AlmacenEmpleado <Jubilado> AlmacenJubilado = new AlmacenEmpleado <Jubilado> (3);

             este codigo da error gracias a la restriccion de la clase generica ya que 
             solo permite clases que implementen la interface IParaEmpleado
            */

            Jefe jefe_1 = new(2200);
            Jefe jefe_2 = new(2400);
            Jefe jefe_3 = new(4000);
            Jefe jefe_4 = new(5300);

            AlmacenJefes.Agregar(jefe_1);
            AlmacenJefes.Agregar(jefe_2);
            AlmacenJefes.Agregar(jefe_3);
            AlmacenJefes.Agregar(jefe_4);


            int z = 1;

            for (int i = 0; i < 4; i++)
            {

                Jefe salarioJefes = AlmacenJefes.GetObjeto(i);

                Console.WriteLine($"Sueldo del jefe {z} : {salarioJefes.GetSalario()}");

                z++;
            }

            //Programador

            Programador programador_1 = new(1500);
            Programador programador_2 = new(1200);
            Programador programador_3 = new(1800);

            AlmacenProgramador.Agregar(programador_1);
            AlmacenProgramador.Agregar(programador_2);
            AlmacenProgramador.Agregar(programador_3);

            z = 1;
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Programador SalarioProgramador = AlmacenProgramador.GetObjeto(i);

                Console.WriteLine($"Sueldo del programador {z} : {SalarioProgramador.GetSalario()}");

                z++;
            }


            //Analista
            Analista analista_1 = new(2100);
            Analista analista_2 = new(2400);
            Analista analista_3 = new(3500);
            Analista analista_4 = new(1500);
            Analista analista_5 = new(2300);
            Analista analista_6 = new(2400);

            AlmacenAnalistas.Agregar(analista_1);
            AlmacenAnalistas.Agregar(analista_2);
            AlmacenAnalistas.Agregar(analista_3);
            AlmacenAnalistas.Agregar(analista_4);
            AlmacenAnalistas.Agregar(analista_5);
            AlmacenAnalistas.Agregar(analista_6);

            Console.WriteLine();
            z = 1;
            for (int i = 0; i < 6; i++)
            {
                Analista salarioAnalistas = AlmacenAnalistas.GetObjeto(i);

                Console.WriteLine($"Salario del analista {z} : {salarioAnalistas.GetSalario()}");

                z++;
            }

            Console.ReadKey();
        }
    }

    interface IParaEmpleado
    {
        public double GetSalario();
    }

    //Clase Generica para que solo almacena objetos de clase que implentan la interface IParaEmpleado
    class AlmacenEmpleado <T> where T : IParaEmpleado
    {
        private int i = 0;

        private T[] DatosEmpleado;
        
        public AlmacenEmpleado(int z)
        {
            DatosEmpleado = new T[z];
        }

        public void Agregar(T objeto)
        {
            DatosEmpleado[i] = objeto;
            i++;
        }

        public T GetObjeto(int i)
        {
            return DatosEmpleado[i];
        }

    }

    class Jefe : IParaEmpleado
    {
        private double salario;

        public Jefe(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }

    class Programador : IParaEmpleado
    {
        private double salario;

        public Programador(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }

    class Analista : IParaEmpleado
    {
        private double salario;

        public Analista(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }

    class Jubilado
    {
        private double pension;

        public Jubilado(double pension)
        {
            this.pension = pension;
        }

        public double GetPesion()
        {
            return pension;
        }
    }

}                                