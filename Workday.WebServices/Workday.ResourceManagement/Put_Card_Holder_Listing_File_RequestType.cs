using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Card_Holder_Listing_File_RequestType : INotifyPropertyChanged
	{
		private Cardholder_Listing_FileObjectType card_Holder_Listing_File_ReferenceField;

		private Card_Holder_Listing_File_DataType card_Holder_Listing_File_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

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

		[XmlElement(Order = 1)]
		public Card_Holder_Listing_File_DataType Card_Holder_Listing_File_Data
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

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
