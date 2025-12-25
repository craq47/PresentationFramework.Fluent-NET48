
  # PresentationFramework.Fluent#NET48

**PresentationFramework.Fluent#NET48** — öå ïîðò Fluent òåìè ç .NET Core 10 íà **.NET Framework 4.8**. Ìåòà ïðîºêòó — çàáåçïå÷èòè ìîæëèâ³ñòü âèêîðèñòîâóâàòè Fluent ñòèëü äëÿ ñòàíäàðòíèõ WPF åëåìåíò³â íà äî³ñòîðè÷íîìó Framework 4.8.

---

## Îãëÿä

Fluent òåìà â³äîìà ó .NET Core/10 ÿê ñó÷àñíà òåìà Windows 10/11 ç ïðîçîðèìè åëåìåíòàìè, ïëàâíèìè àí³ìàö³ÿìè òà ñó÷àñíèì äèçàéíîì UI. Â îðèã³íàëüí³é âåðñ³¿ áàãàòî ðåñóðñ³â ³ ñòèë³â âèêîðèñòîâóþòü âíóòð³øí³ òèïè ³ ComponentResourceKey, ùî íå ï³äòðèìóþòüñÿ ó Framework 4.8.

![Theme Preview](Resources/%D0%97%D0%BD%D1%96%D0%BC%D0%BE%D0%BA%20%D0%B5%D0%BA%D1%80%D0%B0%D0%BD%D0%B0%202025-12-25%20194027.png)

Öåé ïîðò:

- Ïåðåíîñèòü îñíîâí³ ñòèë³ äëÿ **Window, Button, TextBox, ComboBox, Calendar, DataGrid** òà ³íøèõ ñòàíäàðòíèõ åëåìåíò³â.
- Çàì³íþº internal êëþ÷³ íà **ïóáë³÷í³ ðåñóðñè**, äîñòóïí³ ó ðàíòàéì³ Framework 4.8.
- Ï³äòðèìóº **DynamicResource ³ StaticResource äëÿ êîëüîð³â, Brushes ³ ControlTemplates**.
- Äîçâîëÿº ï³äêëþ÷àòè Fluent òåìó ÿê çîâí³øí³é ResourceDictionary àáî ³íòåãðóâàòè ó âàø App.xaml.

---

## Îñîáëèâîñò³

- Ïîâí³ñòþ ôóíêö³îíàëüí³ ñòèë³ äëÿ åëåìåíò³â WPF íà .NET Framework 4.8.
- Ï³äòðèìêà HighContrast ðåæèìó ÷åðåç `SystemParameters.HighContrast`.
- Ïðîñòå ï³äêëþ÷åííÿ ó âàøîìó ïðîºêò³:
  ```xaml
  <Application.Resources>
      <ResourceDictionary>
          <ResourceDictionary.MergedDictionaries>
              <ResourceDictionary Source="/PresentationFramework.Fluent;component/Themes/Fluent.Dark.xaml"/>
          </ResourceDictionary.MergedDictionaries>
      </ResourceDictionary>
  </Application.Resources>
  ```
