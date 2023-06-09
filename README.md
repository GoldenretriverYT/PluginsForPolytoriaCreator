# PluginsForPolytoriaCreator
Making Polytoria Creator usable by providing support for mods/plugins! This tool utilizes [MelonLoader](https://github.com/LavaGang/MelonLoader/) - a Unity Mono & IL2Cpp mod loader. Since the process of installing it
with Polytoria requires additional work than the normal installation I have decided to make this tool.

### hi guyz how 2 instal mod?
1. Download and extract PluginsForPolytoriaCreator (from now on "PfPC")
2. Run PfPC and press the "Install Loader/Sync" button on the top right corner
3. Once the loader installation is finished (you will see "Synced mods!" at the bottom status bar), you can click "Install from zip file"
4. In the opened file dialog, select a valid zipped mod (an example, "F2Rename", is provided in the release section)
5. You are done! Start Polytoria Creator and test if you can rename Instances using F2!

### pls tell how 2 make mod
1. The general modding process is the usual MelonLoader Modding Process, you can refer to this [documentation](https://melonwiki.xyz/#/modders/quickstart) but I have found it to be relatively outdated as of now, so you will have to adapt a bit.
2. Create a new folder and call it "files" - put your mod files in there.
3. Create a new file NEXT to the "files" folder and call it "meta.json"
4. Fill it with the appropriate information following the ModMeta schema.
5. Zip the files - make sure you dont have your files within a subfolder in the zip archive - they have to be at the root of the zip file.

### ModMeta Schema
```json
{
    "ModDisplayName": "string",
    "ModFolderName": "string",
    "MinCreatorVersion": long,
    "MaxCreatorVersion": long,
    "ModType": "string enum: Mod, UserLib"
}
```

### Creator Versions
As you have noticed, the creator version contains dots, but I expect you to provide a number? Well, its easy. Replace the dots with '0' and take the number without the dots. Thats your numeric version. I am not sure if this idea has flaws so if it has
please tell me and I will try to make a better numeric version "calculator"

## Future Plans
Future plans are: 
  - Install from GIT
  - Install multiple from single zip, basically multiple plugins/mods/userlibs bundled within one zip file
  - Public mods registry
  - Update mods directly
  - Maybe even provide some basic libraries to make modding easier
  - Maybe linux support (probably only cli commands though)
