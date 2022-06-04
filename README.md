# LaCunaServer

[![GitHub Workflow Status](https://img.shields.io/github/workflow/status/RavencoinGaming/LaCunaServer/Build?style=for-the-badge)](https://github.com/RavencoinGaming/LaCunaServer/actions)

Also known as "The Cycle: Frontier".

This repository is just something I work on when bored, do not expect much at this stage.

## Features

- [x] Connect with localhost instead of official servers
- [ ] Basic authentication
- [ ] Basic lobby functionality
- [ ] CloudScript
- [ ] ?

## API Development setup

### 1. Download the game

If you are enrolled into the closed beta, you can download a fresh copy with [SteamRE/DepotDownloader](https://github.com/SteamRE/DepotDownloader).

```
.\DepotDownloader.exe -app 1600360 -depot 1600361 -manifest 720055916602660127 -username <username>
```

This gives you the [exact copy](https://steamdb.info/depot/1600361/history/?changeid=M:720055916602660127) that is used for this repository.

### 2. Download the latest launcher

Navigate to the [latest successful](https://github.com/RavencoinGaming/LaCunaServer/actions) build. Extract the launcher files to a directory.

Run the launcher with the first argument being the path of step 1.
```
./SOS.exe "C:\Users\Kathi\Desktop\Spiele\SOSPrivateServer\SOS ALPHA\Outpost Games\Games\SOS"
```

### 3. Clone the repository

```
git clone https://github.com/RavencoinGaming/LaCunaServer.git
```

### 4. Open the solution

Open the `src/LaCunaServer.sln` in either Rider or Visual Studio.
