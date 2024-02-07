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
	public class WA_IIF_Deduction_DataType : INotifyPropertyChanged
	{
		private Metadata_Payroll_WorktagObjectType[] payroll_Tax_Authority_ReferenceField;

		private PositionObjectType[] position_ReferenceField;

		private Workers_Compensation_CodeObjectType[] workers_Compensation_Code_ReferenceField;

		private decimal workers_Compensation_Rate_ReferenceField;

		private bool workers_Compensation_Rate_ReferenceFieldSpecified;

		private decimal washington_Industrial_Insurance_Fund_QTD_ValueField;

		private bool washington_Industrial_Insurance_Fund_QTD_ValueFieldSpecified;

		private decimal washington_Industrial_Insurance_Fund_YTD_ValueField;

		private bool washington_Industrial_Insurance_Fund_YTD_ValueFieldSpecified;

		private decimal qTD_Taxable_HoursField;

		private bool qTD_Taxable_HoursFieldSpecified;

		private decimal yTD_Taxable_HoursField;

		private bool yTD_Taxable_HoursFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Payroll_Tax_Authority_Reference", Order = 0)]
		public Metadata_Payroll_WorktagObjectType[] Payroll_Tax_Authority_Reference
		{
			get
			{
				return this.payroll_Tax_Authority_ReferenceField;
			}
			set
			{
				this.payroll_Tax_Authority_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Tax_Authority_Reference");
			}
		}

		[XmlElement("Position_Reference", Order = 1)]
		public PositionObjectType[] Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement("Workers_Compensation_Code_Reference", Order = 2)]
		public Workers_Compensation_CodeObjectType[] Workers_Compensation_Code_Reference
		{
			get
			{
				return this.workers_Compensation_Code_ReferenceField;
			}
			set
			{
				this.workers_Compensation_Code_ReferenceField = value;
				this.RaisePropertyChanged("Workers_Compensation_Code_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Workers_Compensation_Rate_Reference
		{
			get
			{
				return this.workers_Compensation_Rate_ReferenceField;
			}
			set
			{
				this.workers_Compensation_Rate_ReferenceField = value;
				this.RaisePropertyChanged("Workers_Compensation_Rate_Reference");
			}
		}

		[XmlIgnore]
		public bool Workers_Compensation_Rate_ReferenceSpecified
		{
			get
			{
				return this.workers_Compensation_Rate_ReferenceFieldSpecified;
			}
			set
			{
				this.workers_Compensation_Rate_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Workers_Compensation_Rate_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Washington_Industrial_Insurance_Fund_QTD_Value
		{
			get
			{
				return this.washington_Industrial_Insurance_Fund_QTD_ValueField;
			}
			set
			{
				this.washington_Industrial_Insurance_Fund_QTD_ValueField = value;
				this.RaisePropertyChanged("Washington_Industrial_Insurance_Fund_QTD_Value");
			}
		}

		[XmlIgnore]
		public bool Washington_Industrial_Insurance_Fund_QTD_ValueSpecified
		{
			get
			{
				return this.washington_Industrial_Insurance_Fund_QTD_ValueFieldSpecified;
			}
			set
			{
				this.washington_Industrial_Insurance_Fund_QTD_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Washington_Industrial_Insurance_Fund_QTD_ValueSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Washington_Industrial_Insurance_Fund_YTD_Value
		{
			get
			{
				return this.washington_Industrial_Insurance_Fund_YTD_ValueField;
			}
			set
			{
				this.washington_Industrial_Insurance_Fund_YTD_ValueField = value;
				this.RaisePropertyChanged("Washington_Industrial_Insurance_Fund_YTD_Value");
			}
		}

		[XmlIgnore]
		public bool Washington_Industrial_Insurance_Fund_YTD_ValueSpecified
		{
			get
			{
				return this.washington_Industrial_Insurance_Fund_YTD_ValueFieldSpecified;
			}
			set
			{
				this.washington_Industrial_Insurance_Fund_YTD_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Washington_Industrial_Insurance_Fund_YTD_ValueSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal QTD_Taxable_Hours
		{
			get
			{
				return this.qTD_Taxable_HoursField;
			}
			set
			{
				this.qTD_Taxable_HoursField = value;
				this.RaisePropertyChanged("QTD_Taxable_Hours");
			}
		}

		[XmlIgnore]
		public bool QTD_Taxable_HoursSpecified
		{
			get
			{
				return this.qTD_Taxable_HoursFieldSpecified;
			}
			set
			{
				this.qTD_Taxable_HoursFieldSpecified = value;
				this.RaisePropertyChanged("QTD_Taxable_HoursSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal YTD_Taxable_Hours
		{
			get
			{
				return this.yTD_Taxable_HoursField;
			}
			set
			{
				this.yTD_Taxable_HoursField = value;
				this.RaisePropertyChanged("YTD_Taxable_Hours");
			}
		}

		[XmlIgnore]
		public bool YTD_Taxable_HoursSpecified
		{
			get
			{
				return this.yTD_Taxable_HoursFieldSpecified;
			}
			set
			{
				this.yTD_Taxable_HoursFieldSpecified = value;
				this.RaisePropertyChanged("YTD_Taxable_HoursSpecified");
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
