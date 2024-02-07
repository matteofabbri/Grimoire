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
	public class Suspense_Account_RuleType : INotifyPropertyChanged
	{
		private Suspense_Account_RuleObjectType suspense_Account_Rule_ReferenceField;

		private Suspense_Account_Rule_DataType[] suspense_Account_Rule_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Suspense_Account_RuleObjectType Suspense_Account_Rule_Reference
		{
			get
			{
				return this.suspense_Account_Rule_ReferenceField;
			}
			set
			{
				this.suspense_Account_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Suspense_Account_Rule_Reference");
			}
		}

		[XmlElement("Suspense_Account_Rule_Data", Order = 1)]
		public Suspense_Account_Rule_DataType[] Suspense_Account_Rule_Data
		{
			get
			{
				return this.suspense_Account_Rule_DataField;
			}
			set
			{
				this.suspense_Account_Rule_DataField = value;
				this.RaisePropertyChanged("Suspense_Account_Rule_Data");
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
