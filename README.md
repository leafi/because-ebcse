because-ebcse
=============

To build, just run xbuild or msbuild or build in Visual Studio.

...And fix all the tool paths in the .csproj.

...And if you're not on Unix, fix/hack the build script so it doesn't use 'sed' anymore.

...And if you're not on Mac OS X, replace the hdiutil attach stuff with appropriate tools for mounting the
 loopback image or just hack one up yourself.
 

Yeah, so the build doesn't work so great for people who aren't me right now.  That'll be fixed eventually.
