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
	public class Import_Position_Budget_RequestType : INotifyPropertyChanged
	{
		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private Unique_IdentifierObjectType position_Budget_ReferenceField;

		private Financials_Business_Process_ParametersType[] business_Process_ParametersField;

		private Position_Budget__HV__DataType[] position_Budget_DataField;

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
		public Unique_IdentifierObjectType Position_Budget_Reference
		{
			get
			{
				return this.position_Budget_ReferenceField;
			}
			set
			{
				this.position_Budget_ReferenceField = value;
				this.RaisePropertyChanged("Position_Budget_Reference");
			}
		}

		[XmlElement("Business_Process_Parameters", Order = 2)]
		public Financials_Business_Process_ParametersType[] Business_Process_Parameters
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

		[XmlElement("Position_Budget_Data", Order = 3)]
		public Position_Budget__HV__DataType[] Position_Budget_Data
		{
			get
			{
				return this.position_Budget_DataField;
			}
			set
			{
				this.position_Budget_DataField = value;
				this.RaisePropertyChanged("Position_Budget_Data");
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
