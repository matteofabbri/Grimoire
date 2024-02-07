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
	public class Guest_Listing_File__HV__DataType : INotifyPropertyChanged
	{
		private string guest_Listing_File_NumberField;

		private string guest_Listing_File_NameField;

		private DateTime guest_Listing_File_DateField;

		private bool guest_Listing_File_DateFieldSpecified;

		private Guest__HV__DataType[] guest_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(DataType = "date", Order = 2)]
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

		[XmlElement("Guest_Data", Order = 3)]
		public Guest__HV__DataType[] Guest_Data
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
