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
	public class Payroll_Payee_Student_Loan_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private DateTime effective_As_OfField;

		private CompanyObjectType company_ReferenceField;

		private Payroll_Constant_TextObjectType start_Notification_Type_ReferenceField;

		private Payroll_Constant_TextObjectType repayment_Plan_ReferenceField;

		private DateTime sL2_Stop_Notification_Received_DateField;

		private bool sL2_Stop_Notification_Received_DateFieldSpecified;

		private DateTime stop_DateField;

		private bool stop_DateFieldSpecified;

		private bool stopped_Without_SL2Field;

		private bool stopped_Without_SL2FieldSpecified;

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
		public Payroll_Constant_TextObjectType Start_Notification_Type_Reference
		{
			get
			{
				return this.start_Notification_Type_ReferenceField;
			}
			set
			{
				this.start_Notification_Type_ReferenceField = value;
				this.RaisePropertyChanged("Start_Notification_Type_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Payroll_Constant_TextObjectType Repayment_Plan_Reference
		{
			get
			{
				return this.repayment_Plan_ReferenceField;
			}
			set
			{
				this.repayment_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Repayment_Plan_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime SL2_Stop_Notification_Received_Date
		{
			get
			{
				return this.sL2_Stop_Notification_Received_DateField;
			}
			set
			{
				this.sL2_Stop_Notification_Received_DateField = value;
				this.RaisePropertyChanged("SL2_Stop_Notification_Received_Date");
			}
		}

		[XmlIgnore]
		public bool SL2_Stop_Notification_Received_DateSpecified
		{
			get
			{
				return this.sL2_Stop_Notification_Received_DateFieldSpecified;
			}
			set
			{
				this.sL2_Stop_Notification_Received_DateFieldSpecified = value;
				this.RaisePropertyChanged("SL2_Stop_Notification_Received_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Stop_Date
		{
			get
			{
				return this.stop_DateField;
			}
			set
			{
				this.stop_DateField = value;
				this.RaisePropertyChanged("Stop_Date");
			}
		}

		[XmlIgnore]
		public bool Stop_DateSpecified
		{
			get
			{
				return this.stop_DateFieldSpecified;
			}
			set
			{
				this.stop_DateFieldSpecified = value;
				this.RaisePropertyChanged("Stop_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Stopped_Without_SL2
		{
			get
			{
				return this.stopped_Without_SL2Field;
			}
			set
			{
				this.stopped_Without_SL2Field = value;
				this.RaisePropertyChanged("Stopped_Without_SL2");
			}
		}

		[XmlIgnore]
		public bool Stopped_Without_SL2Specified
		{
			get
			{
				return this.stopped_Without_SL2FieldSpecified;
			}
			set
			{
				this.stopped_Without_SL2FieldSpecified = value;
				this.RaisePropertyChanged("Stopped_Without_SL2Specified");
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
