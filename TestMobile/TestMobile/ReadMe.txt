This is the shared part of the user interface. This project doesn't get compiled
into an assembly, but every project A that includes this shared project B will be
able to use the files from B as if they were part of project A.

Each file in this shared project needs to support all target platforms. In general
one should attempt to make the code (C# and XAML) generic and platform independent.
When this is not possible, compiler directives or run-time checks can be used. If
your code is riddles with these checks, you should consider moving some code to the
platform specific projects (using a DependencyService interface or custom renderers).

This projects contains a DependecyService interface: IColors. This interface is 
implemented by each platform project (each project contains a PlatformColors.cs 
file with a platform specific implementation). The IColors interface is used in the
BoolToColorConverter.cs file.

Interface elements in this project can be 'overloaded'. For example, the UWP and iOS
project provide a ButtonRenderer which inherit from the default ButtonRenderer and
add some tweaking of the parameters. This new ButtonRenderer is registered to be 
used for all Button rendering in that project.