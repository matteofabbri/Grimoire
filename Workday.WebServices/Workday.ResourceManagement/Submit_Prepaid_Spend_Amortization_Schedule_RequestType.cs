using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Submit_Prepaid_Spend_Amortization_Schedule_RequestType : INotifyPropertyChanged
	{
		private object itemField;

		private Financials_Business_Process_ParametersType[] business_Process_ParametersField;

		private Prepaid_Spend_Amortization_Schedule_DataType prepaid_Spend_Amortization_Schedule_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Prepaid_Spend_Amortization_Schedule_Reference", typeof(Prepaid_Spend_Amortization_ScheduleObjectType), Order = 0), XmlElement("Supplier_Invoice_Reference", typeof(Supplier_InvoiceObjectType), Order = 0)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement("Business_Process_Parameters", Order = 1)]
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

		[XmlElement(Order = 2)]
		public Prepaid_Spend_Amortization_Schedule_DataType Prepaid_Spend_Amortization_Schedule_Data
		{
			get
			{
				return this.prepaid_Spend_Amortization_Schedule_DataField;
			}
			set
			{
				this.prepaid_Spend_Amortization_Schedule_DataField = value;
				this.RaisePropertyChanged("Prepaid_Spend_Amortization_Schedule_Data");
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
