using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Former_Worker_Related_DataType : INotifyPropertyChanged
	{
		private bool rehiredField;

		private bool rehiredFieldSpecified;

		private ApplicantObjectType applicant_ReferenceField;

		private WorkerObjectType[] worker_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Rehired
		{
			get
			{
				return this.rehiredField;
			}
			set
			{
				this.rehiredField = value;
				this.RaisePropertyChanged("Rehired");
			}
		}

		[XmlIgnore]
		public bool RehiredSpecified
		{
			get
			{
				return this.rehiredFieldSpecified;
			}
			set
			{
				this.rehiredFieldSpecified = value;
				this.RaisePropertyChanged("RehiredSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public ApplicantObjectType Applicant_Reference
		{
			get
			{
				return this.applicant_ReferenceField;
			}
			set
			{
				this.applicant_ReferenceField = value;
				this.RaisePropertyChanged("Applicant_Reference");
			}
		}

		[XmlElement("Worker_Reference", Order = 2)]
		public WorkerObjectType[] Worker_Reference
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
