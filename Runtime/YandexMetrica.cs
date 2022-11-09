using System.Runtime.InteropServices;
using UnityEngine;

namespace Agava.YandexMetrica
{
    public static class YandexMetrica
    {
        public static void Send(string eventName)
        {
            YandexMetricaSend(eventName, string.Empty);
        }

        public static void Send(string eventName, string eventDataJson)
        {
            YandexMetricaSend(eventName, eventDataJson);
        }

        public static void Send(string eventName, object eventDataObject)
        {
            Send(eventName, JsonUtility.ToJson(eventDataObject));
        }

        [DllImport("__Internal")]
        private static extern bool YandexMetricaSend(string eventName, string eventData);
    }
}
