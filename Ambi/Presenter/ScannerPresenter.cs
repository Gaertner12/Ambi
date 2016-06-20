using System;

using System.Threading.Tasks;

using ZXing.Mobile;
using ZXing;

namespace Ambi
{
	public class ScannerPresenter
	{
		public string id{ get; set;}

		public ScannerPresenter ()
		{
		}

		public async Task startScan(){
			//var scanner = new MobileBarcodeScanner();
			//var result = await scanner.Scan();

			this.id = "91523";
		}
	}
}

