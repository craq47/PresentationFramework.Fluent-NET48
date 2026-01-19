  # PresentationFramework.Fluent#NET48

**PresentationFramework.Fluent#NET48** — це порт Fluent теми з .NET 9+ на **.NET Framework 4.8**. Мета проєкту — забезпечити мінімалістичне використання Fluent стилів для стандартних WPF елементів на доісторичному Framework 4.8. Лише необхідне, без зайвого.

Ви можете отримати Nuget-пакет за [цим посиланням](https://www.nuget.org/packages/PresentationFramework.Fluent).

    dotnet add package PresentationFramework.Fluent --version 1.0.0

## Огляд

Fluent тема відома у **.NET 9+** як сучасна тема **Windows 11** із прозорими елементами, плавними анімаціями та сучасним дизайном UI. В оригінальній версії багато ресурсів і стилів використовують внутрішні типи і та компоненти ресурсів (`ComponentResourceKey`), що не підтримуються у **Net Framework 4.8** напряму, вони були замінені на аналоги або закоментовані (дивіться `TODO`). Також порт надає усі стилі окремо, що дозволяє комбінувати їх у різних елементах.

![Theme Preview](Resources/%D0%97%D0%BD%D1%96%D0%BC%D0%BE%D0%BA%20%D0%B5%D0%BA%D1%80%D0%B0%D0%BD%D0%B0%202025-12-25%20194027.png)

#### Що робить цей порт:

- Переносить основні стилі для **Window, Button, TextBox, ComboBox, Calendar, DataGrid** та інших стандартних елементів.
- Замінює internal ключі на **публічні ресурси**, доступні у рантаймі Net Framework 4.8.
- Підтримує **DynamicResource** і **StaticResource** для кольорів, **Brushes** і **ControlTemplates**.
- Дозволяє підключати Fluent тему як зовнішній **ResourceDictionary** або інтегрувати у ваш `App.xaml`.

## Особливості

- ✅ Повністю функціональні стилі для елементів WPF на **.NET Framework 4.8**.
- ✅ Доступні **4** теми на вибір: `Fluent.Light`, `Fluent.Dark`, `Fluent` та `Fluent.HC` (High Contrast).
- ✅ Підтримка **HighContrast** режиму через `SystemParameters.HighContrast`.
- ✅ Просте підключення у вашому проєкті:
**App.xaml** — обов'язково, якщо ви плануєте використовувати `Designer`.
  ```xaml
  <Application.Resources>
      <ResourceDictionary>
          <ResourceDictionary.MergedDictionaries>
              <ResourceDictionary Source="/PresentationFramework.Fluent;component/Themes/Fluent.Dark.xaml"/>
          </ResourceDictionary.MergedDictionaries>
      </ResourceDictionary>
  </Application.Resources>
  ```
  **YourWindow.xaml** — обов'язково, якщо ви хочете, щоб фон вікна автоматично підтягувався з теми.
  ```xaml
  <Window x:Class="YourNamespace.MainWindow"
          xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
          xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      Title="YourWindow" Style="{StaticResource DefaultWindowStyle}">
  </Window>
  ```
---

###  ⛔ Що не підтримується:

Як вже було написано вище, не підтримуються деякі компоненти ресурсів, які є лише у **NET 9+**, окрім цього порт не підтримує:

- ❌ автовизначення системної теми
- ❌ автовизначення системних кольорів
- ❌ автоматичну зміну **TitleBar** та **SystemContextMenu** відповідно до теми  

Про те, як можна вирішити цю проблему читайте у наступному розділі.
 
## 💡 Використання разом з DarkNet:
Цей порт не змінює вигляд системних **Title Bar** та **Context Menu**, як це робить Net 9.0+. Так, це дійсно неприємно. Однак одним із шляхів вирішення цієї проблеми може стати використання бібліотеки **[DarkNet](https://github.com/Aldaviva/DarkNet?tab=readme-ov-file#wpf)**. Вона містить `SkinManager`, який дозволяє визначати Fluent теми наступним чином:

**YourWindow.xaml.cs**

  ```C#
	public MainWindow()
	{
	    InitializeComponent();

	    new SkinManager().RegisterSkins(
	        lightThemeResources: FluentHelper.LightThemeUri,
	        darkThemeResources: FluentHelper.DarkThemeUri);

	    DarkNet.Instance.SetWindowThemeWpf(this, Theme.Auto);
	}
  ```
  
  
<img width="801" height="458" alt="Image" src="https://github.com/user-attachments/assets/8a147f8c-070e-4a7c-82a0-2215f5c2c4b8" />