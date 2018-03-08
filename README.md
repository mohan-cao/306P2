﻿<div align="center">
<a href="https://github.com/mohan-cao/306P2"><img style="display:inline-block;" src="./bmlogo.png" alt="Our logo WIP"></a>
<br>
</div>

# Execution Instructions
* Run the .exe with "Fantastic" option selected under Graphics Quality. (Else buttons eg Journal may not be sensitive due to Unity issues)
* Use directional arrow keys to move player
* Walk into a character or item to interact
* Press [Space] to continue interactions with NPCs via dialogue
* Press [X] to move between rooms
* There is also an [X] button on the buttom right of the screen


# Setting Up
1. Set up Git LFS. https://git-lfs.github.com/
2. Set up Unity for Git. 
3. Set up automerging of scene files using Unity's YAMLMerge
    - Append the following in the ~/.gitconfig configuration file, replacing the path to the YAML Merge tool with the merge tool location (generally follows a similar directory structure):

For Windows:
```
[merge]
	tool = unityyamlmerge

[mergetool "unityyamlmerge"]
	trustExitCode = false
	cmd = 'C:\Program Files\Unity\Editor\Data\Tools\UnityYAMLMerge.exe' merge -p "$BASE" "$REMOTE" "$LOCAL" "$MERGED"
```

For Mac:
```
[merge]
	tool = unityyamlmerge

[mergetool "unityyamlmerge"]
	trustExitCode = false
	cmd = '/Applications/Unity/Unity.app/Contents/Tools/UnityYAMLMerge' merge -p "$BASE" "$REMOTE" "$LOCAL" "$MERGED"
```

For versions of Unity 3D v4.3 and up:

1. (Skip this step in v4.5 and up) Enable External option in Unity → Preferences → Packages → Repository.
2. Open the Edit menu and pick Project Settings → Editor:
    1. Switch Version Control Mode to Visible Meta Files.
    2. Switch Asset Serialization Mode to Force Text.
3. Save the scene and project from File menu.

# Adding Binary Files to be Tracked
Since we are gitignoring binary files and large files, we have to use Git large file storage to track changes to these files efficiently.
https://help.github.com/articles/configuring-git-large-file-storage/

Generally, use `git lfs track "*.ext"` to track a file of type extension if you find that the file you want to track is not being added.

# Development Team

| Name         | UPI     | GitHub    |
| ------------ | ------- | --------- |
| Abby Shen    | [ashe848](mailto:ashe848@aucklanduni.ac.nz) | [ashe848](http://www.github.com/ashe848) |
| Andrew Lyall    | [alya691](mailto:alya691@aucklanduni.ac.nz) | [Scoobster](http://www.github.com/Scoobster) |
| Brad Miller    | [bmil852](mailto:bmil852@aucklanduni.ac.nz) | [bmil852](http://www.github.com/bmil852) + commits from 'unknown' |
| Mohan Cao    | [mcao024](mailto:mcao024@aucklanduni.ac.nz) | [mohan-cao](http://www.github.com/mohan-cao) |
| Michael Kemp | [mkem114](mailto:mkem114@aucklanduni.ac.nz) | [mkem114](http://www.github.com/mkem114)   |
| Sejal Patel    | [spt098](mailto:spt098@aucklanduni.ac.nz) | [sejpat25](http://www.github.com/sejpat25) |
| Sidharth Parthasarathy   | [spar743](mailto:spar743@aucklanduni.ac.nz) | [sidpartha1](http://www.github.com/sidpartha1) |
| Terran Kroft | [tkro003](mailto:tkro003@aucklanduni.ac.nz) | [itemic](http://www.github.com/itemic)    |
