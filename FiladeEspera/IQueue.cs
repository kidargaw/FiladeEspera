namespace FiladeEspera
{
    public interface IQueue
    {
        void Add(Client clientQueue);
        void Remove();
        int Next();
        int Total();

    }
}
