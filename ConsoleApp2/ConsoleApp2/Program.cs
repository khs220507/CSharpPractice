using System.Collections;

int[] intArray = new int[] { 1, 2, 3, 4, 5 };

IEnumerator enumerator = intArray.GetEnumerator();

while (enumerator.MoveNext()) // 더 이상 열거할 수 없을 때 false를 반환
{
    Console.WriteLine(enumerator.Current + ", ");
}    
