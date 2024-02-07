using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Payroll_Federal_W-4_Tax_ElectionType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Federal_W4_Tax_ElectionType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType payroll_Payee_W4_ReferenceField;

		private Payroll_Federal_W4_Tax_Election_DataType payroll_Federal_W4_Tax_Election_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Payroll_Payee_W-4_Reference", Order = 0)]
		public Unique_IdentifierObjectType Payroll_Payee_W4_Reference
		{
			get
			{
				return this.payroll_Payee_W4_ReferenceField;
			}
			set
			{
				this.payroll_Payee_W4_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Payee_W4_Reference");
			}
		}

		[XmlElement("Payroll_Federal_W-4_Tax_Election_Data", Order = 1)]
		public Payroll_Federal_W4_Tax_Election_DataType Payroll_Federal_W4_Tax_Election_Data
		{
			get
			{
				return this.payroll_Federal_W4_Tax_Election_DataField;
			}
			set
			{
				this.payroll_Federal_W4_Tax_Election_DataField = value;
				this.RaisePropertyChanged("Payroll_Federal_W4_Tax_Election_Data");
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
