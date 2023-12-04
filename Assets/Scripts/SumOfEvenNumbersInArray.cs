
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class SumOfEvenNumbersInArray : MonoBehaviour
{
    public void OnClick()
    {
        OnSumEvenNumbersInArray();
    }
    public void OnSumEvenNumbersInArray()
    {
        int[] array = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        int want = 214;
        int got = SumEvenNumbersInArray(array);
        string message = want == got ? "Результат верный" : $"Результат не верный, ожидается {want}";
        Debug.Log($"Сумма четных чисел в заданном массиве: {got} - {message}");
    }
    private int SumEvenNumbersInArray(int[] array)
    {
        int sum=0;

        for (int chet=0; chet<array.Length; chet++)
        {
            if (array[chet] % 2 == 0)
            {
                sum +=array[chet];
            }
        }
        return sum;
    }
}

