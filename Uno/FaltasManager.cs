using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Uno
{
    public static class FaltasManager
    {
        private static System.Timers.Timer timer;
        private static DateTime ultimaEjecución = DateTime.MinValue;

        public static void Iniciar()
        {
            if (timer != null) { return; }
            timer = new System.Timers.Timer(6000);
            timer.Elapsed += EjecutarFaltas;
            timer.AutoReset = true;
            timer.Start();
        }

        private static void EjecutarFaltas(object sender, ElapsedEventArgs e)
        {
            //Hora de corte 11:59pm
            TimeSpan horadecorte = new TimeSpan(23, 59, 0);
            DateTime ahora = DateTime.Now;

            //No se ejecute el resto de la función si no es la hora, o ya se ejecutó la función ese día
            if (horadecorte.Hours != ahora.Hour || horadecorte.Minutes != ahora.Minute || ultimaEjecución.Date == ahora.Date) { return; }
            ultimaEjecución = ahora;

            //Se ejecuta la función
            using (var context = new DB1Entities())
            {
                DateTime inicioDia = ahora.Date;
                DateTime finDia = inicioDia.AddDays(1);

                int diaSemanaActual = (int)DateTime.Today.DayOfWeek == 0 ? 7 : (int)DateTime.Today.DayOfWeek;

                var usuarios = context.Users.Where(u => u.UserWorkDays.Any(wd => wd.DiaSemana == diaSemanaActual) && !u.Entradas.Any(ent => ent.Fecha >= inicioDia && ent.Fecha < finDia)).ToList();

                foreach (var usuario in usuarios)
                {
                    context.Faltas.Add(new Faltas
                    {
                        UserId = usuario.Id,
                        Fecha = inicioDia
                    });
                }

                context.SaveChanges();
            }
        }
    }
}
