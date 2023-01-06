using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstudiantes
{
	class Estudiante : Persona
	{
		public string Cedula;
		public List<Asignatura> Asignaturas { get; set; }
		public List<Calificacion> Calificaciones { get; set; }
		public int IdCarrera { get; set; }

	}
}
