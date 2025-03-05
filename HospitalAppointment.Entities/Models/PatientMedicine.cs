using HospitalAppointment.Entities.Abstractions;

namespace HospitalAppointment.Entities.Models
{
    public class PatientMedicine:Entity
    {
        public Guid PatientId { get; set; }
        public Patients? Patient { get; set; }

        public Guid MedicineId { get; set; }
        public Medicine? Medicine { get; set; }
    }
}