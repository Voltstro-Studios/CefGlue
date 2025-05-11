# CefGlue

This repo is a fork of the original [CefGlue](https://gitlab.com/xiliumhq/chromiumembedded/cefglue) project. Used by [UnityWebBrowser](https://github.com/Voltstro-Studios/UnityWebBrowser).

Currently updated to CEF `136.1.1+g4dec9aa+chromium-136.0.7103.33`.

## Changes

- Updated CEF
- Support for .NET 8
- Removed some old demos/samples
- Some other minors changes that we done over the years that I cannot remember

## Updating CEF

1. First, download the latest stable [build of CEF](https://cef-builds.spotifycdn.com/index.html). Minimal distribution is fine.

2. Extract `include` folder to `CefGlue.Interop.Gen/include`. 

3. Run `gen-cef3` script.

4. See if project compiles. If not, fix compile errors. Errors may include new handlers or removed methods.

5. Check `cef_types.h` for any additional changes done to the types that need to be manually written (Such as `cef_settings_t` to `CefSettings`).

6. See if demo project works. Make sure to extract `Release` and `Resources` from the downloaded CEF build to the build folder of the demo (`Demos/CefGlue.Demo.WinForms/bin/Debug/net8.0-windows`).

7. Remove any old unused files.

8. Bump version in `CefGlue.csproj`.
