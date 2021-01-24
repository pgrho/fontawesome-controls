# Shipwreck.FontAwesomeControls

A WPF/Xamarin.Forms library to parse and show Font Awesome 5 Free icon classes.

## Usage

### WPF

1. Install `Shipwreck.FontAwesomeControls.PresentationFramework.dll` from [NuGet](https://www.nuget.org/packages/Shipwreck.FontAwesomeControls.PresentationFramework).
2. Add XMLNS `http://schema.shipwreck.jp/fontawesome5/`.

```xml
<Window
    ...
    xmlns:fa="http://schema.shipwreck.jp/fontawesome5/"
    ...
    >
</Window>
```

3. Use `FontAwesomeTextBlock` and set `Icon` property.

```xml
<fa:FontAwesomeTextBlock
    Icon="fas fa-pulse fa-spinner" />
```

### Xamarin.Forms

1. Install `Shipwreck.FontAwesomeControls.XamarinForms.dll` from [NuGet](https://www.nuget.org/packages/Shipwreck.FontAwesomeControls.XamarinForms).
2. Add XMLNS `http://schema.shipwreck.jp/fontawesome5/`.
```xml
<ContentPage
    ...
    xmlns:fa="http://schema.shipwreck.jp/fontawesome5/"
    ...
    >
</ContentPage>
```

3. Use `FontAwesomeLabel` and set `Icon` property.

```xml
<fa:FontAwesomeLabel
    Icon="fas fa-pulse fa-spinner" />
```

## License

- Fonts: Embedded from Font Awesome Free under SIL OFL 1.1 License.
- Codes: The MIT License
