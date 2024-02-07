using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Submit_Count_Inventory_RequestType : INotifyPropertyChanged
	{
		private Inventory_Count_SheetObjectType inventory_Count_Sheet_ReferenceField;

		private Financials_Business_Process_ParametersType business_Process_ParametersField;

		private Count_Inventory_DataType count_Inventory_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Inventory_Count_SheetObjectType Inventory_Count_Sheet_Reference
		{
			get
			{
				return this.inventory_Count_Sheet_ReferenceField;
			}
			set
			{
				this.inventory_Count_Sheet_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Count_Sheet_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Count_Inventory_DataType Count_Inventory_Data
		{
			get
			{
				return this.count_Inventory_DataField;
			}
			set
			{
				this.count_Inventory_DataField = value;
				this.RaisePropertyChanged("Count_Inventory_Data");
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
