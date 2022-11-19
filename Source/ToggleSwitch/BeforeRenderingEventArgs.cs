using System.Runtime.CompilerServices;

using JCS;

namespace BirdBrainmofo.ToggleSwitch
{
	// Token: 0x0200003F RID: 63
	public class BeforeRenderingEventArgs
	{
		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600026E RID: 622 RVA: 0x000078C9 File Offset: 0x00005AC9
		// (set) Token: 0x0600026F RID: 623 RVA: 0x000078D1 File Offset: 0x00005AD1
        public ToggleSwitchRendererBase Renderer;

		// Token: 0x06000270 RID: 624 RVA: 0x000078DA File Offset: 0x00005ADA
		public BeforeRenderingEventArgs(ToggleSwitchRendererBase renderer)
		{
			Renderer = renderer;
		}


	}
}
