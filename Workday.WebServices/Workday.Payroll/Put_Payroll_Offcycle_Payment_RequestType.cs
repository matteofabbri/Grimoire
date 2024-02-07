using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Put_Payroll_Off-cycle_Payment_RequestType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Payroll_Offcycle_Payment_RequestType : INotifyPropertyChanged
	{
		private Payroll_Offcycle_Result_OverrideObjectType payroll_Offcycle_Payment_ReferenceField;

		private Payroll_Offcycle_Payment_DataType payroll_Offcycle_Payment_DataField;

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

		[XmlElement("Payroll_Off-cycle_Payment_Data", Order = 1)]
		public Payroll_Offcycle_Payment_DataType Payroll_Offcycle_Payment_Data
		{
			get
			{
				return this.payroll_Offcycle_Payment_DataField;
			}
			set
			{
				this.payroll_Offcycle_Payment_DataField = value;
				this.RaisePropertyChanged("Payroll_Offcycle_Payment_Data");
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
