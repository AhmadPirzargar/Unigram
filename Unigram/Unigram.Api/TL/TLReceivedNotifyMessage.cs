// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLReceivedNotifyMessage : TLObject 
	{
		public Int32 Id { get; set; }
		public Int32 Flags { get; set; }

		public TLReceivedNotifyMessage() { }
		public TLReceivedNotifyMessage(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ReceivedNotifyMessage; } }

		public override void Read(TLBinaryReader from)
		{
			Id = from.ReadInt32();
			Flags = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(Id);
			to.WriteInt32(Flags);
		}
	}
}