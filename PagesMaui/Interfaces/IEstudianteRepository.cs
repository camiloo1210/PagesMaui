using PagesMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagesMaui.Interfaces
{
    public interface IEstudianteRepository
    {
        List<IEstudianteRepository> DevuelveListadoEstudiante();
        Estudiante GetEstudiante(int id);
        Boolean CrearEstudiante(Estudiante estudiante);
        Boolean ActualizarEstudiante(Estudiante estudiante);
        Boolean EliminarEstudiante(int id);
    }
}
