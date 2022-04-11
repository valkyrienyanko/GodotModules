# Godot Template
A collection of useful modules and scripts that can easily be ported into other C# Godot games.

Ideally you would clone this entire repository and use it as a template for your game but if you just want one module, there are specific setup instructions written out in each module page.

## Modules
### [ModLoader](https://github.com/valkyrienyanko/GodotModules/blob/main/MOD_LOADER.md)  
![image](https://user-images.githubusercontent.com/6277739/162651881-b8f98aa5-da2a-4499-b4dd-737a64dec4a9.png)  

### [Options](https://github.com/valkyrienyanko/GodotModules/blob/main/OPTIONS.md)  
![image](https://user-images.githubusercontent.com/6277739/162651901-f3df3cbd-df78-4bfa-814b-00b8e3ab2f6f.png)  

### ENet (planned)

## Utils
On top of all the modules there are also useful manager / utility scripts in `res://Global/` and `res://Scripts/`

```cs
// Load and play music
MusicManager.Load("menu theme", pathToMusic);
MusicManager.Play("menu theme");
MusicManager.SetVolume(50) // value ranges from 0 to 100
MusicManager.Pause();
MusicManager.Resume();

// Exit and do clean up
GameManager.Exit();

// FileManager
FileManager.GetProjectPath(); // non-exported = "res://", exported = next to the game exe
FileManager.GetConfig(path);
FileManager.WriteConfig<T>(path);
FileManager.WriteConfig(path, data);

// Utils
var someValue = 24f;
someValue.Remap(0, 100, -40, 80); //remap someValue from range 0-100 to range -40-80
```

## Contributing
See [CONTRIBUTING.md](https://github.com/valkyrienyanko/GodotLuaModdingTest/blob/main/CONTRIBUTING.md)
