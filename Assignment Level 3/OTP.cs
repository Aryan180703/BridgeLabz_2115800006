using System;
class OTPGenerator{
    //this method will generate otp
    public static int GenerateOTP() {
        Random random = new Random();
        return random.Next(100000, 1000000);
    }
    //this method will check weather the otp is unique or not
    public static bool OTPUniqueOrNot(int[] otp) {
        for (int i = 0; i < otp.Length; i++) {
            for (int j = i + 1; j < otp.Length; j++) {
                if (otp[i] == otp[j]) {
                    return false;
                }
            }
        }
        return true;
    }
    public static void Main() {
        int[] otp = new int[10];
        for (int i = 0; i < 10; i++) {
            otp[i] = GenerateOTP();
        }
        if (OTPUniqueOrNot(otp)) {
            Console.WriteLine("OTP are unique");
        } else {
            Console.WriteLine("OTP are duplicate");
        }
    }
}
