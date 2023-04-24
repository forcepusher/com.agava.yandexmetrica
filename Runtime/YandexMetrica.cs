using System.Runtime.InteropServices;
using UnityEngine;

namespace Agava.YandexMetrica
{
    public static class YandexMetrica
    {
        public static bool CallbackLogging = false;

        public static void Send(string eventName, string eventDataJson)
        {
            YandexMetricaSend(eventName, eventDataJson);

            if (CallbackLogging)
                Debug.Log($"{nameof(YandexMetrica)}.{nameof(Send)} {nameof(eventName)}={eventName}" + (string.IsNullOrEmpty(eventDataJson) ? "" : $" {nameof(eventDataJson)}={eventDataJson}"));
        }

        public static void Send(string eventName)
        {
            Send(eventName, string.Empty);
        }

        public static void Send(string eventName, object eventDataObject)
        {
            Send(eventName, JsonUtility.ToJson(eventDataObject));
        }

        [DllImport("__Internal")]
        private static extern bool YandexMetricaSend(string eventName, string eventData);
    }
}
