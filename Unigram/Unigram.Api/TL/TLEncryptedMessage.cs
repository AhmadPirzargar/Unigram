// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLEncryptedMessage : TLEncryptedMessageBase 
	{
		public TLEncryptedFileBase File { get; set; }

		public TLEncryptedMessage() { }
		public TLEncryptedMessage(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.EncryptedMessage; } }

		public override void Read(TLBinaryReader from)
		{
			RandomId = from.ReadInt64();
			ChatId = from.ReadInt32();
			Date = from.ReadInt32();
			Bytes = from.ReadByteArray();
			File = TLFactory.Read<TLEncryptedFileBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt64(RandomId);
			to.WriteInt32(ChatId);
			to.WriteInt32(Date);
			to.WriteByteArray(Bytes);
			to.WriteObject(File);
		}
	}
}