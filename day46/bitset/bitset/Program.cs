using System;

using System.Collections;

class BitSet

{

    private BitArray bits;

    public BitSet(int size)

    {

        bits = new BitArray(size);

    }

    public int Cardinality()

    {

        int count = 0;

        foreach (bool bit in bits)

        {

            if (bit)

                count++;

        }

        return count;

    }

    public void And(BitSet other)

    {

        bits.And(other.bits);

    }

    public void Or(BitSet other)

    {

        bits.Or(other.bits);

    }

    public void Xor(BitSet other)

    {

        bits.Xor(other.bits);

    }

    public void Flip(int index)

    {

        bits.Set(index, !bits.Get(index));

    }

    public void Set(int index)

    {

        bits.Set(index, true);

    }

}

class Program

{

    static void Main()

    {

        string[] input = Console.ReadLine().Split(' ');

        int size = int.Parse(input[0]);

        int numOperations = int.Parse(input[1]);

        BitSet bitSet1 = new BitSet(size);

        BitSet bitSet2 = new BitSet(size);

        for (int i = 0; i < numOperations; i++)

        {

            string[] operation = Console.ReadLine().Split(' ');

            string op = operation[0];

            int index = int.Parse(operation[1]);

            int operand = int.Parse(operation[2]);

            switch (op)

            {

                case "AND":

                    if (operand == 1)

                        bitSet1.And(bitSet2);

                    else

                        bitSet2.And(bitSet1);

                    break;

                case "OR":

                    if (operand == 1)

                        bitSet1.Or(bitSet2);

                    else

                        bitSet2.Or(bitSet1);

                    break;

                case "XOR":

                    if (operand == 1)

                        bitSet1.Xor(bitSet2);

                    else

                        bitSet2.Xor(bitSet1);

                    break;

                case "FLIP":

                    if (operand == 1)

                        bitSet1.Flip(index);

                    else

                        bitSet2.Flip(index);

                    break;

                case "SET":

                    if (operand == 1)

                        bitSet1.Set(index);

                    else

                        bitSet2.Set(index);

                    break;

            }

            Console.WriteLine(bitSet1.Cardinality() + " " + bitSet2.Cardinality());

        }

    }

}


