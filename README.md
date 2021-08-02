## AudioPlayer
### Description
Basic MP3 audio file player.

### Download
#### -- Installer --
[AudioPlayer-Setup.exe](https://github.com/sh4d0w4RCH3R415/AudioPlayer/releases/download/1.0.0/AudioPlayer-Setup.exe)

#### -- Portable --
[AudioPlayer.zip](https://github.com/sh4d0w4RCH3R415/AudioPlayer/releases/download/1.0.0/AudioPlayer.zip)

### Code It Yourself
***WMPLib required for this*** -- [WMPLib (NuGet)](https://www.nuget.org/packages/WMPLib)
```csharp
using WMPLib;

WindowsMediaPlayer audioPlayer = new WindowsMediaPlayer();
audioPlayer.URL = "AudioFile.mp3"; // replace the 'AudioFile.mp3' with the path to your audio file
audioPlayer.controls.play();
```
