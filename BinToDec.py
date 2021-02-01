
'''

Demonstrates an implementation of converting a binary number to a decimal number
in Python.

Author: Josh Brown
Date: 2/1/2021

'''

# Returns the decimal equivalent of binary string
# Input: string representing a binary number
# Output: decimal equivalent of input
def BinToDec(bin):
    dec = 0
    for i in range(len(bin), 0, -1):
        val = int(bin[i-1])
        dec = dec + val*2**(len(bin)-i)
    return dec

# Main - passes binary equivalent of "8675309" to BinToDec function and prints
# result
def main():
    bin = "100001000101111111101101"
    print(BinToDec(bin))

if __name__ == '__main__':
    main()
