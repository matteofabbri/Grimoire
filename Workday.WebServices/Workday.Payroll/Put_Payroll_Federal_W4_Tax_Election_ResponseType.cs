using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Put_Payroll_Federal_W-4_Tax_Election_ResponseType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Payroll_Federal_W4_Tax_Election_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType payroll_Payee_W4_ReferenceField;

		private Put_Payroll_Federal_W4_Tax_Election_Response_DataType put_Payroll_Federal_W4_Tax_Election_Response_Data_ElementField;

		private string versionField;

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

		[XmlElement("Put_Payroll_Federal_W-4_Tax_Election_Response_Data_Element", Order = 1)]
		public Put_Payroll_Federal_W4_Tax_Election_Response_DataType Put_Payroll_Federal_W4_Tax_Election_Response_Data_Element
		{
			get
			{
				return this.put_Payroll_Federal_W4_Tax_Election_Response_Data_ElementField;
			}
			set
			{
				this.put_Payroll_Federal_W4_Tax_Election_Response_Data_ElementField = value;
				this.RaisePropertyChanged("Put_Payroll_Federal_W4_Tax_Election_Response_Data_Element");
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
