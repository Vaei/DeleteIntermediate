# DeleteIntermediate
Deletes a project's intermediate folders (including plugins)

The purpose is to have a shortcut that when executed will delete all "Intermediate" folders from the project and all plugins.

This is an exceedingly simple C# helper application. Check Program.cs to view the entirety of the tiny code-base.

Helpful for cleaning a project.

[See the sister application here to delete Binaries folders.](https://github.com/Vaei/DeleteIntermediate)

## How to Use

1. Create a shortcut to `DeleteIntermediate\DeleteIntermediate\bin\Release\net6.0\DeleteIntermediate.exe`
2. Place it in your project folder alongside the `.uproject` file
3. Clear the "Start In" field. This is vitally important, it will not work otherwise. This field must be empty.
