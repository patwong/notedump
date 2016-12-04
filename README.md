# notedump

organizes my notepad files into one simple Windows application. written in C# (Visual Studio 2015).

# but why?

too many notepad files (.txt) spread across my computer's filesystem, whose contents all fall under reminders to myself, random news links, and movie+music recommendations. instead triggering my ocd by having multiple tabs up in my web browser or notepad++, this application relieves the ocd panic attack by providing an outlet of release.

# how to use

doubleclicking any subtab (child of a main tab) will pop open a textbox associated to the tab (notepad file). "movies" is the only main tab that is doubleclickable.

menu options are straightforward with the exception of "get status" - the active tab will be displayed in the status bar on the bottom of the application. useful because i didn't implement the default active tab to be the currently visible tab. in most cases, the currently active tab is the visible tab. when switching between menu tabs the default active tab is the menu itself, not the visible child tab. 

tl;dr: "get status" exists as a sanity check

# how to compile

use GitHub add-on in Visual Studio (older versions of Visual Studio might not support add-ons), fork project, and build project using either "debug" or "build" option.

if using "debug" option, a usable .exe will be located in \<project folder\>\notedump\bin\debug

if "release" option chosen, usable .exe will be located in \<project folder\>\notedump\bin\release

compiled exe available by request

# future additions

- tutorial video
- smarter "active" tab system, i.e. visible tab should automatically be the active tab
- dynamic tab system, i.e. can create new tabs and choose to close it. new tabs would have default option to be "stickied" on the application on subsequent loads. new tabs would have an option that appears on right clicking of the tab that allows you to "close" the tab.
- help menu

# license

The MIT License (MIT)

Copyright (c) 2016 Patrick Wong \<<patrick.wong@uwaterloo.ca>\>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
