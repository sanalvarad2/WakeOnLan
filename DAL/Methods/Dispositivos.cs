using System.Collections.Generic;
using System.Linq;
using DAL.Models;

namespace DAL.Methods
{
    public sealed class DispositivosBC
    {
        #region Mostrar
        public static Dispositivos GetByID(int id)
        {
            Dispositivos retVal = null;
            using (var context = new WakeOnLanContext()) {

                retVal = context.Dispositivos.Where(x => x.Id == id).FirstOrDefault();

            }
            return retVal;
        }

        public static List<Dispositivos> GetByNombre(string nombre)
        {
            List<Dispositivos> retVal = new List<Dispositivos>();
            using (var context = new WakeOnLanContext())
            {
                retVal = context.Dispositivos.Where(x => x.Nombre.Contains(nombre)).ToList();
            }
            return retVal;
        }
        
        public static Dispositivos GetByHostName(string HostName)
        {
            Dispositivos retVal = null;
            using (var context = new WakeOnLanContext())
            {
                retVal = context.Dispositivos.Where(x => x.Hostname.Contains(HostName)).FirstOrDefault();
            }
            return retVal;

        }
        
        public static Dispositivos GetByMacAddress(string macAddress)
        {
            Dispositivos retVal = null;

            string macClean = macAddress.Replace("-", "");

            using (var context = new WakeOnLanContext())
            {
                retVal = context.Dispositivos.Where(x => x.Macaddress.Replace("-", "").Contains(macClean)).FirstOrDefault();
            }
            return retVal;
        }

        public static List<Dispositivos> GetAll()
        {
            List<Dispositivos> retVal = new List<Dispositivos>();

            using (var context = new WakeOnLanContext())
            {
                retVal = context.Dispositivos.ToList();
            }
            return retVal;
        }
        #endregion

        #region Guardar

        public static int Guardar(Dispositivos Obj)
        {
            using (var context = new WakeOnLanContext())
            {
                if (Obj.Id == 0)
                {
                    context.Dispositivos.Add(Obj);
                }
                else
                {
                    context.Dispositivos.Update(Obj);
                }
                context.SaveChanges();
            }
            return Obj.Id;
        }

        #endregion

        #region Borrar
        public static void Borrar(int id)
        {
            using (var context = new WakeOnLanContext())
            {
                if (id != 0)
                {
                    Dispositivos Obj = GetByID(id);
                    context.Dispositivos.Remove(Obj);
                    context.SaveChanges();

                }
            }
        }
        #endregion

    }
}
