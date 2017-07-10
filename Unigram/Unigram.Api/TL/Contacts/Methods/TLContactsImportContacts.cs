// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Contacts.Methods
{
	/// <summary>
	/// RCP method contacts.importContacts.
	/// Returns <see cref="Telegram.Api.TL.TLContactsImportedContacts"/>
	/// </summary>
	public partial class TLContactsImportContacts : TLObject
	{
		public TLVector<TLInputContactBase> Contacts { get; set; }
		public Boolean Replace { get; set; }

		public TLContactsImportContacts() { }
		public TLContactsImportContacts(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ContactsImportContacts; } }

		public override void Read(TLBinaryReader from)
		{
			Contacts = TLFactory.Read<TLVector<TLInputContactBase>>(from);
			Replace = from.ReadBoolean();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Contacts);
			to.WriteBoolean(Replace);
		}
	}
}