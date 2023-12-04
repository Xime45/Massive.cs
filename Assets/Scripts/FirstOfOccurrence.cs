using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class FirstOfOccurrence : MonoBehaviour
{
    public void OnClick()
    {
        OnFirstOccurrence();
    }
    public void OnFirstOccurrence()
    {
        // Первый тест, число присутсвует в массиве
        int[] array = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        int value = 34;
        int want = 3;
        int got = FirstOccurrence(array, value);
        string message = want == got ? "Результат верный" : $"Результат не верный, ожидается {want}";
        Debug.Log($"Индекс первого вхождения числа {value} в массив: {got} - {message}");

        // Второй тест, число не присутсвует в массиве
        array = new int[] { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        value = 55;
        want = -1;
        got = FirstOccurrence(array, value);
        message = want == got ? "Результат верный" : $"Результат не верный, ожидается {want}";
        Debug.Log($"Индекс первого вхождения числа {value} в массив: {got} - {message}");
    }

    /// <summary>
    /// Метод производит поиск первого вхождения числа в массив
    /// </summary>
    /// <param name="array">Исходный массив</param>
    /// <param name="value">Искомое число</param>
    /// <returns>Индекс искомого числа в массиве или -1 если число отсуствует</returns>
    private int FirstOccurrence(int[] array, int value)
    {
        for (int numb = 0; numb < array.Length; numb++)
        {
          if (array[numb] == value)
          {
                return numb;
          }
        }
        return -1;
    }
}