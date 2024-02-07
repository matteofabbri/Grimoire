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
	public class Worker_Travel_Profile_Listing_File__HV__DataType : INotifyPropertyChanged
	{
		private string travel_Profile_Listing_File_NumberField;

		private string travel_Profile_Listing_File_NameField;

		private DateTime travel_Profile_Listing_File_DateField;

		private bool travel_Profile_Listing_File_DateFieldSpecified;

		private Travel__Profile__HV__DataType[] travel_Profile_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Travel_Profile_Listing_File_Number
		{
			get
			{
				return this.travel_Profile_Listing_File_NumberField;
			}
			set
			{
				this.travel_Profile_Listing_File_NumberField = value;
				this.RaisePropertyChanged("Travel_Profile_Listing_File_Number");
			}
		}

		[XmlElement(Order = 1)]
		public string Travel_Profile_Listing_File_Name
		{
			get
			{
				return this.travel_Profile_Listing_File_NameField;
			}
			set
			{
				this.travel_Profile_Listing_File_NameField = value;
				this.RaisePropertyChanged("Travel_Profile_Listing_File_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Travel_Profile_Listing_File_Date
		{
			get
			{
				return this.travel_Profile_Listing_File_DateField;
			}
			set
			{
				this.travel_Profile_Listing_File_DateField = value;
				this.RaisePropertyChanged("Travel_Profile_Listing_File_Date");
			}
		}

		[XmlIgnore]
		public bool Travel_Profile_Listing_File_DateSpecified
		{
			get
			{
				return this.travel_Profile_Listing_File_DateFieldSpecified;
			}
			set
			{
				this.travel_Profile_Listing_File_DateFieldSpecified = value;
				this.RaisePropertyChanged("Travel_Profile_Listing_File_DateSpecified");
			}
		}

		[XmlElement("Travel_Profile_Data", Order = 3)]
		public Travel__Profile__HV__DataType[] Travel_Profile_Data
		{
			get
			{
				return this.travel_Profile_DataField;
			}
			set
			{
				this.travel_Profile_DataField = value;
				this.RaisePropertyChanged("Travel_Profile_Data");
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
