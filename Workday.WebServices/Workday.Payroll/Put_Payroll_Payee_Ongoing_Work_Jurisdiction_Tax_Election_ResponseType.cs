using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType put_Payroll_Payee_Ongoing_Jurisdiction_ReferenceField;

		private Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Response_DataType ongoing_Jurisdiction_Response_Tax_Election_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Put_Payroll_Payee_Ongoing_Jurisdiction_Reference
		{
			get
			{
				return this.put_Payroll_Payee_Ongoing_Jurisdiction_ReferenceField;
			}
			set
			{
				this.put_Payroll_Payee_Ongoing_Jurisdiction_ReferenceField = value;
				this.RaisePropertyChanged("Put_Payroll_Payee_Ongoing_Jurisdiction_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Response_DataType Ongoing_Jurisdiction_Response_Tax_Election_Data
		{
			get
			{
				return this.ongoing_Jurisdiction_Response_Tax_Election_DataField;
			}
			set
			{
				this.ongoing_Jurisdiction_Response_Tax_Election_DataField = value;
				this.RaisePropertyChanged("Ongoing_Jurisdiction_Response_Tax_Election_Data");
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
