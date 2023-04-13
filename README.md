# Simple Lua Executor for Roblox

## This project uses API from <a href="https://wearedevs.net/home">WeAreDevs<a>
> See <a href="https://wearedevs.net/d/Exploit%20API">here<a> for more.

## Getting Started 
  1.) Download 

  3.) After running this command, you can return to Visual Studio and turn on hidden files - include any new ones in your project and the models subdir of your project.

For other options on installation see [Installing AutoRest](https://aka.ms/autorest/install) on the AutoRest github page.

---

## Configuration 
The following are the settings for generating this API with AutoRest.

``` yaml 
# specify the version of Autorest to use
version: 2.0.4262 
input-file: myApi.json

csharp:
  output-folder: ./
  namespace: MyCorp.MyApi.Client
  override-client-name: MyApiClientClassName
  add-credentials: false 

# (more settings here...)
```
