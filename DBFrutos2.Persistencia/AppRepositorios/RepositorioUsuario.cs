using System.Collections.Generic;
using System.Linq;
using DBFrutos2.Dominio;
using Microsoft.EntityFrameworkCore;

namespace DBFrutos2.Persistencia
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
          
        private readonly AppContext _appContext = new AppContext();

        Usuario IRepositorioUsuario.AddUsuario(Usuario usuario)
        {
            var usuarioAdicionado = _appContext.Usuario.Add(usuario);
            _appContext.SaveChanges();
            return usuarioAdicionado.Entity;
        }

        void IRepositorioUsuario.DeleteUsuario(int idUsuario)
        {
            var usuarioEncontrado = _appContext.Usuario.Find(idUsuario);
            if (usuarioEncontrado == null)
                return;
            _appContext.Usuario.Remove(usuarioEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Usuario> IRepositorioUsuario.GetAllUsuario()
        {
            return _appContext.Usuario;
        }

        Paciente IRepositorioUsuario.GetUsuario(int idPaciente)
        {
            return _appContext.Pacientes.Find(idPaciente);
            /*
            var pac = _appContext.Pacientes
                       .Where(p => p.Id == idPaciente)
                       .Include(p => p.Medico)
                       .FirstOrDefault();
            return pac;
            */
        }

        Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.Find(paciente.Id);
            if (pacienteEncontrado != null)
            {
                pacienteEncontrado.Nombre = paciente.Nombre;
                pacienteEncontrado.Apellidos = paciente.Apellidos;
                pacienteEncontrado.NumeroTelefono = paciente.NumeroTelefono;
                pacienteEncontrado.Genero = paciente.Genero;
                pacienteEncontrado.Direccion = paciente.Direccion;
                pacienteEncontrado.Ciudad = paciente.Ciudad;
                pacienteEncontrado.FechaNacimiento = paciente.FechaNacimiento;
                _appContext.SaveChanges();
            }
            return pacienteEncontrado;
        }
        Medico IRepositorioPaciente.AsignarMedico(int idPaciente, int idMedico)
        {
            var pacienteEncontrado = _appContext.Pacientes.Find(idPaciente);
            if (pacienteEncontrado != null)
            {
                var medicoEncontrado = _appContext.Medicos.Find(idMedico);
                if (medicoEncontrado != null)
                {
                    pacienteEncontrado.Medico = medicoEncontrado;
                    _appContext.SaveChanges();
                }
                return medicoEncontrado;
            }
            return null;
        }
        SignoVital IRepositorioPaciente.AsignarSignoVital(int idPaciente, int idSignoVital)
        {
            var pacienteEncontrado = _appContext.Pacientes
            .Where(p => p.Id == idPaciente)
            .Include(p => p.SignosVitales)
            .SingleOrDefault();
            if (pacienteEncontrado != null)
            {
                var signoVitalEncontrado = _appContext.SignosVitales.Find(idSignoVital);
                if (signoVitalEncontrado != null)
                {
                    pacienteEncontrado.SignosVitales.Add(signoVitalEncontrado);
                    _appContext.SaveChanges();
                }
                return signoVitalEncontrado;
            }
            return null;
        }
    }
    }
