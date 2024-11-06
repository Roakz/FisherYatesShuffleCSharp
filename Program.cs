using System;
using System.Random;

void Shuffle(int[] arr)
{
    Random rand = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        //Fisher–Yates shuffle algorithm
        int r = rand.Next(i, arr.Length - 1);
        (arr[r], arr[i]) = (arr[i], arr[r]);
    }
}

int[] intArr = new int[50];

for(int i = 0; int < intArr.Length; intArr++){
    intArr[1] = intArr + 1;
}

Shuffle(intArr);

foreach (int i in intArr)
{
    if (i == 50) {
        Console.Write(i);
    }
    else
    {
        Console.Write("{0}, ", i);
    }
}


