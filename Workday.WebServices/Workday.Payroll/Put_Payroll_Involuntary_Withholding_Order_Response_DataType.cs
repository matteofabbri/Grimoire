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
	public class Put_Payroll_Involuntary_Withholding_Order_Response_DataType : INotifyPropertyChanged
	{
		private Withholding_OrderObjectType withholding_Order_ReferenceField;

		private WorkerObjectType worker_ReferenceField;

		private string withholding_Order_TypeField;

		private Withholding_Order_CaseObjectType withholding_Order_Case_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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
		public string Withholding_Order_Type
		{
			get
			{
				return this.withholding_Order_TypeField;
			}
			set
			{
				this.withholding_Order_TypeField = value;
				this.RaisePropertyChanged("Withholding_Order_Type");
			}
		}

		[XmlElement(Order = 3)]
		public Withholding_Order_CaseObjectType Withholding_Order_Case_Reference
		{
			get
			{
				return this.withholding_Order_Case_ReferenceField;
			}
			set
			{
				this.withholding_Order_Case_ReferenceField = value;
				this.RaisePropertyChanged("Withholding_Order_Case_Reference");
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
