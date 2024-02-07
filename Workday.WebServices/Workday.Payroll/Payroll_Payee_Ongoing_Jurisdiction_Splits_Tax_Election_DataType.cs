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
	public class Payroll_Payee_Ongoing_Jurisdiction_Splits_Tax_Election_DataType : INotifyPropertyChanged
	{
		private Payroll_State_AuthorityObjectType state_ReferenceField;

		private Payroll_Local_County_AuthorityObjectType county_ReferenceField;

		private Payroll_Local_City_AuthorityObjectType city_ReferenceField;

		private Payroll_Other_AuthorityObjectType other_ReferenceField;

		private decimal allocation_PercentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_State_AuthorityObjectType State_Reference
		{
			get
			{
				return this.state_ReferenceField;
			}
			set
			{
				this.state_ReferenceField = value;
				this.RaisePropertyChanged("State_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Payroll_Local_County_AuthorityObjectType County_Reference
		{
			get
			{
				return this.county_ReferenceField;
			}
			set
			{
				this.county_ReferenceField = value;
				this.RaisePropertyChanged("County_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Payroll_Local_City_AuthorityObjectType City_Reference
		{
			get
			{
				return this.city_ReferenceField;
			}
			set
			{
				this.city_ReferenceField = value;
				this.RaisePropertyChanged("City_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Payroll_Other_AuthorityObjectType Other_Reference
		{
			get
			{
				return this.other_ReferenceField;
			}
			set
			{
				this.other_ReferenceField = value;
				this.RaisePropertyChanged("Other_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Allocation_Percent
		{
			get
			{
				return this.allocation_PercentField;
			}
			set
			{
				this.allocation_PercentField = value;
				this.RaisePropertyChanged("Allocation_Percent");
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
