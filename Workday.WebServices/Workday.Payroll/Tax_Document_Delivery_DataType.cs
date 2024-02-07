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
	public class Tax_Document_Delivery_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private Payroll_Payee_Tax_Report_Type_Delivery_GroupObjectType form_Group_ReferenceField;

		private bool override_Default_Delivery_for_PaperField;

		private bool override_Default_Delivery_for_PaperFieldSpecified;

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

		[XmlElement(Order = 2)]
		public Payroll_Payee_Tax_Report_Type_Delivery_GroupObjectType Form_Group_Reference
		{
			get
			{
				return this.form_Group_ReferenceField;
			}
			set
			{
				this.form_Group_ReferenceField = value;
				this.RaisePropertyChanged("Form_Group_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool Override_Default_Delivery_for_Paper
		{
			get
			{
				return this.override_Default_Delivery_for_PaperField;
			}
			set
			{
				this.override_Default_Delivery_for_PaperField = value;
				this.RaisePropertyChanged("Override_Default_Delivery_for_Paper");
			}
		}

		[XmlIgnore]
		public bool Override_Default_Delivery_for_PaperSpecified
		{
			get
			{
				return this.override_Default_Delivery_for_PaperFieldSpecified;
			}
			set
			{
				this.override_Default_Delivery_for_PaperFieldSpecified = value;
				this.RaisePropertyChanged("Override_Default_Delivery_for_PaperSpecified");
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
