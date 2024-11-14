class GenericStore<T>
{
    public T? Data { get; set; }

    public GenericStore(T data)
    {
        Data = data;
    }
}
