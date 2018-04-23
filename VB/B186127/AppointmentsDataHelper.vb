Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraScheduler

Namespace Sample
    Friend Class AppointmentsDataHelper
        Public Shared Function GenerateAppointmentsPerDay(ByVal sourceCollection As AppointmentBaseCollection) As AppointmentBaseCollection
            Dim aptsPerDaysCollection As New AppointmentBaseCollection()

            For Each item As Appointment In sourceCollection
                If item.SameDay Then
                    aptsPerDaysCollection.Add(item)
                Else
                    aptsPerDaysCollection.AddRange(DivideApointments(item))
                End If
            Next item

            Return aptsPerDaysCollection
        End Function

        Private Shared Function DivideApointments(ByVal sourceApt As Appointment) As AppointmentBaseCollection
            Dim daysCollection As New DayIntervalCollection()
            daysCollection.Add(New TimeInterval(sourceApt.Start, sourceApt.End))

            Dim dividedApts As New AppointmentBaseCollection()
            For Each day As TimeInterval In daysCollection
                Dim dailyApt As Appointment = sourceApt.Copy()

                dailyApt.Start = day.Start.Date
                dailyApt.End = day.End.Date
                dailyApt.AllDay = True

                dividedApts.Add(dailyApt)
            Next day

            AdjustStart(dividedApts, sourceApt)
            AdjustEnd(dividedApts, sourceApt)

            Return dividedApts
        End Function

        Private Shared Sub AdjustStart(ByVal dividedApts As AppointmentBaseCollection, ByVal sourceApt As Appointment)
            Dim dividedApt As Appointment = dividedApts(0)
            dividedApt.AllDay = False
            dividedApt.Start = dividedApt.Start.Add(sourceApt.Start.TimeOfDay)
            dividedApt.End = dividedApt.Start.Date.AddDays(1)
            dividedApt.AllDay = dividedApt.Start.TimeOfDay = TimeSpan.Zero
        End Sub

        Private Shared Sub AdjustEnd(ByVal dividedApts As AppointmentBaseCollection, ByVal sourceApt As Appointment)
            Dim dividedApt As Appointment = dividedApts(dividedApts.Count - 1)
            dividedApt.AllDay = False
            dividedApt.End = dividedApt.End.Add(sourceApt.End.TimeOfDay)
            dividedApt.AllDay = dividedApt.End.TimeOfDay = TimeSpan.Zero
        End Sub
    End Class
End Namespace