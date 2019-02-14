# Skeleton Theme for DSTEd
This is an skeleton Theme for DSTEd.

## Build instructions
You must rename the vaiable `$NAME` on all `directorys`, `filenames` and `contents` with your theme name!

## Installation
Go to `IDE.xaml.cs` and set your theme on `this.dockManager.Theme`.

For sample:
```cs
this.dockManager.Theme = new $NAME();
```

***@ToDo***
 - Create an generator script for renaming `$NAME`
