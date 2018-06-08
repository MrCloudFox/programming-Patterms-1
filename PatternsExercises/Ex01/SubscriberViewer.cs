using System;
using System.Collections.Generic;

namespace Patterns.Ex01
{
    public class SubscriberViewer
    {
        /// <summary>
        /// ���������� ������ ����������� ������������ �� ���.����.
        /// TODO: ���������� �������� ���� ����� �� �������� ������
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="networkType"></param>
        /// <returns></returns>

        private Dictionary<SocialNetwork, ISocialNetworkUserProcessor> dict;

        public SocialNetworkUser[] GetSubscribers(String userName, SocialNetwork networkType)
        {
            return dict[networkType].GetSubscribers();
        }
    }
}