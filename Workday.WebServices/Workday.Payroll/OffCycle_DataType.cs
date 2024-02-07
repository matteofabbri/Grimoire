using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Off-Cycle_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class OffCycle_DataType : INotifyPropertyChanged
	{
		private Payroll_Offcycle_TypeObjectType result_Type_ReferenceField;

		private bool additional_PayField;

		private bool additional_PayFieldSpecified;

		private Payroll_Action_ReasonObjectType reason_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_Offcycle_TypeObjectType Result_Type_Reference
		{
			get
			{
				return this.result_Type_ReferenceField;
			}
			set
			{
				this.result_Type_ReferenceField = value;
				this.RaisePropertyChanged("Result_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Additional_Pay
		{
			get
			{
				return this.additional_PayField;
			}
			set
			{
				this.additional_PayField = value;
				this.RaisePropertyChanged("Additional_Pay");
			}
		}

		[XmlIgnore]
		public bool Additional_PaySpecified
		{
			get
			{
				return this.additional_PayFieldSpecified;
			}
			set
			{
				this.additional_PayFieldSpecified = value;
				this.RaisePropertyChanged("Additional_PaySpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Payroll_Action_ReasonObjectType Reason_Reference
		{
			get
			{
				return this.reason_ReferenceField;
			}
			set
			{
				this.reason_ReferenceField = value;
				this.RaisePropertyChanged("Reason_Reference");
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
