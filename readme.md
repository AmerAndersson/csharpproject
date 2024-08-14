# Bitwise AND Assignment (&=)
int x = 5;
x &= 3;
Console.WriteLine(x);

int x = 5; initializes the integer variable x with the value 5.
x &= 3; performs a bitwise AND operation between x and 3 and then assigns the result back to x.
In binary: 5 is 101, and 3 is 011.
Bitwise AND: 101 & 011 = 001 (which is 1 in decimal).
Console.WriteLine(x); prints the value of x, which is 1.

## Bitwise OR Assignment (|=)
int x = 5;
x |= 3;
Console.WriteLine(x);
x |= 3; performs a bitwise OR operation between x and 3 and assigns the result back to x.
In binary: 5 is 101, and 3 is 011.
Bitwise OR: 101 | 011 = 111 (which is 7 in decimal).
Console.WriteLine(x); prints the value of x, which is 7.

## Bitwise XOR Assignment (^=)
csharp
Copy code
int x = 5;
x ^= 3;
Console.WriteLine(x);
x ^= 3; performs a bitwise XOR operation between x and 3 and assigns the result back to x.
In binary: 5 is 101, and 3 is 011.
Bitwise XOR: 101 ^ 011 = 110 (which is 6 in decimal).
Console.WriteLine(x); prints the value of x, which is 6.

---


> The operations `x <<= 3;` and `x >>= 3;` are examples of bitwise shift operations in C#. These operations manipulate the bits of an integer by shifting them left or right.

### 1. **Left Shift (`<<`)**

**Expression: `x <<= 3;`**

- **Meaning**: This operation shifts the bits of the integer `x` to the left by 3 positions. The `<<=` operator is a shorthand for the left shift operation followed by an assignment. So, `x <<= 3;` is equivalent to `x = x << 3;`.

- **How It Works**:
  - Each bit in the binary representation of `x` is moved 3 positions to the left.
  - The vacated positions on the right are filled with zeros.
  - The left shift operation effectively multiplies the number by `2^n` (where `n` is the number of positions shifted).

- **Example**:
  - If `x = 5` (which is `101` in binary):
  - After `x <<= 3;`, the binary representation becomes `101000`, which is `40` in decimal.
  - **Calculation**: \( 5 \times 2^3 = 5 \times 8 = 40 \).

### 2. **Right Shift (`>>`)**

**Expression: `x >>= 3;`**

- **Meaning**: This operation shifts the bits of the integer `x` to the right by 3 positions. The `>>=` operator is a shorthand for the right shift operation followed by an assignment. So, `x >>= 3;` is equivalent to `x = x >> 3;`.

- **How It Works**:
  - Each bit in the binary representation of `x` is moved 3 positions to the right.
  - The vacated positions on the left depend on the sign of the number:
    - For unsigned integers or non-negative signed integers, zeros are filled in on the left.
    - For negative signed integers, ones are filled in on the left (arithmetic right shift).
  - The right shift operation effectively divides the number by `2^n` (where `n` is the number of positions shifted).

- **Example**:
  - If `x = 5` (which is `101` in binary):
  - After `x >>= 3;`, the binary representation becomes `000`, which is `0` in decimal.
  - **Calculation**: \( 5 \div 2^3 = 5 \div 8 = 0 \) (integer division).

### Summary

- `x <<= 3;` shifts bits to the left by 3, multiplying `x` by `8`.
- `x >>= 3;` shifts bits to the right by 3, dividing `x` by `8`.

These operations are efficient ways to perform multiplication and division by powers of two using bitwise manipulation.