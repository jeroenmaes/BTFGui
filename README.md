# BTFGui [![Build status](https://ci.appveyor.com/api/projects/status/mdnke51a2p0590xw?svg=true)](https://ci.appveyor.com/project/joenmaes/btfgui)
A simple windows GUI for managing BizTalk Server, built upon the BizTalkFactory Management Automation SDK.
Use it on your BizTalk Server to quickly do some administration, without the need to use the slow BizTalk Management Console.

![BTF GUI 0.1](http://i.imgur.com/xRezISe.png)

## What can it do?

  * Stop/Restart HostInstances
  * Stop/Restart Applications
  * Remote Applications
  * Export Application Bindings
  * Terminate Suspended Instances

## What it currently can't do... (aka planned features)

 * Work in a multi-server environment
 * GAC Remove BizTalk assemblies
 * Export MSI's

## How does it work?
The application is just a simple C# Winforms app that uses the [BizTalkFactory Management Automation SDK](https://psbiztalk.codeplex.com/#biztalkfactory_management_automation) to do it tasks.

## Disclaimer
Make sure to have a backup of your complete environment when using this tool! Use at own risk...

## LICENSE
BTFGui is licensed under the [MIT License](https://github.com/joenmaes/BTFGui/blob/master/LICENSE) ([OSI](http://www.opensource.org/licenses/mit-license.php)). Basically you're free to do whatever you want with it. Attribution not necessary but appreciated.

## Dependencies
BTFGui depends on the [BizTalkFactory PowerShell Provider](https://psbiztalk.codeplex.com). It works with version 1.4.0.1. Download and install it.
