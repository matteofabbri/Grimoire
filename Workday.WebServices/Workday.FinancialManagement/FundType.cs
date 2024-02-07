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
	public class FundType : INotifyPropertyChanged
	{
		private FundObjectType fund_ReferenceField;

		private Fund_DataType[] fund_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public FundObjectType Fund_Reference
		{
			get
			{
				return this.fund_ReferenceField;
			}
			set
			{
				this.fund_ReferenceField = value;
				this.RaisePropertyChanged("Fund_Reference");
			}
		}

		[XmlElement("Fund_Data", Order = 1)]
		public Fund_DataType[] Fund_Data
		{
			get
			{
				return this.fund_DataField;
			}
			set
			{
				this.fund_DataField = value;
				this.RaisePropertyChanged("Fund_Data");
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
