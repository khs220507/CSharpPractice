using System.Runtime.CompilerServices;

delegate bool CompareDelegate(object arg1, object arg2); // object 인자 2개

class SortObject
{
    object[] things;


    public void Sort(object[] things)
    {
        this.things = things;
    }

    public void Sort(CompareDelegate compareMethod)
    {
        object temp;

        for(int i=0; i<things.Length; i++)
        {
            int lowPos = i;

            for(int j = i+1; j<things.Length; j++)
            {
                if (compareMethod(things[j], things[lowPos]))
                {
                    lowPos =  j;
                }
            }
            temp = things[lowPos];
            things[lowPos] = things[i];
            things[i] = temp;
        }
    }
}

class Program
{
    static bool AscSortByName(object arg1, object arg2)
    {
        Person person1 = arg1 as Person; // 대상 타입으로 형변환
        Person person2 = arg2 as Person;
        return person1.Name.CompareTo(person2.Name)<0;
    }
    static void Main(string[] args)
    {
        SortObject so = new SortObject(personArray);
        so.Sort(AscSortByName);
        so.Display();
    }
}