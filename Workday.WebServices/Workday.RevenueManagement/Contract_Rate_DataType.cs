using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Contract_Rate_DataType : INotifyPropertyChanged
	{
		private Project_RoleObjectType project_Role_ReferenceField;

		private decimal standard_RateField;

		private bool standard_RateFieldSpecified;

		private decimal adjustment_PercentField;

		private bool adjustment_PercentFieldSpecified;

		private decimal contract_RateField;

		private CurrencyObjectType currency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Project_RoleObjectType Project_Role_Reference
		{
			get
			{
				return this.project_Role_ReferenceField;
			}
			set
			{
				this.project_Role_ReferenceField = value;
				this.RaisePropertyChanged("Project_Role_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Standard_Rate
		{
			get
			{
				return this.standard_RateField;
			}
			set
			{
				this.standard_RateField = value;
				this.RaisePropertyChanged("Standard_Rate");
			}
		}

		[XmlIgnore]
		public bool Standard_RateSpecified
		{
			get
			{
				return this.standard_RateFieldSpecified;
			}
			set
			{
				this.standard_RateFieldSpecified = value;
				this.RaisePropertyChanged("Standard_RateSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Adjustment_Percent
		{
			get
			{
				return this.adjustment_PercentField;
			}
			set
			{
				this.adjustment_PercentField = value;
				this.RaisePropertyChanged("Adjustment_Percent");
			}
		}

		[XmlIgnore]
		public bool Adjustment_PercentSpecified
		{
			get
			{
				return this.adjustment_PercentFieldSpecified;
			}
			set
			{
				this.adjustment_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Adjustment_PercentSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Contract_Rate
		{
			get
			{
				return this.contract_RateField;
			}
			set
			{
				this.contract_RateField = value;
				this.RaisePropertyChanged("Contract_Rate");
			}
		}

		[XmlElement(Order = 4)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
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
