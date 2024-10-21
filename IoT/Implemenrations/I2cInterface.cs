using System;
using System.Device.I2c;
using System.Threading.Tasks;

// busId the I2c device is connected to and deviceAddress of the I2C device
using I2cDevice i2cDevice = I2cDevice.Create(new I2cConnectionSettings(1,0x20));

i2cDevice.Write([0x00, 0xFF]);

await Task.Delay(TimeSpan.FromMilliseconds(200));

i2cDevice.Write([0x00, 0x00]);
