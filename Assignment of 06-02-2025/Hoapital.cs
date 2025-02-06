using System;
using System.Collections.Generic;
class Hospital {
    public string Name { get; set; }
    private List<Doctor> doctors = new List<Doctor>();
    private List<Patient> patients = new List<Patient>();
    public Hospital(string name) {
        Name = name;
    }
    public void AddDoctor(Doctor doctor) {
        doctors.Add(doctor);
        Console.WriteLine("Doctor " + doctor.Name + " added to " + Name + );
    }
    public void AddPatient(Patient patient) {
        patients.Add(patient);
        Console.WriteLine("Patient " + patient.Name + " registered at " + Name + );
    }
}
class Doctor {
    public string Name { get; }
    private List<Patient> patients = new List<Patient>();
    public Doctor(string name) {
        Name = name;
    }
    public void Consult(Patient patient) {
        if (!patients.Contains(patient)) {
            patients.Add(patient);
            patient.AddDoctor(this);
        }
        Console.WriteLine("Doctor " + Name + " is consulting Patient " + patient.Name );
    }
}
class Patient {
    public string Name { get; }
    private List<Doctor> doctors = new List<Doctor>();
    public Patient(string name) {
        Name = name;
    }
    public void AddDoctor(Doctor doctor) {
        if (!doctors.Contains(doctor)) {
            doctors.Add(doctor);
        }
    }
}
class Program {
    static void Main() {
        Hospital hospital = new Hospital("CIMS");
        Doctor doctor1 = new Doctor("Dr. Rajeev");
        Doctor doctor2 = new Doctor("Dr. Umesh");
        Patient patient1 = new Patient("Aryan");
        Patient patient2 = new Patient("Dhruv");
        hospital.AddDoctor(doctor1);
        hospital.AddDoctor(doctor2);
        hospital.AddPatient(patient1);
        hospital.AddPatient(patient2);
        doctor1.Consult(patient1);
        doctor1.Consult(patient2);
        doctor2.Consult(patient1);
    }
}
