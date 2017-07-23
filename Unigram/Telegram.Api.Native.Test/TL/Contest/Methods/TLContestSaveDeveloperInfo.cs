// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Contest.Methods
{
	/// <summary>
	/// RCP method contest.saveDeveloperInfo.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLContestSaveDeveloperInfo : TLObject
	{
		public Int32 VkId { get; set; }
		public String Name { get; set; }
		public String PhoneNumber { get; set; }
		public Int32 Age { get; set; }
		public String City { get; set; }

		public TLContestSaveDeveloperInfo() { }
		public TLContestSaveDeveloperInfo(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ContestSaveDeveloperInfo; } }

		public override void Read(TLBinaryReader from)
		{
			VkId = from.ReadInt32();
			Name = from.ReadString();
			PhoneNumber = from.ReadString();
			Age = from.ReadInt32();
			City = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(VkId);
			to.WriteString(Name ?? string.Empty);
			to.WriteString(PhoneNumber ?? string.Empty);
			to.WriteInt32(Age);
			to.WriteString(City ?? string.Empty);
		}
	}
}