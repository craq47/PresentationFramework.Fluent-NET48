# PresentationFramework.Fluent#NET48

**PresentationFramework.Fluent#NET48** is a port of the Fluent theme from **.NET 10** to **.NET Framework 4.8**. The goal of this project is to make it possible to use the Fluent style for standard WPF controls on the legacy .NET Framework 4.8.

---

## Overview

The Fluent theme is well known in **.NET 10** as a modern **Windows 11** theme featuring transparent elements, smooth animations, and a contemporary UI design. In the original implementation, many resources and styles rely on internal types and `ComponentResourceKey`, which are not directly supported in **.NET Framework 4.8**. These parts were replaced with compatible alternatives or commented out (see `TODO` notes).

![Theme Preview](Resources/%D0%97%D0%BD%D1%96%D0%BC%D0%BE%D0%BA%20%D0%B5%D0%BA%D1%80%D0%B0%D0%BD%D0%B0%202025-12-25%20194027.png)

This port:

- Brings core styles for **Window, Button, TextBox, ComboBox, Calendar, DataGrid**, and other standard controls.
- Replaces internal keys with **public resources** accessible at runtime on .NET Framework 4.8.
- Supports **DynamicResource** and **StaticResource** for colors, **Brushes**, and **ControlTemplates**.
- Allows the Fluent theme to be included as an external **ResourceDictionary** or integrated directly into your `App.xaml`.

---

## Features

- Fully functional styles for WPF controls on **.NET Framework 4.8**.
- Four themes available: `Fluent.Light`, `Fluent.Dark`, `Fluent`, and `Fluent.HC` (High Contrast).
- **High Contrast** mode support via `SystemParameters.HighContrast`.
- Simple integration into your project:
  ```xaml
  <Application.Resources>
      <ResourceDictionary>
          <ResourceDictionary.MergedDictionaries>
              <ResourceDictionary Source="/PresentationFramework.Fluent;component/Themes/Fluent.Dark.xaml"/>
          </ResourceDictionary.MergedDictionaries>
      </ResourceDictionary>
  </Application.Resources>
  ```
