using UnityEngine;
using NUnit.Framework;

namespace Agava.YandexMetrica.Tests
{
    public class MetricaTests : MonoBehaviour
    {
        [Test]
        public void ShouldNotThrow()
        {
            YandexMetrica.Send("asdasd");
            YandexMetrica.Send("fdgdfg", new TestData());
            YandexMetrica.Send("asdasd", "{\"SomeString\": \"asdasdstringlol\"}");
        }

        public class TestData
        {
            public int SomeNumber = 42;
        }
    }
}
