// <auto-generated/>
using System;

namespace Telegram.Api.TL.Payments.Methods
{
	/// <summary>
	/// RCP method payments.validateRequestedInfo.
	/// Returns <see cref="Telegram.Api.TL.TLPaymentsValidatedRequestedInfo"/>
	/// </summary>
	public partial class TLPaymentsValidateRequestedInfo : TLObject
	{
		[Flags]
		public enum Flag : Int32
		{
			Save = (1 << 0),
		}

		public bool IsSave { get { return Flags.HasFlag(Flag.Save); } set { Flags = value ? (Flags | Flag.Save) : (Flags & ~Flag.Save); } }

		public Flag Flags { get; set; }
		public Int32 MsgId { get; set; }
		public TLPaymentRequestedInfo Info { get; set; }

		public TLPaymentsValidateRequestedInfo() { }
		public TLPaymentsValidateRequestedInfo(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PaymentsValidateRequestedInfo; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			MsgId = from.ReadInt32();
			Info = TLFactory.Read<TLPaymentRequestedInfo>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x770A8E74);
			to.Write((Int32)Flags);
			to.Write(MsgId);
			to.WriteObject(Info);
		}
	}
}