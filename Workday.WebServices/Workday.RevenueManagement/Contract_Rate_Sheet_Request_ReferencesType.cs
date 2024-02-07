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
	public class Contract_Rate_Sheet_Request_ReferencesType : INotifyPropertyChanged
	{
		private Contract_Rate_SheetObjectType[] contract_Rate_Sheet_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Contract_Rate_Sheet_Reference", Order = 0)]
		public Contract_Rate_SheetObjectType[] Contract_Rate_Sheet_Reference
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
