
/*
 * Demonstrates an implementation of converting a binary number to a decimal
 * number in Java.
 *
 * Auther: Josh Brown
 * Date: 2/1/2021
 *
 */

using System;
public class MainClass {
    static void Main(string[] args) {
        string binary = "100001000101111111101101"; // 8675309 as binary
        Console.WriteLine(BinToDec(binary));
    }

    /*
     * Returns the decimal equivalent of a binary string
     * Input: string representing a binary number
     * Output: int decimal equivalent of input
     */
    static int BinToDec(string binary) {
        int dec = 0;
        for(int i = binary.Length; i > 0; i--) {
            int val = (int)binary[i-1] - '0';
            dec += val*pow(2,binary.Length-i);
        }
        return dec;
    }

    /*
     * Returns a raised to the power b
     * Input: integer a, integer b
     * Output: integer value representing a^b
     */
    static int pow(int a, int b) {
        int result = 1;
        for(; b > 0; b--) {
            result *= a;
        }
        return result;
    }
}
