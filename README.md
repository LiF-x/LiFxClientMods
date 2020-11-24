## LiFx - Client Mods

##### Join us on our discord and take part in the community
[![Widget for the Discord API guild](https://discord.com/api/guilds/779866175134892082/widget.png?style=shield)](https://discord.gg/EH9b6tqQ4C)
---

### LiFx Mod Autoloader
* **[core.zip](https://github.com/LiF-x/LiFxClientMods/blob/main/core.zip)**
  * All our client mods will be autoloaded via the **core.zip** file making it simple and easy to add both initially and subsequent mods we develop. To install the autoloader copy the core.zip into your Life is Feudal:YO root folder. In most cases that's "*\Steam\steamapps\common\Life is Feudal Your Own\*" You do not need to unzip it.
  * All our mods use a common **/mods/** folder so you will need to create this folder in the Life is Feudal:YO root folder so you can place any desired mods into the /mods/ folder where it will be autoloaded.
  
* If you would like to develop mods that are compatible with the LiFx Mod Autoloader you will need to follow the following framework with your mod.
    * Your Mod must use the **/mods/** folder path.
    * Your Mod must have an **init.cs** file in your mods root folder that calls all **exec's** within your mod.

* The autoloader removes the need to manually edit your main.cs or init.cs files and looks for those commands within each mods root folder instead. For any questions or support please visit our LiFx Community discord: https://discord.gg/EH9b6tqQ4C

&nbsp; 
### LiFx Origional Mods
* **LiFx-Larger-Inventories**
  * There are many like it, but this one is ours!

&nbsp; 
### LiFx Modified Mods
* **[https://skunkfu.net/sf-gm-tools/](https://skunkfu.net/sf-gm-tools/)**
  * Added: LocationBar which when in GM Mode shows your current position/coords.
  * Updated: InfoBar (Time/Date), to not show unless in GM Mode.
  
* **[BadilMod:BasilLoader](https://lifeisfeudal.com/forum/basilmod-pack-t14651/)**
  * Added a basilmod folder in /mods/ with an init.cs file insite to load the mod. Just copy the basilmod folder with the init.cs file into your /mods/ folder and you will not need to edit the main.cs file as the FiFx Autoloader will do it.
  * For basilmod specific support visit: https://lifeisfeudal.com/forum/basilmod-pack-t14651/


&nbsp; 
&nbsp; 
---
##### Licenced with: [GPL V3.0](LICENSE)
