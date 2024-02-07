using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Wage_Assignment_Specific_DataType : INotifyPropertyChanged
	{
		private bool head_of_HouseholdField;

		private bool head_of_HouseholdFieldSpecified;

		private bool marriedField;

		private bool marriedFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Head_of_Household
		{
			get
			{
				return this.head_of_HouseholdField;
			}
			set
			{
				this.head_of_HouseholdField = value;
				this.RaisePropertyChanged("Head_of_Household");
			}
		}

		[XmlIgnore]
		public bool Head_of_HouseholdSpecified
		{
			get
			{
				return this.head_of_HouseholdFieldSpecified;
			}
			set
			{
				this.head_of_HouseholdFieldSpecified = value;
				this.RaisePropertyChanged("Head_of_HouseholdSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Married
		{
			get
			{
				return this.marriedField;
			}
			set
			{
				this.marriedField = value;
				this.RaisePropertyChanged("Married");
			}
		}

		[XmlIgnore]
		public bool MarriedSpecified
		{
			get
			{
				return this.marriedFieldSpecified;
			}
			set
			{
				this.marriedFieldSpecified = value;
				this.RaisePropertyChanged("MarriedSpecified");
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
