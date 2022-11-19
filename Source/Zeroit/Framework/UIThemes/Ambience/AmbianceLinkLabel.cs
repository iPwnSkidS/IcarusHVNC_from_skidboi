using System.Drawing;
using System.Windows.Forms;

namespace BirdBrainmofo.Zeroit.Framework.UIThemes.Ambience
{
	// Token: 0x0200005B RID: 91
	public class AmbianceLinkLabel : LinkLabel
	{
		// Token: 0x0600051E RID: 1310 RVA: 0x000235EC File Offset: 0x000217EC
		public AmbianceLinkLabel()
		{
			Font = new Font("Segoe UI", 11f, FontStyle.Regular);
			BackColor = Color.Transparent;
			LinkColor = Color.FromArgb(240, 119, 70);
			ActiveLinkColor = Color.FromArgb(221, 72, 20);
			VisitedLinkColor = Color.FromArgb(240, 119, 70);
			LinkBehavior = LinkBehavior.AlwaysUnderline;
		}
	}
}
