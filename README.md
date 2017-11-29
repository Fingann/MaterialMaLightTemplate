# FingannTemplate
MVVM light, Mahapps, MaterialDesign, Notification, Navigation


## NotificationsService
Notifications are based on 
https://github.com/Federerer/Notifications.Wpf

To create notifications use the following [Interface](https://github.com/Fingann/FingannTemplate/blob/master/FingannTemplate/Services/Notification/INotificationService.cs)
To create notifications **inside** the application use 
```CSharp
areaName = "WindowArea"
```
To create notifications **outside** the application use 
```CSharp
areaName = ""
```
## NavigationService
Notifications are used by initialising a INavigationService with a [NavigationService](https://github.com/Fingann/FingannTemplate/blob/master/FingannTemplate/Services/Navigation/Interfaces/INavigationService.cs)
If you navigate to a view you need to define it in MainWindow.Xaml as a datatemplate under Window.Resources like this:
```Xaml
<DataTemplate DataType="{x:Type viewModels:MainPageViewModel}">
  <views:MainPageView/>
</DataTemplate>
```
To navigate to the MainPageView you can now call NavigateTo with the view model class name like this:

```CSharp
NavigationService.NavigateTo("MainPageViewModel")
```


