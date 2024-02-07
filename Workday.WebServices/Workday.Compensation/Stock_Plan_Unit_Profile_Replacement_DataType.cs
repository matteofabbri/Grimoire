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
	public class Stock_Plan_Unit_Profile_Replacement_DataType : INotifyPropertyChanged
	{
		private decimal target_SharesField;

		private bool target_SharesFieldSpecified;

		private Condition_RuleObjectType eligibility_Rule_ReferenceField;

		private Stock_Profile_Grant_Split_Replacement_DataType[] stock_Profile_Grant_Split_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Target_Shares
		{
			get
			{
				return this.target_SharesField;
			}
			set
			{
				this.target_SharesField = value;
				this.RaisePropertyChanged("Target_Shares");
			}
		}

		[XmlIgnore]
		public bool Target_SharesSpecified
		{
			get
			{
				return this.target_SharesFieldSpecified;
			}
			set
			{
				this.target_SharesFieldSpecified = value;
				this.RaisePropertyChanged("Target_SharesSpecified");
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

		[XmlElement("Stock_Profile_Grant_Split_Replacement_Data", Order = 2)]
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
