const yandexMetricaLibrary = {
  
  // Class definition.

  $yandexMetrica: {
    yandexMetricaSend: function (eventName, eventData) {
      const eventDataJson = eventData === '' ? undefined : JSON.parse(eventData);
      ym(window.yandexMetricaCounterId, 'reachGoal', eventName, eventDataJson);
    },
  },

  // External C# calls.

  YandexMetricaSend: function (eventNamePtr, eventDataPtr) {
    const eventName = UTF8ToString(eventNamePtr);
    const eventData = UTF8ToString(eventDataPtr);
    yandexMetrica.yandexMetricaSend(eventName, eventData);
  },
}

autoAddDeps(yandexMetricaLibrary, '$yandexMetrica');
mergeInto(LibraryManager.library, yandexMetricaLibrary);
