using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        DateTime date = Convert.ToDateTime(appointmentDateDescription);
        return date;
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
       return (appointmentDate < DateTime.Now);
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        return (appointmentDate.Hour >= 12 && appointmentDate.Hour < 18);
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate.ToString()}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(2021, 9, 15, 0, 0, 0);
    }
}
