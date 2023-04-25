namespace SolidASP.Tools
{
    public class Log
    {
        private readonly string _name = "Log.txt";

        public async void Save(string content)
        {
            await File.WriteAllTextAsync(_name, content);
        }
    }
}
