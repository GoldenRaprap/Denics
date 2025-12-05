using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denics
{
    internal static class AppointmentCart
    {
        private static string ServiceType;
        private static string Doctor;
        private static string Date;
        private static string Time;

        // New: store numeric ids (nullable) for service and doctor
        private static int ServiceId;
        private static int DoctorId;

        // setters and getters
        public static void SetServiceType(string serviceType) => ServiceType = serviceType;
        public static string GetServiceType() => ServiceType;
        public static void SetDoctor(string doctor) => Doctor = doctor;
        public static string GetDoctor() => Doctor;
        public static void SetDate(string date) => Date = date;
        public static string GetDate() => Date;
        public static void SetTime(string time) => Time = time;
        public static string GetTime() => Time;

        // service id setters/getters
        public static void SetServiceId(int serviceId) => ServiceId = serviceId;
        public static int GetServiceId() => ServiceId;

        // doctor id setters/getters
        public static void SetDoctorId(int doctorId) => DoctorId = doctorId;
        public static int GetDoctorId() => DoctorId;

        // Clear all
        public static void Clear()
        {
            ServiceType = null;
            Doctor = null;
            Date = null;
            Time = null;
            ServiceId = -1;
            DoctorId = -1;
        }
    }
}
