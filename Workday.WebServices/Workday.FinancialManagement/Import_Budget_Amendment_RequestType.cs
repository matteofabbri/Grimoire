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
	public class Import_Budget_Amendment_RequestType : INotifyPropertyChanged
	{
		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private Budget_AmendmentObjectType budget_Amendment_ReferenceField;

		private Financials_Business_Process_ParametersType business_Process_ParametersField;

		private Budget_Amendment_High_Volume_DataType budget_Amendment_High_Volume_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Budget_AmendmentObjectType Budget_Amendment_Reference
		{
			get
			{
				return this.budget_Amendment_ReferenceField;
			}
			set
			{
				this.budget_Amendment_ReferenceField = value;
				this.RaisePropertyChanged("Budget_Amendment_Reference");
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
		public Budget_Amendment_High_Volume_DataType Budget_Amendment_High_Volume_Data
		{
			get
			{
				return this.budget_Amendment_High_Volume_DataField;
			}
			set
			{
				this.budget_Amendment_High_Volume_DataField = value;
				this.RaisePropertyChanged("Budget_Amendment_High_Volume_Data");
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
