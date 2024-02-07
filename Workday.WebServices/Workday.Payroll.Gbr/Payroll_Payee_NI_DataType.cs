using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Payee_NI_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private DateTime effective_As_OfField;

		private CompanyObjectType company_ReferenceField;

		private NI_CategoryObjectType nI_Category_ReferenceField;

		private PositionObjectType position_ReferenceField;

		private Payroll_Constant_TextObjectType calculation_Method_ReferenceField;

		private string sCONField;

		private Payroll_Constant_TextObjectType proof_of_Age_Exemption_ReferenceField;

		private bool cA2700Field;

		private bool cA2700FieldSpecified;

		private Calendar_YearObjectType cA2700_Valid_for_Tax_Year_Ending_ReferenceField;

		private Payroll_Constant_TextObjectType certificate_of_Election_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Effective_As_Of
		{
			get
			{
				return this.effective_As_OfField;
			}
			set
			{
				this.effective_As_OfField = value;
				this.RaisePropertyChanged("Effective_As_Of");
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
		public NI_CategoryObjectType NI_Category_Reference
		{
			get
			{
				return this.nI_Category_ReferenceField;
			}
			set
			{
				this.nI_Category_ReferenceField = value;
				this.RaisePropertyChanged("NI_Category_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public PositionObjectType Position_Reference
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

		[XmlElement(Order = 5)]
		public Payroll_Constant_TextObjectType Calculation_Method_Reference
		{
			get
			{
				return this.calculation_Method_ReferenceField;
			}
			set
			{
				this.calculation_Method_ReferenceField = value;
				this.RaisePropertyChanged("Calculation_Method_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public string SCON
		{
			get
			{
				return this.sCONField;
			}
			set
			{
				this.sCONField = value;
				this.RaisePropertyChanged("SCON");
			}
		}

		[XmlElement(Order = 7)]
		public Payroll_Constant_TextObjectType Proof_of_Age_Exemption_Reference
		{
			get
			{
				return this.proof_of_Age_Exemption_ReferenceField;
			}
			set
			{
				this.proof_of_Age_Exemption_ReferenceField = value;
				this.RaisePropertyChanged("Proof_of_Age_Exemption_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public bool CA2700
		{
			get
			{
				return this.cA2700Field;
			}
			set
			{
				this.cA2700Field = value;
				this.RaisePropertyChanged("CA2700");
			}
		}

		[XmlIgnore]
		public bool CA2700Specified
		{
			get
			{
				return this.cA2700FieldSpecified;
			}
			set
			{
				this.cA2700FieldSpecified = value;
				this.RaisePropertyChanged("CA2700Specified");
			}
		}

		[XmlElement(Order = 9)]
		public Calendar_YearObjectType CA2700_Valid_for_Tax_Year_Ending_Reference
		{
			get
			{
				return this.cA2700_Valid_for_Tax_Year_Ending_ReferenceField;
			}
			set
			{
				this.cA2700_Valid_for_Tax_Year_Ending_ReferenceField = value;
				this.RaisePropertyChanged("CA2700_Valid_for_Tax_Year_Ending_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public Payroll_Constant_TextObjectType Certificate_of_Election_Reference
		{
			get
			{
				return this.certificate_of_Election_ReferenceField;
			}
			set
			{
				this.certificate_of_Election_ReferenceField = value;
				this.RaisePropertyChanged("Certificate_of_Election_Reference");
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
