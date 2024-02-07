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
	public class Customer_Payment_Remittance_Advice_Details_WWS_DataType : INotifyPropertyChanged
	{
		private Customer_Payment_Remittance_Advice_TypeObjectType remittance_Advice_Type_ReferenceField;

		private string detail_InformationField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Customer_Payment_Remittance_Advice_TypeObjectType Remittance_Advice_Type_Reference
		{
			get
			{
				return this.remittance_Advice_Type_ReferenceField;
			}
			set
			{
				this.remittance_Advice_Type_ReferenceField = value;
				this.RaisePropertyChanged("Remittance_Advice_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Detail_Information
		{
			get
			{
				return this.detail_InformationField;
			}
			set
			{
				this.detail_InformationField = value;
				this.RaisePropertyChanged("Detail_Information");
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
