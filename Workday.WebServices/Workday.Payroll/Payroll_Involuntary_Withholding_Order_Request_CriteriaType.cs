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
	public class Payroll_Involuntary_Withholding_Order_Request_CriteriaType : INotifyPropertyChanged
	{
		private WorkerObjectType[] worker_ReferenceField;

		private Withholding_Order_TypeObjectType[] type_ReferenceField;

		private DateTime effective_As_OfField;

		private bool effective_As_OfFieldSpecified;

		private object[] itemsField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Worker_Reference", Order = 0)]
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

		[XmlElement("Type_Reference", Order = 1)]
		public Withholding_Order_TypeObjectType[] Type_Reference
		{
			get
			{
				return this.type_ReferenceField;
			}
			set
			{
				this.type_ReferenceField = value;
				this.RaisePropertyChanged("Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
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

		[XmlIgnore]
		public bool Effective_As_OfSpecified
		{
			get
			{
				return this.effective_As_OfFieldSpecified;
			}
			set
			{
				this.effective_As_OfFieldSpecified = value;
				this.RaisePropertyChanged("Effective_As_OfSpecified");
			}
		}

		[XmlElement("Case_Number", typeof(string), Order = 3), XmlElement("Case_Reference", typeof(Withholding_Order_CaseObjectType), Order = 3)]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
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
