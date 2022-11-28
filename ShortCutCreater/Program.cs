using IWshRuntimeLibrary;

string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
string startUp = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
string pictures = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

string FileName = "AnyDesk.exe";
string FileLocation = Path.Combine(desktop, FileName);
string shortCutLocation = Path.Combine(startUp, FileName + ".lnk");
string shortCutDescription = "This shortcut created by Slhkl with console application";
string shortCutIconLocation = Path.Combine(pictures, "Saved Pictures", "app.ico");

WshShell shell = new WshShell();
IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortCutLocation);

shortcut.Description = shortCutDescription;
shortcut.IconLocation = shortCutIconLocation;
shortcut.TargetPath = FileLocation;
shortcut.Save();