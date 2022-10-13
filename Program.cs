using System.Dynamic;
using System.ComponentModel;
using System;

namespace tp_n_7_programacion_Lisandro_Schneider
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadDeAlumnos,curso,i;
            float promedioAlumno,notaAlumno,totalNotas=0;
            string turnoDelCurso;

            Console.WriteLine("Digite el año del curso:");
            curso = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el turno del curso");
            turnoDelCurso = Console.ReadLine();

            Console.WriteLine("Digite la cantidad de alumnos del curso:");
            cantidadDeAlumnos = Convert.ToInt32(Console.ReadLine());

            
            for( i=0;i<cantidadDeAlumnos; i++)
            {
                Console.WriteLine("Digite la nota del alunmo n°{0}",i+1);
                notaAlumno = Convert.ToInt32(Console.ReadLine());
                totalNotas = totalNotas + notaAlumno;
            }

                promedioAlumno = totalNotas/cantidadDeAlumnos;

            Console.Clear();
            
            Console.WriteLine("{0}° año Turno: {1} Promedio: {2} ",curso,turnoDelCurso,promedioAlumno);
           



            
        }
    }
}
