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
	public class Card_Holder_Listing_File_DataType : INotifyPropertyChanged
	{
		private string card_Holder_Listing_File_NumberField;

		private string card_Holder_Listing_File_NameField;

		private DateTime card_Holder_Listing_File_DateField;

		private bool card_Holder_Listing_File_DateFieldSpecified;

		private Data_Load_StatusObjectType data_Load_Status_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Card_Holder_Listing_File_Number
		{
			get
			{
				return this.card_Holder_Listing_File_NumberField;
			}
			set
			{
				this.card_Holder_Listing_File_NumberField = value;
				this.RaisePropertyChanged("Card_Holder_Listing_File_Number");
			}
		}

		[XmlElement(Order = 1)]
		public string Card_Holder_Listing_File_Name
		{
			get
			{
				return this.card_Holder_Listing_File_NameField;
			}
			set
			{
				this.card_Holder_Listing_File_NameField = value;
				this.RaisePropertyChanged("Card_Holder_Listing_File_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Card_Holder_Listing_File_Date
		{
			get
			{
				return this.card_Holder_Listing_File_DateField;
			}
			set
			{
				this.card_Holder_Listing_File_DateField = value;
				this.RaisePropertyChanged("Card_Holder_Listing_File_Date");
			}
		}

		[XmlIgnore]
		public bool Card_Holder_Listing_File_DateSpecified
		{
			get
			{
				return this.card_Holder_Listing_File_DateFieldSpecified;
			}
			set
			{
				this.card_Holder_Listing_File_DateFieldSpecified = value;
				this.RaisePropertyChanged("Card_Holder_Listing_File_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Data_Load_StatusObjectType Data_Load_Status_Reference
		{
			get
			{
				return this.data_Load_Status_ReferenceField;
			}
			set
			{
				this.data_Load_Status_ReferenceField = value;
				this.RaisePropertyChanged("Data_Load_Status_Reference");
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
