using System;
using System.Collections.Generic;

public abstract class JobRole {
    public string RoleName { get; set; } 
    public JobRole(string roleName) { 
        RoleName = roleName; 
    }
    public abstract void EvaluateResume(); 
}

public class SoftwareEngineer : JobRole {
    public int YearsOfExperience { get; set; } 
    public SoftwareEngineer(int yearsOfExperience) : base("Software Engineer") { 
        YearsOfExperience = yearsOfExperience; 
    }
    public override void EvaluateResume() { 
        Console.WriteLine("Evaluating resume for " + RoleName + " with " + YearsOfExperience + " years of experience."); 
    }
}

public class DataScientist : JobRole {
    public string PreferredTool { get; set; } 
    public DataScientist(string preferredTool) : base("Data Scientist") { 
        PreferredTool = preferredTool; 
    }
    public override void EvaluateResume() { 
        Console.WriteLine("Evaluating resume for " + RoleName + " specializing in " + PreferredTool + "."); 
    }
}

public class Resume<T> where T : JobRole {
    public string CandidateName { get; set; } 
    public T Role { get; set; } 
    public Resume(string candidateName, T role) { 
        CandidateName = candidateName; 
        Role = role; 
    }
    public void ProcessResume() { 
        Console.WriteLine("Processing resume for candidate: " + CandidateName); 
        Role.EvaluateResume(); 
    }
}

public class ResumeScreeningSystem {
    public List<Resume<JobRole>> Resumes { get; set; } 
    public ResumeScreeningSystem() { 
        Resumes = new List<Resume<JobRole>>(); 
    }
    public void AddResume(Resume<JobRole> resume) { 
        Resumes.Add(resume); 
    }
    public void ProcessAllResumes() { 
        foreach (var resume in Resumes) { 
            resume.ProcessResume(); 
            Console.WriteLine(); 
        } 
    }
}

public class Program {
    public static void Main(string[] args) { 
        var softwareResume = new Resume<SoftwareEngineer>("Alice Johnson", new SoftwareEngineer(5)); 
        var dataScienceResume = new Resume<DataScientist>("Bob Smith", new DataScientist("Python")); 
        var screeningSystem = new ResumeScreeningSystem(); 
        screeningSystem.AddResume(softwareResume); 
        screeningSystem.AddResume(dataScienceResume); 
        screeningSystem.ProcessAllResumes(); 
    }
}
