using GHIElectronics.TinyCLR.Pins;
using GHIElectronics.TinyCLR.Devices.Gpio;

namespace ImplicateX.TinyCLR.Drivers.Adapter.Network
{
	internal class Program
	{
		public static class ControllerPin
		{
			public const int EthernetCS = FEZFeather.GpioPin.PA3; // 6
			/// <summary>Audio codec SPI MISO pin.</summary>
			public const int EthernetSCLK = FEZFeather.GpioPin.PE12; // 11

			/// <summary>Ethernet SPI MOSI pin.</summary>
			public const int EthernetMOSI = FEZFeather.GpioPin.PE14; // 12

			/// <summary>Ethernet SPI MISO pin.</summary>
			public const int EthernetMISO = FEZFeather.GpioPin.PE13; // 13

			/// <summary>Ethernet interrupt input pin.</summary>
			public const int EthernetINT = FEZFeather.GpioPin.PA10; // 14

			/// <summary>Ethernet reset pin.</summary>
			public const int EthernetReset = FEZFeather.GpioPin.PA9; // 15
		}

		private static GpioController gpioController;

		static void Main()
		{
			gpioController = GpioController.GetDefault();

		}
	}
}
