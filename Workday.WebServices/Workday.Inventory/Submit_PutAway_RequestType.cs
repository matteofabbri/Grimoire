using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Submit_Put-Away_RequestType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Submit_PutAway_RequestType : INotifyPropertyChanged
	{
		private Financials_Business_Process_ParametersType business_Process_ParametersField;

		private Inventory_PutAway_DataType inventory_PutAway_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement("Inventory_Put-Away_Data", Order = 1)]
		public Inventory_PutAway_DataType Inventory_PutAway_Data
		{
			get
			{
				return this.inventory_PutAway_DataField;
			}
			set
			{
				this.inventory_PutAway_DataField = value;
				this.RaisePropertyChanged("Inventory_PutAway_Data");
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
