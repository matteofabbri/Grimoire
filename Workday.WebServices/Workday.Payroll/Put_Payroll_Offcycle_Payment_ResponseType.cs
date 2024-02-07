using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Put_Payroll_Off-cycle_Payment_ResponseType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Payroll_Offcycle_Payment_ResponseType : INotifyPropertyChanged
	{
		private Payroll_Offcycle_Result_OverrideObjectType payroll_Offcycle_Payment_ReferenceField;

		private string batch_IDField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Payroll_Off-cycle_Payment_Reference", Order = 0)]
		public Payroll_Offcycle_Result_OverrideObjectType Payroll_Offcycle_Payment_Reference
		{
			get
			{
				return this.payroll_Offcycle_Payment_ReferenceField;
			}
			set
			{
				this.payroll_Offcycle_Payment_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Offcycle_Payment_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Batch_ID
		{
			get
			{
				return this.batch_IDField;
			}
			set
			{
				this.batch_IDField = value;
				this.RaisePropertyChanged("Batch_ID");
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
