using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Primary_Posting_RequestType : INotifyPropertyChanged
	{
		private Job_Requisition_EnabledObjectType job_Requisition_ReferenceField;

		private Job_PostingObjectType job_Posting_ReferenceField;

		private decimal forecasted_PayoutField;

		private bool forecasted_PayoutFieldSpecified;

		private CurrencyObjectType agency_Currency_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Job_Requisition_EnabledObjectType Job_Requisition_Reference
		{
			get
			{
				return this.job_Requisition_ReferenceField;
			}
			set
			{
				this.job_Requisition_ReferenceField = value;
				this.RaisePropertyChanged("Job_Requisition_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Job_PostingObjectType Job_Posting_Reference
		{
			get
			{
				return this.job_Posting_ReferenceField;
			}
			set
			{
				this.job_Posting_ReferenceField = value;
				this.RaisePropertyChanged("Job_Posting_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Forecasted_Payout
		{
			get
			{
				return this.forecasted_PayoutField;
			}
			set
			{
				this.forecasted_PayoutField = value;
				this.RaisePropertyChanged("Forecasted_Payout");
			}
		}

		[XmlIgnore]
		public bool Forecasted_PayoutSpecified
		{
			get
			{
				return this.forecasted_PayoutFieldSpecified;
			}
			set
			{
				this.forecasted_PayoutFieldSpecified = value;
				this.RaisePropertyChanged("Forecasted_PayoutSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public CurrencyObjectType Agency_Currency_Reference
		{
			get
			{
				return this.agency_Currency_ReferenceField;
			}
			set
			{
				this.agency_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Agency_Currency_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
