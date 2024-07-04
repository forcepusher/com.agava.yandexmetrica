# com.agava.yandexmetrica  
  
Make sure you have standalone [Git](https://git-scm.com/downloads) installed first. Reboot after installation.  
In Unity, open "Window" -> "Package Manager".  
Click the "+" sign at the top left corner -> "Add package from git URL..."  
Paste this: `https://github.com/forcepusher/com.agava.yandexmetrica.git#1.2.0`  
To update the package, simply add it again while using a different version tag.  
See minimum required Unity version in the `package.json` file.  
Find "Samples" in the package window and click the "Import" button. Use it as a guide.  
  
Samples also contain WebGL Template required for Yandex Metrica to work.  
Drag and drop WebGLTemplates folder into Assets and select it in Edit -> Project Settings -> Player -> Resolution and Presentation. Select the template and insert your Yandex Mertica counter id found in the dashboard URL page, such as `https://metrica.yandex.com/dashboard?group=day&period=month&id=89587935` where last numbers is the counter id you're looking for.  
  
This is a publishing repo. If you need to create a pull request, use the [Development Repo](https://github.com/forcepusher/YandexMetricaUnity).
