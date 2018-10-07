using System.Windows.Forms;

namespace Shlok.BoilerPlateApp
{
	public class CustomUserControl : UserControl
	{
		public virtual CustomUserControl Instance { get; }

		public virtual void Load() { }
	}
}
