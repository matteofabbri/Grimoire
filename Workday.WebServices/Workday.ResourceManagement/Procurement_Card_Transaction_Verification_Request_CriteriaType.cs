using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Procurement_Card_Transaction_Verification_Request_CriteriaType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private WorkerObjectType worker_ReferenceField;

		private DateTime verification_On_or_AfterField;

		private bool verification_On_or_AfterFieldSpecified;

		private DateTime verification_On_or_BeforeField;

		private bool verification_On_or_BeforeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Verification_On_or_After
		{
			get
			{
				return this.verification_On_or_AfterField;
			}
			set
			{
				this.verification_On_or_AfterField = value;
				this.RaisePropertyChanged("Verification_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Verification_On_or_AfterSpecified
		{
			get
			{
				return this.verification_On_or_AfterFieldSpecified;
			}
			set
			{
				this.verification_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Verification_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Verification_On_or_Before
		{
			get
			{
				return this.verification_On_or_BeforeField;
			}
			set
			{
				this.verification_On_or_BeforeField = value;
				this.RaisePropertyChanged("Verification_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Verification_On_or_BeforeSpecified
		{
			get
			{
				return this.verification_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.verification_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Verification_On_or_BeforeSpecified");
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
