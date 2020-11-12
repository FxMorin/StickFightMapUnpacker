# StickFightMapUnpacker
A map unpacker/packer tool for Stick Fight: The Game. Allows you to unpack the map files as json, then repack them so you can use them in game! 

File locations may differ!

Where to find your local Stick Fight Maps: `C:\Users\<username>\AppData\LocalLow\Landfall West\Stick Fight_ The Game\CustomLevels`

Where to find your online Stick Fight Maps: `C:\Program Files (x86)\Steam\steamapps\Workshop\Content\674940`

### How to use Stick Fight Map Unpacker (SFMU)
Using SFMU is actually really easy.
1. Go to the releases tab
2. Download the latest release zip
3. unzip the zip...
4. Open Command Prompt
5. CD into the folder, command: `cd <location>`
6. Run the SFMU command

SFMU Commands:
`SFMU.exe <input> <output>`
Use a .bin as your input & a .json as your output to unpack the .bin into the .json file
Use a .json as your input & a .bin as your output to pack the .json into the .bin file

___

Technically speaking this is not exactly an unpacker. The Stick Fight saves are not stored in JSON, they are stored in serialized C# objects. This tool unserializes them back into C# objects (classes) then uses Newtonsoft JS to convert the classes into JSON. The process is then reversed to save ;)

___

Enjoy!

Need more help: https://discord.gg/rcTjvxq/

Watch my videos: https://youtube.com/c/fx-modding/
