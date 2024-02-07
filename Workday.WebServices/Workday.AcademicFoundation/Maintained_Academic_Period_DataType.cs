using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Maintained_Academic_Period_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string academic_Period_NameField;

		private Academic_Period_TypeObjectType academic_Period_Type_ReferenceField;

		private DateTime standard_Start_DateField;

		private bool standard_Start_DateFieldSpecified;

		private DateTime academic_Period_Start_DateField;

		private DateTime academic_Period_End_DateField;

		private DateTime standard_End_DateField;

		private bool standard_End_DateFieldSpecified;

		private bool display_Date_RangeField;

		private bool display_Date_RangeFieldSpecified;

		private decimal academic_Period_Weeks_of_InstructionField;

		private bool academic_Period_Weeks_of_InstructionFieldSpecified;

		private Academic_Period_UsageObjectType[] academic_Period_Usage_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Academic_Period_Division_Configuration_DataType[] academic_Period_Division_Configuration_DataField;

		private Academic_Period_Weight_DataType[] academic_Period_Weight_DataField;

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
		public string Academic_Period_Name
		{
			get
			{
				return this.academic_Period_NameField;
			}
			set
			{
				this.academic_Period_NameField = value;
				this.RaisePropertyChanged("Academic_Period_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Academic_Period_TypeObjectType Academic_Period_Type_Reference
		{
			get
			{
				return this.academic_Period_Type_ReferenceField;
			}
			set
			{
				this.academic_Period_Type_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Period_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Standard_Start_Date
		{
			get
			{
				return this.standard_Start_DateField;
			}
			set
			{
				this.standard_Start_DateField = value;
				this.RaisePropertyChanged("Standard_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Standard_Start_DateSpecified
		{
			get
			{
				return this.standard_Start_DateFieldSpecified;
			}
			set
			{
				this.standard_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Standard_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Academic_Period_Start_Date
		{
			get
			{
				return this.academic_Period_Start_DateField;
			}
			set
			{
				this.academic_Period_Start_DateField = value;
				this.RaisePropertyChanged("Academic_Period_Start_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Academic_Period_End_Date
		{
			get
			{
				return this.academic_Period_End_DateField;
			}
			set
			{
				this.academic_Period_End_DateField = value;
				this.RaisePropertyChanged("Academic_Period_End_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Standard_End_Date
		{
			get
			{
				return this.standard_End_DateField;
			}
			set
			{
				this.standard_End_DateField = value;
				this.RaisePropertyChanged("Standard_End_Date");
			}
		}

		[XmlIgnore]
		public bool Standard_End_DateSpecified
		{
			get
			{
				return this.standard_End_DateFieldSpecified;
			}
			set
			{
				this.standard_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Standard_End_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Display_Date_Range
		{
			get
			{
				return this.display_Date_RangeField;
			}
			set
			{
				this.display_Date_RangeField = value;
				this.RaisePropertyChanged("Display_Date_Range");
			}
		}

		[XmlIgnore]
		public bool Display_Date_RangeSpecified
		{
			get
			{
				return this.display_Date_RangeFieldSpecified;
			}
			set
			{
				this.display_Date_RangeFieldSpecified = value;
				this.RaisePropertyChanged("Display_Date_RangeSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Academic_Period_Weeks_of_Instruction
		{
			get
			{
				return this.academic_Period_Weeks_of_InstructionField;
			}
			set
			{
				this.academic_Period_Weeks_of_InstructionField = value;
				this.RaisePropertyChanged("Academic_Period_Weeks_of_Instruction");
			}
		}

		[XmlIgnore]
		public bool Academic_Period_Weeks_of_InstructionSpecified
		{
			get
			{
				return this.academic_Period_Weeks_of_InstructionFieldSpecified;
			}
			set
			{
				this.academic_Period_Weeks_of_InstructionFieldSpecified = value;
				this.RaisePropertyChanged("Academic_Period_Weeks_of_InstructionSpecified");
			}
		}

		[XmlElement("Academic_Period_Usage_Reference", Order = 9)]
		public Academic_Period_UsageObjectType[] Academic_Period_Usage_Reference
		{
			get
			{
				return this.academic_Period_Usage_ReferenceField;
			}
			set
			{
				this.academic_Period_Usage_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Period_Usage_Reference");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement("Academic_Period_Division_Configuration_Data", Order = 11)]
		public Academic_Period_Division_Configuration_DataType[] Academic_Period_Division_Configuration_Data
		{
			get
			{
				return this.academic_Period_Division_Configuration_DataField;
			}
			set
			{
				this.academic_Period_Division_Configuration_DataField = value;
				this.RaisePropertyChanged("Academic_Period_Division_Configuration_Data");
			}
		}

		[XmlElement("Academic_Period_Weight_Data", Order = 12)]
		public Academic_Period_Weight_DataType[] Academic_Period_Weight_Data
		{
			get
			{
				return this.academic_Period_Weight_DataField;
			}
			set
			{
				this.academic_Period_Weight_DataField = value;
				this.RaisePropertyChanged("Academic_Period_Weight_Data");
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
