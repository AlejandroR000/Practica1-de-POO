using System;



  public class Alumno : Calificaciones
  {

    public Calificaciones[] lista;
    public int bajo { get; set; }
    public int alto { get; set; }
    public float promedio  { get; set; }
    public int suma { get; set; }
   

    public void captura()
    {
        lista = new Calificaciones[5];
        suma = 0;
        for (int i = 0; i < 5; i++)
        {
            lista[i] = new Calificaciones();
        }


        for (int i = 0; i < 5; i++)
        {

            lista[i] = new Calificaciones();
            

                Console.Write("\n Nombre de la materia: ");
                lista[i].materia = Convert.ToString(Console.ReadLine());
                Console.Write("\n Calificacion : ");
                lista[i].calificacion = Convert.ToInt32(Console.ReadLine());

            if (i == 0)
                bajo = lista[i].calificacion;
            else if (bajo > lista[i].calificacion)
                bajo = lista[i].calificacion;

            if (i == 0)
                alto = lista[i].calificacion;
            else if (alto < lista[i].calificacion)
                alto = lista[i].calificacion;

            
           suma += lista[i].calificacion;

        }


    }

        public void imprimir()
        {
        promedio = suma / 5;
        for (int i = 0; i < 5; i++)
           {
            Console.WriteLine(" \n >>> Materia: {0} \n >>> Calificacion: {1}", lista[i].materia, lista[i].calificacion);
           

           }
        Console.WriteLine("\n >>> El promedio es: {0}", promedio);
        }

    public void imprimirbaja()
    {
       
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(" \n >>> Materia: {0} \n >>> Calificacion: {1}", lista[i].materia, lista[i].calificacion);

        }

        Console.WriteLine("\n >>> La calificacion mas baja fue: {0}", bajo);
    }

    public void imprimiralto()
    {

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(" \n >>> Materia: {0} \n >>> Calificacion: {1}", lista[i].materia, lista[i].calificacion);
        }

        Console.WriteLine("\n >>> La calificacion mas alta fue: {0}", alto);
    }


}

