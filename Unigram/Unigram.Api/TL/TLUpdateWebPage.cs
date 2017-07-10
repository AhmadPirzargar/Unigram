// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLUpdateWebPage : TLUpdateBase, ITLMultiPts 
	{
		public TLWebPageBase WebPage { get; set; }
		public Int32 Pts { get; set; }
		public Int32 PtsCount { get; set; }

		public TLUpdateWebPage() { }
		public TLUpdateWebPage(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateWebPage; } }

		public override void Read(TLBinaryReader from)
		{
			WebPage = TLFactory.Read<TLWebPageBase>(from);
			Pts = from.ReadInt32();
			PtsCount = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(WebPage);
			to.WriteInt32(Pts);
			to.WriteInt32(PtsCount);
		}
	}
}