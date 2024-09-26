# BioPulseRpi
1. Install libraries on rpi:
* sudo apt update
* sudo apt upgrade
* sudo reboot
* sudo apt-get install libgbm1 libgl1-mesa-dri libegl1-mesa libinput10

2. Deploy on rpi:
  dotnet publish -c Release -o publish -r linux-arm -p:PublishReadyToRun=true -p:PublishSingleFile=true -p:PublishTrimmed=true --self-contained true -p:IncludeNativeLibrariesForSelfExtract=true

3. Run on rpi:
   sudo chmod +x /path/to/app/AvaloniaRaspbianLiteDrm
   sudo ./path/to/app/AvaloniaRaspbianLiteDrm --drm  OR  sudo ./path/to/app/AvaloniaRaspbianLiteDrm --fbdev
