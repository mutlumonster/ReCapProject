namespace Core.Utilities.Result
{
    public class DataResult<T>: Result, IDataResult<T>
    {
        public T Data { get; }

        public DataResult(T Data, bool success, string message) : base(success, message) 
        {

        }

        public DataResult(T data, bool success ) : base(success)
        {
            Data = data;
        }
    }
}
