using Patterns.Ex05.ExternalLibs;

namespace Patterns.Ex05.SubEx_02
{
    public class Decorator : IDatabaseSaver
    {
        private IDatabaseSaver databaseSaver;

        public Decorator(IDatabaseSaver databaseSaver)
        {
            this.databaseSaver = databaseSaver;
        }

        public void SaveData(object obj)
        {
            databaseSaver.SaveData(obj);
        }

    }


    public class ChildDecorator : Decorator
    {
        private IDatabaseSaver databaseSaver;
        private MailSender mailSender;
        private CacheUpdater cacheUpdater;

        public ChildDecorator(IDatabaseSaver databaseSaver, MailSender mailSender, CacheUpdater cacheUpdater)
           : base(databaseSaver)
        {
            this.mailSender = mailSender;
            this.cacheUpdater = cacheUpdater;
        }


        public void SaveData(object obj)
        {
            databaseSaver.SaveData(obj);
            mailSender.Send(null);
            cacheUpdater.UpdateCache();
        }
    }


    public class DatabaseSaverClient
    {

        public void Main(bool b)
        {
            var databaseSaver = new DatabaseSaver();
            var databaseSaverDec = new ChildDecorator(databaseSaver, new MailSender(), new CacheUpdater());
            DoSmth(databaseSaver);
        }

        private void DoSmth(IDatabaseSaver saver)
        {
            saver.SaveData(null);
        }
    }
}