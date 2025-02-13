using System;
class CircularTour {
    public static int FindStartingPoint(int[] petrol, int[] distance) {
        int totalSurplus = 0;
        int currentSurplus = 0;
        int startIndex = 0;
        for (int i = 0; i < petrol.Length; i++) {
            int netGain = petrol[i] - distance[i];
            totalSurplus += netGain;
            currentSurplus += netGain;
            if (currentSurplus < 0) {
                startIndex = i + 1;
                currentSurplus = 0;
            }
        }
        return totalSurplus >= 0 ? startIndex : -1;
    }
    static void Main(string[] args) {
        int[] petrol = { 4, 6, 7, 4 };
        int[] distance = { 6, 5, 3, 5 };
        int result = FindStartingPoint(petrol, distance);
        if (result == -1) {
            Console.WriteLine("No starting point.");
        } else {
            Console.WriteLine("The starting petrol pump index is " + result);
        }
    }
}
