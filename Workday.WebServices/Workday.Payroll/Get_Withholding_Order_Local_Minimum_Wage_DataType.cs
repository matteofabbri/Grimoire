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
	public class Get_Withholding_Order_Local_Minimum_Wage_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType local_Minimum_Wage_ReferenceField;

		private WorkerObjectType worker_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private Withholding_OrderObjectType withholding_Order_ReferenceField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private decimal local_Minimum_Wage_RateField;

		private bool local_Minimum_Wage_RateFieldSpecified;

		private string commentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Local_Minimum_Wage_Reference
		{
			get
			{
				return this.local_Minimum_Wage_ReferenceField;
			}
			set
			{
				this.local_Minimum_Wage_ReferenceField = value;
				this.RaisePropertyChanged("Local_Minimum_Wage_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Withholding_OrderObjectType Withholding_Order_Reference
		{
			get
			{
				return this.withholding_Order_ReferenceField;
			}
			set
			{
				this.withholding_Order_ReferenceField = value;
				this.RaisePropertyChanged("Withholding_Order_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Local_Minimum_Wage_Rate
		{
			get
			{
				return this.local_Minimum_Wage_RateField;
			}
			set
			{
				this.local_Minimum_Wage_RateField = value;
				this.RaisePropertyChanged("Local_Minimum_Wage_Rate");
			}
		}

		[XmlIgnore]
		public bool Local_Minimum_Wage_RateSpecified
		{
			get
			{
				return this.local_Minimum_Wage_RateFieldSpecified;
			}
			set
			{
				this.local_Minimum_Wage_RateFieldSpecified = value;
				this.RaisePropertyChanged("Local_Minimum_Wage_RateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
				this.RaisePropertyChanged("Comment");
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
