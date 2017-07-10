// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLPaymentSavedCredentialsCard : TLPaymentSavedCredentialsBase 
	{
		public String Id { get; set; }
		public String Title { get; set; }

		public TLPaymentSavedCredentialsCard() { }
		public TLPaymentSavedCredentialsCard(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PaymentSavedCredentialsCard; } }

		public override void Read(TLBinaryReader from)
		{
			Id = from.ReadString();
			Title = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteString(Id ?? string.Empty);
			to.WriteString(Title ?? string.Empty);
		}
	}
}