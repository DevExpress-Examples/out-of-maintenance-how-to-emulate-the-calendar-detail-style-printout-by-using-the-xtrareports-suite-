using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraScheduler;

namespace Sample {
    class AppointmentsDataHelper {
        public static AppointmentBaseCollection GenerateAppointmentsPerDay(AppointmentBaseCollection sourceCollection) {
            AppointmentBaseCollection aptsPerDaysCollection = new AppointmentBaseCollection();

            foreach (Appointment item in sourceCollection) {
                if (item.SameDay)
                    aptsPerDaysCollection.Add(item);
                else
                    aptsPerDaysCollection.AddRange(DivideApointments(item));
            }

            return aptsPerDaysCollection;
        }

        static AppointmentBaseCollection DivideApointments(Appointment sourceApt) {
            DayIntervalCollection daysCollection = new DayIntervalCollection();
            daysCollection.Add(new TimeInterval(sourceApt.Start, sourceApt.End));

            AppointmentBaseCollection dividedApts = new AppointmentBaseCollection();
            foreach (TimeInterval day in daysCollection) {
                Appointment dailyApt = sourceApt.Copy();

                dailyApt.Start = day.Start.Date;
                dailyApt.End = day.End.Date;
                dailyApt.AllDay = true;

                dividedApts.Add(dailyApt);
            }

            AdjustStart(dividedApts, sourceApt);
            AdjustEnd(dividedApts, sourceApt);

            return dividedApts;
        }

        static void AdjustStart(AppointmentBaseCollection dividedApts, Appointment sourceApt) {
            Appointment dividedApt = dividedApts[0];
            dividedApt.AllDay = false;
            dividedApt.Start = dividedApt.Start.Add(sourceApt.Start.TimeOfDay);
            dividedApt.End = dividedApt.Start.Date.AddDays(1);
            dividedApt.AllDay = dividedApt.Start.TimeOfDay == TimeSpan.Zero;
        }

        static void AdjustEnd(AppointmentBaseCollection dividedApts, Appointment sourceApt) {
            Appointment dividedApt = dividedApts[dividedApts.Count - 1];
            dividedApt.AllDay = false;
            dividedApt.End = dividedApt.End.Add(sourceApt.End.TimeOfDay);
            dividedApt.AllDay = dividedApt.End.TimeOfDay == TimeSpan.Zero;
        }
    }
}