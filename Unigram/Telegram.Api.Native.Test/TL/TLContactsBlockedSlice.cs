// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLContactsBlockedSlice : TLContactsBlockedBase 
	{
		public Int32 Count { get; set; }

		public TLContactsBlockedSlice() { }
		public TLContactsBlockedSlice(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ContactsBlockedSlice; } }

		public override void Read(TLBinaryReader from)
		{
			Count = from.ReadInt32();
			Blocked = TLFactory.Read<TLVector<TLContactBlocked>>(from);
			Users = TLFactory.Read<TLVector<TLUserBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(Count);
			to.WriteObject(Blocked);
			to.WriteObject(Users);
		}
	}
}