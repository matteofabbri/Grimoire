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
	public class Travel_Booking_File_DataType : INotifyPropertyChanged
	{
		private string file_IDField;

		private string file_NameField;

		private DateTime file_DateField;

		private bool file_DateFieldSpecified;

		private CompanyObjectType default_Company_ReferenceField;

		private Travel_Booking_Record_DataType[] travel_Booking_Record_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string File_ID
		{
			get
			{
				return this.file_IDField;
			}
			set
			{
				this.file_IDField = value;
				this.RaisePropertyChanged("File_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string File_Name
		{
			get
			{
				return this.file_NameField;
			}
			set
			{
				this.file_NameField = value;
				this.RaisePropertyChanged("File_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime File_Date
		{
			get
			{
				return this.file_DateField;
			}
			set
			{
				this.file_DateField = value;
				this.RaisePropertyChanged("File_Date");
			}
		}

		[XmlIgnore]
		public bool File_DateSpecified
		{
			get
			{
				return this.file_DateFieldSpecified;
			}
			set
			{
				this.file_DateFieldSpecified = value;
				this.RaisePropertyChanged("File_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public CompanyObjectType Default_Company_Reference
		{
			get
			{
				return this.default_Company_ReferenceField;
			}
			set
			{
				this.default_Company_ReferenceField = value;
				this.RaisePropertyChanged("Default_Company_Reference");
			}
		}

		[XmlElement("Travel_Booking_Record_Data", Order = 4)]
		public Travel_Booking_Record_DataType[] Travel_Booking_Record_Data
		{
			get
			{
				return this.travel_Booking_Record_DataField;
			}
			set
			{
				this.travel_Booking_Record_DataField = value;
				this.RaisePropertyChanged("Travel_Booking_Record_Data");
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
