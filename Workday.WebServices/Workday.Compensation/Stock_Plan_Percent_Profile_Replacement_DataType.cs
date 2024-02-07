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
	public class Stock_Plan_Percent_Profile_Replacement_DataType : INotifyPropertyChanged
	{
		private decimal target_PercentField;

		private bool target_PercentFieldSpecified;

		private Condition_RuleObjectType eligibility_Rule_ReferenceField;

		private Compensation_BasisObjectType compensation_Basis_ReferenceField;

		private Stock_Profile_Grant_Split_Replacement_DataType[] stock_Profile_Grant_Split_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Target_Percent
		{
			get
			{
				return this.target_PercentField;
			}
			set
			{
				this.target_PercentField = value;
				this.RaisePropertyChanged("Target_Percent");
			}
		}

		[XmlIgnore]
		public bool Target_PercentSpecified
		{
			get
			{
				return this.target_PercentFieldSpecified;
			}
			set
			{
				this.target_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Target_PercentSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Condition_RuleObjectType Eligibility_Rule_Reference
		{
			get
			{
				return this.eligibility_Rule_ReferenceField;
			}
			set
			{
				this.eligibility_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Eligibility_Rule_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Compensation_BasisObjectType Compensation_Basis_Reference
		{
			get
			{
				return this.compensation_Basis_ReferenceField;
			}
			set
			{
				this.compensation_Basis_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Basis_Reference");
			}
		}

		[XmlElement("Stock_Profile_Grant_Split_Replacement_Data", Order = 3)]
		public Stock_Profile_Grant_Split_Replacement_DataType[] Stock_Profile_Grant_Split_Replacement_Data
		{
			get
			{
				return this.stock_Profile_Grant_Split_Replacement_DataField;
			}
			set
			{
				this.stock_Profile_Grant_Split_Replacement_DataField = value;
				this.RaisePropertyChanged("Stock_Profile_Grant_Split_Replacement_Data");
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
