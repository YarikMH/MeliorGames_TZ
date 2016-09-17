namespace Model
{
    public class DataLayer : IDataLayer
    {
        private Data _data;

        public Data LoadData()
        {
            if (_data == null) _data = new Data();
            return _data;
        }

        public void SaveData(Data data)
        {
            _data = data;
        }
    }
}
