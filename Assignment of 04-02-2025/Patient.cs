using System;
public class Patient {
    public static string HospitalName = "The Johns Hopkins Hospital";
    public static int TotalPatients = 0;
    public readonly string PatientID;
    private string name;
    private int age;
    private string ailment;
    public Patient(string name, int age, string ailment) {
        this.name = name;
        this.age = age;
        this.ailment = ailment;
        this.PatientID = Guid.NewGuid().ToString();
        TotalPatients++;
    }
    public string GetName() {
        return name;
    }
    public void SetName(string name) {
        this.name = name;
    }
    public int GetAge() {
        return age;
    }
    public void SetAge(int age) {
        this.age = age;
    }
    public string GetAilment() {
        return ailment;
    }
    public void SetAilment(string ailment) {
        this.ailment = ailment;
    }
    public static int GetTotalPatients() {
        return TotalPatients;
    }
    public void DisplayPatientDetails() {
        Console.WriteLine("Hospital Name : " + HospitalName);
        Console.WriteLine("Patient Name : " + name);
        Console.WriteLine("Patient Age : " + age);
        Console.WriteLine("Patient Ailment : " + ailment);
        Console.WriteLine("Patient ID : " + PatientID);
    }
}
class Program {
    static void Main(string[] args) {
        Patient patient1 = new Patient("Aryan", 21, "Scabies");
        Patient patient2 = new Patient("Dhruv", 19, "Stomach Infection");

        if (patient1 is Patient) {
            patient1.DisplayPatientDetails();
        }

        if (patient2 is Patient) {
            patient2.DisplayPatientDetails();
        }

        Console.WriteLine("Total Patients Admitted: " + Patient.GetTotalPatients());
    }
}