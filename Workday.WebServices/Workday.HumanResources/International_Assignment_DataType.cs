using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class International_Assignment_DataType : INotifyPropertyChanged
	{
		private International_Assignment_TypeObjectType international_Assignment_Type_ReferenceField;

		private Event_Classification_SubcategoryObjectType start_International_Assignment_Reason_ReferenceField;

		private DateTime expected_Assignment_End_DateField;

		private bool expected_Assignment_End_DateFieldSpecified;

		private CountryObjectType host_Country_ReferenceField;

		private CountryObjectType home_Country_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public International_Assignment_TypeObjectType International_Assignment_Type_Reference
		{
			get
			{
				return this.international_Assignment_Type_ReferenceField;
			}
			set
			{
				this.international_Assignment_Type_ReferenceField = value;
				this.RaisePropertyChanged("International_Assignment_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Event_Classification_SubcategoryObjectType Start_International_Assignment_Reason_Reference
		{
			get
			{
				return this.start_International_Assignment_Reason_ReferenceField;
			}
			set
			{
				this.start_International_Assignment_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Start_International_Assignment_Reason_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Expected_Assignment_End_Date
		{
			get
			{
				return this.expected_Assignment_End_DateField;
			}
			set
			{
				this.expected_Assignment_End_DateField = value;
				this.RaisePropertyChanged("Expected_Assignment_End_Date");
			}
		}

		[XmlIgnore]
		public bool Expected_Assignment_End_DateSpecified
		{
			get
			{
				return this.expected_Assignment_End_DateFieldSpecified;
			}
			set
			{
				this.expected_Assignment_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Expected_Assignment_End_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public CountryObjectType Host_Country_Reference
		{
			get
			{
				return this.host_Country_ReferenceField;
			}
			set
			{
				this.host_Country_ReferenceField = value;
				this.RaisePropertyChanged("Host_Country_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public CountryObjectType Home_Country_Reference
		{
			get
			{
				return this.home_Country_ReferenceField;
			}
			set
			{
				this.home_Country_ReferenceField = value;
				this.RaisePropertyChanged("Home_Country_Reference");
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
