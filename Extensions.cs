namespace M0n0p01y;

public static class Extensions
{
    public static T[] ShallowCopy<T>(this T[] array)
    {
        var temp = new T[array.Length];
        for (var i = 0; i < array.Length; i++)
        {
            temp[i] = array[i];
        }
        return temp;
    }
}
