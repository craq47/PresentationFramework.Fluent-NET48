
  # PresentationFramework.Fluent#NET48

**PresentationFramework.Fluent#NET48** — це порт Fluent теми з .NET 10 на **.NET Framework 4.8**. Мета проєкту — забезпечити можливість використовувати Fluent стиль для стандартних WPF елементів на доісторичному Framework 4.8.

---

## Огляд

Fluent тема відома у **.NET 10** як сучасна тема **Windows 11** із прозорими елементами, плавними анімаціями та сучасним дизайном UI. В оригінальній версії багато ресурсів і стилів використовують внутрішні типи і `ComponentResourceKey`, що не підтримуються у **Framework 4.8** напряму, вони були замінені на аналоги або закоментовані (дивіться `TODO`).

![Theme Preview](Resources/%D0%97%D0%BD%D1%96%D0%BC%D0%BE%D0%BA%20%D0%B5%D0%BA%D1%80%D0%B0%D0%BD%D0%B0%202025-12-25%20194027.png)

Цей порт:

- Переносить основні стилі для **Window, Button, TextBox, ComboBox, Calendar, DataGrid** та інших стандартних елементів.
- Замінює internal ключі на **публічні ресурси**, доступні у рантаймі Framework 4.8.
- Підтримує **DynamicResource** і **StaticResource** для кольорів, **Brushes** і **ControlTemplates**.
- Дозволяє підключати Fluent тему як зовнішній **ResourceDictionary** або інтегрувати у ваш `App.xaml`.

---

## Особливості

- Повністю функціональні стилі для елементів WPF на **.NET Framework 4.8**.
- Доступні 4 теми на вибір: `Fluent.Light`, `Fluent.Dark`, `Fluent` та `Fluent.HC` (High Contrast).
- Підтримка **HighContrast** режиму через `SystemParameters.HighContrast`.
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
