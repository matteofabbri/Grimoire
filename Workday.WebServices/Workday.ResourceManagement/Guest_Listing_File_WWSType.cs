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
	public class Guest_Listing_File_WWSType : INotifyPropertyChanged
	{
		private Guest_Listing_FileObjectType guest_Listing_File_ReferenceField;

		private string guest_Listing_File_NumberField;

		private string guest_Listing_File_NameField;

		private DateTime guest_Listing_File_DateField;

		private bool guest_Listing_File_DateFieldSpecified;

		private Guest_WWSType[] guest_DataField;

		private Guest_Listing_File_DataType[] guest_Listing_File_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Guest_Listing_FileObjectType Guest_Listing_File_Reference
		{
			get
			{
				return this.guest_Listing_File_ReferenceField;
			}
			set
			{
				this.guest_Listing_File_ReferenceField = value;
				this.RaisePropertyChanged("Guest_Listing_File_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Guest_Listing_File_Number
		{
			get
			{
				return this.guest_Listing_File_NumberField;
			}
			set
			{
				this.guest_Listing_File_NumberField = value;
				this.RaisePropertyChanged("Guest_Listing_File_Number");
			}
		}

		[XmlElement(Order = 2)]
		public string Guest_Listing_File_Name
		{
			get
			{
				return this.guest_Listing_File_NameField;
			}
			set
			{
				this.guest_Listing_File_NameField = value;
				this.RaisePropertyChanged("Guest_Listing_File_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Guest_Listing_File_Date
		{
			get
			{
				return this.guest_Listing_File_DateField;
			}
			set
			{
				this.guest_Listing_File_DateField = value;
				this.RaisePropertyChanged("Guest_Listing_File_Date");
			}
		}

		[XmlIgnore]
		public bool Guest_Listing_File_DateSpecified
		{
			get
			{
				return this.guest_Listing_File_DateFieldSpecified;
			}
			set
			{
				this.guest_Listing_File_DateFieldSpecified = value;
				this.RaisePropertyChanged("Guest_Listing_File_DateSpecified");
			}
		}

		[XmlElement("Guest_Data", Order = 4)]
		public Guest_WWSType[] Guest_Data
		{
			get
			{
				return this.guest_DataField;
			}
			set
			{
				this.guest_DataField = value;
				this.RaisePropertyChanged("Guest_Data");
			}
		}

		[XmlElement("Guest_Listing_File_Data", Order = 5)]
		public Guest_Listing_File_DataType[] Guest_Listing_File_Data
		{
			get
			{
				return this.guest_Listing_File_DataField;
			}
			set
			{
				this.guest_Listing_File_DataField = value;
				this.RaisePropertyChanged("Guest_Listing_File_Data");
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
