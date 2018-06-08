namespace Patterns.Ex00
{
    public class LogImporterClient
    {
        /// <summary>
        /// TODO: Изменения нужно вносить в этом методе
        /// </summary>
        public void DoMethod()
        {
            LogImporter importer = new LogImporter(new FileLogReader());
            importer.ImportLogs("ftp://log.txt");
        }

        public void DoMethodWithFtp(string log, string pass)
        {
            LogImporter importer = new LogImporter(new FtpLogReader(log, pass));
            importer.ImportLogs("ftp://log.txt");
        }
    }
}