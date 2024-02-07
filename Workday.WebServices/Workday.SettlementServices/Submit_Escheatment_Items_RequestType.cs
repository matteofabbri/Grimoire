using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.SettlementServices
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Submit_Escheatment_Items_RequestType : INotifyPropertyChanged
	{
		private OrganizationObjectType organization_ReferenceField;

		private Financials_Business_Process_ParametersType financials_Business_Process_ParametersField;

		private Escheatment_WWS_ItemType[] escheatment_ItemField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public OrganizationObjectType Organization_Reference
		{
			get
			{
				return this.organization_ReferenceField;
			}
			set
			{
				this.organization_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Reference");
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

		[XmlArray(Order = 2), XmlArrayItem("Escheatment_WWS_Item", IsNullable = false)]
		public Escheatment_WWS_ItemType[] Escheatment_Item
		{
			get
			{
				return this.escheatment_ItemField;
			}
			set
			{
				this.escheatment_ItemField = value;
				this.RaisePropertyChanged("Escheatment_Item");
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
