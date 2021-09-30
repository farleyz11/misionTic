using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        List<Rutas> rutas;
 
    public RepositorioRutas()
        {
            rutas= new List<Rutas>()
            {
                new Rutas{id=1,origen=0000,destino= 0000,tiempo_estimado= 0000},
                new Rutas{id=2,origen=0000,destino= 0000,tiempo_estimado= 0000},
                new Rutas{id=3,origen=0000,destino= 0000,tiempo_estimado= 0000}
 
            };
        }
 
        public IEnumerable<Rutas> GetAll()
        {
            return rutas;
        }
 
        public Rutas GetRutaWithId(int id){
            return rutas.SingleOrDefault(b => b.id == id);
        }

        public Rutas Create(Rutas newRuta)
        {
           newRuta.id=rutas.Max(r => r.id) +1; 
           rutas.Add(newRuta);
           return newRuta;
        }


        public Rutas Update(Rutas newRuta){
            var ruta= rutas.SingleOrDefault(b => b.id == newRuta.id);
            if(ruta != null){
                ruta.origen = newRuta.origen;
                ruta.destino = newRuta.destino;
                ruta.tiempo_estimado = newRuta.tiempo_estimado;
            }
        return ruta;
        }

    }
}
