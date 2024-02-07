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
	public class Award_ContractType : INotifyPropertyChanged
	{
		private Award_ContractObjectType award_ReferenceField;

		private Award_Contract_DataType award_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Award_ContractObjectType Award_Reference
		{
			get
			{
				return this.award_ReferenceField;
			}
			set
			{
				this.award_ReferenceField = value;
				this.RaisePropertyChanged("Award_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Award_Contract_DataType Award_Data
		{
			get
			{
				return this.award_DataField;
			}
			set
			{
				this.award_DataField = value;
				this.RaisePropertyChanged("Award_Data");
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
