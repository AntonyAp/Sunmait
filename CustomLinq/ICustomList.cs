namespace CustomLinq
{
    interface ICustomList <T>
    {
        void Add(T el);
        int Count(CustomList<T> list);
    }
}
