using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Has_Billable_Load_Status_Defaults_DataType : INotifyPropertyChanged
	{
		private decimal contact_HoursField;

		private bool contact_HoursFieldSpecified;

		private Other_Unit_TypeObjectType unit_Type_ReferenceField;

		private decimal minimum_UnitsField;

		private bool minimum_UnitsFieldSpecified;

		private decimal maximum_UnitsField;

		private bool maximum_UnitsFieldSpecified;

		private bool repeatableField;

		private bool repeatableFieldSpecified;

		private decimal repeat_Maximum_AttemptsField;

		private bool repeat_Maximum_AttemptsFieldSpecified;

		private decimal repeat_Maximum_CreditsField;

		private bool repeat_Maximum_CreditsFieldSpecified;

		private bool other_Unit_ValuesField;

		private bool other_Unit_ValuesFieldSpecified;

		private Other_Credit_Type_Value_DataType[] other_Credit_Type_Value_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Contact_Hours
		{
			get
			{
				return this.contact_HoursField;
			}
			set
			{
				this.contact_HoursField = value;
				this.RaisePropertyChanged("Contact_Hours");
			}
		}

		[XmlIgnore]
		public bool Contact_HoursSpecified
		{
			get
			{
				return this.contact_HoursFieldSpecified;
			}
			set
			{
				this.contact_HoursFieldSpecified = value;
				this.RaisePropertyChanged("Contact_HoursSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Other_Unit_TypeObjectType Unit_Type_Reference
		{
			get
			{
				return this.unit_Type_ReferenceField;
			}
			set
			{
				this.unit_Type_ReferenceField = value;
				this.RaisePropertyChanged("Unit_Type_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Minimum_Units
		{
			get
			{
				return this.minimum_UnitsField;
			}
			set
			{
				this.minimum_UnitsField = value;
				this.RaisePropertyChanged("Minimum_Units");
			}
		}

		[XmlIgnore]
		public bool Minimum_UnitsSpecified
		{
			get
			{
				return this.minimum_UnitsFieldSpecified;
			}
			set
			{
				this.minimum_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Minimum_UnitsSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Maximum_Units
		{
			get
			{
				return this.maximum_UnitsField;
			}
			set
			{
				this.maximum_UnitsField = value;
				this.RaisePropertyChanged("Maximum_Units");
			}
		}

		[XmlIgnore]
		public bool Maximum_UnitsSpecified
		{
			get
			{
				return this.maximum_UnitsFieldSpecified;
			}
			set
			{
				this.maximum_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Maximum_UnitsSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Repeatable
		{
			get
			{
				return this.repeatableField;
			}
			set
			{
				this.repeatableField = value;
				this.RaisePropertyChanged("Repeatable");
			}
		}

		[XmlIgnore]
		public bool RepeatableSpecified
		{
			get
			{
				return this.repeatableFieldSpecified;
			}
			set
			{
				this.repeatableFieldSpecified = value;
				this.RaisePropertyChanged("RepeatableSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Repeat_Maximum_Attempts
		{
			get
			{
				return this.repeat_Maximum_AttemptsField;
			}
			set
			{
				this.repeat_Maximum_AttemptsField = value;
				this.RaisePropertyChanged("Repeat_Maximum_Attempts");
			}
		}

		[XmlIgnore]
		public bool Repeat_Maximum_AttemptsSpecified
		{
			get
			{
				return this.repeat_Maximum_AttemptsFieldSpecified;
			}
			set
			{
				this.repeat_Maximum_AttemptsFieldSpecified = value;
				this.RaisePropertyChanged("Repeat_Maximum_AttemptsSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Repeat_Maximum_Credits
		{
			get
			{
				return this.repeat_Maximum_CreditsField;
			}
			set
			{
				this.repeat_Maximum_CreditsField = value;
				this.RaisePropertyChanged("Repeat_Maximum_Credits");
			}
		}

		[XmlIgnore]
		public bool Repeat_Maximum_CreditsSpecified
		{
			get
			{
				return this.repeat_Maximum_CreditsFieldSpecified;
			}
			set
			{
				this.repeat_Maximum_CreditsFieldSpecified = value;
				this.RaisePropertyChanged("Repeat_Maximum_CreditsSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Other_Unit_Values
		{
			get
			{
				return this.other_Unit_ValuesField;
			}
			set
			{
				this.other_Unit_ValuesField = value;
				this.RaisePropertyChanged("Other_Unit_Values");
			}
		}

		[XmlIgnore]
		public bool Other_Unit_ValuesSpecified
		{
			get
			{
				return this.other_Unit_ValuesFieldSpecified;
			}
			set
			{
				this.other_Unit_ValuesFieldSpecified = value;
				this.RaisePropertyChanged("Other_Unit_ValuesSpecified");
			}
		}

		[XmlElement("Other_Credit_Type_Value_Data", Order = 8)]
		public Other_Credit_Type_Value_DataType[] Other_Credit_Type_Value_Data
		{
			get
			{
				return this.other_Credit_Type_Value_DataField;
			}
			set
			{
				this.other_Credit_Type_Value_DataField = value;
				this.RaisePropertyChanged("Other_Credit_Type_Value_Data");
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
