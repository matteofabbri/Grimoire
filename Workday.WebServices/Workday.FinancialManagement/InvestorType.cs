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
	public class InvestorType : INotifyPropertyChanged
	{
		private InvestorObjectType investor_ReferenceField;

		private Investor_DataType[] investor_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public InvestorObjectType Investor_Reference
		{
			get
			{
				return this.investor_ReferenceField;
			}
			set
			{
				this.investor_ReferenceField = value;
				this.RaisePropertyChanged("Investor_Reference");
			}
		}

		[XmlElement("Investor_Data", Order = 1)]
		public Investor_DataType[] Investor_Data
		{
			get
			{
				return this.investor_DataField;
			}
			set
			{
				this.investor_DataField = value;
				this.RaisePropertyChanged("Investor_Data");
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
