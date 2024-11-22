using PagesMaui.Interfaces;
using PagesMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagesMaui.Repositories
{
    public class EstudianteRepository : IEstudianteRepository
    {
        public bool ActualizarEstudiante(Estudiante estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudiante(Estudiante estudiante)
        {
            throw new NotImplementedException();
        }

        public List<Estudiante> DevuelveListadoEstudiante()
        {
           List<Estudiante> estudiantes= new List<Estudiante>();
            estudiantes.Add(GetEstudiante(1));
            estudiantes.Add(GetEstudiante(2));
            estudiantes.Add(GetEstudiante(3));
            return estudiantes;
           
        }

        public bool EliminarEstudiante(int id)
        {
            throw new NotImplementedException();
        }

        public Estudiante GetEstudiante(int id)
        {
            return new Estudiante
            {
                Id = id,
                Name = "Camily",
                Degree = "Ing Software"
            };
        }
    }
}
