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
	public class Frequency_DataType : INotifyPropertyChanged
	{
		private string frequency_IDField;

		private string nameField;

		private decimal annualization_FactorField;

		private Frequency_BehaviorObjectType frequency_Behavior_ReferenceField;

		private bool use_Weekly_HoursField;

		private bool use_Weekly_HoursFieldSpecified;

		private bool used_in_Payroll_InterfaceField;

		private bool used_in_Payroll_InterfaceFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Frequency_ID
		{
			get
			{
				return this.frequency_IDField;
			}
			set
			{
				this.frequency_IDField = value;
				this.RaisePropertyChanged("Frequency_ID");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public decimal Annualization_Factor
		{
			get
			{
				return this.annualization_FactorField;
			}
			set
			{
				this.annualization_FactorField = value;
				this.RaisePropertyChanged("Annualization_Factor");
			}
		}

		[XmlElement(Order = 3)]
		public Frequency_BehaviorObjectType Frequency_Behavior_Reference
		{
			get
			{
				return this.frequency_Behavior_ReferenceField;
			}
			set
			{
				this.frequency_Behavior_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Behavior_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public bool Use_Weekly_Hours
		{
			get
			{
				return this.use_Weekly_HoursField;
			}
			set
			{
				this.use_Weekly_HoursField = value;
				this.RaisePropertyChanged("Use_Weekly_Hours");
			}
		}

		[XmlIgnore]
		public bool Use_Weekly_HoursSpecified
		{
			get
			{
				return this.use_Weekly_HoursFieldSpecified;
			}
			set
			{
				this.use_Weekly_HoursFieldSpecified = value;
				this.RaisePropertyChanged("Use_Weekly_HoursSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Used_in_Payroll_Interface
		{
			get
			{
				return this.used_in_Payroll_InterfaceField;
			}
			set
			{
				this.used_in_Payroll_InterfaceField = value;
				this.RaisePropertyChanged("Used_in_Payroll_Interface");
			}
		}

		[XmlIgnore]
		public bool Used_in_Payroll_InterfaceSpecified
		{
			get
			{
				return this.used_in_Payroll_InterfaceFieldSpecified;
			}
			set
			{
				this.used_in_Payroll_InterfaceFieldSpecified = value;
				this.RaisePropertyChanged("Used_in_Payroll_InterfaceSpecified");
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
