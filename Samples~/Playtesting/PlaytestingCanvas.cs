using UnityEngine;
using UnityEngine.UI;

namespace Agava.YandexMetrica.Samples
{
    public class PlaytestingCanvas : MonoBehaviour
    {
        [SerializeField]
        private InputField _eventNameField;
        [SerializeField]
        private InputField _eventDataField;

        public void OnSendButtonClick()
        {
            YandexMetrica.Send(_eventNameField.text, _eventDataField.text);
        }
    }
}
