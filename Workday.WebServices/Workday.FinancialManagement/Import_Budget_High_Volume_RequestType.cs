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
	public class Import_Budget_High_Volume_RequestType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType budget_ReferenceField;

		private Budget_Import_ModeObjectType import_Mode_ReferenceField;

		private Financials_Business_Process_ParametersType business_Process_ParametersField;

		private Budget_High_Volume_DataType budget_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Budget_Reference
		{
			get
			{
				return this.budget_ReferenceField;
			}
			set
			{
				this.budget_ReferenceField = value;
				this.RaisePropertyChanged("Budget_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Budget_Import_ModeObjectType Import_Mode_Reference
		{
			get
			{
				return this.import_Mode_ReferenceField;
			}
			set
			{
				this.import_Mode_ReferenceField = value;
				this.RaisePropertyChanged("Import_Mode_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Financials_Business_Process_ParametersType Business_Process_Parameters
		{
			get
			{
				return this.business_Process_ParametersField;
			}
			set
			{
				this.business_Process_ParametersField = value;
				this.RaisePropertyChanged("Business_Process_Parameters");
			}
		}

		[XmlElement(Order = 3)]
		public Budget_High_Volume_DataType Budget_Data
		{
			get
			{
				return this.budget_DataField;
			}
			set
			{
				this.budget_DataField = value;
				this.RaisePropertyChanged("Budget_Data");
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
