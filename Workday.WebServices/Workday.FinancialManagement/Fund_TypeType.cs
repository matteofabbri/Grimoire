using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Fund_TypeType : INotifyPropertyChanged
	{
		private Fund_TypeObjectType fund_Type_ReferenceField;

		private Fund_Type_DataType fund_Type_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Fund_TypeObjectType Fund_Type_Reference
		{
			get
			{
				return this.fund_Type_ReferenceField;
			}
			set
			{
				this.fund_Type_ReferenceField = value;
				this.RaisePropertyChanged("Fund_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Fund_Type_DataType Fund_Type_Data
		{
			get
			{
				return this.fund_Type_DataField;
			}
			set
			{
				this.fund_Type_DataField = value;
				this.RaisePropertyChanged("Fund_Type_Data");
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
