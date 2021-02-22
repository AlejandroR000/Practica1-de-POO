using System;



    public class Program
    {
      static void Main(string[] args)
      {
        int opc;
        
        Alumno a = new Alumno();

        do
        {
            Console.Write("\n\t Elije una opcion" +
                "\n >>> 1) Caputurar materia y calificaciones" +
                "\n >>> 2) Mostrar calificaciones y promedio" +
                "\n >>> 3) Mostrar calificaciones y calif mas baja" +
                "\n >>> 4) Mostrar calificaciones y calif mas alta" +
                "\n >>> 0) Salir" +
                "\n >>>  ");
            opc = Convert.ToInt32(Console.ReadLine());


            switch (opc)
            {
                case 1:

                    a.captura();
                    break;

                case 2:
                    a.imprimir();
                   
                    break;

                case 3:
                    a.imprimirbaja();
                    break;

                case 4:
                    a.imprimiralto();
                    break;

                default:
                    Console.WriteLine("Numero invalido");
                    break;

            }

        } while (opc != 0);


      }

    }

