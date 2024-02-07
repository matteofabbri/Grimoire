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
	public class Stock_Profile_Grant_Split_Replacement_DataType : INotifyPropertyChanged
	{
		private Stock_Grant_TypeObjectType stock_Grant_Type_ReferenceField;

		private Stock_Date_RuleObjectType stock_Date_Rule_ReferenceField;

		private decimal grant_Split_PercentField;

		private bool grant_Split_PercentFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Stock_Grant_TypeObjectType Stock_Grant_Type_Reference
		{
			get
			{
				return this.stock_Grant_Type_ReferenceField;
			}
			set
			{
				this.stock_Grant_Type_ReferenceField = value;
				this.RaisePropertyChanged("Stock_Grant_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Stock_Date_RuleObjectType Stock_Date_Rule_Reference
		{
			get
			{
				return this.stock_Date_Rule_ReferenceField;
			}
			set
			{
				this.stock_Date_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Stock_Date_Rule_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Grant_Split_Percent
		{
			get
			{
				return this.grant_Split_PercentField;
			}
			set
			{
				this.grant_Split_PercentField = value;
				this.RaisePropertyChanged("Grant_Split_Percent");
			}
		}

		[XmlIgnore]
		public bool Grant_Split_PercentSpecified
		{
			get
			{
				return this.grant_Split_PercentFieldSpecified;
			}
			set
			{
				this.grant_Split_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Grant_Split_PercentSpecified");
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
