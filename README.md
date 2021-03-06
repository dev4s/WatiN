## Behind story
This is my work on the WatiN source code. As one of my projects is still reusing the WatiN (it's a good library for automated testing) I needed to make some changes to the source code. I'm leaving some of the original things, but some of them will be removed.

## Planned roadmap
- [x] Cleaning the project.
- [x] Move project to VS2017.
- [x] Change .Net version.
- [x] Reuse Nuget for the needed libraries (and use newer ones, we like this :)).
- [ ] Support for newer browsers:
    - [ ] Firefox (without JSSH, need to find what should be used).
    - [ ] Chrome (Jeroen started worked on it, but it's in reaaalllyyy unstable place).
    - [ ] IE 11 (Windows 10), Edge. (I don't think that IE 10 will be necessary [it should work, but I don't think it should support it]).
    - [ ] PhantomJS, Firefox -headless.
    - [ ] Firefox for Android
    - [ ] Firefox OS
- [ ] Move browsers support to external libraries, should reduce dependencies and also allow to write plugins for other "browsers".
- [ ] Fix tests (almost all of them, moqs).
- [ ] Remove documentation links to original page.
- [ ] Fix examples folder.

## Credits
@Jeroen van Menen - for the awesome work on this.

## Notes
- I know that there are currently better options to automate browsers, but WatiN was so easy to use ;)

### Firefox usage
- close all running instances of Firefox
- run Firefox
- go to about:config
- find and change:

Preference Name                       | Value   | Comment
--------------------------------------|---------|---------
`devtools.debugger.remote-enabled`    | `true`  | Required
`devtools.chrome.enabled`             | `true`  | Required
`devtools.debugger.prompt-connection` | `false` | Recommended

## Original readme.txt (this will be removed/changed in future)

### Welcome
Thanks for dowloading WatiN. WatiN (pronounced "what-in") stands for Web Application Testing 
in dotNet. Inspired by Watir, WatiN enables web application testing, through Internet Explorer 
on a Windows platform, expressed in any .Net language.
 
Visit ~~http://watin.org~~ for more information and to download the latest version. 

### License
WatiN is Apache License 2.0 licensed so before using WatiN please read the license.txt so you know
the terms and conditions for using and modifying WatiN.

### Pre requisits
- WatiN can only be run on a Windows operating system
- Make sure you have a working IE6, IE7, IE8, IE9, Firefox 2 or Firefox 3.x installed on your machine.
- The .Net 2.0 or later framework needs to be installed.

### ~~Installing WatiN~~
- ~~Create an installation directory like C:\Program Files\WatiN <versionnumber>.~~
- ~~unzip the files in this zip file to the installation directory.~~
- ~~ready!~~

### Using WatiN
Following are the basic steps:
- Create a new project in Visual Studio 2005/2008/2010 (or another dev tool like SharpDevelop).
- Add a reference to WatiN.Core.dll in the installation directory.
- Start coding and exploring the object model (See the code files in the UnitTests directory 
  for code examples).

For a more complete example visit ~~http://watin.org/documentation/getting-started/~~.
For more documentation about (using) WatiN visit ~~http://watin.org/documentation/~~.
Or read my blogposts at ~~http://watinandmore.blogspot.com~~ (no new updates)

### Support
Subscribe to the mailinglist(s) and/or use the bug and feature tracker on 
~~http://sourceforge.net/projects/watin~~ (not maintaned) for the intended purposes.
(Note: [SourceForge - feature-requests (not maintained)](https://sourceforge.net/p/watin/feature-requests/), [SourceForge - bugs (not maintained)](https://sourceforge.net/p/watin/bugs/))

Enjoy testing with WatiN!

Copyright Jeroen van Menen 2011
