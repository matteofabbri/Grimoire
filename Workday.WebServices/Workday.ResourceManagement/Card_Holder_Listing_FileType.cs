using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Card_Holder_Listing_FileType : INotifyPropertyChanged
	{
		private Cardholder_Listing_FileObjectType card_Holder_Listing_File_ReferenceField;

		private Card_Holder_Listing_File_DataType[] card_Holder_Listing_File_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Cardholder_Listing_FileObjectType Card_Holder_Listing_File_Reference
		{
			get
			{
				return this.card_Holder_Listing_File_ReferenceField;
			}
			set
			{
				this.card_Holder_Listing_File_ReferenceField = value;
				this.RaisePropertyChanged("Card_Holder_Listing_File_Reference");
			}
		}

		[XmlElement("Card_Holder_Listing_File_Data", Order = 1)]
		public Card_Holder_Listing_File_DataType[] Card_Holder_Listing_File_Data
		{
			get
			{
				return this.card_Holder_Listing_File_DataField;
			}
			set
			{
				this.card_Holder_Listing_File_DataField = value;
				this.RaisePropertyChanged("Card_Holder_Listing_File_Data");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
