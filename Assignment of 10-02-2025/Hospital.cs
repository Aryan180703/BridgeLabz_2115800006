using System;
using System.Collections.Generic;

abstract class Patient {
    private int patientId;
    private string name;
    private int age;
    private string diagnosis;
    private List<string> medicalHistory;

    public int PatientId {
        get { return patientId; }
        private set { patientId = value; }
    }

    public string Name {
        get { return name; }
        private set { name = value; }
    }

    public int Age {
        get { return age; }
        private set { age = value; }
    }

    protected Patient(int patientId, string name, int age, string diagnosis) {
        PatientId = patientId;
        Name = name;
        Age = age;
        this.diagnosis = diagnosis;
        medicalHistory = new List<string>();
    }

    public virtual void GetPatientDetails() {
        Console.WriteLine("Patient ID : " + PatientId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Diagnosis: " + diagnosis);
        Console.WriteLine("Total Bill: " + CalculateBill());
        Console.WriteLine();
    }

    public void AddMedicalHistory(string record) {
        medicalHistory.Add(record);
    }

    public void ViewMedicalHistory() {
        Console.WriteLine("Medical History for " + Name + ":");
        foreach (var record in medicalHistory) {
            Console.WriteLine("- " + record);
        }
        Console.WriteLine();
    }

    public abstract double CalculateBill();
}

interface IMedicalRecord {
    void AddRecord(string record);
    void ViewRecords();
}

class InPatient : Patient, IMedicalRecord {
    private int daysAdmitted;
    private double dailyCharge;

    public InPatient(int patientId, string name, int age, string diagnosis, int daysAdmitted, double dailyCharge) 
        : base(patientId, name, age, diagnosis) {
        this.daysAdmitted = daysAdmitted;
        this.dailyCharge = dailyCharge;
    }

    public override double CalculateBill() {
        return daysAdmitted * dailyCharge;
    }

    public void AddRecord(string record) {
        AddMedicalHistory(record);
        Console.WriteLine("Medical record added for InPatient: " + Name);
        Console.WriteLine();
    }

    public void ViewRecords() {
        ViewMedicalHistory();
    }
}

class OutPatient : Patient, IMedicalRecord {
    private double consultationFee;

    public OutPatient(int patientId, string name, int age, string diagnosis, double consultationFee) 
        : base(patientId, name, age, diagnosis) {
        this.consultationFee = consultationFee;
    }

    public override double CalculateBill() {
        return consultationFee;
    }

    public void AddRecord(string record) {
        AddMedicalHistory(record);
        Console.WriteLine("Medical record added for OutPatient: " + Name);
        Console.WriteLine();
    }

    public void ViewRecords() {
        ViewMedicalHistory();
    }
}

class Program {
    static void Main() {
        List<Patient> patients = new List<Patient>();

        while (true) {
            Console.WriteLine("1. Add Patient");
            Console.WriteLine("2. View Patient Details");
            Console.WriteLine("3. Add Medical Record");
            Console.WriteLine("4. View Medical Records");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice) {
                case 1:
                    Console.WriteLine("1. InPatient");
                    Console.WriteLine("2. OutPatient");
                    Console.Write("Enter patient type: ");
                    int type = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Patient ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Diagnosis: ");
                    string diagnosis = Console.ReadLine();

                    if (type == 1) {
                        Console.Write("Enter Days Admitted: ");
                        int days = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Daily Charge: ");
                        double charge = Convert.ToDouble(Console.ReadLine());

                        patients.Add(new InPatient(id, name, age, diagnosis, days, charge));
                    } else if (type == 2) {
                        Console.Write("Enter Consultation Fee: ");
                        double fee = Convert.ToDouble(Console.ReadLine());

                        patients.Add(new OutPatient(id, name, age, diagnosis, fee));
                    }

                    Console.WriteLine("Patient Added Successfully");
                    Console.WriteLine();
                    break;

                case 2:
                    foreach (var patient in patients) {
                        patient.GetPatientDetails();
                    }
                    break;

                case 3:
                    Console.Write("Enter Patient ID to add record: ");
                    int recordId = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Medical Record: ");
                    string record = Console.ReadLine();

                    foreach (var patient in patients) {
                        if (patient.PatientId == recordId && patient is IMedicalRecord) {
                            ((IMedicalRecord)patient).AddRecord(record);
                            break;
                        }
                    }
                    break;

                case 4:
                    Console.Write("Enter Patient ID to view records: ");
                    int viewId = Convert.ToInt32(Console.ReadLine());

                    foreach (var patient in patients) {
                        if (patient.PatientId == viewId && patient is IMedicalRecord) {
                            ((IMedicalRecord)patient).ViewRecords();
                            break;
                        }
                    }
                    break;

                case 5:
                    return;

                default:
                    Console.WriteLine("Invalid Choice!");
                    Console.WriteLine();
                    break;
            }
        }
    }
}
