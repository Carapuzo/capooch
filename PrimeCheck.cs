using System;

class PrimeCheck {
    static bool IsPrime(int num) {
        if (num <= 1) return false;
        if (num <= 3) return true;

        if (num % 2 == 0 || num % 3 == 0) return false;

        for (int i = 5; i * i <= num; i += 6) {
            if (num % i == 0 || num % (i + 2) == 0) return false;
        }

        return true;
    }

    static void Main() {
        int number = 17;
        if (IsPrime(number)) {
            Console.WriteLine(number + " is prime.");
        } else {
            Console.WriteLine(number + " is not prime.");
        }
    }
}
