
  # PresentationFramework.Fluent#NET48

**PresentationFramework.Fluent#NET48** — це порт Fluent теми з .NET Core 10 на **.NET Framework 4.8**. Мета проєкту — забезпечити можливість використовувати Fluent стиль для стандартних WPF елементів на доісторичному Framework 4.8.

---

## Огляд

Fluent тема відома у .NET Core/10 як сучасна тема Windows 10/11 з прозорими елементами, плавними анімаціями та сучасним дизайном UI. В оригінальній версії багато ресурсів і стилів використовують внутрішні типи і ComponentResourceKey, що не підтримуються у Framework 4.8.

Цей порт:

- Переносить основні стилі для **Window, Button, TextBox, ComboBox, Calendar, DataGrid** та інших стандартних елементів.
- Замінює internal ключі на **публічні ресурси**, доступні у рантаймі Framework 4.8.
- Підтримує **DynamicResource і StaticResource для кольорів, Brushes і ControlTemplates**.
- Дозволяє підключати Fluent тему як зовнішній ResourceDictionary або інтегрувати у ваш App.xaml.

---

## Особливості

- Повністю функціональні стилі для елементів WPF на .NET Framework 4.8.
- Підтримка HighContrast режиму через `SystemParameters.HighContrast`.
- Просте підключення у вашому проєкті:
  ```xaml
  <Application.Resources>
      <ResourceDictionary>
          <ResourceDictionary.MergedDictionaries>
              <ResourceDictionary Source="/PresentationFramework.Fluent;component/Themes/Fluent.Dark.xaml"/>
          </ResourceDictionary.MergedDictionaries>
      </ResourceDictionary>
  </Application.Resources>
  ```