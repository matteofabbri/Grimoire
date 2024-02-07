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
	public class Period_Reporting_Calendar_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string reporting_Calendar_NameField;

		private Academic_UnitObjectType[] academic_Unit_ReferenceField;

		private bool default_CalendarField;

		private bool default_CalendarFieldSpecified;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Period_Reporting_Calendar_Row_DataType[] period_Reporting_Calendar_Row_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Reporting_Calendar_Name
		{
			get
			{
				return this.reporting_Calendar_NameField;
			}
			set
			{
				this.reporting_Calendar_NameField = value;
				this.RaisePropertyChanged("Reporting_Calendar_Name");
			}
		}

		[XmlElement("Academic_Unit_Reference", Order = 2)]
		public Academic_UnitObjectType[] Academic_Unit_Reference
		{
			get
			{
				return this.academic_Unit_ReferenceField;
			}
			set
			{
				this.academic_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Unit_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool Default_Calendar
		{
			get
			{
				return this.default_CalendarField;
			}
			set
			{
				this.default_CalendarField = value;
				this.RaisePropertyChanged("Default_Calendar");
			}
		}

		[XmlIgnore]
		public bool Default_CalendarSpecified
		{
			get
			{
				return this.default_CalendarFieldSpecified;
			}
			set
			{
				this.default_CalendarFieldSpecified = value;
				this.RaisePropertyChanged("Default_CalendarSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement("Period_Reporting_Calendar_Row_Data", Order = 5)]
		public Period_Reporting_Calendar_Row_DataType[] Period_Reporting_Calendar_Row_Data
		{
			get
			{
				return this.period_Reporting_Calendar_Row_DataField;
			}
			set
			{
				this.period_Reporting_Calendar_Row_DataField = value;
				this.RaisePropertyChanged("Period_Reporting_Calendar_Row_Data");
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
