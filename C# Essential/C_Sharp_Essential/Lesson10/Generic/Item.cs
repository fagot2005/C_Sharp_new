namespace Generic
{
    class Item<T> where T : new()
    {
        public static T FactoryMetod()
        {
            return new T();
        }
    }
}
