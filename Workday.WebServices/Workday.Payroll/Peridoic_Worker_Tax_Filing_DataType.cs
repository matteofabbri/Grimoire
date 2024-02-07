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
	public class Peridoic_Worker_Tax_Filing_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private bool third_Party_Provides_Sick_Pay_W2Field;

		private bool third_Party_Provides_Sick_Pay_W2FieldSpecified;

		private Payroll_Result_DataType[] payroll_Result_DataField;

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

		[XmlElement(Order = 1)]
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

		[XmlElement("Third_Party_Provides_Sick_Pay_W-2", Order = 2)]
		public bool Third_Party_Provides_Sick_Pay_W2
		{
			get
			{
				return this.third_Party_Provides_Sick_Pay_W2Field;
			}
			set
			{
				this.third_Party_Provides_Sick_Pay_W2Field = value;
				this.RaisePropertyChanged("Third_Party_Provides_Sick_Pay_W2");
			}
		}

		[XmlIgnore]
		public bool Third_Party_Provides_Sick_Pay_W2Specified
		{
			get
			{
				return this.third_Party_Provides_Sick_Pay_W2FieldSpecified;
			}
			set
			{
				this.third_Party_Provides_Sick_Pay_W2FieldSpecified = value;
				this.RaisePropertyChanged("Third_Party_Provides_Sick_Pay_W2Specified");
			}
		}

		[XmlElement("Payroll_Result_Data", Order = 3)]
		public Payroll_Result_DataType[] Payroll_Result_Data
		{
			get
			{
				return this.payroll_Result_DataField;
			}
			set
			{
				this.payroll_Result_DataField = value;
				this.RaisePropertyChanged("Payroll_Result_Data");
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
