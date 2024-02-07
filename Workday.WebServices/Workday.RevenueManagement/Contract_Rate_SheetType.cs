using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Contract_Rate_SheetType : INotifyPropertyChanged
	{
		private Contract_Rate_SheetObjectType contract_Rate_Sheet_ReferenceField;

		private Contract_Rate_Sheet_DataType contract_Rate_Sheet_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Contract_Rate_SheetObjectType Contract_Rate_Sheet_Reference
		{
			get
			{
				return this.contract_Rate_Sheet_ReferenceField;
			}
			set
			{
				this.contract_Rate_Sheet_ReferenceField = value;
				this.RaisePropertyChanged("Contract_Rate_Sheet_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Contract_Rate_Sheet_DataType Contract_Rate_Sheet_Data
		{
			get
			{
				return this.contract_Rate_Sheet_DataField;
			}
			set
			{
				this.contract_Rate_Sheet_DataField = value;
				this.RaisePropertyChanged("Contract_Rate_Sheet_Data");
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
