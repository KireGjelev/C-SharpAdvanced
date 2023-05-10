using Newtonsoft.Json;
using Task.Domain;

namespace Task.Domain
{
    public class Db<T> where T : Dog
    {
        private string _folderPath;
        private string _filePath;


        public Db()
        {
            _folderPath = @"..\..\..\Dogs";
            _filePath = _folderPath + $@"\{typeof(T).Name}s.json";

            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }

            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
            }
            List<T> data = ReadFromFile();
            if (data == null)
            {
                WriteToFile(new List<T>());
            }

        }

        public List<T> ReadFromFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(_filePath))
                {
                    string data = sr.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<T>>(data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public void WriteToFile(List<T> data)
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(data);
                using (StreamWriter sw = new StreamWriter(_filePath))
                {
                    sw.WriteLine(jsonData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<T> GetAll()
        {
            List<T> data = ReadFromFile();
            return data;
        }

        public void Insert(T item)
        {
            List<T> data = ReadFromFile();
            data.Add(item);
            WriteToFile(data);
        }
    }
}