using Newtonsoft.Json;
using PagesMaui.Interfaces;
using PagesMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace PagesMaui.Repositories
{
    public class EstudianteRepository : IEstudianteRepository
    {
        public HttpClient _httpClient;
        public string endpoint = "https://freetestapi.com/api/v1/students/1"; 
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
            using (_httpClient)
            {
                var response = _httpClient.GetAsync(endpoint).Result;
                string json_data=response.Content.ReadAsStringAsync().Result;  
                 List<Estudiante> estudianteAPI= new List<Estudiante>;
                 estudianteAPI = JsonConverter.DeserializeObject<List<Estudiante>>(json_data);
                estu
            }

        }

        public bool EliminarEstudiante(int id)
        {
            throw new NotImplementedException();
        }

        public Estudiante GetEstudiante(int id)
        {
            return new Estudiante
            {
                id = id,
                name = "Camily",
                age = 9,
            };
        }
    }
}
