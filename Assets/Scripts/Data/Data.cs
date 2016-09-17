namespace Model
{
    public class Data
    {
        public int Count;
        public DataType Type;
    }

    public enum DataType
    {
        Rabbit,
        Dog
    }

    public interface IDataLayer
    {
        void SaveData(Data data);
        Data LoadData();
    }
}
