
/*
 * Demonstrates an implementation of converting a binary number to a decimal
 * number in Java.
 *
 * Auther: Josh Brown
 * Date: 2/1/2021
 *
 */

#include <math.h>
#include <stdio.h>

/*
 * Returns the decimal equivalent of a binary string
 * Input: string representing a binary number and length of string
 * Output: int decimal equivalent of input
*/
int BinToDec(char binary[], int length) {
    int dec = 0;
    for(int i = length; i > 0; i--) {
        int val = binary[i-1] - '0';
        dec += val*pow(2, length-i);
    }
    return dec;
}

void main() {
    char binary[] = "100001000101111111101101"; // 8675309 as binary string
    printf("%i", BinToDec(binary, 24));
}
