using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Holiday_Calendar_DataType : INotifyPropertyChanged
	{
		private string nameField;

		private string descriptionField;

		private Condition_RuleObjectType condition_Rule_ReferenceField;

		private bool display_on_Time_Off_and_Leave_CalendarField;

		private bool display_on_Time_Off_and_Leave_CalendarFieldSpecified;

		private Holiday_Calendar_Event_DataType[] holiday_Calendar_Event_DataField;

		private string idField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 2)]
		public Condition_RuleObjectType Condition_Rule_Reference
		{
			get
			{
				return this.condition_Rule_ReferenceField;
			}
			set
			{
				this.condition_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Condition_Rule_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool Display_on_Time_Off_and_Leave_Calendar
		{
			get
			{
				return this.display_on_Time_Off_and_Leave_CalendarField;
			}
			set
			{
				this.display_on_Time_Off_and_Leave_CalendarField = value;
				this.RaisePropertyChanged("Display_on_Time_Off_and_Leave_Calendar");
			}
		}

		[XmlIgnore]
		public bool Display_on_Time_Off_and_Leave_CalendarSpecified
		{
			get
			{
				return this.display_on_Time_Off_and_Leave_CalendarFieldSpecified;
			}
			set
			{
				this.display_on_Time_Off_and_Leave_CalendarFieldSpecified = value;
				this.RaisePropertyChanged("Display_on_Time_Off_and_Leave_CalendarSpecified");
			}
		}

		[XmlElement("Holiday_Calendar_Event_Data", Order = 4)]
		public Holiday_Calendar_Event_DataType[] Holiday_Calendar_Event_Data
		{
			get
			{
				return this.holiday_Calendar_Event_DataField;
			}
			set
			{
				this.holiday_Calendar_Event_DataField = value;
				this.RaisePropertyChanged("Holiday_Calendar_Event_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
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
