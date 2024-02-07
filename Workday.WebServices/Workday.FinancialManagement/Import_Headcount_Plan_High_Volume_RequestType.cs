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
	public class Import_Headcount_Plan_High_Volume_RequestType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType headcount_Plan_ReferenceField;

		private Budget_Import_ModeObjectType import_Mode_ReferenceField;

		private Financials_Business_Process_ParametersType business_Process_ParametersField;

		private Headcount_Plan_High_Volume_DataType headcount_Plan_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Headcount_Plan_Reference
		{
			get
			{
				return this.headcount_Plan_ReferenceField;
			}
			set
			{
				this.headcount_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Headcount_Plan_Reference");
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
		public Headcount_Plan_High_Volume_DataType Headcount_Plan_Data
		{
			get
			{
				return this.headcount_Plan_DataField;
			}
			set
			{
				this.headcount_Plan_DataField = value;
				this.RaisePropertyChanged("Headcount_Plan_Data");
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
