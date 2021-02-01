
/*
 * Demonstrates an implementation of converting a binary number to a decimal
 * number in Java.
 *
 * Auther: Josh Brown
 * Date: 2/1/2021
 *
 */
public class BinToDec {

	public static void main(String args[]) {
		String binary = "100001000101111111101101"; // 8675309 as binary
		System.out.println(BinToDec(binary));
	}

    /*
     * Returns the decimal equivalent of a binary string
     * Input: string representing a binary number
     * Output: int decimal equivalent of input
     */
	public static int BinToDec(String binary) {
		int dec = 0;
		for(int i = binary.length(); i > 0; i--) {
			int val = (int)binary.charAt(i-1) - '0'; // charAt returns ascii, convert to numeric
			dec += val*Math.pow(2, binary.length()-i);
			System.out.println("val:" + val + "\ndec:" + dec);
		}
		return dec;
	}
}
