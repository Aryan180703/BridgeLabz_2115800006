using System;

class Course {
    public string CourseName { get; set; }
    public int Duration { get; set; }
    public Course(string courseName, int duration) {
        CourseName = courseName;
        Duration = duration;
    }
    public virtual void DisplayDetails() {
        Console.WriteLine("Course Name :  " + CourseName);
        Console.WriteLine("Duration : " + Duration);
    }
}

class OnlineCourse : Course {
    public string Platform { get; set; }
    public bool IsRecorded { get; set; }
    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded) : base(courseName, duration) {
        Platform = platform;
        IsRecorded = isRecorded;
    }
    public override void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine("Platform : " + Platform);
        Console.WriteLine("Recorded : " + (IsRecorded ? "Yes" : "No"));
    }
}

class PaidOnlineCourse : OnlineCourse {
    public double Fee { get; set; }
    public double Discount { get; set; }
    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount) : base(courseName, duration, platform, isRecorded) {
        Fee = fee;
        Discount = discount;
    }
    public override void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine("Fee : " + Fee);
        Console.WriteLine("Discount : " + Discount );
    }
}
