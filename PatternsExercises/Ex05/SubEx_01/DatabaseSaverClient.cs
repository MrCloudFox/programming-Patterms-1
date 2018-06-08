using Patterns.Ex05.ExternalLibs;
using System.Collections.Generic;

namespace Patterns.Ex05.SubEx_01
{
    interface Subsciber
    {
        void Update();
    }

    public class MailSenderOnSave : Subsciber
    {
        public void Update()
        {
            var sender = new MailSender();
            sender.Send("update");
        }
    }

    public class CacheUpdaterOnSave : Subsciber
    {
        public void Update()
        {
            var cache = new CacheUpdater();
            cache.UpdateCache();
        }
    }

    public class DatabaseSaverClient
    {
        private Dictionary<string, List<Subsciber>> dict;

        public void Main(bool b)
        {
            var databaseSaver = new DatabaseSaver();
            DoSmth(databaseSaver);
        }

        private void DoSmth(IDatabaseSaver saver)
        {
            saver.SaveData(null);
            NotifySubscribers("save");
        }

        private void NotifySubscribers(string Action)
        {
            foreach (Subsciber sub in dict[Action])
            {
                sub.Update();
            }
        }

        private void Subscribe(Subsciber sub, string action)
        {
            dict[action].Add(sub);
        }
    }
}