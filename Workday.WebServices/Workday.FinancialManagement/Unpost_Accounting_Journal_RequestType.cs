using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Unpost_Accounting_Journal_RequestType : INotifyPropertyChanged
	{
		private Accounting_JournalObjectType accounting_Journal_ReferenceField;

		private Financials_Business_Process_ParametersType financials_Business_Process_ParametersField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Accounting_JournalObjectType Accounting_Journal_Reference
		{
			get
			{
				return this.accounting_Journal_ReferenceField;
			}
			set
			{
				this.accounting_Journal_ReferenceField = value;
				this.RaisePropertyChanged("Accounting_Journal_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Financials_Business_Process_ParametersType Financials_Business_Process_Parameters
		{
			get
			{
				return this.financials_Business_Process_ParametersField;
			}
			set
			{
				this.financials_Business_Process_ParametersField = value;
				this.RaisePropertyChanged("Financials_Business_Process_Parameters");
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
