# PresentationFramework.Fluent#NET48

**PresentationFramework.Fluent#NET48** is a port of the Fluent theme from .NET Core 10 to **.NET Framework 4.8**. The project aims to enable using Fluent-style UI for standard WPF controls on the legacy Framework 4.8.

---

## Overview

The Fluent theme is well-known in .NET Core/10 as a modern Windows 10/11 theme with transparent elements, smooth animations, and a contemporary UI design. In the original version, many resources and styles use internal types and ComponentResourceKey, which are not supported in Framework 4.8.

This port:

- Brings core styles for **Window, Button, TextBox, ComboBox, Calendar, DataGrid**, and other standard controls.
- Replaces internal keys with **public resources**, accessible at runtime in Framework 4.8.
- Supports **DynamicResource and StaticResource for colors, brushes, and ControlTemplates**.
- Allows including the Fluent theme either as an external ResourceDictionary or directly in your App.xaml.

---

## Features

- Fully functional styles for WPF controls on .NET Framework 4.8.
- HighContrast mode support via `SystemParameters.HighContrast`.
- Easy integration into your project:
  ```xaml
  <Application.Resources>
      <ResourceDictionary>
          <ResourceDictionary.MergedDictionaries>
              <ResourceDictionary Source="/PresentationFramework.Fluent;component/Themes/Fluent.Dark.xaml"/>
          </ResourceDictionary.MergedDictionaries>
      </ResourceDictionary>
  </Application.Resources>
  ```