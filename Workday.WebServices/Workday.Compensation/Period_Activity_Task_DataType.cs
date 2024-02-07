using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Period_Activity_Task_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string period_Activity_Task_CodeField;

		private string period_Activity_Task_NameField;

		private string period_Activity_Task_DescriptionField;

		private Period_Activity_UnitObjectType period_Activity_Unit_ReferenceField;

		private Academic_PeriodObjectType academic_Period_ReferenceField;

		private decimal default_Unit_QuantityField;

		private bool default_Unit_QuantityFieldSpecified;

		private bool allow_Unit_Quantity_OverrideField;

		private bool allow_Unit_Quantity_OverrideFieldSpecified;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

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
		public string Period_Activity_Task_Code
		{
			get
			{
				return this.period_Activity_Task_CodeField;
			}
			set
			{
				this.period_Activity_Task_CodeField = value;
				this.RaisePropertyChanged("Period_Activity_Task_Code");
			}
		}

		[XmlElement(Order = 2)]
		public string Period_Activity_Task_Name
		{
			get
			{
				return this.period_Activity_Task_NameField;
			}
			set
			{
				this.period_Activity_Task_NameField = value;
				this.RaisePropertyChanged("Period_Activity_Task_Name");
			}
		}

		[XmlElement(Order = 3)]
		public string Period_Activity_Task_Description
		{
			get
			{
				return this.period_Activity_Task_DescriptionField;
			}
			set
			{
				this.period_Activity_Task_DescriptionField = value;
				this.RaisePropertyChanged("Period_Activity_Task_Description");
			}
		}

		[XmlElement(Order = 4)]
		public Period_Activity_UnitObjectType Period_Activity_Unit_Reference
		{
			get
			{
				return this.period_Activity_Unit_ReferenceField;
			}
			set
			{
				this.period_Activity_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Period_Activity_Unit_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Academic_PeriodObjectType Academic_Period_Reference
		{
			get
			{
				return this.academic_Period_ReferenceField;
			}
			set
			{
				this.academic_Period_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Period_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Default_Unit_Quantity
		{
			get
			{
				return this.default_Unit_QuantityField;
			}
			set
			{
				this.default_Unit_QuantityField = value;
				this.RaisePropertyChanged("Default_Unit_Quantity");
			}
		}

		[XmlIgnore]
		public bool Default_Unit_QuantitySpecified
		{
			get
			{
				return this.default_Unit_QuantityFieldSpecified;
			}
			set
			{
				this.default_Unit_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Default_Unit_QuantitySpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Allow_Unit_Quantity_Override
		{
			get
			{
				return this.allow_Unit_Quantity_OverrideField;
			}
			set
			{
				this.allow_Unit_Quantity_OverrideField = value;
				this.RaisePropertyChanged("Allow_Unit_Quantity_Override");
			}
		}

		[XmlIgnore]
		public bool Allow_Unit_Quantity_OverrideSpecified
		{
			get
			{
				return this.allow_Unit_Quantity_OverrideFieldSpecified;
			}
			set
			{
				this.allow_Unit_Quantity_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Allow_Unit_Quantity_OverrideSpecified");
			}
		}

		[XmlElement(Order = 8)]
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
